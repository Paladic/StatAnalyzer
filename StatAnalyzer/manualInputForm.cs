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
using System.Globalization;

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
                    MessageBox.Show($"Количество выборок меньше, чем допустимое количество. Текущее — {lines.Length}, минимальное допустимое — 2.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lines.Length > 10)
                {
                    MessageBox.Show($"Количество выборок превышает допустимое количество. Текущее — {lines.Length}, максимальное допустимое — 10.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AllSamples = new List<List<double>>();

                AllSamples = SampleCSVParser.TextToSamples(lines);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка разбора значений.\nВведите числовые значения.\nИспользуйте точки для написания десятичных дробей и запятую как разделитель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
