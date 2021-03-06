﻿namespace OpenCarTestbed.Windows
{
    partial class BusMonitorCompact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusMonitorCompact));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Monitor = new System.Windows.Forms.TabPage();
            this.pictureBoxTester = new System.Windows.Forms.PictureBox();
            this.buttonTesterPresent = new System.Windows.Forms.Button();
            this.RefreshInterfaces = new System.Windows.Forms.Button();
            this.ReceiveCount = new System.Windows.Forms.Label();
            this.lblReceiveCount = new System.Windows.Forms.Label();
            this.lblTransmitInterface = new System.Windows.Forms.Label();
            this.TransmitInterfaceBox = new System.Windows.Forms.ComboBox();
            this.TransmitFuzz = new System.Windows.Forms.Button();
            this.ReceiveInterfaceBox = new System.Windows.Forms.ComboBox();
            this.lblReceiveInterface = new System.Windows.Forms.Label();
            this.CopyClipboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TransmitPackets2 = new System.Windows.Forms.Button();
            this.ClearMonitor2 = new System.Windows.Forms.Button();
            this.MonitorBus2 = new System.Windows.Forms.Button();
            this.StopMonitor2 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeBetween = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TesterPresentMessage = new System.Windows.Forms.TextBox();
            this.TesterPresentDLC = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.TesterPresentID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerboseTransmit = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLSB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericMSB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Monitor_Decimal = new System.Windows.Forms.RadioButton();
            this.Monitor_Hex = new System.Windows.Forms.RadioButton();
            this.MonitorOutput = new System.Windows.Forms.Label();
            this.XMLFilter = new System.Windows.Forms.TabPage();
            this.IfThenpictureBox = new System.Windows.Forms.PictureBox();
            this.IfThenActivateButton = new System.Windows.Forms.Button();
            this.FilterLoadLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnloadFilter = new System.Windows.Forms.Button();
            this.LoadFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterList = new System.Windows.Forms.ListBox();
            this.RefreshFilters = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.btnHighlightFilter = new System.Windows.Forms.Button();
            this.applyFilters = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilterLoadStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorkerRead = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerTester = new System.ComponentModel.BackgroundWorker();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.identifyPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renamePacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTester)).BeginInit();
            this.Settings.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TesterPresentDLC)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMSB)).BeginInit();
            this.panel1.SuspendLayout();
            this.XMLFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IfThenpictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.toolStripStatusLabel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Monitor);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Controls.Add(this.XMLFilter);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(506, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 424);
            this.tabControl1.TabIndex = 36;
            // 
            // Monitor
            // 
            this.Monitor.AutoScroll = true;
            this.Monitor.Controls.Add(this.pictureBoxTester);
            this.Monitor.Controls.Add(this.buttonTesterPresent);
            this.Monitor.Controls.Add(this.RefreshInterfaces);
            this.Monitor.Controls.Add(this.ReceiveCount);
            this.Monitor.Controls.Add(this.lblReceiveCount);
            this.Monitor.Controls.Add(this.lblTransmitInterface);
            this.Monitor.Controls.Add(this.TransmitInterfaceBox);
            this.Monitor.Controls.Add(this.TransmitFuzz);
            this.Monitor.Controls.Add(this.ReceiveInterfaceBox);
            this.Monitor.Controls.Add(this.lblReceiveInterface);
            this.Monitor.Controls.Add(this.CopyClipboard);
            this.Monitor.Controls.Add(this.label5);
            this.Monitor.Controls.Add(this.label6);
            this.Monitor.Controls.Add(this.TransmitPackets2);
            this.Monitor.Controls.Add(this.ClearMonitor2);
            this.Monitor.Controls.Add(this.MonitorBus2);
            this.Monitor.Controls.Add(this.StopMonitor2);
            this.Monitor.Location = new System.Drawing.Point(4, 22);
            this.Monitor.Name = "Monitor";
            this.Monitor.Padding = new System.Windows.Forms.Padding(3);
            this.Monitor.Size = new System.Drawing.Size(327, 398);
            this.Monitor.TabIndex = 0;
            this.Monitor.Text = "Transmit / Receive";
            this.Monitor.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTester
            // 
            this.pictureBoxTester.BackColor = System.Drawing.Color.Red;
            this.pictureBoxTester.Location = new System.Drawing.Point(142, 338);
            this.pictureBoxTester.Name = "pictureBoxTester";
            this.pictureBoxTester.Size = new System.Drawing.Size(24, 37);
            this.pictureBoxTester.TabIndex = 44;
            this.pictureBoxTester.TabStop = false;
            // 
            // buttonTesterPresent
            // 
            this.buttonTesterPresent.Location = new System.Drawing.Point(30, 338);
            this.buttonTesterPresent.Name = "buttonTesterPresent";
            this.buttonTesterPresent.Size = new System.Drawing.Size(106, 37);
            this.buttonTesterPresent.TabIndex = 43;
            this.buttonTesterPresent.Text = "Activate Tester Present";
            this.buttonTesterPresent.UseVisualStyleBackColor = true;
            this.buttonTesterPresent.Click += new System.EventHandler(this.buttonTesterPresent_Click_1);
            // 
            // RefreshInterfaces
            // 
            this.RefreshInterfaces.Location = new System.Drawing.Point(176, 279);
            this.RefreshInterfaces.Name = "RefreshInterfaces";
            this.RefreshInterfaces.Size = new System.Drawing.Size(106, 23);
            this.RefreshInterfaces.TabIndex = 42;
            this.RefreshInterfaces.Text = "Refresh Interfaces";
            this.RefreshInterfaces.UseVisualStyleBackColor = true;
            this.RefreshInterfaces.Click += new System.EventHandler(this.RefreshInterfaces_Click_1);
            // 
            // ReceiveCount
            // 
            this.ReceiveCount.AutoSize = true;
            this.ReceiveCount.Location = new System.Drawing.Point(107, 97);
            this.ReceiveCount.Name = "ReceiveCount";
            this.ReceiveCount.Size = new System.Drawing.Size(13, 13);
            this.ReceiveCount.TabIndex = 39;
            this.ReceiveCount.Text = "0";
            // 
            // lblReceiveCount
            // 
            this.lblReceiveCount.AutoSize = true;
            this.lblReceiveCount.Location = new System.Drawing.Point(27, 97);
            this.lblReceiveCount.Name = "lblReceiveCount";
            this.lblReceiveCount.Size = new System.Drawing.Size(81, 13);
            this.lblReceiveCount.TabIndex = 38;
            this.lblReceiveCount.Text = "Receive Count:";
            // 
            // lblTransmitInterface
            // 
            this.lblTransmitInterface.AutoSize = true;
            this.lblTransmitInterface.Location = new System.Drawing.Point(25, 214);
            this.lblTransmitInterface.Name = "lblTransmitInterface";
            this.lblTransmitInterface.Size = new System.Drawing.Size(95, 13);
            this.lblTransmitInterface.TabIndex = 37;
            this.lblTransmitInterface.Text = "Transmit Interface:";
            // 
            // TransmitInterfaceBox
            // 
            this.TransmitInterfaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransmitInterfaceBox.FormattingEnabled = true;
            this.TransmitInterfaceBox.Location = new System.Drawing.Point(126, 208);
            this.TransmitInterfaceBox.Name = "TransmitInterfaceBox";
            this.TransmitInterfaceBox.Size = new System.Drawing.Size(175, 21);
            this.TransmitInterfaceBox.TabIndex = 36;
            // 
            // TransmitFuzz
            // 
            this.TransmitFuzz.Location = new System.Drawing.Point(176, 162);
            this.TransmitFuzz.Name = "TransmitFuzz";
            this.TransmitFuzz.Size = new System.Drawing.Size(146, 23);
            this.TransmitFuzz.TabIndex = 41;
            this.TransmitFuzz.Text = "Transmit Modified Packet";
            this.TransmitFuzz.UseVisualStyleBackColor = true;
            this.TransmitFuzz.Click += new System.EventHandler(this.TransmitFuzz_Click_1);
            // 
            // ReceiveInterfaceBox
            // 
            this.ReceiveInterfaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReceiveInterfaceBox.FormattingEnabled = true;
            this.ReceiveInterfaceBox.Location = new System.Drawing.Point(123, 57);
            this.ReceiveInterfaceBox.Name = "ReceiveInterfaceBox";
            this.ReceiveInterfaceBox.Size = new System.Drawing.Size(175, 21);
            this.ReceiveInterfaceBox.TabIndex = 34;
            // 
            // lblReceiveInterface
            // 
            this.lblReceiveInterface.AutoSize = true;
            this.lblReceiveInterface.Location = new System.Drawing.Point(25, 60);
            this.lblReceiveInterface.Name = "lblReceiveInterface";
            this.lblReceiveInterface.Size = new System.Drawing.Size(95, 13);
            this.lblReceiveInterface.TabIndex = 35;
            this.lblReceiveInterface.Text = "Receive Interface:";
            // 
            // CopyClipboard
            // 
            this.CopyClipboard.Location = new System.Drawing.Point(27, 279);
            this.CopyClipboard.Name = "CopyClipboard";
            this.CopyClipboard.Size = new System.Drawing.Size(106, 23);
            this.CopyClipboard.TabIndex = 33;
            this.CopyClipboard.Text = "Copy to Clipboard";
            this.CopyClipboard.UseVisualStyleBackColor = true;
            this.CopyClipboard.Click += new System.EventHandler(this.CopyClipboard_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 31;
            // 
            // TransmitPackets2
            // 
            this.TransmitPackets2.Location = new System.Drawing.Point(27, 162);
            this.TransmitPackets2.Name = "TransmitPackets2";
            this.TransmitPackets2.Size = new System.Drawing.Size(139, 23);
            this.TransmitPackets2.TabIndex = 30;
            this.TransmitPackets2.Text = "Transmit Selected Packet";
            this.TransmitPackets2.UseVisualStyleBackColor = true;
            this.TransmitPackets2.Click += new System.EventHandler(this.TransmitPackets2_Click_1);
            // 
            // ClearMonitor2
            // 
            this.ClearMonitor2.Location = new System.Drawing.Point(218, 17);
            this.ClearMonitor2.Name = "ClearMonitor2";
            this.ClearMonitor2.Size = new System.Drawing.Size(94, 23);
            this.ClearMonitor2.TabIndex = 26;
            this.ClearMonitor2.Text = "Clear Monitor";
            this.ClearMonitor2.UseVisualStyleBackColor = true;
            this.ClearMonitor2.Click += new System.EventHandler(this.ClearMonitor2_Click);
            // 
            // MonitorBus2
            // 
            this.MonitorBus2.Location = new System.Drawing.Point(22, 17);
            this.MonitorBus2.Name = "MonitorBus2";
            this.MonitorBus2.Size = new System.Drawing.Size(94, 23);
            this.MonitorBus2.TabIndex = 23;
            this.MonitorBus2.Text = "Monitor Bus ";
            this.MonitorBus2.UseVisualStyleBackColor = true;
            this.MonitorBus2.Click += new System.EventHandler(this.MonitorBus2_Click);
            // 
            // StopMonitor2
            // 
            this.StopMonitor2.Location = new System.Drawing.Point(122, 17);
            this.StopMonitor2.Name = "StopMonitor2";
            this.StopMonitor2.Size = new System.Drawing.Size(90, 23);
            this.StopMonitor2.TabIndex = 25;
            this.StopMonitor2.Text = "Stop Monitor";
            this.StopMonitor2.UseVisualStyleBackColor = true;
            this.StopMonitor2.Click += new System.EventHandler(this.StopMonitor2_Click_1);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.panel5);
            this.Settings.Controls.Add(this.panel3);
            this.Settings.Controls.Add(this.MonitorOutput);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(327, 398);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TimeBetween);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.TesterPresentMessage);
            this.panel5.Controls.Add(this.TesterPresentDLC);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.TesterPresentID);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.VerboseTransmit);
            this.panel5.Location = new System.Drawing.Point(176, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 349);
            this.panel5.TabIndex = 73;
            // 
            // TimeBetween
            // 
            this.TimeBetween.Location = new System.Drawing.Point(13, 324);
            this.TimeBetween.Name = "TimeBetween";
            this.TimeBetween.Size = new System.Drawing.Size(120, 20);
            this.TimeBetween.TabIndex = 82;
            this.TimeBetween.Text = "1000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "Time Between (ms)";
            // 
            // TesterPresentMessage
            // 
            this.TesterPresentMessage.Location = new System.Drawing.Point(13, 271);
            this.TesterPresentMessage.Name = "TesterPresentMessage";
            this.TesterPresentMessage.Size = new System.Drawing.Size(120, 20);
            this.TesterPresentMessage.TabIndex = 80;
            this.TesterPresentMessage.Text = "013E";
            // 
            // TesterPresentDLC
            // 
            this.TesterPresentDLC.Location = new System.Drawing.Point(13, 217);
            this.TesterPresentDLC.Name = "TesterPresentDLC";
            this.TesterPresentDLC.Size = new System.Drawing.Size(120, 20);
            this.TesterPresentDLC.TabIndex = 79;
            this.TesterPresentDLC.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Length of Message";
            // 
            // TesterPresentID
            // 
            this.TesterPresentID.Location = new System.Drawing.Point(13, 164);
            this.TesterPresentID.Name = "TesterPresentID";
            this.TesterPresentID.Size = new System.Drawing.Size(100, 20);
            this.TesterPresentID.TabIndex = 77;
            this.TesterPresentID.Text = "242";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "CAN Message";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "CAN Identifier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Tester Present";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Transmit Settings";
            // 
            // VerboseTransmit
            // 
            this.VerboseTransmit.AutoSize = true;
            this.VerboseTransmit.Location = new System.Drawing.Point(4, 56);
            this.VerboseTransmit.Name = "VerboseTransmit";
            this.VerboseTransmit.Size = new System.Drawing.Size(143, 17);
            this.VerboseTransmit.TabIndex = 64;
            this.VerboseTransmit.Text = "Verbose Transmit Output";
            this.VerboseTransmit.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelLSB);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.numericMSB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(6, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 349);
            this.panel3.TabIndex = 70;
            // 
            // labelLSB
            // 
            this.labelLSB.AutoSize = true;
            this.labelLSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLSB.Location = new System.Drawing.Point(45, 291);
            this.labelLSB.Name = "labelLSB";
            this.labelLSB.Size = new System.Drawing.Size(18, 20);
            this.labelLSB.TabIndex = 75;
            this.labelLSB.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Bit - Least Sig. Bit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Bit - Most Sig. Bit";
            // 
            // numericMSB
            // 
            this.numericMSB.Location = new System.Drawing.Point(13, 242);
            this.numericMSB.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericMSB.Name = "numericMSB";
            this.numericMSB.ReadOnly = true;
            this.numericMSB.Size = new System.Drawing.Size(120, 20);
            this.numericMSB.TabIndex = 72;
            this.numericMSB.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Receive Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.Monitor_Decimal);
            this.panel1.Controls.Add(this.Monitor_Hex);
            this.panel1.Location = new System.Drawing.Point(13, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 57);
            this.panel1.TabIndex = 68;
            // 
            // Monitor_Decimal
            // 
            this.Monitor_Decimal.AutoSize = true;
            this.Monitor_Decimal.Enabled = false;
            this.Monitor_Decimal.Location = new System.Drawing.Point(18, 12);
            this.Monitor_Decimal.Name = "Monitor_Decimal";
            this.Monitor_Decimal.Size = new System.Drawing.Size(63, 17);
            this.Monitor_Decimal.TabIndex = 10;
            this.Monitor_Decimal.Text = "Decimal";
            this.Monitor_Decimal.UseVisualStyleBackColor = true;
            // 
            // Monitor_Hex
            // 
            this.Monitor_Hex.AutoSize = true;
            this.Monitor_Hex.Checked = true;
            this.Monitor_Hex.Location = new System.Drawing.Point(18, 36);
            this.Monitor_Hex.Name = "Monitor_Hex";
            this.Monitor_Hex.Size = new System.Drawing.Size(44, 17);
            this.Monitor_Hex.TabIndex = 11;
            this.Monitor_Hex.TabStop = true;
            this.Monitor_Hex.Text = "Hex";
            this.Monitor_Hex.UseVisualStyleBackColor = true;
            // 
            // MonitorOutput
            // 
            this.MonitorOutput.AutoSize = true;
            this.MonitorOutput.Location = new System.Drawing.Point(344, 183);
            this.MonitorOutput.Name = "MonitorOutput";
            this.MonitorOutput.Size = new System.Drawing.Size(0, 13);
            this.MonitorOutput.TabIndex = 60;
            // 
            // XMLFilter
            // 
            this.XMLFilter.Controls.Add(this.IfThenpictureBox);
            this.XMLFilter.Controls.Add(this.IfThenActivateButton);
            this.XMLFilter.Controls.Add(this.FilterLoadLabel);
            this.XMLFilter.Controls.Add(this.label4);
            this.XMLFilter.Controls.Add(this.UnloadFilter);
            this.XMLFilter.Controls.Add(this.LoadFilter);
            this.XMLFilter.Controls.Add(this.label3);
            this.XMLFilter.Controls.Add(this.FilterList);
            this.XMLFilter.Controls.Add(this.RefreshFilters);
            this.XMLFilter.Location = new System.Drawing.Point(4, 22);
            this.XMLFilter.Name = "XMLFilter";
            this.XMLFilter.Padding = new System.Windows.Forms.Padding(3);
            this.XMLFilter.Size = new System.Drawing.Size(327, 398);
            this.XMLFilter.TabIndex = 2;
            this.XMLFilter.Text = "XML Filter";
            this.XMLFilter.UseVisualStyleBackColor = true;
            // 
            // IfThenpictureBox
            // 
            this.IfThenpictureBox.BackColor = System.Drawing.Color.Red;
            this.IfThenpictureBox.Location = new System.Drawing.Point(170, 329);
            this.IfThenpictureBox.Name = "IfThenpictureBox";
            this.IfThenpictureBox.Size = new System.Drawing.Size(24, 37);
            this.IfThenpictureBox.TabIndex = 45;
            this.IfThenpictureBox.TabStop = false;
            // 
            // IfThenActivateButton
            // 
            this.IfThenActivateButton.BackColor = System.Drawing.Color.Transparent;
            this.IfThenActivateButton.Location = new System.Drawing.Point(24, 329);
            this.IfThenActivateButton.Name = "IfThenActivateButton";
            this.IfThenActivateButton.Size = new System.Drawing.Size(122, 37);
            this.IfThenActivateButton.TabIndex = 7;
            this.IfThenActivateButton.Text = "Activate If Then";
            this.IfThenActivateButton.UseVisualStyleBackColor = false;
            this.IfThenActivateButton.Click += new System.EventHandler(this.IfThenActivateButton_Click);
            // 
            // FilterLoadLabel
            // 
            this.FilterLoadLabel.AutoSize = true;
            this.FilterLoadLabel.Location = new System.Drawing.Point(190, 266);
            this.FilterLoadLabel.Name = "FilterLoadLabel";
            this.FilterLoadLabel.Size = new System.Drawing.Size(33, 13);
            this.FilterLoadLabel.TabIndex = 6;
            this.FilterLoadLabel.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filter Loaded:";
            // 
            // UnloadFilter
            // 
            this.UnloadFilter.Location = new System.Drawing.Point(24, 279);
            this.UnloadFilter.Name = "UnloadFilter";
            this.UnloadFilter.Size = new System.Drawing.Size(98, 23);
            this.UnloadFilter.TabIndex = 4;
            this.UnloadFilter.Text = "Unload Filter";
            this.UnloadFilter.UseVisualStyleBackColor = true;
            this.UnloadFilter.Click += new System.EventHandler(this.UnloadFilter_Click);
            // 
            // LoadFilter
            // 
            this.LoadFilter.Location = new System.Drawing.Point(24, 240);
            this.LoadFilter.Name = "LoadFilter";
            this.LoadFilter.Size = new System.Drawing.Size(98, 23);
            this.LoadFilter.TabIndex = 3;
            this.LoadFilter.Text = "Load Filter";
            this.LoadFilter.UseVisualStyleBackColor = true;
            this.LoadFilter.Click += new System.EventHandler(this.LoadFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter List";
            // 
            // FilterList
            // 
            this.FilterList.FormattingEnabled = true;
            this.FilterList.Location = new System.Drawing.Point(24, 53);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(257, 134);
            this.FilterList.TabIndex = 1;
            // 
            // RefreshFilters
            // 
            this.RefreshFilters.Location = new System.Drawing.Point(24, 198);
            this.RefreshFilters.Name = "RefreshFilters";
            this.RefreshFilters.Size = new System.Drawing.Size(98, 23);
            this.RefreshFilters.TabIndex = 0;
            this.RefreshFilters.Text = "Refresh Filters";
            this.RefreshFilters.UseVisualStyleBackColor = true;
            this.RefreshFilters.Click += new System.EventHandler(this.RefreshFilters_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Controls.Add(this.btnHighlightFilter);
            this.tabPage1.Controls.Add(this.applyFilters);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(327, 398);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Receive Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "ID:";
            // 
            // btnHighlightFilter
            // 
            this.btnHighlightFilter.Location = new System.Drawing.Point(127, 78);
            this.btnHighlightFilter.Name = "btnHighlightFilter";
            this.btnHighlightFilter.Size = new System.Drawing.Size(105, 23);
            this.btnHighlightFilter.TabIndex = 55;
            this.btnHighlightFilter.Text = "Highlight Selection";
            this.btnHighlightFilter.UseVisualStyleBackColor = true;
            this.btnHighlightFilter.Click += new System.EventHandler(this.btnHighlightFilter_Click);
            // 
            // applyFilters
            // 
            this.applyFilters.Location = new System.Drawing.Point(24, 78);
            this.applyFilters.Name = "applyFilters";
            this.applyFilters.Size = new System.Drawing.Size(75, 23);
            this.applyFilters.TabIndex = 52;
            this.applyFilters.Text = "Apply Filters";
            this.applyFilters.UseVisualStyleBackColor = true;
            this.applyFilters.Click += new System.EventHandler(this.applyFilters_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 20);
            this.txtID.TabIndex = 49;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.FilterLoadStatus});
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 466);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(858, 22);
            this.toolStripStatusLabel1.TabIndex = 35;
            this.toolStripStatusLabel1.Text = "Bus Monitor";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel2.Text = "Bus Monitor";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(661, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // FilterLoadStatus
            // 
            this.FilterLoadStatus.Name = "FilterLoadStatus";
            this.FilterLoadStatus.Size = new System.Drawing.Size(110, 17);
            this.FilterLoadStatus.Text = "Filter Loaded: None";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 420);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backgroundWorkerRead
            // 
            this.backgroundWorkerRead.WorkerReportsProgress = true;
            this.backgroundWorkerRead.WorkerSupportsCancellation = true;
            // 
            // backgroundWorkerTester
            // 
            this.backgroundWorkerTester.WorkerSupportsCancellation = true;
            this.backgroundWorkerTester.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTester_DoWork);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.editToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(858, 25);
            this.editToolStripMenuItem.TabIndex = 39;
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyPacketToolStripMenuItem,
            this.renamePacketToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Edit";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // identifyPacketToolStripMenuItem
            // 
            this.identifyPacketToolStripMenuItem.Name = "identifyPacketToolStripMenuItem";
            this.identifyPacketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.identifyPacketToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.identifyPacketToolStripMenuItem.Text = "Identify Packet";
            this.identifyPacketToolStripMenuItem.Click += new System.EventHandler(this.identifyPacketToolStripMenuItem_Click_1);
            // 
            // renamePacketToolStripMenuItem
            // 
            this.renamePacketToolStripMenuItem.Name = "renamePacketToolStripMenuItem";
            this.renamePacketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renamePacketToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.renamePacketToolStripMenuItem.Text = "Rename Packet";
            this.renamePacketToolStripMenuItem.Click += new System.EventHandler(this.renamePacketToolStripMenuItem_Click_1);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click_1);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click_1);
            // 
            // BusMonitorCompact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 488);
            this.Controls.Add(this.editToolStripMenuItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusMonitorCompact";
            this.Text = "Bus Monitor Compact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusMonitorCompact_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BusMonitorCompact_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Monitor.ResumeLayout(false);
            this.Monitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTester)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TesterPresentDLC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMSB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.XMLFilter.ResumeLayout(false);
            this.XMLFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IfThenpictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripStatusLabel1.ResumeLayout(false);
            this.toolStripStatusLabel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editToolStripMenuItem.ResumeLayout(false);
            this.editToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Monitor;
        private System.Windows.Forms.PictureBox pictureBoxTester;
        private System.Windows.Forms.Button buttonTesterPresent;
        private System.Windows.Forms.Button RefreshInterfaces;
        private System.Windows.Forms.Label ReceiveCount;
        private System.Windows.Forms.Label lblReceiveCount;
        private System.Windows.Forms.Label lblTransmitInterface;
        private System.Windows.Forms.ComboBox TransmitInterfaceBox;
        private System.Windows.Forms.Button TransmitFuzz;
        private System.Windows.Forms.ComboBox ReceiveInterfaceBox;
        private System.Windows.Forms.Label lblReceiveInterface;
        private System.Windows.Forms.Button CopyClipboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TransmitPackets2;
        private System.Windows.Forms.Button ClearMonitor2;
        private System.Windows.Forms.Button MonitorBus2;
        private System.Windows.Forms.Button StopMonitor2;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TimeBetween;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TesterPresentMessage;
        private System.Windows.Forms.NumericUpDown TesterPresentDLC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TesterPresentID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox VerboseTransmit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLSB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericMSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Monitor_Decimal;
        private System.Windows.Forms.RadioButton Monitor_Hex;
        private System.Windows.Forms.Label MonitorOutput;
        private System.Windows.Forms.TabPage XMLFilter;
        private System.Windows.Forms.PictureBox IfThenpictureBox;
        private System.Windows.Forms.Button IfThenActivateButton;
        private System.Windows.Forms.Label FilterLoadLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UnloadFilter;
        private System.Windows.Forms.Button LoadFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox FilterList;
        private System.Windows.Forms.Button RefreshFilters;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnHighlightFilter;
        private System.Windows.Forms.Button applyFilters;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.StatusStrip toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel FilterLoadStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRead;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTester;
        private System.Windows.Forms.ToolStrip editToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem identifyPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renamePacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
    }
}