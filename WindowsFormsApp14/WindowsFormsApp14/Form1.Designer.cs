namespace WindowsFormsApp14
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SSH = new System.Windows.Forms.TabPage();
            this.textBoxVtyLines = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxKeyModulus = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxDomainNameSSH = new System.Windows.Forms.TextBox();
            this.textBoxUserNameSSH = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSSH = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButtonTelnet = new System.Windows.Forms.RadioButton();
            this.radioButtonSSH = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSSHTelnet = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TabPage();
            this.textBoxLoginTime = new System.Windows.Forms.TextBox();
            this.textBoxAttempts = new System.Windows.Forms.TextBox();
            this.textBoxLockoutTime = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonLoginBlock = new System.Windows.Forms.Button();
            this.checkBoxPassEncryption = new System.Windows.Forms.CheckBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.radioButtonSecretPass = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalPass = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConfPass = new System.Windows.Forms.Button();
            this.Interface = new System.Windows.Forms.TabPage();
            this.textBoxShutdown = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxInterface = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.radioButtonOspf = new System.Windows.Forms.RadioButton();
            this.buttonOverride = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.buttonConfInterface = new System.Windows.Forms.Button();
            this.textBoxAmountOfHosts = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRIP = new System.Windows.Forms.RadioButton();
            this.radioButtonEIGRP = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Host_Motd = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfHost = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.textBoxMOTD = new System.Windows.Forms.TextBox();
            this.DHCP = new System.Windows.Forms.TabPage();
            this.textBoxDNSServerSecondary = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonConfDHCP = new System.Windows.Forms.Button();
            this.textBoxExcludedAddresses = new System.Windows.Forms.TextBox();
            this.textBoxLeaseDuration = new System.Windows.Forms.TextBox();
            this.textBoxDefaultGateway = new System.Windows.Forms.TextBox();
            this.textBoxDNSServerPrimary = new System.Windows.Forms.TextBox();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.textBoxNetworkDHCP = new System.Windows.Forms.TextBox();
            this.textBoxPoolName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vlanTrunk = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxDot1q = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxSubnetVlan = new System.Windows.Forms.TextBox();
            this.textBoxIpVlan = new System.Windows.Forms.TextBox();
            this.textBoxInterfaceVlan = new System.Windows.Forms.TextBox();
            this.encapsulationDot1q = new System.Windows.Forms.CheckBox();
            this.trunkRadio = new System.Windows.Forms.RadioButton();
            this.dynamicRadio = new System.Windows.Forms.RadioButton();
            this.accessRadio = new System.Windows.Forms.RadioButton();
            this.vlanNameBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vlanNumBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.staticRoute = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.routeStatic = new System.Windows.Forms.Button();
            this.targetSubnet = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.nextJumpAddr = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.targetNetwork = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.SaveWork = new System.Windows.Forms.TabPage();
            this.buttonSaveConf = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonROMmon = new System.Windows.Forms.Button();
            this.buttonEraseNvram = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRouterReset = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxRouterOutput = new System.Windows.Forms.TextBox();
            this.buttonShutdownInterf = new System.Windows.Forms.Button();
            this.buttonNoShutdownInterf = new System.Windows.Forms.Button();
            this.SSH.SuspendLayout();
            this.Password.SuspendLayout();
            this.Interface.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Host_Motd.SuspendLayout();
            this.DHCP.SuspendLayout();
            this.vlanTrunk.SuspendLayout();
            this.staticRoute.SuspendLayout();
            this.SaveWork.SuspendLayout();
            this.Reset.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSH
            // 
            this.SSH.Controls.Add(this.textBoxVtyLines);
            this.SSH.Controls.Add(this.label21);
            this.SSH.Controls.Add(this.textBoxKeyModulus);
            this.SSH.Controls.Add(this.label19);
            this.SSH.Controls.Add(this.textBoxDomainNameSSH);
            this.SSH.Controls.Add(this.textBoxUserNameSSH);
            this.SSH.Controls.Add(this.textBoxPasswordSSH);
            this.SSH.Controls.Add(this.label18);
            this.SSH.Controls.Add(this.radioButtonTelnet);
            this.SSH.Controls.Add(this.radioButtonSSH);
            this.SSH.Controls.Add(this.label17);
            this.SSH.Controls.Add(this.label16);
            this.SSH.Controls.Add(this.buttonSSHTelnet);
            this.SSH.Location = new System.Drawing.Point(4, 25);
            this.SSH.Margin = new System.Windows.Forms.Padding(4);
            this.SSH.Name = "SSH";
            this.SSH.Padding = new System.Windows.Forms.Padding(4);
            this.SSH.Size = new System.Drawing.Size(780, 439);
            this.SSH.TabIndex = 2;
            this.SSH.Text = "SSH/Telnet";
            this.SSH.UseVisualStyleBackColor = true;
            // 
            // textBoxVtyLines
            // 
            this.textBoxVtyLines.Location = new System.Drawing.Point(225, 139);
            this.textBoxVtyLines.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVtyLines.Name = "textBoxVtyLines";
            this.textBoxVtyLines.Size = new System.Drawing.Size(132, 22);
            this.textBoxVtyLines.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(221, 119);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 17);
            this.label21.TabIndex = 11;
            this.label21.Text = "VTY lines example: 0 4";
            // 
            // textBoxKeyModulus
            // 
            this.textBoxKeyModulus.Location = new System.Drawing.Point(225, 91);
            this.textBoxKeyModulus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyModulus.Name = "textBoxKeyModulus";
            this.textBoxKeyModulus.Size = new System.Drawing.Size(131, 22);
            this.textBoxKeyModulus.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(221, 71);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(199, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "Size of key modulus 360-2048";
            // 
            // textBoxDomainNameSSH
            // 
            this.textBoxDomainNameSSH.Location = new System.Drawing.Point(80, 91);
            this.textBoxDomainNameSSH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDomainNameSSH.Name = "textBoxDomainNameSSH";
            this.textBoxDomainNameSSH.Size = new System.Drawing.Size(132, 22);
            this.textBoxDomainNameSSH.TabIndex = 8;
            // 
            // textBoxUserNameSSH
            // 
            this.textBoxUserNameSSH.Location = new System.Drawing.Point(80, 139);
            this.textBoxUserNameSSH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserNameSSH.Name = "textBoxUserNameSSH";
            this.textBoxUserNameSSH.Size = new System.Drawing.Size(132, 22);
            this.textBoxUserNameSSH.TabIndex = 7;
            // 
            // textBoxPasswordSSH
            // 
            this.textBoxPasswordSSH.Location = new System.Drawing.Point(80, 187);
            this.textBoxPasswordSSH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordSSH.Name = "textBoxPasswordSSH";
            this.textBoxPasswordSSH.Size = new System.Drawing.Size(132, 22);
            this.textBoxPasswordSSH.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(76, 167);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Password";
            // 
            // radioButtonTelnet
            // 
            this.radioButtonTelnet.AutoSize = true;
            this.radioButtonTelnet.Location = new System.Drawing.Point(225, 191);
            this.radioButtonTelnet.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTelnet.Name = "radioButtonTelnet";
            this.radioButtonTelnet.Size = new System.Drawing.Size(69, 21);
            this.radioButtonTelnet.TabIndex = 4;
            this.radioButtonTelnet.Text = "Telnet";
            this.radioButtonTelnet.UseVisualStyleBackColor = true;
            // 
            // radioButtonSSH
            // 
            this.radioButtonSSH.AutoSize = true;
            this.radioButtonSSH.Checked = true;
            this.radioButtonSSH.Location = new System.Drawing.Point(225, 167);
            this.radioButtonSSH.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSSH.Name = "radioButtonSSH";
            this.radioButtonSSH.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSSH.TabIndex = 3;
            this.radioButtonSSH.TabStop = true;
            this.radioButtonSSH.Text = "SSH";
            this.radioButtonSSH.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(76, 119);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "User Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 71);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Domain Name";
            // 
            // buttonSSHTelnet
            // 
            this.buttonSSHTelnet.Enabled = false;
            this.buttonSSHTelnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSHTelnet.Location = new System.Drawing.Point(80, 219);
            this.buttonSSHTelnet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSSHTelnet.Name = "buttonSSHTelnet";
            this.buttonSSHTelnet.Size = new System.Drawing.Size(267, 79);
            this.buttonSSHTelnet.TabIndex = 0;
            this.buttonSSHTelnet.Text = "Configure";
            this.buttonSSHTelnet.UseVisualStyleBackColor = true;
            this.buttonSSHTelnet.Click += new System.EventHandler(this.buttonSSHTelnet_Click);
            // 
            // Password
            // 
            this.Password.Controls.Add(this.textBoxLoginTime);
            this.Password.Controls.Add(this.textBoxAttempts);
            this.Password.Controls.Add(this.textBoxLockoutTime);
            this.Password.Controls.Add(this.label24);
            this.Password.Controls.Add(this.label23);
            this.Password.Controls.Add(this.label22);
            this.Password.Controls.Add(this.buttonLoginBlock);
            this.Password.Controls.Add(this.checkBoxPassEncryption);
            this.Password.Controls.Add(this.textBoxPassword2);
            this.Password.Controls.Add(this.textBoxPassword1);
            this.Password.Controls.Add(this.radioButtonSecretPass);
            this.Password.Controls.Add(this.radioButtonNormalPass);
            this.Password.Controls.Add(this.label7);
            this.Password.Controls.Add(this.buttonConfPass);
            this.Password.Location = new System.Drawing.Point(4, 25);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(4);
            this.Password.Size = new System.Drawing.Size(780, 439);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginTime
            // 
            this.textBoxLoginTime.Location = new System.Drawing.Point(556, 121);
            this.textBoxLoginTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginTime.Name = "textBoxLoginTime";
            this.textBoxLoginTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxLoginTime.TabIndex = 14;
            // 
            // textBoxAttempts
            // 
            this.textBoxAttempts.Location = new System.Drawing.Point(411, 166);
            this.textBoxAttempts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAttempts.Name = "textBoxAttempts";
            this.textBoxAttempts.Size = new System.Drawing.Size(132, 22);
            this.textBoxAttempts.TabIndex = 13;
            // 
            // textBoxLockoutTime
            // 
            this.textBoxLockoutTime.Location = new System.Drawing.Point(411, 121);
            this.textBoxLockoutTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLockoutTime.Name = "textBoxLockoutTime";
            this.textBoxLockoutTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxLockoutTime.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(552, 101);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 11;
            this.label24.Text = "Login time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(407, 146);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "Attempts";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(407, 101);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 17);
            this.label22.TabIndex = 9;
            this.label22.Text = "Lockout time";
            // 
            // buttonLoginBlock
            // 
            this.buttonLoginBlock.Enabled = false;
            this.buttonLoginBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginBlock.Location = new System.Drawing.Point(411, 197);
            this.buttonLoginBlock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginBlock.Name = "buttonLoginBlock";
            this.buttonLoginBlock.Size = new System.Drawing.Size(279, 70);
            this.buttonLoginBlock.TabIndex = 8;
            this.buttonLoginBlock.Text = "Configure";
            this.buttonLoginBlock.UseVisualStyleBackColor = true;
            this.buttonLoginBlock.Click += new System.EventHandler(this.buttonLoginBlock_Click);
            // 
            // checkBoxPassEncryption
            // 
            this.checkBoxPassEncryption.AutoSize = true;
            this.checkBoxPassEncryption.Location = new System.Drawing.Point(187, 166);
            this.checkBoxPassEncryption.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPassEncryption.Name = "checkBoxPassEncryption";
            this.checkBoxPassEncryption.Size = new System.Drawing.Size(162, 21);
            this.checkBoxPassEncryption.TabIndex = 7;
            this.checkBoxPassEncryption.Text = "Password Encryption";
            this.checkBoxPassEncryption.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(51, 166);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword2.TabIndex = 6;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(51, 140);
            this.textBoxPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword1.TabIndex = 2;
            // 
            // radioButtonSecretPass
            // 
            this.radioButtonSecretPass.AutoSize = true;
            this.radioButtonSecretPass.Location = new System.Drawing.Point(187, 142);
            this.radioButtonSecretPass.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSecretPass.Name = "radioButtonSecretPass";
            this.radioButtonSecretPass.Size = new System.Drawing.Size(135, 21);
            this.radioButtonSecretPass.TabIndex = 4;
            this.radioButtonSecretPass.TabStop = true;
            this.radioButtonSecretPass.Text = "Secret Password";
            this.radioButtonSecretPass.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormalPass
            // 
            this.radioButtonNormalPass.AutoSize = true;
            this.radioButtonNormalPass.Location = new System.Drawing.Point(187, 118);
            this.radioButtonNormalPass.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNormalPass.Name = "radioButtonNormalPass";
            this.radioButtonNormalPass.Size = new System.Drawing.Size(139, 21);
            this.radioButtonNormalPass.TabIndex = 3;
            this.radioButtonNormalPass.TabStop = true;
            this.radioButtonNormalPass.Text = "Normal Password";
            this.radioButtonNormalPass.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password";
            // 
            // buttonConfPass
            // 
            this.buttonConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfPass.Location = new System.Drawing.Point(51, 196);
            this.buttonConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfPass.Name = "buttonConfPass";
            this.buttonConfPass.Size = new System.Drawing.Size(281, 71);
            this.buttonConfPass.TabIndex = 0;
            this.buttonConfPass.Text = "Configure";
            this.buttonConfPass.UseVisualStyleBackColor = true;
            this.buttonConfPass.Click += new System.EventHandler(this.buttonConfPass_Click);
            // 
            // Interface
            // 
            this.Interface.Controls.Add(this.buttonNoShutdownInterf);
            this.Interface.Controls.Add(this.buttonShutdownInterf);
            this.Interface.Controls.Add(this.textBoxShutdown);
            this.Interface.Controls.Add(this.label35);
            this.Interface.Controls.Add(this.textBoxInterface);
            this.Interface.Controls.Add(this.labelArea);
            this.Interface.Controls.Add(this.textBoxArea);
            this.Interface.Controls.Add(this.radioButtonOspf);
            this.Interface.Controls.Add(this.buttonOverride);
            this.Interface.Controls.Add(this.label6);
            this.Interface.Controls.Add(this.comboBoxSerialPorts);
            this.Interface.Controls.Add(this.radioButtonNone);
            this.Interface.Controls.Add(this.buttonConfInterface);
            this.Interface.Controls.Add(this.textBoxAmountOfHosts);
            this.Interface.Controls.Add(this.textBoxIpAddress);
            this.Interface.Controls.Add(this.label3);
            this.Interface.Controls.Add(this.label2);
            this.Interface.Controls.Add(this.label1);
            this.Interface.Controls.Add(this.radioButtonRIP);
            this.Interface.Controls.Add(this.radioButtonEIGRP);
            this.Interface.Location = new System.Drawing.Point(4, 25);
            this.Interface.Margin = new System.Windows.Forms.Padding(4);
            this.Interface.Name = "Interface";
            this.Interface.Padding = new System.Windows.Forms.Padding(4);
            this.Interface.Size = new System.Drawing.Size(780, 439);
            this.Interface.TabIndex = 0;
            this.Interface.Text = "Interface";
            this.Interface.UseVisualStyleBackColor = true;
            // 
            // textBoxShutdown
            // 
            this.textBoxShutdown.Location = new System.Drawing.Point(550, 104);
            this.textBoxShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShutdown.Name = "textBoxShutdown";
            this.textBoxShutdown.Size = new System.Drawing.Size(189, 22);
            this.textBoxShutdown.TabIndex = 23;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(550, 85);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 17);
            this.label35.TabIndex = 22;
            this.label35.Text = "Interface";
            this.toolTip1.SetToolTip(this.label35, "If range is needed simply type \"range\" before your selected ranges.");
            // 
            // textBoxInterface
            // 
            this.textBoxInterface.Location = new System.Drawing.Point(104, 154);
            this.textBoxInterface.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInterface.Name = "textBoxInterface";
            this.textBoxInterface.Size = new System.Drawing.Size(160, 22);
            this.textBoxInterface.TabIndex = 21;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(364, 92);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(38, 17);
            this.labelArea.TabIndex = 20;
            this.labelArea.Text = "Area";
            this.labelArea.Visible = false;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(367, 113);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(71, 22);
            this.textBoxArea.TabIndex = 19;
            this.textBoxArea.Visible = false;
            // 
            // radioButtonOspf
            // 
            this.radioButtonOspf.AutoSize = true;
            this.radioButtonOspf.Location = new System.Drawing.Point(293, 114);
            this.radioButtonOspf.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOspf.Name = "radioButtonOspf";
            this.radioButtonOspf.Size = new System.Drawing.Size(66, 21);
            this.radioButtonOspf.TabIndex = 18;
            this.radioButtonOspf.Text = "OSPF";
            this.radioButtonOspf.UseVisualStyleBackColor = true;
            this.radioButtonOspf.CheckedChanged += new System.EventHandler(this.RadioButtonOspf_CheckedChanged);
            // 
            // buttonOverride
            // 
            this.buttonOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverride.Location = new System.Drawing.Point(8, 363);
            this.buttonOverride.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOverride.Name = "buttonOverride";
            this.buttonOverride.Size = new System.Drawing.Size(201, 59);
            this.buttonOverride.TabIndex = 17;
            this.buttonOverride.Text = "Override startup feature";
            this.buttonOverride.UseVisualStyleBackColor = true;
            this.buttonOverride.Click += new System.EventHandler(this.buttonOverride_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select COM port";
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(104, 105);
            this.comboBoxSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSerialPorts.TabIndex = 15;
            this.comboBoxSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPorts_SelectedIndexChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(293, 85);
            this.radioButtonNone.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNone.TabIndex = 14;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.RadioButtonNone_CheckedChanged);
            // 
            // buttonConfInterface
            // 
            this.buttonConfInterface.Enabled = false;
            this.buttonConfInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfInterface.Location = new System.Drawing.Point(104, 241);
            this.buttonConfInterface.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfInterface.Name = "buttonConfInterface";
            this.buttonConfInterface.Size = new System.Drawing.Size(303, 59);
            this.buttonConfInterface.TabIndex = 0;
            this.buttonConfInterface.Text = "Configure";
            this.buttonConfInterface.UseVisualStyleBackColor = true;
            this.buttonConfInterface.Click += new System.EventHandler(this.buttonConfInterface_Click);
            // 
            // textBoxAmountOfHosts
            // 
            this.textBoxAmountOfHosts.Location = new System.Drawing.Point(273, 209);
            this.textBoxAmountOfHosts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmountOfHosts.Name = "textBoxAmountOfHosts";
            this.textBoxAmountOfHosts.Size = new System.Drawing.Size(132, 22);
            this.textBoxAmountOfHosts.TabIndex = 4;
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(104, 209);
            this.textBoxIpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(160, 22);
            this.textBoxIpAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount of hosts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Interface";
            this.toolTip1.SetToolTip(this.label1, "If range is needed simply type \"range\" before your selected ranges.");
            // 
            // radioButtonRIP
            // 
            this.radioButtonRIP.AutoSize = true;
            this.radioButtonRIP.Location = new System.Drawing.Point(293, 169);
            this.radioButtonRIP.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRIP.Name = "radioButtonRIP";
            this.radioButtonRIP.Size = new System.Drawing.Size(51, 21);
            this.radioButtonRIP.TabIndex = 8;
            this.radioButtonRIP.Text = "RIP";
            this.radioButtonRIP.UseVisualStyleBackColor = true;
            this.radioButtonRIP.CheckedChanged += new System.EventHandler(this.RadioButtonRIP_CheckedChanged);
            // 
            // radioButtonEIGRP
            // 
            this.radioButtonEIGRP.AutoSize = true;
            this.radioButtonEIGRP.Location = new System.Drawing.Point(293, 140);
            this.radioButtonEIGRP.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEIGRP.Name = "radioButtonEIGRP";
            this.radioButtonEIGRP.Size = new System.Drawing.Size(71, 21);
            this.radioButtonEIGRP.TabIndex = 7;
            this.radioButtonEIGRP.Text = "EIGRP";
            this.radioButtonEIGRP.UseVisualStyleBackColor = true;
            this.radioButtonEIGRP.CheckedChanged += new System.EventHandler(this.RadioButtonEIGRP_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Interface);
            this.tabControl.Controls.Add(this.Host_Motd);
            this.tabControl.Controls.Add(this.DHCP);
            this.tabControl.Controls.Add(this.Password);
            this.tabControl.Controls.Add(this.SSH);
            this.tabControl.Controls.Add(this.vlanTrunk);
            this.tabControl.Controls.Add(this.staticRoute);
            this.tabControl.Controls.Add(this.SaveWork);
            this.tabControl.Controls.Add(this.Reset);
            this.tabControl.Location = new System.Drawing.Point(3, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 468);
            this.tabControl.TabIndex = 15;
            // 
            // Host_Motd
            // 
            this.Host_Motd.Controls.Add(this.label5);
            this.Host_Motd.Controls.Add(this.buttonConfHost);
            this.Host_Motd.Controls.Add(this.label4);
            this.Host_Motd.Controls.Add(this.textBoxHostName);
            this.Host_Motd.Controls.Add(this.textBoxMOTD);
            this.Host_Motd.Location = new System.Drawing.Point(4, 25);
            this.Host_Motd.Name = "Host_Motd";
            this.Host_Motd.Padding = new System.Windows.Forms.Padding(3);
            this.Host_Motd.Size = new System.Drawing.Size(780, 439);
            this.Host_Motd.TabIndex = 9;
            this.Host_Motd.Text = "Host/MOTD";
            this.Host_Motd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Message of the day";
            // 
            // buttonConfHost
            // 
            this.buttonConfHost.Enabled = false;
            this.buttonConfHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfHost.Location = new System.Drawing.Point(255, 215);
            this.buttonConfHost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfHost.Name = "buttonConfHost";
            this.buttonConfHost.Size = new System.Drawing.Size(275, 59);
            this.buttonConfHost.TabIndex = 14;
            this.buttonConfHost.Text = "Configure";
            this.toolTip1.SetToolTip(this.buttonConfHost, "Configures hostname and message of the day");
            this.buttonConfHost.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Host name";
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(255, 183);
            this.textBoxHostName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(132, 22);
            this.textBoxHostName.TabIndex = 15;
            // 
            // textBoxMOTD
            // 
            this.textBoxMOTD.Location = new System.Drawing.Point(397, 183);
            this.textBoxMOTD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMOTD.Name = "textBoxMOTD";
            this.textBoxMOTD.Size = new System.Drawing.Size(132, 22);
            this.textBoxMOTD.TabIndex = 16;
            // 
            // DHCP
            // 
            this.DHCP.Controls.Add(this.textBoxDNSServerSecondary);
            this.DHCP.Controls.Add(this.label15);
            this.DHCP.Controls.Add(this.buttonConfDHCP);
            this.DHCP.Controls.Add(this.textBoxExcludedAddresses);
            this.DHCP.Controls.Add(this.textBoxLeaseDuration);
            this.DHCP.Controls.Add(this.textBoxDefaultGateway);
            this.DHCP.Controls.Add(this.textBoxDNSServerPrimary);
            this.DHCP.Controls.Add(this.textBoxDomainName);
            this.DHCP.Controls.Add(this.textBoxNetworkDHCP);
            this.DHCP.Controls.Add(this.textBoxPoolName);
            this.DHCP.Controls.Add(this.label14);
            this.DHCP.Controls.Add(this.label13);
            this.DHCP.Controls.Add(this.label12);
            this.DHCP.Controls.Add(this.label11);
            this.DHCP.Controls.Add(this.label10);
            this.DHCP.Controls.Add(this.label9);
            this.DHCP.Controls.Add(this.label8);
            this.DHCP.Location = new System.Drawing.Point(4, 25);
            this.DHCP.Margin = new System.Windows.Forms.Padding(4);
            this.DHCP.Name = "DHCP";
            this.DHCP.Padding = new System.Windows.Forms.Padding(4);
            this.DHCP.Size = new System.Drawing.Size(780, 439);
            this.DHCP.TabIndex = 4;
            this.DHCP.Text = "DHCP";
            this.DHCP.UseVisualStyleBackColor = true;
            // 
            // textBoxDNSServerSecondary
            // 
            this.textBoxDNSServerSecondary.Location = new System.Drawing.Point(385, 224);
            this.textBoxDNSServerSecondary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDNSServerSecondary.Name = "textBoxDNSServerSecondary";
            this.textBoxDNSServerSecondary.Size = new System.Drawing.Size(188, 22);
            this.textBoxDNSServerSecondary.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 204);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Secondary DNS-Server address";
            // 
            // buttonConfDHCP
            // 
            this.buttonConfDHCP.Enabled = false;
            this.buttonConfDHCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfDHCP.Location = new System.Drawing.Point(75, 278);
            this.buttonConfDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfDHCP.Name = "buttonConfDHCP";
            this.buttonConfDHCP.Size = new System.Drawing.Size(500, 75);
            this.buttonConfDHCP.TabIndex = 14;
            this.buttonConfDHCP.Text = "Configure";
            this.buttonConfDHCP.UseVisualStyleBackColor = true;
            this.buttonConfDHCP.Click += new System.EventHandler(this.buttonConfDHCP_Click);
            // 
            // textBoxExcludedAddresses
            // 
            this.textBoxExcludedAddresses.Location = new System.Drawing.Point(385, 122);
            this.textBoxExcludedAddresses.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExcludedAddresses.Name = "textBoxExcludedAddresses";
            this.textBoxExcludedAddresses.Size = new System.Drawing.Size(188, 22);
            this.textBoxExcludedAddresses.TabIndex = 13;
            // 
            // textBoxLeaseDuration
            // 
            this.textBoxLeaseDuration.Location = new System.Drawing.Point(385, 66);
            this.textBoxLeaseDuration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLeaseDuration.Name = "textBoxLeaseDuration";
            this.textBoxLeaseDuration.Size = new System.Drawing.Size(188, 22);
            this.textBoxLeaseDuration.TabIndex = 12;
            // 
            // textBoxDefaultGateway
            // 
            this.textBoxDefaultGateway.Location = new System.Drawing.Point(75, 224);
            this.textBoxDefaultGateway.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDefaultGateway.Name = "textBoxDefaultGateway";
            this.textBoxDefaultGateway.Size = new System.Drawing.Size(188, 22);
            this.textBoxDefaultGateway.TabIndex = 11;
            // 
            // textBoxDNSServerPrimary
            // 
            this.textBoxDNSServerPrimary.Location = new System.Drawing.Point(385, 176);
            this.textBoxDNSServerPrimary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDNSServerPrimary.Name = "textBoxDNSServerPrimary";
            this.textBoxDNSServerPrimary.Size = new System.Drawing.Size(188, 22);
            this.textBoxDNSServerPrimary.TabIndex = 10;
            // 
            // textBoxDomainName
            // 
            this.textBoxDomainName.Location = new System.Drawing.Point(75, 176);
            this.textBoxDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(188, 22);
            this.textBoxDomainName.TabIndex = 9;
            // 
            // textBoxNetworkDHCP
            // 
            this.textBoxNetworkDHCP.Location = new System.Drawing.Point(75, 122);
            this.textBoxNetworkDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetworkDHCP.Name = "textBoxNetworkDHCP";
            this.textBoxNetworkDHCP.Size = new System.Drawing.Size(188, 22);
            this.textBoxNetworkDHCP.TabIndex = 8;
            // 
            // textBoxPoolName
            // 
            this.textBoxPoolName.Location = new System.Drawing.Point(75, 66);
            this.textBoxPoolName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPoolName.Name = "textBoxPoolName";
            this.textBoxPoolName.Size = new System.Drawing.Size(188, 22);
            this.textBoxPoolName.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Excluded addresses example : 1.1.1.10 1.1.1.11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 47);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Lease Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Default Gateway";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Primary DNS-Server address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Network example : 1.1.1.1 /8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Domain Name example : Mydomain.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address Pool Name";
            // 
            // vlanTrunk
            // 
            this.vlanTrunk.Controls.Add(this.label34);
            this.vlanTrunk.Controls.Add(this.textBoxDot1q);
            this.vlanTrunk.Controls.Add(this.label33);
            this.vlanTrunk.Controls.Add(this.label32);
            this.vlanTrunk.Controls.Add(this.textBoxSubnetVlan);
            this.vlanTrunk.Controls.Add(this.textBoxIpVlan);
            this.vlanTrunk.Controls.Add(this.textBoxInterfaceVlan);
            this.vlanTrunk.Controls.Add(this.encapsulationDot1q);
            this.vlanTrunk.Controls.Add(this.trunkRadio);
            this.vlanTrunk.Controls.Add(this.dynamicRadio);
            this.vlanTrunk.Controls.Add(this.accessRadio);
            this.vlanTrunk.Controls.Add(this.vlanNameBox);
            this.vlanTrunk.Controls.Add(this.label27);
            this.vlanTrunk.Controls.Add(this.button1);
            this.vlanTrunk.Controls.Add(this.vlanNumBox);
            this.vlanTrunk.Controls.Add(this.label26);
            this.vlanTrunk.Controls.Add(this.label25);
            this.vlanTrunk.Location = new System.Drawing.Point(4, 25);
            this.vlanTrunk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlanTrunk.Name = "vlanTrunk";
            this.vlanTrunk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlanTrunk.Size = new System.Drawing.Size(780, 439);
            this.vlanTrunk.TabIndex = 7;
            this.vlanTrunk.Text = "Vlan/Trunking";
            this.vlanTrunk.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(52, 257);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 17);
            this.label34.TabIndex = 27;
            this.label34.Text = "dot1q number";
            // 
            // textBoxDot1q
            // 
            this.textBoxDot1q.Location = new System.Drawing.Point(56, 276);
            this.textBoxDot1q.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDot1q.Name = "textBoxDot1q";
            this.textBoxDot1q.Size = new System.Drawing.Size(161, 22);
            this.textBoxDot1q.TabIndex = 26;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(53, 194);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 17);
            this.label33.TabIndex = 25;
            this.label33.Text = "Subnet";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(53, 130);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 17);
            this.label32.TabIndex = 24;
            this.label32.Text = "Ip-address";
            // 
            // textBoxSubnetVlan
            // 
            this.textBoxSubnetVlan.Location = new System.Drawing.Point(57, 213);
            this.textBoxSubnetVlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubnetVlan.Name = "textBoxSubnetVlan";
            this.textBoxSubnetVlan.Size = new System.Drawing.Size(161, 22);
            this.textBoxSubnetVlan.TabIndex = 23;
            // 
            // textBoxIpVlan
            // 
            this.textBoxIpVlan.Location = new System.Drawing.Point(56, 149);
            this.textBoxIpVlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIpVlan.Name = "textBoxIpVlan";
            this.textBoxIpVlan.Size = new System.Drawing.Size(161, 22);
            this.textBoxIpVlan.TabIndex = 22;
            // 
            // textBoxInterfaceVlan
            // 
            this.textBoxInterfaceVlan.Location = new System.Drawing.Point(56, 82);
            this.textBoxInterfaceVlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInterfaceVlan.Name = "textBoxInterfaceVlan";
            this.textBoxInterfaceVlan.Size = new System.Drawing.Size(161, 22);
            this.textBoxInterfaceVlan.TabIndex = 21;
            // 
            // encapsulationDot1q
            // 
            this.encapsulationDot1q.AutoSize = true;
            this.encapsulationDot1q.Location = new System.Drawing.Point(349, 218);
            this.encapsulationDot1q.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encapsulationDot1q.Name = "encapsulationDot1q";
            this.encapsulationDot1q.Size = new System.Drawing.Size(116, 21);
            this.encapsulationDot1q.TabIndex = 20;
            this.encapsulationDot1q.Text = "dot1Q encap.";
            this.encapsulationDot1q.UseVisualStyleBackColor = true;
            // 
            // trunkRadio
            // 
            this.trunkRadio.AutoSize = true;
            this.trunkRadio.Location = new System.Drawing.Point(349, 190);
            this.trunkRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trunkRadio.Name = "trunkRadio";
            this.trunkRadio.Size = new System.Drawing.Size(66, 21);
            this.trunkRadio.TabIndex = 19;
            this.trunkRadio.TabStop = true;
            this.trunkRadio.Text = "Trunk";
            this.trunkRadio.UseVisualStyleBackColor = true;
            // 
            // dynamicRadio
            // 
            this.dynamicRadio.AutoSize = true;
            this.dynamicRadio.Location = new System.Drawing.Point(268, 217);
            this.dynamicRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dynamicRadio.Name = "dynamicRadio";
            this.dynamicRadio.Size = new System.Drawing.Size(83, 21);
            this.dynamicRadio.TabIndex = 18;
            this.dynamicRadio.TabStop = true;
            this.dynamicRadio.Text = "Dynamic";
            this.dynamicRadio.UseVisualStyleBackColor = true;
            // 
            // accessRadio
            // 
            this.accessRadio.AutoSize = true;
            this.accessRadio.Location = new System.Drawing.Point(269, 190);
            this.accessRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessRadio.Name = "accessRadio";
            this.accessRadio.Size = new System.Drawing.Size(74, 21);
            this.accessRadio.TabIndex = 17;
            this.accessRadio.TabStop = true;
            this.accessRadio.Text = "Access";
            this.accessRadio.UseVisualStyleBackColor = true;
            // 
            // vlanNameBox
            // 
            this.vlanNameBox.Location = new System.Drawing.Point(272, 149);
            this.vlanNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlanNameBox.Name = "vlanNameBox";
            this.vlanNameBox.Size = new System.Drawing.Size(159, 22);
            this.vlanNameBox.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(269, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(111, 17);
            this.label27.TabIndex = 15;
            this.label27.Text = "Enter vlan name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 76);
            this.button1.TabIndex = 14;
            this.button1.Text = "Configure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // vlanNumBox
            // 
            this.vlanNumBox.Location = new System.Drawing.Point(269, 84);
            this.vlanNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlanNumBox.Name = "vlanNumBox";
            this.vlanNumBox.Size = new System.Drawing.Size(161, 22);
            this.vlanNumBox.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(267, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(260, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "Enter vlan numbers divided by a comma";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(52, 64);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 17);
            this.label25.TabIndex = 11;
            this.label25.Text = "Interface";
            // 
            // staticRoute
            // 
            this.staticRoute.Controls.Add(this.label31);
            this.staticRoute.Controls.Add(this.routeStatic);
            this.staticRoute.Controls.Add(this.targetSubnet);
            this.staticRoute.Controls.Add(this.label30);
            this.staticRoute.Controls.Add(this.nextJumpAddr);
            this.staticRoute.Controls.Add(this.label29);
            this.staticRoute.Controls.Add(this.targetNetwork);
            this.staticRoute.Controls.Add(this.label28);
            this.staticRoute.Location = new System.Drawing.Point(4, 25);
            this.staticRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staticRoute.Name = "staticRoute";
            this.staticRoute.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staticRoute.Size = new System.Drawing.Size(780, 439);
            this.staticRoute.TabIndex = 8;
            this.staticRoute.Text = "Static Route";
            this.staticRoute.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(75, 209);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(469, 18);
            this.label31.TabIndex = 7;
            this.label31.Text = "OBS. If more routes are necessary simply repeat the process";
            // 
            // routeStatic
            // 
            this.routeStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeStatic.Location = new System.Drawing.Point(77, 113);
            this.routeStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.routeStatic.Name = "routeStatic";
            this.routeStatic.Size = new System.Drawing.Size(465, 94);
            this.routeStatic.TabIndex = 6;
            this.routeStatic.Text = "Configure";
            this.routeStatic.UseVisualStyleBackColor = true;
            this.routeStatic.Click += new System.EventHandler(this.routeStatic_Click);
            // 
            // targetSubnet
            // 
            this.targetSubnet.Location = new System.Drawing.Point(235, 84);
            this.targetSubnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetSubnet.Name = "targetSubnet";
            this.targetSubnet.Size = new System.Drawing.Size(151, 22);
            this.targetSubnet.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(232, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "Enter Target Subnet";
            // 
            // nextJumpAddr
            // 
            this.nextJumpAddr.Location = new System.Drawing.Point(392, 84);
            this.nextJumpAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextJumpAddr.Name = "nextJumpAddr";
            this.nextJumpAddr.Size = new System.Drawing.Size(151, 22);
            this.nextJumpAddr.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(389, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 17);
            this.label29.TabIndex = 2;
            this.label29.Text = "Enter Next Jump Addr.";
            // 
            // targetNetwork
            // 
            this.targetNetwork.Location = new System.Drawing.Point(77, 84);
            this.targetNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetNetwork.Name = "targetNetwork";
            this.targetNetwork.Size = new System.Drawing.Size(151, 22);
            this.targetNetwork.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(75, 63);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(143, 17);
            this.label28.TabIndex = 0;
            this.label28.Text = "Enter Target Network";
            // 
            // SaveWork
            // 
            this.SaveWork.Controls.Add(this.buttonSaveConf);
            this.SaveWork.Location = new System.Drawing.Point(4, 25);
            this.SaveWork.Margin = new System.Windows.Forms.Padding(4);
            this.SaveWork.Name = "SaveWork";
            this.SaveWork.Padding = new System.Windows.Forms.Padding(4);
            this.SaveWork.Size = new System.Drawing.Size(780, 439);
            this.SaveWork.TabIndex = 5;
            this.SaveWork.Text = "Save Work";
            this.SaveWork.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConf
            // 
            this.buttonSaveConf.Enabled = false;
            this.buttonSaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConf.Location = new System.Drawing.Point(176, 123);
            this.buttonSaveConf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveConf.Name = "buttonSaveConf";
            this.buttonSaveConf.Size = new System.Drawing.Size(383, 159);
            this.buttonSaveConf.TabIndex = 0;
            this.buttonSaveConf.Text = "Save configuration";
            this.buttonSaveConf.UseVisualStyleBackColor = true;
            this.buttonSaveConf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reset
            // 
            this.Reset.Controls.Add(this.label20);
            this.Reset.Controls.Add(this.labelTimer);
            this.Reset.Controls.Add(this.buttonROMmon);
            this.Reset.Controls.Add(this.buttonEraseNvram);
            this.Reset.Location = new System.Drawing.Point(4, 25);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Padding = new System.Windows.Forms.Padding(4);
            this.Reset.Size = new System.Drawing.Size(780, 439);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(449, 156);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "Time until completion :";
            this.label20.Visible = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(607, 156);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(32, 17);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "170";
            this.labelTimer.Visible = false;
            // 
            // buttonROMmon
            // 
            this.buttonROMmon.Enabled = false;
            this.buttonROMmon.Location = new System.Drawing.Point(453, 176);
            this.buttonROMmon.Margin = new System.Windows.Forms.Padding(4);
            this.buttonROMmon.Name = "buttonROMmon";
            this.buttonROMmon.Size = new System.Drawing.Size(197, 101);
            this.buttonROMmon.TabIndex = 1;
            this.buttonROMmon.Text = "ROMmon reset";
            this.buttonROMmon.UseVisualStyleBackColor = true;
            this.buttonROMmon.Visible = false;
            this.buttonROMmon.Click += new System.EventHandler(this.buttonROMmon_Click);
            // 
            // buttonEraseNvram
            // 
            this.buttonEraseNvram.Enabled = false;
            this.buttonEraseNvram.Location = new System.Drawing.Point(124, 176);
            this.buttonEraseNvram.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEraseNvram.Name = "buttonEraseNvram";
            this.buttonEraseNvram.Size = new System.Drawing.Size(197, 101);
            this.buttonEraseNvram.TabIndex = 0;
            this.buttonEraseNvram.Text = "Erase NV RAM";
            this.buttonEraseNvram.UseVisualStyleBackColor = true;
            this.buttonEraseNvram.Click += new System.EventHandler(this.buttonEraseNvram_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRouterReset
            // 
            this.timerRouterReset.Interval = 1000;
            this.timerRouterReset.Tick += new System.EventHandler(this.timerRouterReset_Tick);
            // 
            // textBoxRouterOutput
            // 
            this.textBoxRouterOutput.Location = new System.Drawing.Point(812, 25);
            this.textBoxRouterOutput.Multiline = true;
            this.textBoxRouterOutput.Name = "textBoxRouterOutput";
            this.textBoxRouterOutput.ReadOnly = true;
            this.textBoxRouterOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRouterOutput.Size = new System.Drawing.Size(443, 439);
            this.textBoxRouterOutput.TabIndex = 16;
            // 
            // buttonShutdownInterf
            // 
            this.buttonShutdownInterf.Location = new System.Drawing.Point(550, 130);
            this.buttonShutdownInterf.Name = "buttonShutdownInterf";
            this.buttonShutdownInterf.Size = new System.Drawing.Size(84, 23);
            this.buttonShutdownInterf.TabIndex = 24;
            this.buttonShutdownInterf.Text = "Shutdown";
            this.buttonShutdownInterf.UseVisualStyleBackColor = true;
            this.buttonShutdownInterf.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonNoShutdownInterf
            // 
            this.buttonNoShutdownInterf.Location = new System.Drawing.Point(632, 130);
            this.buttonNoShutdownInterf.Name = "buttonNoShutdownInterf";
            this.buttonNoShutdownInterf.Size = new System.Drawing.Size(107, 23);
            this.buttonNoShutdownInterf.TabIndex = 25;
            this.buttonNoShutdownInterf.Text = "No Shutdown";
            this.buttonNoShutdownInterf.UseVisualStyleBackColor = true;
            this.buttonNoShutdownInterf.Click += new System.EventHandler(this.ButtonNoShutdownInterf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 475);
            this.Controls.Add(this.textBoxRouterOutput);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bjørns Router Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SSH.ResumeLayout(false);
            this.SSH.PerformLayout();
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            this.Interface.ResumeLayout(false);
            this.Interface.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Host_Motd.ResumeLayout(false);
            this.Host_Motd.PerformLayout();
            this.DHCP.ResumeLayout(false);
            this.DHCP.PerformLayout();
            this.vlanTrunk.ResumeLayout(false);
            this.vlanTrunk.PerformLayout();
            this.staticRoute.ResumeLayout(false);
            this.staticRoute.PerformLayout();
            this.SaveWork.ResumeLayout(false);
            this.Reset.ResumeLayout(false);
            this.Reset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage SSH;
        private System.Windows.Forms.TabPage Password;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.RadioButton radioButtonSecretPass;
        private System.Windows.Forms.RadioButton radioButtonNormalPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConfPass;
        private System.Windows.Forms.TabPage Interface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.Button buttonConfInterface;
        private System.Windows.Forms.TextBox textBoxAmountOfHosts;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRIP;
        private System.Windows.Forms.RadioButton radioButtonEIGRP;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage DHCP;
        private System.Windows.Forms.Button buttonConfDHCP;
        private System.Windows.Forms.TextBox textBoxExcludedAddresses;
        private System.Windows.Forms.TextBox textBoxLeaseDuration;
        private System.Windows.Forms.TextBox textBoxDefaultGateway;
        private System.Windows.Forms.TextBox textBoxDNSServerPrimary;
        private System.Windows.Forms.TextBox textBoxDomainName;
        private System.Windows.Forms.TextBox textBoxNetworkDHCP;
        private System.Windows.Forms.TextBox textBoxPoolName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDNSServerSecondary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxPassEncryption;
        private System.Windows.Forms.Button buttonSSHTelnet;
        private System.Windows.Forms.TextBox textBoxDomainNameSSH;
        private System.Windows.Forms.TextBox textBoxUserNameSSH;
        private System.Windows.Forms.TextBox textBoxPasswordSSH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioButtonTelnet;
        private System.Windows.Forms.RadioButton radioButtonSSH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxKeyModulus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage SaveWork;
        private System.Windows.Forms.Button buttonSaveConf;
        private System.Windows.Forms.TabPage Reset;
        private System.Windows.Forms.Button buttonROMmon;
        private System.Windows.Forms.Button buttonEraseNvram;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox textBoxVtyLines;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxLoginTime;
        private System.Windows.Forms.TextBox textBoxAttempts;
        private System.Windows.Forms.TextBox textBoxLockoutTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonLoginBlock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timerRouterReset;
        private System.Windows.Forms.Button buttonOverride;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage vlanTrunk;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vlanNumBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox vlanNameBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton trunkRadio;
        private System.Windows.Forms.RadioButton dynamicRadio;
        private System.Windows.Forms.RadioButton accessRadio;
        private System.Windows.Forms.TabPage staticRoute;
        private System.Windows.Forms.Button routeStatic;
        private System.Windows.Forms.TextBox targetSubnet;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox nextJumpAddr;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox targetNetwork;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox encapsulationDot1q;
        private System.Windows.Forms.RadioButton radioButtonOspf;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxInterface;
        private System.Windows.Forms.TextBox textBoxInterfaceVlan;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxSubnetVlan;
        private System.Windows.Forms.TextBox textBoxIpVlan;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxDot1q;
        private System.IO.Ports.SerialPort serialPort2;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxRouterOutput;
        private System.Windows.Forms.TabPage Host_Motd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.TextBox textBoxMOTD;
        private System.Windows.Forms.TextBox textBoxShutdown;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button buttonNoShutdownInterf;
        private System.Windows.Forms.Button buttonShutdownInterf;
    }
}

