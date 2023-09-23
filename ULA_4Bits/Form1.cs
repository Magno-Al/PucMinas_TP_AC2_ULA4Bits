namespace ULA_4Bits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    string fileName = openFileDialog.FileName;
                    string fileText = File.ReadAllText(fileName);

                    textBoxFileName.Text = fileName;
                    richTextBox1.Text = fileText;
                }
            }
        }

        private void btn_ConvertToHex_Click(object sender, EventArgs e)
        {
            HexConverter hexConverter = new HexConverter();

            string[] fileTextInHex = hexConverter.ConvetToHex(richTextBox1.Text);

            foreach (string file in fileTextInHex)
            {
                richTextBox2.Text += file + "\n";
            }
        }

        private void btn_DownloadHexFile_Click(object sender, EventArgs e)
        {
            string filePath = "./HexFile.hex";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(richTextBox2.Text);
                    writer.Close();

                    MessageBox.Show("Download realizado com sucesso em " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}