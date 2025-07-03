namespace StatAnalyzer
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            tableLayout = new TableLayoutPanel();
            uploadingData = new GroupBox();
            uploadingLayout = new TableLayoutPanel();
            fromFile = new Button();
            keyboardInput = new Button();
            selectionsGroupBox = new GroupBox();
            dataGridLayout = new TableLayoutPanel();
            selectionsDataGrid = new DataGridView();
            isDependentCheckBox = new CheckBox();
            analyseButton = new Button();
            resultsGroupBox = new GroupBox();
            resultsLayout = new TableLayoutPanel();
            graphicsButton = new Button();
            resultsTextBox = new TextBox();
            tableLayout.SuspendLayout();
            uploadingData.SuspendLayout();
            uploadingLayout.SuspendLayout();
            selectionsGroupBox.SuspendLayout();
            dataGridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectionsDataGrid).BeginInit();
            resultsGroupBox.SuspendLayout();
            resultsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.AutoScroll = true;
            tableLayout.AutoSize = true;
            tableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(uploadingData, 0, 0);
            tableLayout.Controls.Add(selectionsGroupBox, 0, 1);
            tableLayout.Controls.Add(isDependentCheckBox, 0, 2);
            tableLayout.Controls.Add(analyseButton, 0, 3);
            tableLayout.Controls.Add(resultsGroupBox, 0, 4);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 5;
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.Size = new Size(662, 593);
            tableLayout.TabIndex = 0;
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
            uploadingData.Size = new Size(656, 86);
            uploadingData.TabIndex = 0;
            uploadingData.TabStop = false;
            uploadingData.Text = "Загрузка данных";
            // 
            // uploadingLayout
            // 
            uploadingLayout.AutoSize = true;
            uploadingLayout.ColumnCount = 1;
            uploadingLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uploadingLayout.Controls.Add(fromFile, 0, 0);
            uploadingLayout.Controls.Add(keyboardInput, 0, 1);
            uploadingLayout.Dock = DockStyle.Fill;
            uploadingLayout.Location = new Point(3, 21);
            uploadingLayout.Name = "uploadingLayout";
            uploadingLayout.RowCount = 2;
            uploadingLayout.RowStyles.Add(new RowStyle());
            uploadingLayout.RowStyles.Add(new RowStyle());
            uploadingLayout.Size = new Size(650, 62);
            uploadingLayout.TabIndex = 0;
            // 
            // fromFile
            // 
            fromFile.AutoSize = true;
            fromFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fromFile.Dock = DockStyle.Fill;
            fromFile.Font = new Font("Segoe UI", 9F);
            fromFile.Location = new Point(3, 3);
            fromFile.Name = "fromFile";
            fromFile.Size = new Size(644, 25);
            fromFile.TabIndex = 0;
            fromFile.Text = "Загрузить из файла";
            fromFile.UseVisualStyleBackColor = true;
            fromFile.Click += fromFile_Click;
            // 
            // keyboardInput
            // 
            keyboardInput.AutoSize = true;
            keyboardInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyboardInput.Dock = DockStyle.Fill;
            keyboardInput.Font = new Font("Segoe UI", 9F);
            keyboardInput.Location = new Point(3, 34);
            keyboardInput.Name = "keyboardInput";
            keyboardInput.Size = new Size(644, 25);
            keyboardInput.TabIndex = 1;
            keyboardInput.Text = "Ввод вручную";
            keyboardInput.UseVisualStyleBackColor = true;
            keyboardInput.Click += keyboardInput_Click;
            // 
            // selectionsGroupBox
            // 
            selectionsGroupBox.AutoSize = true;
            selectionsGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectionsGroupBox.Controls.Add(dataGridLayout);
            selectionsGroupBox.Dock = DockStyle.Fill;
            selectionsGroupBox.Enabled = false;
            selectionsGroupBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            selectionsGroupBox.Location = new Point(3, 95);
            selectionsGroupBox.Name = "selectionsGroupBox";
            selectionsGroupBox.Size = new Size(656, 180);
            selectionsGroupBox.TabIndex = 1;
            selectionsGroupBox.TabStop = false;
            selectionsGroupBox.Text = "Данные выборок";
            // 
            // dataGridLayout
            // 
            dataGridLayout.AutoSize = true;
            dataGridLayout.ColumnCount = 1;
            dataGridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dataGridLayout.Controls.Add(selectionsDataGrid, 0, 0);
            dataGridLayout.Dock = DockStyle.Fill;
            dataGridLayout.Location = new Point(3, 21);
            dataGridLayout.Name = "dataGridLayout";
            dataGridLayout.RowCount = 1;
            dataGridLayout.RowStyles.Add(new RowStyle());
            dataGridLayout.Size = new Size(650, 156);
            dataGridLayout.TabIndex = 0;
            // 
            // selectionsDataGrid
            // 
            selectionsDataGrid.AllowDrop = true;
            selectionsDataGrid.AllowUserToAddRows = false;
            selectionsDataGrid.AllowUserToDeleteRows = false;
            selectionsDataGrid.AllowUserToResizeColumns = false;
            selectionsDataGrid.AllowUserToResizeRows = false;
            selectionsDataGrid.BackgroundColor = SystemColors.ControlLight;
            selectionsDataGrid.BorderStyle = BorderStyle.Fixed3D;
            selectionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectionsDataGrid.ColumnHeadersVisible = false;
            selectionsDataGrid.Dock = DockStyle.Fill;
            selectionsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            selectionsDataGrid.Location = new Point(3, 3);
            selectionsDataGrid.Name = "selectionsDataGrid";
            selectionsDataGrid.ReadOnly = true;
            selectionsDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            selectionsDataGrid.Size = new Size(644, 150);
            selectionsDataGrid.TabIndex = 0;
            // 
            // isDependentCheckBox
            // 
            isDependentCheckBox.AutoSize = true;
            isDependentCheckBox.Dock = DockStyle.Fill;
            isDependentCheckBox.Enabled = false;
            isDependentCheckBox.Location = new Point(20, 288);
            isDependentCheckBox.Margin = new Padding(20, 10, 20, 10);
            isDependentCheckBox.Name = "isDependentCheckBox";
            isDependentCheckBox.Size = new Size(622, 19);
            isDependentCheckBox.TabIndex = 2;
            isDependentCheckBox.Text = "Выборки зависимы";
            isDependentCheckBox.UseVisualStyleBackColor = true;
            isDependentCheckBox.CheckedChanged += isDependentCheckBox_CheckedChanged;
            // 
            // analyseButton
            // 
            analyseButton.AutoSize = true;
            analyseButton.Dock = DockStyle.Fill;
            analyseButton.Enabled = false;
            analyseButton.Location = new Point(3, 320);
            analyseButton.MaximumSize = new Size(0, 25);
            analyseButton.Name = "analyseButton";
            analyseButton.RightToLeft = RightToLeft.Yes;
            analyseButton.Size = new Size(656, 25);
            analyseButton.TabIndex = 3;
            analyseButton.Text = "Анализировать";
            analyseButton.UseVisualStyleBackColor = true;
            analyseButton.Click += analyseButton_Click;
            // 
            // resultsGroupBox
            // 
            resultsGroupBox.AutoSize = true;
            resultsGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultsGroupBox.Controls.Add(resultsLayout);
            resultsGroupBox.Dock = DockStyle.Fill;
            resultsGroupBox.Enabled = false;
            resultsGroupBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            resultsGroupBox.Location = new Point(3, 351);
            resultsGroupBox.Name = "resultsGroupBox";
            resultsGroupBox.Size = new Size(656, 239);
            resultsGroupBox.TabIndex = 4;
            resultsGroupBox.TabStop = false;
            resultsGroupBox.Text = "Результат";
            // 
            // resultsLayout
            // 
            resultsLayout.AutoSize = true;
            resultsLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultsLayout.ColumnCount = 1;
            resultsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            resultsLayout.Controls.Add(graphicsButton, 0, 1);
            resultsLayout.Controls.Add(resultsTextBox, 0, 0);
            resultsLayout.Dock = DockStyle.Fill;
            resultsLayout.Location = new Point(3, 21);
            resultsLayout.Name = "resultsLayout";
            resultsLayout.RowCount = 2;
            resultsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            resultsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            resultsLayout.Size = new Size(650, 215);
            resultsLayout.TabIndex = 1;
            // 
            // graphicsButton
            // 
            graphicsButton.AutoSize = true;
            graphicsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            graphicsButton.Dock = DockStyle.Fill;
            graphicsButton.Enabled = false;
            graphicsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            graphicsButton.Location = new Point(3, 187);
            graphicsButton.MaximumSize = new Size(0, 25);
            graphicsButton.Name = "graphicsButton";
            graphicsButton.Size = new Size(644, 25);
            graphicsButton.TabIndex = 0;
            graphicsButton.Text = "Показать график";
            graphicsButton.UseVisualStyleBackColor = true;
            // 
            // resultsTextBox
            // 
            resultsTextBox.BorderStyle = BorderStyle.None;
            resultsTextBox.Dock = DockStyle.Fill;
            resultsTextBox.Enabled = false;
            resultsTextBox.Font = new Font("Segoe UI", 9F);
            resultsTextBox.Location = new Point(3, 3);
            resultsTextBox.MaximumSize = new Size(1000, 10000);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ReadOnly = true;
            resultsTextBox.Size = new Size(644, 178);
            resultsTextBox.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(662, 593);
            Controls.Add(tableLayout);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подбор статистических методов для анализа выборок с различной структурой";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            uploadingData.ResumeLayout(false);
            uploadingData.PerformLayout();
            uploadingLayout.ResumeLayout(false);
            uploadingLayout.PerformLayout();
            selectionsGroupBox.ResumeLayout(false);
            selectionsGroupBox.PerformLayout();
            dataGridLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectionsDataGrid).EndInit();
            resultsGroupBox.ResumeLayout(false);
            resultsGroupBox.PerformLayout();
            resultsLayout.ResumeLayout(false);
            resultsLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private GroupBox uploadingData;
        private GroupBox selectionsGroupBox;
        private TableLayoutPanel dataGridLayout;
        private DataGridView selectionsDataGrid;
        private CheckBox isDependentCheckBox;
        private Button analyseButton;
        private GroupBox resultsGroupBox;
        private TableLayoutPanel resultsLayout;
        private Button graphicsButton;
        private TextBox resultsTextBox;
        private TableLayoutPanel uploadingLayout;
        private Button fromFile;
        private Button keyboardInput;
    }
}
