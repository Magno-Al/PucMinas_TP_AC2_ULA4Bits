using System.IO.Ports;
using System.Windows.Forms;

namespace ULA_4Bits
{
    public partial class Form1 : Form
    {
        SerialCOM SerialCOM = new SerialCOM();

        public Form1()
        {
            InitializeComponent();
        }

        #region ComboBox de comunicação serial  
        private void comboBox_SerialPorts_DropDown(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void comboBox_SerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialCOM.Port = comboBox_SerialPorts.SelectedItem.ToString();

            ShowCommunicationStatus(SerialCOM.OpenCommunication());
        }

        private void FillComboBox()
        {
            comboBox_SerialPorts.Items.Clear();

            comboBox_SerialPorts.Items.Add("Sem conecção");
            foreach (string port in SerialCOM.AutodetectArduinoPort())
            {
                comboBox_SerialPorts.Items.Add(port);
            }
        }
        #endregion

        #region Botões de tratamento de arquivos
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
                }
                else
                    MessageBox.Show("Nada para enviar");
            }
            else
            {
                ShowCommunicationStatus(false);
            }
        }
        #endregion

        #region Status de comunicação serial 
        private async void ShowCommunicationStatus(bool status)
        {
            if (status)
            {
                lbl_ConnectionStatus.Text = "Conectado";
                lbl_ConnectionStatus.ForeColor = Color.Green;
                btn_SendDataToSerial.Enabled = true;
                await ReadSerialDataAsync();
            }
            else
            {
                lbl_ConnectionStatus.Text = "Não conectado";
                lbl_ConnectionStatus.ForeColor = Color.Red;
                btn_SendDataToSerial.Enabled = false;
                FillComboBox();
            }
        }
        #endregion

        #region Async Leitura da comunicação serial 
        private async Task ReadSerialDataAsync()
        {
            string data;
            bool exit = false;
            while (!exit)
            {
                if (SerialCOM.TestCommunication())
                {
                    data = SerialCOM.Read();

                    UpdateSerialMonitor(data);
                }
                else
                {
                    exit = true;
                }

                await Task.Delay(1000);
            }
        }

        private void UpdateSerialMonitor(string data)
        {
            // Use Invoke para atualizar a interface do usuário a partir de um thread de segundo plano
            if (rtb_SerialMonitor.InvokeRequired)
            {
                rtb_SerialMonitor.Invoke((MethodInvoker)(() => UpdateSerialMonitor(data)));
            }
            else
            {
                rtb_SerialMonitor.AppendText("\n");
                rtb_SerialMonitor.AppendText(data);
                rtb_SerialMonitor.ScrollToCaret();
            }
        }
        #endregion
    }
}