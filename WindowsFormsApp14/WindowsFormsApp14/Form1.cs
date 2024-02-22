#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
#endregion

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        #region CiscoConfig
        DateTime routerResetFinishTime = DateTime.MaxValue;

        public delegate void AddDataDelegate(String dataStream);
        public AddDataDelegate myDelegate;

        #region Program Startup Function Bools
        public string routerOutput = "";
        bool answeredDialog = false;
        bool answeredTerminateAuto = false;
        bool answeredPressReturn = false;
        bool rommonBreak = false;
        bool rommonMode = false;
        bool delayTimerRun = false;
        bool reloadFunction = false;
        #endregion

        #region Startup Delay
        async Task startupDelay()
        {
            await Task.Delay(10000);
        }
        #endregion

        #region SSH Delay Timer
        async Task SSHDelay()
        {
            await Task.Delay(15000);
        }
        #endregion

        #region NVRAM Delay Timer
        async Task NVRAMDelay()
        {
            await Task.Delay(10000);
        }
        #endregion

        #region Rommon Delay Timer
        async Task RommonDelay()
        {
            await Task.Delay(120000);
        }
        #endregion

        #region SecondDelay
        async Task SecondDelay()
        {
            await Task.Delay(1000);
        }
        #endregion

        string ipAddress = "";
        int area = 0;

        public Form1()
        {
            InitializeComponent();
        }


        #region SerialPort
        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] serialPorts = SerialPort.GetPortNames();
                foreach (string serialPort in serialPorts)
                {
                    comboBoxSerialPorts.Items.Add(serialPort);
                }

                if (comboBoxSerialPorts.Items.Count > 0)
                    comboBoxSerialPorts.SelectedIndex = 0;

                serialPort1.Open();
                
            }
            catch (Exception error)
            {
                if (error is System.IO.IOException)
                {
                    MessageBox.Show("No COM port connection detected!\nPlease check your connection and restart the program");
                    Environment.Exit(0);
                }
                else
                    throw;
            }

            myDelegate = new AddDataDelegate(AddDataMethod);
        }

        public void AddDataMethod(String dataStream)
        {
            textBoxRouterOutput.AppendText(dataStream);
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            textBoxRouterOutput.Invoke(myDelegate, new Object[] { indata });
        }

        private void comboBoxSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxSerialPorts.SelectedItem.ToString();
        }
        #endregion

        
        private void Enable()
        {
            writeToRouter("");
            writeToRouter("enable");
            writeToRouter("configure terminal");
        }

        #region Interface Configuration
        private void buttonConfInterface_Click(object sender, EventArgs e)
        {
            #region Variables
            ipAddress = textBoxIpAddress.Text;
            int hosts = Convert.ToInt32(textBoxAmountOfHosts.Text);
            area = Convert.ToInt32(textBoxArea.Text);
            #endregion

            #region Interface Configuration
            if (radioButtonRIP.Checked)
            {
                if (textBoxInterface.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    startInterface(hosts);
                    callFunctionRIP(hosts);
                }
            }

            else if (radioButtonEIGRP.Checked)
            {
                if (textBoxInterface.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    startInterface(hosts);
                    callFunctionEIGRP(hosts);
                }
            }

            else if (radioButtonOspf.Checked)
            {
                textBoxArea.Visible = true;
                if (textBoxInterface.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    startInterface(hosts);
                    callFunctionOSPF(hosts, area);
                }
            }

            else //if (radioButtonNone.Checked)
            {
                if (textBoxInterface.Text == "")
                {
                    MessageBox.Show("Please select an interface before proceeding");
                }
                else
                {
                    startInterface(hosts);
                }
            }
            #endregion
        }

        private void startInterface(int hosts)
        {
            string interfaceName = textBoxInterface.Text;
            string subnet = getSubnetMask(hosts);
            Enable();
            writeToRouter("interface " + interfaceName + "");
            writeToRouter("ip address " + ipAddress + " " + subnet + "");
            writeToRouter("no shutdown");
            writeToRouter("end");
        }

        private void callFunctionEIGRP(int hosts)
        {
            string subnet = getSubnetMask(hosts);
            string wildCard = getWildCardMask(hosts);

            Enable();
            writeToRouter("router eigrp 1");
            writeToRouter("network " + ipAddress + " " + wildCard + "");
            writeToRouter("no auto-summary");
            writeToRouter("end");
        }

        private void callFunctionOSPF(int hosts, int area)
        {
            string wildCard = getWildCardMask(hosts);

            Enable();
            writeToRouter("router ospf 1");
            writeToRouter("network " + ipAddress + " " + wildCard + " area " + area);
            writeToRouter("end");
        }

        private void callFunctionRIP(int hosts)
        {
            string subnet = getSubnetMask(hosts);

            Enable();
            writeToRouter("router rip");
            writeToRouter("version 2");
            writeToRouter("network " + ipAddress + " " + subnet + "");
            writeToRouter("no auto-summary");
            writeToRouter("end");
        }

        private string getSubnetMask(int hosts)
        {
            string SubnetMask = "";

            switch (hosts)
            {

                case 1 when hosts < 7:
                    SubnetMask = "255.255.255.248";
                    break;

                case 2 when hosts < 15:
                    SubnetMask = "255.255.255.240";
                    break;

                case 3 when hosts < 31:
                    SubnetMask = "255.255.255.224";
                    break;

                case 4 when hosts < 63:
                    SubnetMask = "255.255.255.192";
                    break;

                case 5 when hosts < 127:
                    SubnetMask = "255.255.255.128";
                    break;

                case 6 when hosts < 254:
                    SubnetMask = "255.255.255.0";
                    break;

                case 7 when hosts < 511:
                    SubnetMask = "255.255.254.0";
                    break;

                case 8 when hosts < 1023:
                    SubnetMask = "255.255.252.0";
                    break;

                case 9 when hosts < 2047:
                    SubnetMask = "255.255.248.0";
                    break;

                case 10 when hosts < 4095:
                    SubnetMask = "255.255.240.0";
                    break;

                case 11 when hosts < 8191:
                    SubnetMask = "255.255.224.0";
                    break;

                case 12 when hosts < 16383:
                    SubnetMask = "255.255.192.0";
                    break;

                case 13 when hosts < 32767:
                    SubnetMask = "255.255.128.0";
                    break;

                case 14 when hosts < 65535:
                    SubnetMask = "255.255.0.0";
                    break;
            }

            return SubnetMask;
        }

        private string getWildCardMask(int hosts)
        {
            string WildCardMask = "";

            switch (hosts)
            {
                
                case 1 when hosts < 7:
                    WildCardMask = "0.0.0.7";
                    break;

                case 2 when hosts < 15:
                    WildCardMask = "0.0.0.15";
                    break;

                case 3 when hosts < 31:
                    WildCardMask = "0.0.0.31";
                    break;

                case 4 when hosts < 63:
                    WildCardMask = "0.0.0.63";
                    break;

                case 5 when hosts < 127:
                    WildCardMask = "0.0.0.127";
                    break;

                case 6 when hosts < 254:
                    WildCardMask = "0.0.0.255";
                    break;

                case 7 when hosts < 511:
                    WildCardMask = "0.0.1.255";
                    break;

                case 8 when hosts < 1023:
                    WildCardMask = "0.0.3.255";
                    break;

                case 9 when hosts < 2047:
                    WildCardMask = "0.0.7.255";
                    break;

                case 10 when hosts < 4095:
                    WildCardMask = "0.0.15.255";
                    break;

                case 11 when hosts < 8191:
                    WildCardMask = "0.0.31.255";
                    break;

                case 12 when hosts < 16383:
                    WildCardMask = "0.0.63.255";
                    break;

                case 13 when hosts < 32767:
                    WildCardMask = "0.0.127.255";
                    break;

                case 14 when hosts < 65535:
                    WildCardMask = "0.0.255.255";
                    break;
            }
            return WildCardMask;
        }
        #endregion

        #region Configure Host name and MOTD
        private void buttonConfHost_Click(object sender, EventArgs e)
        {
            #region Variables
            string hostName = textBoxHostName.Text;
            string motd = textBoxMOTD.Text;
            #endregion

            #region Hostname/MOTD
            
            Enable();
            writeToRouter("hostname " + hostName + "");
            writeToRouter("banner motd ." + motd + ".");
            writeToRouter("end");
            #endregion
        }
        #endregion

        #region Configure Password
        private void buttonConfPass_Click(object sender, EventArgs e)
        {
            if (radioButtonNormalPass.Checked)
            {
                configureNormalPass();
            }
            else if (radioButtonSecretPass.Checked)
            {
                configureSecretPass();
            }
            else
            {
                MessageBox.Show("Please select normal or secret password.");
            }
        }

        private void configureNormalPass()
        {
            string passWord1 = textBoxPassword1.Text;
            string passWord2 = textBoxPassword2.Text;

            if (passWord1 != passWord2)
            {
                MessageBox.Show("Your passwords do not match.");
            }
            else
            {
                Enable();
                writeToRouter("enable password " + passWord1 + "");
                if (checkBoxPassEncryption.Checked)
                {
                    writeToRouter("service password encryption");
                }
                writeToRouter("end");
            }
        }

        private void configureSecretPass()
        {
            string passWord1 = textBoxPassword1.Text;
            string passWord2 = textBoxPassword2.Text;

            if (passWord1 != passWord2)
            {
                MessageBox.Show("Your password do not match.");
            }
            else
            {
                Enable();
                writeToRouter("enable secret " + passWord1 + "");
                if (checkBoxPassEncryption.Checked)
                {
                    writeToRouter("service password encryption");
                }
                writeToRouter("end");
            }
        }
        #endregion

        #region Login Block-For
        private void buttonLoginBlock_Click(object sender, EventArgs e)
        {
            string lockoutTime = textBoxLockoutTime.Text;
            string attempts = textBoxAttempts.Text;
            string loginTime = textBoxLoginTime.Text;

            
            Enable();
            writeToRouter("login block-for " + lockoutTime + " attempts " + attempts + " within " + loginTime + "");
            writeToRouter("end");
        }
        #endregion

        #region Configure DHCP and DNS
        private void buttonConfDHCP_Click(object sender, EventArgs e)
        {
            string poolName = textBoxPoolName.Text;
            string dhcpNetwork = textBoxNetworkDHCP.Text;
            string domainName = textBoxDomainName.Text;
            string dnsServerAddrPrimary = textBoxDNSServerPrimary.Text;
            string dnsServerAddrSecondary = textBoxDNSServerSecondary.Text;
            string defaultGateway = textBoxDefaultGateway.Text;
            string leaseDuration = textBoxLeaseDuration.Text;
            string excludedAddr = textBoxExcludedAddresses.Text;

            
            Enable();
            writeToRouter("ip dhcp pool " + poolName + "");
            writeToRouter("network " + dhcpNetwork + "");
            writeToRouter("domain-name " + domainName + "");
            writeToRouter("dns-Server " + dnsServerAddrPrimary + " " + dnsServerAddrSecondary + "");
            writeToRouter("default-router " + defaultGateway + "");
            writeToRouter("lease " + leaseDuration + "");
            writeToRouter("exit");
            writeToRouter("ip dhcp excluded-address " + excludedAddr + "");
            writeToRouter("end");
        }
        #endregion

        #region Configure SSH/Telnet
        private async void buttonSSHTelnet_Click(object sender, EventArgs e)
        {
            string domainNameSSH = textBoxDomainNameSSH.Text;
            string userNameSSH = textBoxUserNameSSH.Text;
            string passwordSSH = textBoxPasswordSSH.Text;
            string keyModulus = textBoxKeyModulus.Text;
            string vtyLines = textBoxVtyLines.Text;

            
            Enable();
            writeToRouter("username " + userNameSSH + " secret " + passwordSSH + "");
            writeToRouter("ip domain-name " + domainNameSSH + "");
            writeToRouter("crypto key generate rsa");
            writeToRouter(keyModulus + "");
            writeToRouter("");
            await SSHDelay();
            writeToRouter("line vty " + vtyLines + "");

            if (radioButtonSSH.Checked)
                writeToRouter("transport input ssh");

            if (radioButtonTelnet.Checked)
                writeToRouter("transport input telnet");

            writeToRouter("login local");
            writeToRouter("end");
        }
        #endregion

        #region Save Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            Enable();
            writeToRouter("copy running-config startup-config");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region Erase NVRAM
        private async void buttonEraseNvram_Click(object sender, EventArgs e)
        {
            Enable();
            writeToRouter("erase nvram");
            await NVRAMDelay();
            writeToRouter("reload");
        }
        #endregion

        #region ROMmon Reset
        private async void buttonROMmon_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            routerResetFinishTime = now.AddSeconds(170);
            timerRouterReset.Enabled = true;

            tabControl.Enabled = false;

            writeToRouter("");
            await SecondDelay();
            writeToRouter("");
            readFromRouter();

            if (routerOutput.Contains(">") && reloadFunction == false)
            {
                Enable();
                writeToRouter("reload");
                writeToRouter("");
                await startupDelay();
                readFromRouter();
                reloadFunction = true;
            }
            
            if (routerOutput.Contains("Readonly ROMMON initialized") && rommonBreak == false)
            {
                serialPort1.BreakState = true;
                serialPort1.BreakState = false;
                rommonBreak = true;
                await SecondDelay();
                await SecondDelay();
                readFromRouter();
            }

            if (routerOutput.Contains("rommon 1>") && rommonMode == false)
            {
                rommonMode = true;
                writeToRouter("confreg 0x2142");
                writeToRouter("reset");
                await RommonDelay();
                writeToRouter("no");
                await SSHDelay();
                writeToRouter("no");
                await SSHDelay();
                Enable();
                writeToRouter("config-register 0x2102");
                serialPort1.BreakState = true;
                serialPort1.BreakState = false;
                await NVRAMDelay();
                writeToRouter("exit");
                writeToRouter("copy running-config startup-config");
                writeToRouter("end");
                tabControl.Enabled = true;
                timerRouterReset.Enabled = false;
            }
        }

        private void writeToRouter(string input)
        {
            serialPort1.Write(input + "\r\n");
            Console.WriteLine(input);
        }

        public string readFromRouter()
        {
            string routerOutputTemp = serialPort1.ReadExisting();
            routerOutput = routerOutput + routerOutputTemp;
            return routerOutput;
        }
        #endregion

        #region Program Startup Function
        private async void timer1_Tick(object sender, EventArgs e)
        {
            readFromRouter();

            if (routerOutput.Contains("dialog? [yes/no]:") && answeredDialog == false)
            {
                writeToRouter("no");
                answeredDialog = true;
            }

            else if (routerOutput.Contains("terminate autoinstall? [yes]:") && answeredTerminateAuto == false)
            {
                writeToRouter("yes");
                answeredTerminateAuto = true;
            }

            else if (routerOutput.Contains("Press RETURN to get started!") && answeredPressReturn == false)
            {
                if (delayTimerRun == false)
                {
                    writeToRouter("");
                    delayTimerRun = true;
                    await startupDelay();
                    writeToRouter("");
                }

                buttonConfDHCP.Enabled = true;
                buttonConfHost.Enabled = true;
                buttonConfInterface.Enabled = true;
                buttonConfPass.Enabled = true;
                buttonEraseNvram.Enabled = true;
                buttonLoginBlock.Enabled = true;
                buttonROMmon.Enabled = true;
                buttonSaveConf.Enabled = true;
                buttonSSHTelnet.Enabled = true;
                answeredPressReturn = true;
            }

            if (routerOutput.Contains(">"))
                timer1.Enabled = false;

        }
        #endregion

        private void timerRouterReset_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeLeft = routerResetFinishTime - now;
            labelTimer.Text = timeLeft.TotalSeconds.ToString();
        }

        private void buttonOverride_Click(object sender, EventArgs e)
        {
            buttonConfDHCP.Enabled = true;
            buttonConfHost.Enabled = true;
            buttonConfInterface.Enabled = true;
            buttonConfPass.Enabled = true;
            buttonEraseNvram.Enabled = true;
            buttonLoginBlock.Enabled = true;
            buttonROMmon.Enabled = true;
            buttonSaveConf.Enabled = true;
            buttonSSHTelnet.Enabled = true;
            timer1.Enabled = false;
        }

        #region VLAN/Trunking
        private void button1_Click_2(object sender, EventArgs e)
        {
            string interFaceVlan = textBoxInterfaceVlan.Text;
            string vlan = vlanNumBox.Text;
            string vlanName = vlanNameBox.Text;
            string vlanIp = textBoxIpVlan.Text;
            string subnetVlan = textBoxSubnetVlan.Text;
            string dot1q = textBoxDot1q.Text;

            Enable();
            writeToRouter("vlan " + vlan);
            writeToRouter("name " + vlanName);
            writeToRouter("exit");

            if (accessRadio.Checked)
            {
                writeToRouter("interface " + interFaceVlan);
                writeToRouter("switchport mode access");
                writeToRouter("switchport access vlan " + vlan);
            }
            else if (dynamicRadio.Checked)
            {
                writeToRouter("interface " + interFaceVlan);
                writeToRouter("switchport mode dynamic");
                writeToRouter("switchport dynamic vlan " + vlan);
            }
            else if (trunkRadio.Checked)
            {
                writeToRouter("interface " + interFaceVlan);
                writeToRouter("switchport mode trunk");
                writeToRouter("switchport trunk vlan " + vlan);
            }
            else if (encapsulationDot1q.Checked)
            {
                writeToRouter("interface " + interFaceVlan + "." + dot1q);
                writeToRouter("encapsulation dot1q " + dot1q);
                writeToRouter("ip address " + vlanIp + " " + subnetVlan);
                writeToRouter("interface " + interFaceVlan);
                writeToRouter("no shutdown");
                writeToRouter("end");
            }
        }
        #endregion

        #region Static Route
        private void routeStatic_Click(object sender, EventArgs e)
        {
            string targetNet = targetNetwork.Text;
            string targetSub = targetSubnet.Text;
            string nextJump = nextJumpAddr.Text;

            Enable();
            writeToRouter("ip route " + targetNet + " " + targetSub + " " + nextJump);
        }
        #endregion

        #region Hide/Show Area box
        private void RadioButtonOspf_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.Visible = true;
            labelArea.Visible = true;
        }

        private void RadioButtonEIGRP_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.Visible = false;
            labelArea.Visible = false;
        }

        private void RadioButtonRIP_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.Visible = false;
            labelArea.Visible = false;
        }

        private void RadioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.Visible = false;
            labelArea.Visible = false;
        }
        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            string shutInterf = textBoxShutdown.Text;

            Enable();
            writeToRouter("interface " + shutInterf);
            writeToRouter("shutdown");
            writeToRouter("end");
        }

        private void ButtonNoShutdownInterf_Click(object sender, EventArgs e)
        {
            string shutInterf = textBoxShutdown.Text;

            Enable();
            writeToRouter("interface " + shutInterf);
            writeToRouter("no shutdown");
            writeToRouter("end");
        }
        #endregion
    }
}