namespace serialcom
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CONNECT = new System.Windows.Forms.Button();
            this.DISCONNECT = new System.Windows.Forms.Button();
            this.RXWINDOW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portName = new System.IO.Ports.SerialPort(this.components);
            this.PressureBox = new System.Windows.Forms.TextBox();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.HumidityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Select_btn = new System.Windows.Forms.Button();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.TextBox();
            this.Bitch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.YAW = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ELEVATION = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(190, 320);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(75, 23);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // DISCONNECT
            // 
            this.DISCONNECT.Location = new System.Drawing.Point(328, 320);
            this.DISCONNECT.Name = "DISCONNECT";
            this.DISCONNECT.Size = new System.Drawing.Size(88, 23);
            this.DISCONNECT.TabIndex = 1;
            this.DISCONNECT.Text = "DISCONNECT";
            this.DISCONNECT.UseVisualStyleBackColor = true;
            this.DISCONNECT.Click += new System.EventHandler(this.DISCONNECT_Click);
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.AllowDrop = true;
            this.RXWINDOW.Location = new System.Drawing.Point(758, 207);
            this.RXWINDOW.Multiline = true;
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.Size = new System.Drawing.Size(206, 21);
            this.RXWINDOW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RX WINDOW";
            // 
            // portName
            // 
            this.portName.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.cmbSerialPorts_DataReceived);
            // 
            // PressureBox
            // 
            this.PressureBox.Location = new System.Drawing.Point(7, 38);
            this.PressureBox.Multiline = true;
            this.PressureBox.Name = "PressureBox";
            this.PressureBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PressureBox.Size = new System.Drawing.Size(156, 93);
            this.PressureBox.TabIndex = 7;
            // 
            // TempBox
            // 
            this.TempBox.Location = new System.Drawing.Point(169, 38);
            this.TempBox.Multiline = true;
            this.TempBox.Name = "TempBox";
            this.TempBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TempBox.Size = new System.Drawing.Size(159, 93);
            this.TempBox.TabIndex = 8;
            // 
            // HumidityBox
            // 
            this.HumidityBox.Location = new System.Drawing.Point(517, 38);
            this.HumidityBox.Multiline = true;
            this.HumidityBox.Name = "HumidityBox";
            this.HumidityBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HumidityBox.Size = new System.Drawing.Size(160, 93);
            this.HumidityBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PRESSURE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(177, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TEMPERATURE ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(543, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "HUMIDITY";
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(837, 111);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(115, 20);
            this.latitude.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(853, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "LATITUDE";
            // 
            // Select_btn
            // 
            this.Select_btn.Location = new System.Drawing.Point(53, 320);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(75, 23);
            this.Select_btn.TabIndex = 16;
            this.Select_btn.Text = "Select Port";
            this.Select_btn.UseVisualStyleBackColor = true;
            this.Select_btn.Click += new System.EventHandler(this.Select_Click);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(42, 270);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 17;
            // 
            // serialSettingsBindingSource
            // 
            this.serialSettingsBindingSource.DataSource = typeof(SerialPortListener.Serial.SerialSettings);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(169, 270);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 19;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(296, 270);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.dataBitsComboBox.TabIndex = 20;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(423, 270);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityComboBox.TabIndex = 21;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(550, 270);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Port Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Baud Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Data Bits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Parity Bits";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Stop Bits";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 470);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Roll);
            this.tabPage1.Controls.Add(this.Bitch);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.YAW);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ELEVATION);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.longitude);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.RXWINDOW);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.latitude);
            this.tabPage1.Controls.Add(this.stopBitsComboBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.parityComboBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataBitsComboBox);
            this.tabPage1.Controls.Add(this.baudRateComboBox);
            this.tabPage1.Controls.Add(this.PressureBox);
            this.tabPage1.Controls.Add(this.DISCONNECT);
            this.tabPage1.Controls.Add(this.Select_btn);
            this.tabPage1.Controls.Add(this.CONNECT);
            this.tabPage1.Controls.Add(this.cmbSerialPorts);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TempBox);
            this.tabPage1.Controls.Add(this.HumidityBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(905, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "i";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(824, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 47;
            this.button8.Text = "h";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(744, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 46;
            this.button9.Text = "g";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(905, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "f";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(824, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "e";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(371, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "ROLL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(334, 145);
            this.Roll.Multiline = true;
            this.Roll.Name = "Roll";
            this.Roll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Roll.Size = new System.Drawing.Size(177, 93);
            this.Roll.TabIndex = 42;
            // 
            // Bitch
            // 
            this.Bitch.Location = new System.Drawing.Point(7, 145);
            this.Bitch.Multiline = true;
            this.Bitch.Name = "Bitch";
            this.Bitch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Bitch.Size = new System.Drawing.Size(156, 93);
            this.Bitch.TabIndex = 36;
            this.Bitch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(30, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "PITCH";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // YAW
            // 
            this.YAW.Location = new System.Drawing.Point(169, 145);
            this.YAW.Multiline = true;
            this.YAW.Name = "YAW";
            this.YAW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YAW.Size = new System.Drawing.Size(159, 93);
            this.YAW.TabIndex = 37;
            this.YAW.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(177, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "YAW";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(744, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "d";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(905, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "c";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(824, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "b";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "a";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(371, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "ELEVATION";
            // 
            // ELEVATION
            // 
            this.ELEVATION.Location = new System.Drawing.Point(334, 38);
            this.ELEVATION.Multiline = true;
            this.ELEVATION.Name = "ELEVATION";
            this.ELEVATION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ELEVATION.Size = new System.Drawing.Size(177, 93);
            this.ELEVATION.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(715, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "LONGITUDE";
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(704, 111);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(115, 20);
            this.longitude.TabIndex = 28;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-388, -128);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8, 7, 3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 18);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1414, 623);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 468);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Can-Sat";
            this.Load += new System.EventHandler(this.webBrowser1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        private void cmbSerialPorts_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.TextBox RXWINDOW;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort portName;
        private System.Windows.Forms.TextBox PressureBox;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.TextBox HumidityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ELEVATION;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Roll;
        private System.Windows.Forms.TextBox Bitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox YAW;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

