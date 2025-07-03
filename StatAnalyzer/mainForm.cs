namespace StatAnalyzer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void uploadingData_Enter(object sender, EventArgs e)
        {

        }

        private void fromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с данными";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
            }
        }

        private void keyboardInput_Click(object sender, EventArgs e)
        {
            using (manualInputForm inputForm = new manualInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    var allSamples = inputForm.AllSamples;
                    selectionsDataGrid.Rows.Clear();
                    selectionsDataGrid.Columns.Clear();

                    int maxCols = allSamples.Max(s => s.Count);

                    for (int i = 0; i < maxCols; i++)
                    {
                        selectionsDataGrid.Columns.Add($"", $"");
                    }

                    for (int row = 0; row < allSamples.Count; row++)
                    {
                        var sample = allSamples[row];
                        var rowValues = new string[maxCols];
                        for (int col = 0; col < sample.Count; col++)
                            rowValues[col] = sample[col].ToString();

                        selectionsDataGrid.Rows.Add(rowValues);
                        selectionsDataGrid.Rows[row].HeaderCell.Value = $"Выборка {row + 1}";
                    }
                }
            }
        }
    }
}
