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

        public manualInputForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = enterTextBox.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (!SampleCSVParser.isSamplesValid(lines)) return;
                
                var newSamples = SampleCSVParser.TextToSamples(lines);
                Samples.ClearSamples();
                Samples.AllSamples = newSamples;


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка разбора значений.\nВведите числовые значения.\nИспользуйте точку для написания десятичных дробей и точку с запятой как разделитель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
