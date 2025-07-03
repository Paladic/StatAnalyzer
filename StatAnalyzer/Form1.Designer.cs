namespace StatAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            uploadingData = new GroupBox();
            uploadingLayout = new TableLayoutPanel();
            uploadFirstSelection = new Button();
            uploadSecondSelection = new Button();
            selectionsGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            isDependentCheckBox = new CheckBox();
            analyseButton = new Button();
            resultsGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            graphicsButton = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            uploadingData.SuspendLayout();
            uploadingLayout.SuspendLayout();
            selectionsGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            resultsGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(uploadingData, 0, 0);
            tableLayoutPanel1.Controls.Add(selectionsGroupBox, 0, 1);
            tableLayoutPanel1.Controls.Add(isDependentCheckBox, 0, 2);
            tableLayoutPanel1.Controls.Add(analyseButton, 0, 3);
            tableLayoutPanel1.Controls.Add(resultsGroupBox, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(525, 555);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uploadingData
            // 
            uploadingData.AutoSize = true;
            uploadingData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uploadingData.Controls.Add(uploadingLayout);
            uploadingData.Dock = DockStyle.Fill;
            uploadingData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadingData.Location = new Point(3, 3);
            uploadingData.Name = "uploadingData";
            uploadingData.Size = new Size(519, 60);
            uploadingData.TabIndex = 0;
            uploadingData.TabStop = false;
            uploadingData.Text = "Загрузка данных";
            uploadingData.Enter += uploadingData_Enter;
            // 
            // uploadingLayout
            // 
            uploadingLayout.AutoSize = true;
            uploadingLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uploadingLayout.ColumnCount = 2;
            uploadingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uploadingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uploadingLayout.Controls.Add(uploadFirstSelection, 0, 0);
            uploadingLayout.Controls.Add(uploadSecondSelection, 1, 0);
            uploadingLayout.Dock = DockStyle.Fill;
            uploadingLayout.Location = new Point(3, 21);
            uploadingLayout.Name = "uploadingLayout";
            uploadingLayout.RowCount = 1;
            uploadingLayout.RowStyles.Add(new RowStyle());
            uploadingLayout.Size = new Size(513, 36);
            uploadingLayout.TabIndex = 0;
            // 
            // uploadFirstSelection
            // 
            uploadFirstSelection.AutoSize = true;
            uploadFirstSelection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uploadFirstSelection.Dock = DockStyle.Fill;
            uploadFirstSelection.Font = new Font("Segoe UI", 9F);
            uploadFirstSelection.Location = new Point(3, 3);
            uploadFirstSelection.Name = "uploadFirstSelection";
            uploadFirstSelection.Size = new Size(250, 30);
            uploadFirstSelection.TabIndex = 0;
            uploadFirstSelection.Text = "Загрузить первую выборку";
            uploadFirstSelection.UseVisualStyleBackColor = true;
            // 
            // uploadSecondSelection
            // 
            uploadSecondSelection.AutoSize = true;
            uploadSecondSelection.Dock = DockStyle.Top;
            uploadSecondSelection.Font = new Font("Segoe UI", 9F);
            uploadSecondSelection.Location = new Point(259, 3);
            uploadSecondSelection.Name = "uploadSecondSelection";
            uploadSecondSelection.Size = new Size(251, 30);
            uploadSecondSelection.TabIndex = 1;
            uploadSecondSelection.Text = "Загрузить вторую выборку";
            uploadSecondSelection.UseVisualStyleBackColor = true;
            // 
            // selectionsGroupBox
            // 
            selectionsGroupBox.AutoSize = true;
            selectionsGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectionsGroupBox.Controls.Add(tableLayoutPanel2);
            selectionsGroupBox.Dock = DockStyle.Fill;
            selectionsGroupBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            selectionsGroupBox.Location = new Point(3, 69);
            selectionsGroupBox.Name = "selectionsGroupBox";
            selectionsGroupBox.Size = new Size(519, 180);
            selectionsGroupBox.TabIndex = 1;
            selectionsGroupBox.TabStop = false;
            selectionsGroupBox.Text = "Данные выборок";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(513, 156);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.Size = new Size(507, 150);
            dataGridView1.TabIndex = 0;
            // 
            // isDependentCheckBox
            // 
            isDependentCheckBox.AutoSize = true;
            isDependentCheckBox.Dock = DockStyle.Fill;
            isDependentCheckBox.Location = new Point(20, 262);
            isDependentCheckBox.Margin = new Padding(20, 10, 20, 10);
            isDependentCheckBox.Name = "isDependentCheckBox";
            isDependentCheckBox.Size = new Size(485, 19);
            isDependentCheckBox.TabIndex = 2;
            isDependentCheckBox.Text = "Выборки зависимы";
            isDependentCheckBox.UseVisualStyleBackColor = true;
            // 
            // analyseButton
            // 
            analyseButton.AutoSize = true;
            analyseButton.Dock = DockStyle.Fill;
            analyseButton.Location = new Point(3, 294);
            analyseButton.Name = "analyseButton";
            analyseButton.RightToLeft = RightToLeft.Yes;
            analyseButton.Size = new Size(519, 25);
            analyseButton.TabIndex = 3;
            analyseButton.Text = "Анализировать";
            analyseButton.UseVisualStyleBackColor = true;
            // 
            // resultsGroupBox
            // 
            resultsGroupBox.AutoSize = true;
            resultsGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultsGroupBox.Controls.Add(tableLayoutPanel3);
            resultsGroupBox.Dock = DockStyle.Fill;
            resultsGroupBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            resultsGroupBox.Location = new Point(3, 325);
            resultsGroupBox.Name = "resultsGroupBox";
            resultsGroupBox.Size = new Size(519, 227);
            resultsGroupBox.TabIndex = 4;
            resultsGroupBox.TabStop = false;
            resultsGroupBox.Text = "Результат";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(graphicsButton, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(513, 203);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // graphicsButton
            // 
            graphicsButton.AutoSize = true;
            graphicsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            graphicsButton.Dock = DockStyle.Fill;
            graphicsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            graphicsButton.Location = new Point(3, 163);
            graphicsButton.Name = "graphicsButton";
            graphicsButton.Size = new Size(507, 37);
            graphicsButton.TabIndex = 0;
            graphicsButton.Text = "Показать график";
            graphicsButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(507, 154);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(525, 555);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Подбор статистических методов для анализа выборок с различной структурой";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            uploadingData.ResumeLayout(false);
            uploadingData.PerformLayout();
            uploadingLayout.ResumeLayout(false);
            uploadingLayout.PerformLayout();
            selectionsGroupBox.ResumeLayout(false);
            selectionsGroupBox.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            resultsGroupBox.ResumeLayout(false);
            resultsGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox uploadingData;
        private TableLayoutPanel uploadingLayout;
        private Button uploadFirstSelection;
        private Button uploadSecondSelection;
        private GroupBox selectionsGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private CheckBox isDependentCheckBox;
        private Button analyseButton;
        private GroupBox resultsGroupBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button graphicsButton;
        private TextBox textBox1;
    }
}
