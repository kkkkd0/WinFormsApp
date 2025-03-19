using BuisnesLogic.Interfaces;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using BuisnessLogic.Services;
using BuisnessLogic.Services.Interfaces;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Interfaces;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp.Views
{
    public partial class TaskForm : Form
    {

        private ModuleBase _ModuleBase { get; set; }
        private int _Position { get; set; }
        private string _Email { get; set; }
        private IUserModulesManager _UserModulesManager { get; set; }

        private IRadioInput? InputRadio = null;

        private ITextInput? InputText = null;

        private ICheckInput? InputCheck = null;
        private IHandlerInput _HandlerInput { get; set; }
        private IUserManager _UserManager { get; set; }
        private bool _TherModuleRedFlag = false;
        public TaskForm(ModuleBase module, string useremail, int position, Point? location = null)
        {
            InitializeComponent();

            _Email = useremail;

            _HandlerInput = new HandlerInput();

            var database = DataBaseInit.GetAppDbContext();

            _UserManager = new UserManager(database);

            _Position = position;

            _UserModulesManager = new UserModulesManager(_UserManager, _HandlerInput, database);

            _ModuleBase = module;

            this.Location = location ?? new Point(0, 0);

        }

        private async void TaskForm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.HorizontalScroll.Visible = false;
            plane.MaximumSize = new Size(this.Width - 35, 0);
            var task = _ModuleBase.Assignments![_Position];
            var label = new Label()
            {
                Text = task.Content!.Text,
                Font = new Font(new FontFamily("Sitka Text"), 14, FontStyle.Bold),
                ForeColor = Color.Black,
                MaximumSize = new Size(plane.Width - 60, 0),
                AutoSize = true,
            };
            planeforQuestion.Controls.Add(label);

            if (task.Content.BinaryDatas is not null)
            {
                using (var httpclient = new HttpClient())
                {
                    foreach (var data in task.Content.BinaryDatas)
                    {
                        var model = await httpclient.GetStreamAsync(data.LinkOnData);
                        PictureBox pictureBox = new PictureBox()
                        {
                            Image = Image.FromStream(model),

                            SizeMode = PictureBoxSizeMode.StretchImage,

                            Size = new Size(plane.Width - 60, plane.Width / 2),

                            Location = new Point(planeforQuestion.Location.X, label.Location.Y + label.Size.Height),

                            BackColor = Color.DarkSlateGray,
                        };

                        planeforQuestion.Controls.Add(pictureBox);
                    }
                }
            }

            planeforAnswer.Location = new Point(plane.Location.X, planeforQuestion.Location.Y + planeforQuestion.Size.Height + 30);
            planeforAnswer.Controls.Add(SwitchTypeOfAnswer(task.Content.TypeInput!));

            buttonComplete.Visible = false;

            buttonChange.Visible = false;

            if (_Position == _ModuleBase.Assignments.Count - 1)
            {
                buttonNext.Visible = false;
                buttonComplete.Visible = true;
            }

            if (_Position == 0)
            {
                buttonBefore.Visible = false;
                if (string.IsNullOrWhiteSpace(_ModuleBase.Assignments[_Position].Content!.UserAnswer))
                {
                    if (_ModuleBase as TestModule is not null)
                    {
                        _UserModulesManager.OpenModuleTest(_Email, (_ModuleBase as TestModule)!);
                        var list = _UserModulesManager.TakeModuleTest(_Email, _ModuleBase.Name!)!.ToList();
                        if (list is null || list.Count == 0) return;
                        _ModuleBase = list.SingleOrDefault()!;
                    }

                    if (_ModuleBase as TheoreticalModule is not null)
                    {
                        try
                        {
                            _UserModulesManager.OpenModuleTheoretical(_Email, (_ModuleBase as TheoreticalModule)!);
                            var list = _UserModulesManager.TakeModuleTher(_Email, _ModuleBase.Name!)!.ToList();
                            _ModuleBase = list.SingleOrDefault()!;
                            if (list is null || list.Count == 0) return;
                        }
                        catch
                        {
                            _TherModuleRedFlag = true;
                        }
                    }
                }
            }
            if (_ModuleBase as TheoreticalModule is not null)
            {
                buttonChange.Visible = false;
                buttonAnswer.Visible = false;
                title.Text = "Теория: " + _ModuleBase.Name;
            }
            if(_ModuleBase as TestModule is not null)
            {
                title.Text = "Задание: " + _ModuleBase.Name;
            }
            if (!string.IsNullOrWhiteSpace(task.Content.UserAnswer))
            {
                buttonChange.Visible = true;
                buttonAnswer.Visible = false;
            }
            ButtonLocationChange([buttonAnswer,buttonBefore,buttonComplete,buttonChange,buttonNext]);
            //buttonComplete.Location = new Point(buttonComplete.Location.X - 30,0);
        }
        private void ButtonLocationChange(IList<Button> list)
        {
            foreach(var button in list)
            {
                button.Location = new Point(button.Location.X, planeforAnswer.Size.Height + planeforAnswer.Location.Y + 30);
            }
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (InputCheck is not null)
            {
                _UserModulesManager.GiveAnswer(InputCheck.InputCheck, _Email);
                RedirectOnPosition(_Position);
            }

            if (InputRadio is not null)
            {
                _UserModulesManager.GiveAnswer(InputRadio.InputRadio, _Email);
                RedirectOnPosition(_Position);
            }

            if (InputText is not null)
            {
                _UserModulesManager.GiveAnswer(InputText.InputText, _Email);
                RedirectOnPosition(_Position);
            }
        }
        private Control? SwitchTypeOfAnswer(string typeOfInput, string? userAnswer = null)
        {
            User data = null;
            var task = _ModuleBase.Assignments![_Position];
            var ct = task.Content;

            if (typeOfInput == TypeInput.Text.ToString())
            {
                var textbox = new TextBox()
                {
                    Size = new Size(200, 100),
                    Multiline = true,
                    Text = userAnswer ?? string.Empty
                };
                InputText = new InputMethods(textbox, new ModuleLinkInfo(nameof(data.TestModules)), _Position, _UserModulesManager);
                return textbox;
            }


            else if (typeOfInput == TypeInput.Check.ToString())
            {
                var checkbox = new CheckedListBox();

                checkbox.Controls.Add(new CheckBox()
                {
                    Text = ct.CorrectAnswer,
                });
                var list = ct!.ConfusingAnswers;

                if (list is null) return null;

                foreach (var cfansw in list)
                {
                    checkbox.Controls.Add(new CheckBox() { Text = cfansw.Text });
                }
                InputCheck = new InputMethods(checkbox, new ModuleLinkInfo(nameof(data.TestModules)), _Position, _UserModulesManager);
                return checkbox;
            }
            else if (typeOfInput == TypeInput.Radio.ToString())
            {
                var panelradio = new Panel()
                {
                    AutoScroll = true,
                };
                var list = _ModuleBase.Assignments![_Position].Content!.ConfusingAnswers;

                panelradio.Controls.Add(new RadioButton()
                {
                    Text = ct!.CorrectAnswer,
                    Location = new Point(panelradio.Location.X, panelradio.Location.Y),
                    Checked = userAnswer == ct!.CorrectAnswer
                });
                if (list is not null)
                {
                    int locYCounter = 0;
                    foreach (var cfansw in list)
                    {
                        panelradio.Controls.Add(new RadioButton()
                        {
                            Location = new Point(panelradio.Location.X, panelradio.Location.Y + locYCounter),
                            Text = cfansw.Text,
                            Checked = userAnswer == cfansw.Text

                        });
                        locYCounter += 30;
                    }
                }
                InputRadio = new InputMethods(panelradio, new ModuleLinkInfo(nameof(data.TestModules)), _Position, _UserModulesManager);
                return panelradio;
            }

            else
            {
                return null;

            }

        }
        private void buttonBefore_Click(object sender, EventArgs e)
        {
            RedirectOnPosition(_Position - 1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            RedirectOnPosition(_Position + 1);
        }
        private void RedirectOnPosition(int pos)
        {
            TaskForm taskForm = new TaskForm(_ModuleBase, _Email, pos);
            Hide();
            taskForm.ShowDialog();
            Close();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            var ct = _ModuleBase.Assignments![_Position].Content!;

            var input = SwitchTypeOfAnswer(ct.TypeInput!);

            TestModule newModel = (_ModuleBase as TestModule)!;


            newModel.Assignments![_Position].Content!.UserAnswer = input!.Text;

            _UserModulesManager.ChangeUserModuleTest(_Email, _ModuleBase.Name!, newModel);

            RedirectOnPosition(_Position);
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            var counter = 0;
            foreach (var task in _ModuleBase.Assignments!)
            {
                if (task.Content.UserAnswer == task.Content.CorrectAnswer) counter++;
            }

            if (_ModuleBase.Assignments![_Position].TestModel is not null)
            {
                _UserModulesManager.CloseModuleTest(_Email, (_ModuleBase as TestModule)!);
                Exit(counter);
            }

            if (_ModuleBase.Assignments[_Position].TheoreticalModel is not null)
            {
                if (!_TherModuleRedFlag)
                {
                    _UserModulesManager.CloseModuleTheoretical(_Email, (_ModuleBase as TheoreticalModule)!);
                }
                ModuleForm form = new ModuleForm(_Email);
                Hide();
                form.ShowDialog();
                Close();
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var dialogRes = MessageBox.Show("Вы точно уверены что хотите завершить?", "Message", MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                ModuleForm form = new ModuleForm(_Email);
                Hide();
                form.ShowDialog();
                Close();
            }
            else return;
        }
        private void Exit(int res)
        {
            CompleteForm form = new CompleteForm(res, _ModuleBase.Assignments!.Count, _ModuleBase.Name!, _Email);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
