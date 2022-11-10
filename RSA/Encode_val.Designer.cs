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
            // Encode_val
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 173);
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

        }

        #endregion

        private NumericUpDown RSA_n;
        private NumericUpDown EG_p;
        private NumericUpDown EG_g;
        private NumericUpDown EG_x;
        private Button EncodeButton;
        private NumericUpDown RSA_e;
    }
}