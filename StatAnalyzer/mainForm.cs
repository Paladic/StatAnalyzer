using static System.Windows.Forms.LinkLabel;

namespace StatAnalyzer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void newSampleForm()
        {
            Samples.IsSameSize = Samples.AllSamples.All(s => s.Count == Samples.AllSamples[0].Count);
            if (Samples.IsSameSize)
            {
                isDependentCheckBox.Enabled = true;
                dependentWarningLabel.Visible = false;
            }
            else
            {
                isDependentCheckBox.Enabled = false;
                dependentWarningLabel.Visible = true;
            }
            resultsTextBox.Clear();
            isDependentCheckBox.Checked = false;
            selectionsDataGrid.Enabled = true;
            selectionsGroupBox.Enabled = true;
            analyseButton.Enabled = true;
            resultsGroupBox.Enabled = false;
            graphicsButton.Enabled = false;
        }

        private void isDependentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Samples.IsDependent = isDependentCheckBox.Checked;
        }

        private void fromFile_Click(object sender, EventArgs e)
        {
            if (Samples.AllSamples.Count != 0)
            {
                DialogResult res = MessageBox.Show("Текущие данные будут стерты и перезаписаны новыми.\nПродолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
            }

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с данными";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] strings = File.ReadAllLines(filePath);
                    if (!SampleCSVParser.isSamplesValid(strings)) return;
                    var newSamples = SampleCSVParser.TextToSamples(strings);
                    Samples.ClearSamples();
                    Samples.AllSamples = newSamples;
                    newSampleForm();

                    InterfaceHelper.SamplesToGrid(selectionsDataGrid, Samples.AllSamples);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка разбора значений.\nВведите числовые значения.\nИспользуйте точку для написания десятичных дробей и точку с запятой как разделитель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void keyboardInput_Click(object sender, EventArgs e)
        {
            if (Samples.AllSamples.Count != 0)
            {
                DialogResult res = MessageBox.Show("Текущие данные будут стерты и перезаписаны новыми.\nПродолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
            }
            using (manualInputForm inputForm = new manualInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    newSampleForm();
                    var allSamples = Samples.AllSamples;
                    InterfaceHelper.SamplesToGrid(selectionsDataGrid, allSamples);
                }
            }
        }

        private void analyseButton_Click(object sender, EventArgs e)
        {
            resultsTextBox.Clear();
            resultsGroupBox.Enabled = true;
            graphicsButton.Enabled = true;
            resultsTextBox.Enabled = true;
            SamplesAnalyzer.AnalyzeSamples();
            resultsTextBox.AppendText(InterfaceHelper.BuildAnalysisSummary());
        }
    }
}
