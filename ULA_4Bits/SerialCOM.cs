using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ULA_4Bits
{
    internal class SerialCOM
    {
        static SerialPort serialPort = new SerialPort();
        public string Port { get; set; }

        public bool OpenCommunication()
        {
            try
            {
                serialPort.PortName = Port;
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.Handshake = Handshake.None;
                serialPort.ReadTimeout = 500000;
                serialPort.WriteTimeout = 500;

                serialPort.Open();
            }
            catch (Exception ex)
            {
                serialPort.Close();
                return false;
            }

            return true;
        }

        public bool CloseCommunication()
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return true;
        }

        public bool TestCommunication()
        {
            if (serialPort.IsOpen)
                return true;
            else
                return false;
        }

        public string Read()
        {
            string readData = "";

            if (!serialPort.IsOpen)
                OpenCommunication();

            try
            {
                serialPort.DiscardInBuffer();
                readData = serialPort.ReadLine();
                if (readData == null)
                {
                    readData = "readData is null";
                }
                readData = readData.Replace("\r", string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return readData;
        }

        public void Write(string data)
        {
            if (!serialPort.IsOpen)
                OpenCommunication();

            try
            {
                serialPort.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public List<string> AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            string desc;
            string deviceId;
            List<string> devicesMatch = new List<string>();

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    desc = item["Description"].ToString();
                    deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        devicesMatch.Add(deviceId);
                    }
                }
            }
            catch
            {
                /* Do Nothing */
            }

            return devicesMatch;

        }

    }
}
