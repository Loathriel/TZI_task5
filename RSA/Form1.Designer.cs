namespace RSA
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRSAKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateElGamalKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(31, 49);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(376, 343);
            this.InputField.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.generateRSAKeysToolStripMenuItem,
            this.generateElGamalKeysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // generateRSAKeysToolStripMenuItem
            // 
            this.generateRSAKeysToolStripMenuItem.Name = "generateRSAKeysToolStripMenuItem";
            this.generateRSAKeysToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.generateRSAKeysToolStripMenuItem.Text = "Generate RSA Keys";
            this.generateRSAKeysToolStripMenuItem.Click += new System.EventHandler(this.generateRSAKeysToolStripMenuItem_Click);
            // 
            // generateElGamalKeysToolStripMenuItem
            // 
            this.generateElGamalKeysToolStripMenuItem.Name = "generateElGamalKeysToolStripMenuItem";
            this.generateElGamalKeysToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.generateElGamalKeysToolStripMenuItem.Text = "Generate El Gamal Keys";
            this.generateElGamalKeysToolStripMenuItem.Click += new System.EventHandler(this.generateElGamalKeysToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Text|*.txt\"";
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(552, 106);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(106, 51);
            this.EncodeButton.TabIndex = 11;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(552, 253);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(106, 51);
            this.DecodeButton.TabIndex = 16;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "example.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox InputField;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem generateRSAKeysToolStripMenuItem;
        private ToolStripMenuItem generateElGamalKeysToolStripMenuItem;
        private Button EncodeButton;
        private Button DecodeButton;
        public OpenFileDialog openFileDialog;
        public SaveFileDialog saveFileDialog;
    }
}