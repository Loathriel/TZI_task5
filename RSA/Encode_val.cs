using System.Windows.Forms;

namespace RSA
{
    public partial class Encode_val : Form
    {
        private Form1 parent;
        public Encode_val(Form1 original)
        {
            InitializeComponent();
            parent = original;
            FormClosed += (arg1, arg2) =>
            {
                parent.Enabled = true;
            };
            parent.Enabled = false;
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            long[] RSA_keys = new long[] { (long)RSA_n.Value, (long)RSA_e.Value };
            int[] EG_keys = new int[] { (int)EG_p.Value, (int)EG_g.Value, (int)EG_x.Value };
            var text = parent.InputField.Text;
            var encoded = ClassLibrary.RSA.Encode(text, RSA_keys);
            var sign = ClassLibrary.EG.Sign(text, EG_keys);
            parent.InputField.Text = $"{encoded}| {sign}";
            if (parent.saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(parent.saveFileDialog.FileName, parent.InputField.Text);
            Close();
        }
    }
}
