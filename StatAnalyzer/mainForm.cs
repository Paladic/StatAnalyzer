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

            openFileDialog.Filter = "CSV ����� (*.csv)|*.csv|��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            openFileDialog.Title = "�������� ���� � �������";

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
                }
            }
        }
    }
}
