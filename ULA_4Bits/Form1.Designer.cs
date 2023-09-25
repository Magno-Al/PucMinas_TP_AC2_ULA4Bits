namespace ULA_4Bits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog = new OpenFileDialog();
            rtb_FileInstructions = new RichTextBox();
            btn_openFile = new Button();
            btn_ConvertToHex = new Button();
            rtb_HexInstructions = new RichTextBox();
            btn_DownloadHexFile = new Button();
            btn_SendDataToSerial = new Button();
            comboBox_SerialPorts = new ComboBox();
            lbl_ConnectionStatus = new Label();
            label2 = new Label();
            textBoxFileName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rtb_SerialMonitor = new RichTextBox();
            label1 = new Label();
            btn_ExecuteULA = new Button();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // rtb_FileInstructions
            // 
            rtb_FileInstructions.Location = new Point(12, 112);
            rtb_FileInstructions.Name = "rtb_FileInstructions";
            rtb_FileInstructions.Size = new Size(268, 507);
            rtb_FileInstructions.TabIndex = 0;
            rtb_FileInstructions.Text = "";
            // 
            // btn_openFile
            // 
            btn_openFile.Location = new Point(12, 8);
            btn_openFile.Name = "btn_openFile";
            btn_openFile.Size = new Size(75, 23);
            btn_openFile.TabIndex = 1;
            btn_openFile.Text = "Select File ";
            btn_openFile.UseVisualStyleBackColor = true;
            btn_openFile.Click += btn_openFile_Click;
            // 
            // btn_ConvertToHex
            // 
            btn_ConvertToHex.Enabled = false;
            btn_ConvertToHex.Location = new Point(12, 625);
            btn_ConvertToHex.Name = "btn_ConvertToHex";
            btn_ConvertToHex.Size = new Size(195, 43);
            btn_ConvertToHex.TabIndex = 3;
            btn_ConvertToHex.Text = "Converter intruções para Hex";
            btn_ConvertToHex.UseVisualStyleBackColor = true;
            btn_ConvertToHex.Click += btn_ConvertToHex_Click;
            // 
            // rtb_HexInstructions
            // 
            rtb_HexInstructions.Enabled = false;
            rtb_HexInstructions.Location = new Point(286, 112);
            rtb_HexInstructions.Name = "rtb_HexInstructions";
            rtb_HexInstructions.Size = new Size(268, 507);
            rtb_HexInstructions.TabIndex = 4;
            rtb_HexInstructions.Text = "";
            // 
            // btn_DownloadHexFile
            // 
            btn_DownloadHexFile.Enabled = false;
            btn_DownloadHexFile.Location = new Point(286, 625);
            btn_DownloadHexFile.Name = "btn_DownloadHexFile";
            btn_DownloadHexFile.Size = new Size(195, 43);
            btn_DownloadHexFile.TabIndex = 5;
            btn_DownloadHexFile.Text = "Download do arquivo em Hex";
            btn_DownloadHexFile.UseVisualStyleBackColor = true;
            btn_DownloadHexFile.Click += btn_DownloadHexFile_Click;
            // 
            // btn_SendDataToSerial
            // 
            btn_SendDataToSerial.Enabled = false;
            btn_SendDataToSerial.Location = new Point(560, 625);
            btn_SendDataToSerial.Name = "btn_SendDataToSerial";
            btn_SendDataToSerial.Size = new Size(127, 43);
            btn_SendDataToSerial.TabIndex = 6;
            btn_SendDataToSerial.Text = "Enviar instruções para saída serial";
            btn_SendDataToSerial.UseVisualStyleBackColor = true;
            btn_SendDataToSerial.Click += btn_SendDataToSerial_Click;
            // 
            // comboBox_SerialPorts
            // 
            comboBox_SerialPorts.FormattingEnabled = true;
            comboBox_SerialPorts.Location = new Point(707, 12);
            comboBox_SerialPorts.Name = "comboBox_SerialPorts";
            comboBox_SerialPorts.Size = new Size(121, 23);
            comboBox_SerialPorts.TabIndex = 7;
            comboBox_SerialPorts.DropDown += comboBox_SerialPorts_DropDown;
            comboBox_SerialPorts.SelectedIndexChanged += comboBox_SerialPorts_SelectedIndexChanged;
            // 
            // lbl_ConnectionStatus
            // 
            lbl_ConnectionStatus.AutoSize = true;
            lbl_ConnectionStatus.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_ConnectionStatus.Location = new Point(707, 38);
            lbl_ConnectionStatus.Name = "lbl_ConnectionStatus";
            lbl_ConnectionStatus.Size = new Size(88, 15);
            lbl_ConnectionStatus.TabIndex = 8;
            lbl_ConnectionStatus.Text = "Não conectado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 20);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Saída Serial:";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(93, 8);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(461, 23);
            textBoxFileName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 11;
            label3.Text = "Arquivo de instruções:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(286, 89);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 12;
            label4.Text = "Instruções em Hex:";
            // 
            // rtb_SerialMonitor
            // 
            rtb_SerialMonitor.Enabled = false;
            rtb_SerialMonitor.Location = new Point(560, 112);
            rtb_SerialMonitor.Name = "rtb_SerialMonitor";
            rtb_SerialMonitor.Size = new Size(268, 507);
            rtb_SerialMonitor.TabIndex = 13;
            rtb_SerialMonitor.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(560, 89);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 14;
            label1.Text = "Monitor Serial:";
            // 
            // btn_ExecuteULA
            // 
            btn_ExecuteULA.Enabled = false;
            btn_ExecuteULA.Location = new Point(701, 625);
            btn_ExecuteULA.Name = "btn_ExecuteULA";
            btn_ExecuteULA.Size = new Size(127, 43);
            btn_ExecuteULA.TabIndex = 15;
            btn_ExecuteULA.Text = "Executa instruções e lê entrada serial";
            btn_ExecuteULA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 706);
            Controls.Add(btn_ExecuteULA);
            Controls.Add(label1);
            Controls.Add(rtb_SerialMonitor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxFileName);
            Controls.Add(label2);
            Controls.Add(lbl_ConnectionStatus);
            Controls.Add(comboBox_SerialPorts);
            Controls.Add(btn_SendDataToSerial);
            Controls.Add(btn_DownloadHexFile);
            Controls.Add(rtb_HexInstructions);
            Controls.Add(btn_ConvertToHex);
            Controls.Add(btn_openFile);
            Controls.Add(rtb_FileInstructions);
            MaximumSize = new Size(860, 745);
            MinimumSize = new Size(860, 745);
            Name = "Form1";
            Text = "Conversor de instruções ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private RichTextBox rtb_FileInstructions;
        private Button btn_openFile;
        private Button btn_ConvertToHex;
        private RichTextBox rtb_HexInstructions;
        private Button btn_DownloadHexFile;
        private Button btn_SendDataToSerial;
        private ComboBox comboBox_SerialPorts;
        private Label lbl_ConnectionStatus;
        private Label label2;
        private TextBox textBoxFileName;
        private Label label3;
        private Label label4;
        private RichTextBox rtb_SerialMonitor;
        private Label label1;
        private Button btn_ExecuteULA;
    }
}