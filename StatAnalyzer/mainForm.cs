namespace StatAnalyzer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void isDependentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Samples.IsDependent = isDependentCheckBox.Checked;
        }

        private void fromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с данными";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                isDependentCheckBox.Enabled = true;
                isDependentCheckBox.Checked = false;
                selectionsDataGrid.Enabled = true;
                selectionsGroupBox.Enabled = true;
                analyseButton.Enabled = true;
                resultsGroupBox.Enabled = false;
                graphicsButton.Enabled = false;

                string filePath = openFileDialog.FileName;
                string[] strings = File.ReadAllLines(filePath);
                Samples.AllSamples = new List<List<double>>();
                Samples.AllSamples = SampleCSVParser.TextToSamples(strings);

                InterfaceHelper.SamplesToGrid(selectionsDataGrid, Samples.AllSamples);
            }
            else MessageBox.Show("Произошла ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void keyboardInput_Click(object sender, EventArgs e)
        {
            using (manualInputForm inputForm = new manualInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    isDependentCheckBox.Enabled = true;
                    isDependentCheckBox.Checked = false;
                    selectionsDataGrid.Enabled = true;
                    selectionsGroupBox.Enabled = true;
                    analyseButton.Enabled = true;
                    resultsGroupBox.Enabled = false;
                    graphicsButton.Enabled = false;

                    var allSamples = Samples.AllSamples;
                    InterfaceHelper.SamplesToGrid(selectionsDataGrid, allSamples);
                }
            }
        }

        private void analyseButton_Click(object sender, EventArgs e)
        {
            resultsGroupBox.Enabled = true;
            graphicsButton.Enabled = true;
        }
    }
}
