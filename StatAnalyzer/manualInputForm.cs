using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace StatAnalyzer
{
    public partial class manualInputForm : Form
    {
        public List<List<double>> AllSamples { get; private set; }

        public manualInputForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = enterTextBox.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length < 2)
                {
                    MessageBox.Show($"Количество выборок меньше, чем допустимое количество. Текущее — {lines.Length}, минимальное допустимое — 2.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (lines.Length > 10)
                {
                    MessageBox.Show($"Количество выборок превышает допустимое количество. Текущее — {lines.Length}, максимальное допустимое — 10.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                AllSamples = new List<List<double>>();

                foreach (var line in lines)
                {
                    var sample = line
                        .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => double.Parse(s.Trim()))
                        .ToList();

                    AllSamples.Add(sample);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка разбора чисел. Используйте точки для написания десятичных дробей и запятую с пробелом пробелы как разделитель.");
            }
        }

    }
}
