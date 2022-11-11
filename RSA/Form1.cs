using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                InputField.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            Encode_val form = new Encode_val(this);
            form.ShowDialog();
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            Decode_val form = new Decode_val(this);
            form.ShowDialog();
        }

        private void generateRSAKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keys = KeyGenerator.GenerateRSA();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, $"Public key: n = {keys[0]}, e = {keys[1]}\n\rPrivate key: n = {keys[0]}, d = {keys[2]}");
        }

        private void generateElGamalKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keys = KeyGenerator.GenerateEG();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, $"Public key: p = {keys[0]}, g = {keys[1]}, y = {keys[3]}\n\rPrivate key: x = {keys[2]}");
        }
    }
}