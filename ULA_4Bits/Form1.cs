using System.Windows.Forms;

namespace ULA_4Bits
{
    public partial class Form1 : Form
    {
        SerialCOM SerialCOM = new SerialCOM();
        public Form1()
        {
            InitializeComponent();

            FillComboBox();
        }

        private void FillComboBox()
        {
            comboBox_SerialPorts.Items.Clear();
            comboBox_SerialPorts.Items.Add("");

            foreach (string port in SerialCOM.AutodetectArduinoPort())
            {
                comboBox_SerialPorts.Items.Add(port);
            }
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
                    rtb_FileInstructions.Text = fileText;

                    if (fileText.Length > 0)
                        btn_ConvertToHex.Enabled = true;
                }
            }
        }

        private void btn_ConvertToHex_Click(object sender, EventArgs e)
        {
            HexConverter hexConverter = new HexConverter();

            string[] fileTextInHex = hexConverter.ConvetToHex(rtb_FileInstructions.Text);

            foreach (string file in fileTextInHex)
            {
                rtb_HexInstructions.Text += file + "\n";
            }

            rtb_HexInstructions.Enabled = true;
            btn_DownloadHexFile.Enabled = true;
        }

        private void btn_DownloadHexFile_Click(object sender, EventArgs e)
        {
            string filePath = "./HexFile.hex";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(rtb_HexInstructions.Text);
                    writer.Close();

                    MessageBox.Show("Download realizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SendDataToSerial_Click(object sender, EventArgs e)
        {
            bool testConnection = SerialCOM.TestCommunication();

            if (testConnection)
            {
                if (rtb_HexInstructions.Text.Length > 0)
                {
                    SerialCOM.Write(rtb_HexInstructions.Text);
                    rtb_SerialMonitor.Text = SerialCOM.Read(); // remover
                }
                else
                    MessageBox.Show("Nada para enviar");
            }
            else
            {
                lbl_ConnectionStatus.Text = "Não conectado";
                lbl_ConnectionStatus.ForeColor = Color.Red;
                btn_SendDataToSerial.Enabled = false;
                FillComboBox();
            }
        }

        private void comboBox_SerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialCOM.Port = comboBox_SerialPorts.SelectedItem.ToString();
            if (SerialCOM.OpenCommunication())
            {
                lbl_ConnectionStatus.Text = "Conectado";
                lbl_ConnectionStatus.ForeColor = Color.Green;
                btn_SendDataToSerial.Enabled = true;
            }
            else
            {
                lbl_ConnectionStatus.Text = "Não conectado";
                lbl_ConnectionStatus.ForeColor = Color.Red;
                btn_SendDataToSerial.Enabled = false;
                FillComboBox();
            }
        }

        private void comboBox_SerialPorts_DropDown(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}