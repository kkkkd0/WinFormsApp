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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Views.ModuleInfoViews
{
    public partial class AddAssigment : Form
    {
        public Assignment Assignment { get; set; } = new Assignment();
        private IYandexClient _YandexClient;
        private List<string> _Paths { get; set; } = new List<string>();
        public AddAssigment(IYandexClient yandexClient, Point? location = null)
        {

            InitializeComponent();
            _YandexClient = yandexClient;
            this.Location = location ?? new Point(0, 0);
        }
        private async void buttonOk_Click(object sender, EventArgs e)
        {
            IList<BinaryData> datas = new List<BinaryData>();
            if (_Paths.Count != 0)
            {
                foreach (var path in _Paths)
                {
                    using (var file = new FileStream(path, FileMode.Open))
                    {
                        var par1 = path.Substring(0, path.LastIndexOf(@"\"));
                        var par2 = path.Substring(path.LastIndexOf(@"\") + 1);
                        var res = await _YandexClient.AddModel(file, par1, par2);
                        if (!res.isCorrect) continue;
                        datas.Add(new BinaryData() { LinkOnData = res.resultUrlFromModel });
                    }
                }
            }
            Content ct = new Content()
            {
                BinaryDatas = datas,
                TypeInput = ReturnType().ToString(),
                Text = textBoxQuestion.Text,
                CorrectAnswer = textCorrect.Text,

            };
            ct.ConfusingAnswers = textBoxConfusing.Text.Split(",").Select(x => new ConfusingAnswers() { Text = x, Content = ct }).ToList();
            Assignment.Content = ct;

            DialogResult = DialogResult.OK;
            Close();
        }
        private TypeInput ReturnType()
        {
            if (radioButtonRadio.Checked) return TypeInput.Radio;
            if (radioButtonText.Checked) return TypeInput.Text;
            if (radioButtonCheck.Checked) return TypeInput.Check;
            throw new NotImplementedException();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            _Paths.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            };
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.Cancel) return;
            _Paths.AddRange(openFileDialog.FileNames.Select(x => $@"{x}"));
            labelQuantityFile.Text = "Количество файлов: " + _Paths.Count;
        }

        private void AddAssigment_Load(object sender, EventArgs e)
        {
            radioButtonText.Checked = true;

        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                label2.Visible = false;
                textBoxConfusing.Visible = false;
            }
        }

        private void radioButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRadio.Checked)
            {
                label2.Visible = true;
                textBoxConfusing.Visible = true;
            }
        }

        private void radioButtonCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCheck.Checked)
            {
                label2.Visible = true;
                textBoxConfusing.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
