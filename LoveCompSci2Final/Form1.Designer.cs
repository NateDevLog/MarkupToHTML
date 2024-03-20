namespace LoveCompSci2Final
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
            txtText = new TextBox();
            txtTranslate = new TextBox();
            btnTranslate = new Button();
            btnOpen = new Button();
            btnOpenFile = new Button();
            txtFile = new TextBox();
            lblFileName = new Label();
            btnSaveMarkdown = new Button();
            button1 = new Button();
            lblMarkdown = new Label();
            lblHTML = new Label();
            lblNumWords = new Label();
            lblNumLines = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtText
            // 
            txtText.Location = new Point(38, 57);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(530, 495);
            txtText.TabIndex = 2;
            txtText.TextChanged += btnTranslate_Click;
            // 
            // txtTranslate
            // 
            txtTranslate.Location = new Point(606, 57);
            txtTranslate.Multiline = true;
            txtTranslate.Name = "txtTranslate";
            txtTranslate.ReadOnly = true;
            txtTranslate.Size = new Size(530, 495);
            txtTranslate.TabIndex = 3;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(38, 583);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(112, 34);
            btnTranslate.TabIndex = 4;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Visible = false;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(606, 583);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 7;
            btnOpen.Text = "&Search File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(606, 623);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(112, 34);
            btnOpenFile.TabIndex = 10;
            btnOpenFile.Text = "&Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(724, 625);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(150, 31);
            txtFile.TabIndex = 11;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(742, 588);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(115, 25);
            lblFileName.TabIndex = 8;
            lblFileName.Text = "File Directory";
            // 
            // btnSaveMarkdown
            // 
            btnSaveMarkdown.Location = new Point(38, 650);
            btnSaveMarkdown.Name = "btnSaveMarkdown";
            btnSaveMarkdown.Size = new Size(196, 48);
            btnSaveMarkdown.TabIndex = 13;
            btnSaveMarkdown.Text = "Save &Markdown";
            btnSaveMarkdown.UseVisualStyleBackColor = true;
            btnSaveMarkdown.Click += btnSaveMarkdown_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 650);
            button1.Name = "button1";
            button1.Size = new Size(196, 48);
            button1.TabIndex = 14;
            button1.Text = "Save &HTML";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMarkdown
            // 
            lblMarkdown.AutoSize = true;
            lblMarkdown.Location = new Point(240, 19);
            lblMarkdown.Name = "lblMarkdown";
            lblMarkdown.Size = new Size(132, 25);
            lblMarkdown.TabIndex = 0;
            lblMarkdown.Text = "Markdown Text";
            // 
            // lblHTML
            // 
            lblHTML.AutoSize = true;
            lblHTML.Location = new Point(783, 19);
            lblHTML.Name = "lblHTML";
            lblHTML.Size = new Size(147, 25);
            lblHTML.TabIndex = 1;
            lblHTML.Text = "HTML Translation";
            // 
            // lblNumWords
            // 
            lblNumWords.AutoSize = true;
            lblNumWords.Location = new Point(897, 588);
            lblNumWords.Name = "lblNumWords";
            lblNumWords.Size = new Size(157, 25);
            lblNumWords.TabIndex = 9;
            lblNumWords.Text = "Number of words:";
            // 
            // lblNumLines
            // 
            lblNumLines.AutoSize = true;
            lblNumLines.Location = new Point(911, 623);
            lblNumLines.Name = "lblNumLines";
            lblNumLines.Size = new Size(143, 25);
            lblNumLines.TabIndex = 12;
            lblNumLines.Text = "Number of lines:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 583);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(324, 583);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 726);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblNumLines);
            Controls.Add(lblNumWords);
            Controls.Add(lblHTML);
            Controls.Add(lblMarkdown);
            Controls.Add(button1);
            Controls.Add(btnSaveMarkdown);
            Controls.Add(lblFileName);
            Controls.Add(txtFile);
            Controls.Add(btnOpenFile);
            Controls.Add(btnOpen);
            Controls.Add(btnTranslate);
            Controls.Add(txtTranslate);
            Controls.Add(txtText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtText;
        private TextBox txtTranslate;
        private Button btnTranslate;
        private Button btnOpen;
        private Button btnOpenFile;
        private TextBox txtFile;
        private Label lblFileName;
        private Button btnSaveMarkdown;
        private Button button1;
        private Label lblMarkdown;
        private Label lblHTML;
        private Label lblNumWords;
        private Label lblNumLines;
        private Button btnClear;
        private Button btnExit;
    }
}
