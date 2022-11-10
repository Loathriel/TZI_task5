namespace RSA
{
    public partial class Decode_val : Form
    {
        private Form1 parent;
        public Decode_val(Form1 original)
        {
            InitializeComponent();
            parent = original;
            FormClosed += (arg1, arg2) =>
            {
                parent.Enabled = true;
            };
            parent.Enabled = false;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            long[] RSA_keys = new long[] { (long)RSA_n.Value, (long)RSA_d.Value };
            int[] EG_keys = new int[] { (int)EG_p.Value, (int)EG_g.Value, (int)EG_h.Value };
            var text = parent.InputField.Text.Split(" | ");
            var decoded = ClassLibrary.RSA.Decode(text[0], RSA_keys);
            if (ClassLibrary.EG.Check(decoded, text[1], EG_keys))
                MessageBox.Show("Message was signed correctly");
            else
                MessageBox.Show("Sign is incorrect");
            parent.InputField.Text = decoded;
            if (parent.saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(parent.saveFileDialog.FileName, parent.InputField.Text);
            Close();
        }
    }
}
