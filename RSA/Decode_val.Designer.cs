namespace RSA
{
    partial class Decode_val
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
            this.EG_h = new System.Windows.Forms.NumericUpDown();
            this.EG_g = new System.Windows.Forms.NumericUpDown();
            this.EG_p = new System.Windows.Forms.NumericUpDown();
            this.RSA_n = new System.Windows.Forms.NumericUpDown();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.RSA_d = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EG_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_d)).BeginInit();
            this.SuspendLayout();
            // 
            // EG_h
            // 
            this.EG_h.Location = new System.Drawing.Point(232, 83);
            this.EG_h.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.EG_h.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EG_h.Name = "EG_h";
            this.EG_h.Size = new System.Drawing.Size(75, 23);
            this.EG_h.TabIndex = 12;
            this.EG_h.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // EG_g
            // 
            this.EG_g.Location = new System.Drawing.Point(131, 83);
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
            this.EG_g.TabIndex = 11;
            this.EG_g.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EG_p
            // 
            this.EG_p.Location = new System.Drawing.Point(29, 83);
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
            this.EG_p.TabIndex = 10;
            this.EG_p.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // RSA_n
            // 
            this.RSA_n.Location = new System.Drawing.Point(29, 29);
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
            this.RSA_n.TabIndex = 13;
            this.RSA_n.Value = new decimal(new int[] {
            9173503,
            0,
            0,
            0});
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(131, 134);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 15;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // RSA_d
            // 
            this.RSA_d.Location = new System.Drawing.Point(131, 29);
            this.RSA_d.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.RSA_d.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RSA_d.Name = "RSA_d";
            this.RSA_d.Size = new System.Drawing.Size(75, 23);
            this.RSA_d.TabIndex = 16;
            this.RSA_d.Value = new decimal(new int[] {
            6111579,
            0,
            0,
            0});
            // 
            // Decode_val
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 169);
            this.Controls.Add(this.RSA_d);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.RSA_n);
            this.Controls.Add(this.EG_h);
            this.Controls.Add(this.EG_g);
            this.Controls.Add(this.EG_p);
            this.Name = "Decode_val";
            this.Text = "Decode_val";
            ((System.ComponentModel.ISupportInitialize)(this.EG_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EG_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSA_d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown EG_h;
        private NumericUpDown EG_g;
        private NumericUpDown EG_p;
        private NumericUpDown RSA_n;
        private Button DecodeButton;
        private NumericUpDown RSA_d;
    }
}