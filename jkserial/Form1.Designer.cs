namespace jkserial
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRxNum = new System.Windows.Forms.Label();
            this.lblTxNum = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSerialSta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.chkNewLine = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.radTxAsc = new System.Windows.Forms.RadioButton();
            this.radTxHex = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnClrData = new System.Windows.Forms.Button();
            this.chkDisTime = new System.Windows.Forms.CheckBox();
            this.chkDisSend = new System.Windows.Forms.CheckBox();
            this.radRxHex = new System.Windows.Forms.RadioButton();
            this.radRxAsc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSwitchSerial = new System.Windows.Forms.Button();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbCheckBit = new System.Windows.Forms.ComboBox();
            this.cmbDataBit = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbSerialNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSerialData = new System.Windows.Forms.TextBox();
            this.cmbSendList = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblRxNum);
            this.panel6.Controls.Add(this.lblTxNum);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 26);
            this.panel6.TabIndex = 2;
            // 
            // lblRxNum
            // 
            this.lblRxNum.AutoSize = true;
            this.lblRxNum.Location = new System.Drawing.Point(162, 7);
            this.lblRxNum.Name = "lblRxNum";
            this.lblRxNum.Size = new System.Drawing.Size(11, 12);
            this.lblRxNum.TabIndex = 1;
            this.lblRxNum.Text = " ";
            // 
            // lblTxNum
            // 
            this.lblTxNum.AutoSize = true;
            this.lblTxNum.Location = new System.Drawing.Point(16, 7);
            this.lblTxNum.Name = "lblTxNum";
            this.lblTxNum.Size = new System.Drawing.Size(29, 12);
            this.lblTxNum.TabIndex = 0;
            this.lblTxNum.Text = "    ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(587, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 26);
            this.panel5.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver1.0.0 @ Goldcard";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSerialSta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 26);
            this.panel4.TabIndex = 0;
            // 
            // lblSerialSta
            // 
            this.lblSerialSta.AutoSize = true;
            this.lblSerialSta.Location = new System.Drawing.Point(4, 7);
            this.lblSerialSta.Name = "lblSerialSta";
            this.lblSerialSta.Size = new System.Drawing.Size(29, 12);
            this.lblSerialSta.TabIndex = 0;
            this.lblSerialSta.Text = "    ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 491);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUploadFile);
            this.groupBox3.Controls.Add(this.nudInterval);
            this.groupBox3.Controls.Add(this.chkNewLine);
            this.groupBox3.Controls.Add(this.chkAutoSend);
            this.groupBox3.Controls.Add(this.radTxAsc);
            this.groupBox3.Controls.Add(this.radTxHex);
            this.groupBox3.Location = new System.Drawing.Point(13, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 144);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(16, 92);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(65, 23);
            this.btnUploadFile.TabIndex = 3;
            this.btnUploadFile.Text = "加载文件";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // nudInterval
            // 
            this.nudInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInterval.Location = new System.Drawing.Point(88, 68);
            this.nudInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(57, 21);
            this.nudInterval.TabIndex = 3;
            this.nudInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // chkNewLine
            // 
            this.chkNewLine.AutoSize = true;
            this.chkNewLine.Location = new System.Drawing.Point(16, 45);
            this.chkNewLine.Name = "chkNewLine";
            this.chkNewLine.Size = new System.Drawing.Size(72, 16);
            this.chkNewLine.TabIndex = 2;
            this.chkNewLine.Text = "发送换行";
            this.chkNewLine.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(16, 70);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(72, 16);
            this.chkAutoSend.TabIndex = 2;
            this.chkAutoSend.Text = "自动发送";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            this.chkAutoSend.CheckedChanged += new System.EventHandler(this.chkAutoSend_CheckedChanged);
            // 
            // radTxAsc
            // 
            this.radTxAsc.AutoSize = true;
            this.radTxAsc.Location = new System.Drawing.Point(16, 20);
            this.radTxAsc.Name = "radTxAsc";
            this.radTxAsc.Size = new System.Drawing.Size(53, 16);
            this.radTxAsc.TabIndex = 0;
            this.radTxAsc.TabStop = true;
            this.radTxAsc.Text = "ASCII";
            this.radTxAsc.UseVisualStyleBackColor = true;
            // 
            // radTxHex
            // 
            this.radTxHex.AutoSize = true;
            this.radTxHex.Location = new System.Drawing.Point(76, 20);
            this.radTxHex.Name = "radTxHex";
            this.radTxHex.Size = new System.Drawing.Size(41, 16);
            this.radTxHex.TabIndex = 1;
            this.radTxHex.TabStop = true;
            this.radTxHex.Text = "HEX";
            this.radTxHex.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveData);
            this.groupBox2.Controls.Add(this.btnClrData);
            this.groupBox2.Controls.Add(this.chkDisTime);
            this.groupBox2.Controls.Add(this.chkDisSend);
            this.groupBox2.Controls.Add(this.radRxHex);
            this.groupBox2.Controls.Add(this.radRxAsc);
            this.groupBox2.Location = new System.Drawing.Point(13, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(88, 91);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(65, 23);
            this.btnSaveData.TabIndex = 3;
            this.btnSaveData.Text = "保存日志";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnClrData
            // 
            this.btnClrData.Location = new System.Drawing.Point(16, 91);
            this.btnClrData.Name = "btnClrData";
            this.btnClrData.Size = new System.Drawing.Size(72, 23);
            this.btnClrData.TabIndex = 3;
            this.btnClrData.Text = "清空接收";
            this.btnClrData.UseVisualStyleBackColor = true;
            this.btnClrData.Click += new System.EventHandler(this.btnClrData_Click);
            // 
            // chkDisTime
            // 
            this.chkDisTime.AutoSize = true;
            this.chkDisTime.Location = new System.Drawing.Point(16, 66);
            this.chkDisTime.Name = "chkDisTime";
            this.chkDisTime.Size = new System.Drawing.Size(72, 16);
            this.chkDisTime.TabIndex = 2;
            this.chkDisTime.Text = "显示时间";
            this.chkDisTime.UseVisualStyleBackColor = true;
            // 
            // chkDisSend
            // 
            this.chkDisSend.AutoSize = true;
            this.chkDisSend.Location = new System.Drawing.Point(16, 44);
            this.chkDisSend.Name = "chkDisSend";
            this.chkDisSend.Size = new System.Drawing.Size(72, 16);
            this.chkDisSend.TabIndex = 2;
            this.chkDisSend.Text = "显示发送";
            this.chkDisSend.UseVisualStyleBackColor = true;
            // 
            // radRxHex
            // 
            this.radRxHex.AutoSize = true;
            this.radRxHex.Location = new System.Drawing.Point(76, 21);
            this.radRxHex.Name = "radRxHex";
            this.radRxHex.Size = new System.Drawing.Size(41, 16);
            this.radRxHex.TabIndex = 1;
            this.radRxHex.TabStop = true;
            this.radRxHex.Text = "HEX";
            this.radRxHex.UseVisualStyleBackColor = true;
            // 
            // radRxAsc
            // 
            this.radRxAsc.AutoSize = true;
            this.radRxAsc.Location = new System.Drawing.Point(16, 21);
            this.radRxAsc.Name = "radRxAsc";
            this.radRxAsc.Size = new System.Drawing.Size(53, 16);
            this.radRxAsc.TabIndex = 0;
            this.radRxAsc.TabStop = true;
            this.radRxAsc.Text = "ASCII";
            this.radRxAsc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSwitchSerial);
            this.groupBox1.Controls.Add(this.cmbStopBit);
            this.groupBox1.Controls.Add(this.cmbCheckBit);
            this.groupBox1.Controls.Add(this.cmbDataBit);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.cmbSerialNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // btnSwitchSerial
            // 
            this.btnSwitchSerial.Location = new System.Drawing.Point(16, 154);
            this.btnSwitchSerial.Name = "btnSwitchSerial";
            this.btnSwitchSerial.Size = new System.Drawing.Size(137, 23);
            this.btnSwitchSerial.TabIndex = 2;
            this.btnSwitchSerial.Text = "打开串口";
            this.btnSwitchSerial.UseVisualStyleBackColor = true;
            this.btnSwitchSerial.Click += new System.EventHandler(this.btnSwitchSerial_Click);
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(61, 125);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(91, 20);
            this.cmbStopBit.TabIndex = 1;
            // 
            // cmbCheckBit
            // 
            this.cmbCheckBit.FormattingEnabled = true;
            this.cmbCheckBit.Items.AddRange(new object[] {
            "NONE",
            "EVEN",
            "ODD"});
            this.cmbCheckBit.Location = new System.Drawing.Point(61, 101);
            this.cmbCheckBit.Name = "cmbCheckBit";
            this.cmbCheckBit.Size = new System.Drawing.Size(91, 20);
            this.cmbCheckBit.TabIndex = 1;
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.FormattingEnabled = true;
            this.cmbDataBit.Items.AddRange(new object[] {
            "8",
            "8",
            "9"});
            this.cmbDataBit.Location = new System.Drawing.Point(61, 77);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(91, 20);
            this.cmbDataBit.TabIndex = 1;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200",
            "921600"});
            this.cmbBaudrate.Location = new System.Drawing.Point(62, 53);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(91, 20);
            this.cmbBaudrate.TabIndex = 1;
            // 
            // cmbSerialNumber
            // 
            this.cmbSerialNumber.FormattingEnabled = true;
            this.cmbSerialNumber.Location = new System.Drawing.Point(62, 29);
            this.cmbSerialNumber.Name = "cmbSerialNumber";
            this.cmbSerialNumber.Size = new System.Drawing.Size(91, 20);
            this.cmbSerialNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串  口";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 491);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSerialData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmbSendList);
            this.splitContainer1.Panel2.Controls.Add(this.btnSend);
            this.splitContainer1.Panel2.Controls.Add(this.txtSendData);
            this.splitContainer1.Size = new System.Drawing.Size(587, 487);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSerialData
            // 
            this.txtSerialData.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSerialData.Location = new System.Drawing.Point(0, 0);
            this.txtSerialData.Multiline = true;
            this.txtSerialData.Name = "txtSerialData";
            this.txtSerialData.Size = new System.Drawing.Size(584, 362);
            this.txtSerialData.TabIndex = 0;
            // 
            // cmbSendList
            // 
            this.cmbSendList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSendList.FormattingEnabled = true;
            this.cmbSendList.Location = new System.Drawing.Point(4, 95);
            this.cmbSendList.Name = "cmbSendList";
            this.cmbSendList.Size = new System.Drawing.Size(573, 20);
            this.cmbSendList.TabIndex = 2;
            this.cmbSendList.SelectedIndexChanged += new System.EventHandler(this.cmbSendList_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = global::jkserial.Properties.Resources.send;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(511, 31);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(3, 6);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(475, 83);
            this.txtSendData.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JKSerialTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSwitchSerial;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbCheckBit;
        private System.Windows.Forms.ComboBox cmbDataBit;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbSerialNumber;
        private System.Windows.Forms.CheckBox chkDisTime;
        private System.Windows.Forms.CheckBox chkDisSend;
        private System.Windows.Forms.RadioButton radRxHex;
        private System.Windows.Forms.RadioButton radRxAsc;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.RadioButton radTxAsc;
        private System.Windows.Forms.RadioButton radTxHex;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnClrData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSerialData;
        private System.Windows.Forms.ComboBox cmbSendList;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRxNum;
        private System.Windows.Forms.Label lblTxNum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSerialSta;
        private System.Windows.Forms.CheckBox chkNewLine;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

