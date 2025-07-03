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
            resultsTextBox.Clear();
            isDependentCheckBox.Enabled = true;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "CSV ����� (*.csv)|*.csv|��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            openFileDialog.Title = "�������� ���� � �������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newSampleForm();
                Samples.ClearSamples();
                string filePath = openFileDialog.FileName;
                string[] strings = File.ReadAllLines(filePath);
                Samples.AllSamples = new List<List<double>>();
                Samples.AllSamples = SampleCSVParser.TextToSamples(strings);

                InterfaceHelper.SamplesToGrid(selectionsDataGrid, Samples.AllSamples);
            }
            else MessageBox.Show("��������� ������ ��� �������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void keyboardInput_Click(object sender, EventArgs e)
        {
            Samples.ClearSamples();
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

            resultsTextBox.AppendText(Samples.IsDependent ? "������� ���������." : "������� �����������.");
            resultsTextBox.AppendText("\r\n");
            bool sameSize = Samples.AllSamples.All(s => s.Count == Samples.AllSamples[0].Count);

            resultsTextBox.AppendText(sameSize
                ? $"������ ������� ����������. ������ ������� �������� {Samples.AllSamples[0].Count} ���������."
                : "������� ������� �������.");
            resultsTextBox.AppendText("\r\n");
        }
    }
}
