using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Views.ModuleInfoViews;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp.Views
{
    public partial class AddModuleForm: Form
    {
        private IYandexClient _YandexClient { get; set; }
        private TypeModule _TypeModule { get; set; }
        private int _CounterFileForTher {  get; set; }
        public ModuleBase Module { get; set; } = new ModuleBase()
        {
            Assignments = new List<Assignment>()
        };
        public int _CounterTask = 0;
        public AddModuleForm(IYandexClient yandexClient, TypeModule typeModule, Point? location = null)
        {
            InitializeComponent();
            _YandexClient = yandexClient;
            _TypeModule = typeModule;
            this.Location = location ?? new Point(0,0);
        }
        private void Test_CheckedChanged()
        {
            planeForTypeAttribute.Controls.Clear();
            var button = new Button()
            {
                Text = "Добавить задание",
                Size = new Size(250, 30),
                Font = new Font(new FontFamily("Sitka Text"), 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black,
            };
            button.Click += Button_Click;
            planeForTypeAttribute.Controls.Add(button);
        }
        private void Theoretical_CheckedChanged()
        {
            Module.Exists = 1;
            Module.Assignments = new List<Assignment>()
            {
                new Assignment()
                {
                    Content = new Content()
                    {
                        BinaryDatas = new List<BinaryData>(),
                    }
                }
            };
            
            planeForTypeAttribute.Controls.Clear();
            var label = new Label()
            {
                AutoSize = true,
                Text = "Введите теорию",
                Font = new Font(new FontFamily("Sitka Text"), 14, FontStyle.Bold),
                ForeColor = Color.White,
            };
            planeForTypeAttribute.Controls.Add(label);
            var textbox = new TextBox()
            {
                Location = new Point(planeForTypeAttribute.Location.X,label.Location.Y + 30),
                Size = new Size(100, 100),
            };
            var buttonAddFile = new Button()
            {
                Location = new Point(planeForTypeAttribute.Location.X, textbox.Location.Y + 30),
                Text = "Добавить файлы",
                Font = new Font(new FontFamily("Sitka Text"), 12, FontStyle.Bold),
                Size = new Size(250, 30),
                FlatStyle = FlatStyle.Flat,
              
            };
            buttonAddFile.Click += ButtonAddFile_Click;
            textbox.TextChanged += TextboxTheoretical_TextChanged;
            planeForTypeAttribute.Controls.Add(textbox);
            planeForTypeAttribute.Controls.Add(buttonAddFile);
        }

        private async void ButtonAddFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            };
            var dialog = openFileDialog.ShowDialog();
            if (dialog == DialogResult.Cancel) return;
            foreach (var path in openFileDialog.FileNames.Select(x => $@"{x}"))
            {
                using (var file = new FileStream(path, FileMode.Open))
                {
                    var par1 = path.Substring(0, path.LastIndexOf(@"\"));
                    var par2 = path.Substring(path.LastIndexOf(@"\") + 1);
                    var res = await _YandexClient.AddModel(file, par1, par2);
                    if (!res.isCorrect) continue;
                    Module.Assignments![0].Content!.BinaryDatas!.Add(new BinaryData() { LinkOnData = res.resultUrlFromModel });
                }
            }
        }

        private void TextboxTheoretical_TextChanged(object? sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            Module.Assignments![0].Content!.Text = textbox!.Text;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            var form = new AddAssigment(_YandexClient);
            var dialog = form.ShowDialog();
            if (dialog == DialogResult.Cancel) return;
            Module.Assignments!.Add(form.Assignment);
            Module.Exists = 1;
            _CounterTask++;
            labelQuantityTask.Text = "Количество заданий: " + _CounterTask;
        }
       

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Введите имя");
                return;
            }
            Module.Name = textName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddModuleForm_Load(object sender, EventArgs e)
        {
            switch (_TypeModule)
            {
                case TypeModule.Test:
                    Test_CheckedChanged();
                    break;
                case TypeModule.Ther:
                    Theoretical_CheckedChanged();
                    break;
            }
        }
    }
}
