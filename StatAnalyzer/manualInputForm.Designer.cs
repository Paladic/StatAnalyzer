namespace StatAnalyzer
{
    partial class manualInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manualInputForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            enterTextBox = new TextBox();
            enterButton = new Button();
            manualLabel = new Label();
            exampleLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(enterTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(enterButton, 0, 3);
            tableLayoutPanel1.Controls.Add(manualLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(exampleLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(508, 263);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // enterTextBox
            // 
            enterTextBox.Dock = DockStyle.Fill;
            enterTextBox.Location = new Point(3, 121);
            enterTextBox.Multiline = true;
            enterTextBox.Name = "enterTextBox";
            enterTextBox.ScrollBars = ScrollBars.Both;
            enterTextBox.Size = new Size(502, 108);
            enterTextBox.TabIndex = 2;
            // 
            // enterButton
            // 
            enterButton.Dock = DockStyle.Fill;
            enterButton.Location = new Point(3, 235);
            enterButton.MaximumSize = new Size(0, 25);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(502, 25);
            enterButton.TabIndex = 4;
            enterButton.Text = "Подтвердить";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // manualLabel
            // 
            manualLabel.AutoSize = true;
            manualLabel.Dock = DockStyle.Fill;
            manualLabel.Location = new Point(3, 0);
            manualLabel.Name = "manualLabel";
            manualLabel.Size = new Size(502, 65);
            manualLabel.TabIndex = 5;
            manualLabel.Text = "Ввод десятичных дробей осуществляется через точку. \r\nЗначения разделяются запятой с пробелом.\r\nКаждая выборка на отдельной строке.\r\nПоддерживаемое количество выборок – от 2 до 10.\r\n";
            // 
            // exampleLabel
            // 
            exampleLabel.AutoSize = true;
            exampleLabel.Dock = DockStyle.Fill;
            exampleLabel.Location = new Point(3, 65);
            exampleLabel.Name = "exampleLabel";
            exampleLabel.Size = new Size(502, 53);
            exampleLabel.TabIndex = 6;
            exampleLabel.Text = "Например:\r\n12.5, 56.4\r\n16, 89, 89.6";
            // 
            // manualInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(508, 263);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "manualInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод вручную";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox enterTextBox;
        private Button enterButton;
        private Label manualLabel;
        private Label exampleLabel;
    }
}