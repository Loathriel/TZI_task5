namespace RSA
{
    partial class Encode_val
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
            this.RSA_n = new System.Windows.Forms.NumericUpDown();
            this.EG_p = new System.Windows.Forms.NumericUpDown();
            this.EG_g = new System.Windows.Forms.NumericUpDown();
            this.EG_x = new System.Windows.Forms.NumericUpDown();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.RSA_e = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_e)).BeginInit();
            this.SuspendLayout();
            // 
            // RSA_n
            // 
            this.RSA_n.Location = new System.Drawing.Point(27, 34);
            this.RSA_n.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RSA_n.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RSA_n.Name = "RSA_n";
            this.RSA_n.Size = new System.Drawing.Size(75, 23);
            this.RSA_n.TabIndex = 3;
            this.RSA_n.Value = new decimal(new int[] {
            9173503,
            0,
            0,
            0});
            // 
            // EG_p
            // 
            this.EG_p.Location = new System.Drawing.Point(27, 83);
            this.EG_p.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.EG_p.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EG_p.Name = "EG_p";
            this.EG_p.Size = new System.Drawing.Size(75, 23);
            this.EG_p.TabIndex = 6;
            this.EG_p.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // EG_g
            // 
            this.EG_g.Location = new System.Drawing.Point(129, 83);
            this.EG_g.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.EG_g.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EG_g.Name = "EG_g";
            this.EG_g.Size = new System.Drawing.Size(75, 23);
            this.EG_g.TabIndex = 7;
            this.EG_g.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EG_x
            // 
            this.EG_x.Location = new System.Drawing.Point(230, 83);
            this.EG_x.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.EG_x.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EG_x.Name = "EG_x";
            this.EG_x.Size = new System.Drawing.Size(75, 23);
            this.EG_x.TabIndex = 9;
            this.EG_x.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(129, 138);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 10;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // RSA_e
            // 
            this.RSA_e.Location = new System.Drawing.Point(129, 34);
            this.RSA_e.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RSA_e.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RSA_e.Name = "RSA_e";
            this.RSA_e.Size = new System.Drawing.Size(75, 23);
            this.RSA_e.TabIndex = 15;
            this.RSA_e.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "E:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "N:";
            // 
            // Encode_val
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 173);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RSA_e);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.EG_x);
            this.Controls.Add(this.EG_g);
            this.Controls.Add(this.EG_p);
            this.Controls.Add(this.RSA_n);
            this.Name = "Encode_val";
            this.Text = "Encode_val";
            ((System.ComponentModel.ISupportInitialize)(this.RSA_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_e)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown RSA_n;
        private NumericUpDown EG_p;
        private NumericUpDown EG_g;
        private NumericUpDown EG_x;
        private Button EncodeButton;
        private NumericUpDown RSA_e;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}