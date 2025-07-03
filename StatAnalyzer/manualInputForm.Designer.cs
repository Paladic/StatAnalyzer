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
            manualTextBox = new TextBox();
            enterTextBox = new TextBox();
            exampleTextBox = new TextBox();
            enterButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(manualTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(enterTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(exampleTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(enterButton, 0, 3);
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
            // manualTextBox
            // 
            manualTextBox.BorderStyle = BorderStyle.None;
            manualTextBox.CausesValidation = false;
            manualTextBox.Dock = DockStyle.Fill;
            manualTextBox.HideSelection = false;
            manualTextBox.Location = new Point(3, 3);
            manualTextBox.Multiline = true;
            manualTextBox.Name = "manualTextBox";
            manualTextBox.ReadOnly = true;
            manualTextBox.Size = new Size(502, 59);
            manualTextBox.TabIndex = 1;
            manualTextBox.Text = "Ввод десятичных дробей осуществляется через точку. \r\nЗначения разделяются запятой с пробелом.\r\nКаждая выборка на отдельной строке.\r\nПоддерживаемое количество выборок – от 2 до 10.";
            // 
            // enterTextBox
            // 
            enterTextBox.Dock = DockStyle.Fill;
            enterTextBox.Location = new Point(3, 121);
            enterTextBox.Multiline = true;
            enterTextBox.Name = "enterTextBox";
            enterTextBox.Size = new Size(502, 108);
            enterTextBox.TabIndex = 2;
            // 
            // exampleTextBox
            // 
            exampleTextBox.BorderStyle = BorderStyle.None;
            exampleTextBox.Dock = DockStyle.Fill;
            exampleTextBox.Location = new Point(3, 68);
            exampleTextBox.Multiline = true;
            exampleTextBox.Name = "exampleTextBox";
            exampleTextBox.ReadOnly = true;
            exampleTextBox.Size = new Size(502, 47);
            exampleTextBox.TabIndex = 3;
            exampleTextBox.Text = "Например:\r\n12.5, 56.4\r\n16, 89, 89.6";
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
        private TextBox manualTextBox;
        private TextBox enterTextBox;
        private TextBox exampleTextBox;
        private Button enterButton;
    }
}