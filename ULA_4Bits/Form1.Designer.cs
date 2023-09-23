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
            richTextBox1 = new RichTextBox();
            btn_openFile = new Button();
            btn_ConvertToHex = new Button();
            richTextBox2 = new RichTextBox();
            btn_DownloadHexFile = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxFileName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(228, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(268, 339);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
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
            btn_ConvertToHex.Location = new Point(12, 293);
            btn_ConvertToHex.Name = "btn_ConvertToHex";
            btn_ConvertToHex.Size = new Size(195, 43);
            btn_ConvertToHex.TabIndex = 3;
            btn_ConvertToHex.Text = "Converter intruções para Hex";
            btn_ConvertToHex.UseVisualStyleBackColor = true;
            btn_ConvertToHex.Click += btn_ConvertToHex_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(520, 99);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(268, 339);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // btn_DownloadHexFile
            // 
            btn_DownloadHexFile.Location = new Point(12, 342);
            btn_DownloadHexFile.Name = "btn_DownloadHexFile";
            btn_DownloadHexFile.Size = new Size(195, 43);
            btn_DownloadHexFile.TabIndex = 5;
            btn_DownloadHexFile.Text = "Download do arquivo em Hex";
            btn_DownloadHexFile.UseVisualStyleBackColor = true;
            btn_DownloadHexFile.Click += btn_DownloadHexFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 391);
            button3.Name = "button3";
            button3.Size = new Size(195, 43);
            button3.TabIndex = 6;
            button3.Text = "Enviar instruções para saída serial";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 8;
            label1.Text = "Não conectado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 16);
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
            label3.Location = new Point(228, 81);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 11;
            label3.Text = "Texto de instruções:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 81);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 12;
            label4.Text = "Instruções em Hex:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxFileName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(btn_DownloadHexFile);
            Controls.Add(richTextBox2);
            Controls.Add(btn_ConvertToHex);
            Controls.Add(btn_openFile);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private RichTextBox richTextBox1;
        private Button btn_openFile;
        private Button btn_ConvertToHex;
        private RichTextBox richTextBox2;
        private Button btn_DownloadHexFile;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxFileName;
        private Label label3;
        private Label label4;
    }
}