using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Security.Principal;
using System.Security.AccessControl;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace MyInterMetr
{

    public partial class Form1 : Form
    {
        private IniFile INI = new IniFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr\\config.ini");
        private string FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr";
        private int tmpX, tmpY;
        private bool flMove = false;
        private int InternetStat;
        private double bytesent = 0, byterecieved = 0;
        private ulong AllSent = 0, AllReceived = 0;
        private double lbyterecieved = 0, lbytesent = 0;
        private double limit = 0;
        private Timer time;
        Form2 tmpForm;
        private bool whattext = true;

        int p;
        private System.Net.NetworkInformation.IPv4InterfaceStatistics interfaceStats;
        private double bytesSentSpeed = 0, bytesReceivedSpeed = 0;
        private System.Net.NetworkInformation.NetworkInterface nic;
        public System.Net.NetworkInformation.NetworkInterface[] nicArr;

        public Form1()
        {
            if (Directory.Exists(FileName) != true)
            {
                Directory.CreateDirectory(FileName);
            }
            auto_read();
            //
            InitializeComponent();
            //
            this_sets();
            //
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            //
            time = new System.Windows.Forms.Timer();
            time.Interval = 1000;
            time.Tick += InitializeNetworkInterface;
            StartTimer();
            this.FormClosed += this_closed;
        }

        private void This_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            flMove = true;
        }
        private void This_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                if (flMove)
                {
                    this.Left = this.Left + (Cursor.Position.X - tmpX);
                    this.Top = this.Top + (Cursor.Position.Y - tmpY);

                    tmpX = this.Left + this.Width / 2;
                    tmpY = this.Top + this.Height / 2;
                }
        }
        private void This_MouseUp(object sender, MouseEventArgs e)
        {
            flMove = false;
            INI.Write("Form", "Width", this.Left.ToString());
            INI.Write("Form", "Height", this.Top.ToString());
        }

        private void auto_read()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr\\config.ini") == true)
            {
                //
                if (bool.Parse(INI.ReadINI("Interface", "ShowTraffic")) == true)
                    this.Size = new System.Drawing.Size(190, 80);
                else
                    this.Size = new System.Drawing.Size(190, 55);
                //

                AllReceived = ulong.Parse(INI.ReadINI("Traffic", "Download"));
                AllSent = ulong.Parse(INI.ReadINI("Traffic", "Upload"));
            }
            else DefaultSettings();
        }
        public void DefaultSettings()
        {
            this.Size = new System.Drawing.Size(190, 55);

            INI.Write("Form", "Width", "100");
            INI.Write("Form", "Height", "100");
            INI.Write("Form", "AutoStartEnabled", "False");
            INI.Write("Interface", "ShowTraffic", "False");
            INI.Write("Interface", "ToTrayAtClosing", "False");
            INI.Write("Interface", "OnTopOfWindows", "True");
            INI.Write("Interface", "OpacityBackGround", "False");
            INI.Write("Interface", "Opacity", "100");
            INI.Write("InternetSetting", "AutoSearchEnabled", "True");
            INI.Write("InternetSetting", "AdapterIndex", "0");
            INI.Write("LimitConnection", "Enabled", "False");
            INI.Write("LimitConnection", "Reset", "True");
            INI.Write("LimitConnection", "TimeLapse", "1");
            INI.Write("LimitConnection", "LimitSize", "0,1");
            INI.Write("Traffic", "Download", "0");
            INI.Write("Traffic", "Upload", "0");
            //INI.Write("Grafic", "Enabled", "false");
            //INI.Write("Grafic", "Width", "0");
            //INI.Write("Grafic", "Height", "0");
        }
        private void this_sets()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr\\config.ini") == true)
            {
                this.Location = new Point(int.Parse(INI.ReadINI("Form", "Width")), int.Parse(INI.ReadINI("Form", "Height")));
                this.Opacity = int.Parse(INI.ReadINI("Interface", "Opacity")) / 100;
                this.TopMost = bool.Parse(INI.ReadINI("Interface", "OnTopOfWindows"));

                if (int.Parse(INI.ReadINI("LimitConnection", "TimeLapse")) != DateTime.Today.Day)
                    INI.Write("LimitConnection", "Reset", "False");

                if (bool.Parse(INI.ReadINI("LimitConnection", "Enabled")) == true)
                {
                    if (int.Parse(INI.ReadINI("LimitConnection", "TimeLapse")) == DateTime.Today.Day && bool.Parse(INI.ReadINI("LimitConnection", "Reset")) == false)
                    {
                        AllReceived = 0;
                        AllSent = 0;
                        INI.Write("LimitConnection", "Reset", "True");
                    }
                    progressBar1.Visible = true;
                    Textlabel.Visible = false;
                    Textlabel2.Visible = false;
                    Trafficlabel.Visible = false;
                    Downloaded.Visible = false;
                    Uploaded.Visible = false;
                }
            }
            else DefaultSettings();
        }
        public void PrBarEnbd()
        {
            if (bool.Parse(INI.ReadINI("LimitConnection", "Enabled")) == true)
            {
                progressBar1.Visible = true;
                Textlabel.Visible = false;
                Textlabel2.Visible = false;
                Trafficlabel.Visible = false;
            }
            else
            {
                progressBar1.Visible = false;
                Textlabel.Visible = true;
                Textlabel2.Visible = true;
                Trafficlabel.Visible = true;
            }
        }
        private void StartTimer()
        {
            time.Start();
        }
        public void InitializeNetworkInterface(object sender, EventArgs e)
        {
            p = -1; InternetStat += 1;
            if (bool.Parse(INI.ReadINI("InternetSetting", "AutoSearchEnabled")) == true)
            {
                for (int i = 0; i < nicArr.Length; i++)
                    if ((nicArr[i].OperationalStatus == OperationalStatus.Up) &&
                        (nicArr[i].Supports(NetworkInterfaceComponent.IPv4)) &&
                        (nicArr[i].GetIPProperties().GatewayAddresses.Count > 0))
                        p = i;
            }
            else
            {
                p = int.Parse(INI.ReadINI("InternetSetting", "AdapterIndex"));
                bytesent = 0; byterecieved = 0;
                lbyterecieved = 0; lbytesent = 0;
                bytesSentSpeed = 0; bytesReceivedSpeed = 0;
                AllSent = 0; AllReceived = 0;
            }
            UpdateNetworkInterface();
            if (progressBar1.Visible == true)
                CheckLimits();
        }
        private void UpdateNetworkInterface()
        {
            UpSpeed.Text = "";
            DownSpeed.Text = "";
            Uploaded.Text = "";
            Downloaded.Text = "";
            Trafficlabel.Text = "";
            //
            if (p != -1)
            {
                InternetStat = 0;
                nic = nicArr[p];
                interfaceStats = nic.GetIPv4Statistics();
                if (lbytesent != 0 || lbyterecieved != 0)
                {
                    bytesSentSpeed = (interfaceStats.BytesSent - lbytesent);
                    bytesReceivedSpeed = (interfaceStats.BytesReceived - lbyterecieved);
                }
                lbyterecieved = interfaceStats.BytesReceived;
                lbytesent = interfaceStats.BytesSent;
                if ((bytesSentSpeed / 1024) < 1024)
                    UpSpeed.Text += (bytesSentSpeed / 1024).ToString("N2") + " KB/s";
                else UpSpeed.Text += (bytesSentSpeed / (1024 * 1024)).ToString("N2") + " MB/s";
                if ((bytesReceivedSpeed / 1024) < 1024)
                    DownSpeed.Text += (bytesReceivedSpeed / 1024).ToString("N2") + " KB/s";
                else DownSpeed.Text += (bytesReceivedSpeed / (1024 * 1024)).ToString("N2") + " MB/s";

                if (nicArr[p].GetIPv4Statistics().BytesSent != bytesSentSpeed)
                {
                    bytesent += bytesSentSpeed;
                    byterecieved += bytesReceivedSpeed;
                }
            }
            if (InternetStat == 2)
                MessageBox.Show("No Internet");
            //
            if ((byterecieved / 1000) < 1000)
                Downloaded.Text += (byterecieved / 1000).ToString("N2") + " KB";
            else if (((byterecieved / (1048576)) < 1000))
                Downloaded.Text += (byterecieved / (1000000)).ToString("N2") + " MB";
            else Downloaded.Text += (byterecieved / (1000000000)).ToString("N2") + " GB";
            //
            if (bytesent < 1000000)
                Uploaded.Text += (bytesent / 1000).ToString("N2") + " KB";
            else if (bytesent < 1000000000)
                Uploaded.Text += (bytesent / 1000000).ToString("N2") + " MB";
            else Uploaded.Text += (bytesent / 1000000000).ToString("N2") + " GB";
            //
            if ((bytesent + byterecieved) < 1000000)
                Trafficlabel.Text += ((bytesent + byterecieved) / 1000).ToString("N2") + " KB";
            else if ((bytesent + byterecieved) < 1000000000)
                Trafficlabel.Text += ((bytesent + byterecieved) / 1000000).ToString("N2") + " MB";
            else Trafficlabel.Text += ((bytesent + byterecieved) / 1000000000).ToString("N2") + " GB";
            //
            progressBar1.CustomText = Trafficlabel.Text;
        }

        private void ShowDetailTrafik(object sender, EventArgs e)
        {
            if (bool.Parse(INI.ReadINI("LimitConnection", "Enabled")) == false)
            {
                this.Size = new System.Drawing.Size(190, 95);
                Trafficlabel.Visible = false;
                Textlabel.Visible = false;
                Textlabel2.Visible = true;
                Downloaded.Visible = true;
                Uploaded.Visible = true;
            }
        }
        private void ShowShortTrafik(object sender, EventArgs e)
        {
            if (bool.Parse(INI.ReadINI("LimitConnection", "Enabled")) == false)
            {
                this.Size = new System.Drawing.Size(190, 80);
                Downloaded.Visible = false;
                Uploaded.Visible = false;
                Trafficlabel.Visible = true;
                Textlabel.Visible = true;
                Textlabel2.Visible = true;
            }
        }

        private void OpenStatistic(object sender, EventArgs e)
        {
            if ((AllSent + bytesent) < 1000000 || (AllReceived + byterecieved) < 1000000)
                MessageBox.Show("Получено : " + ((AllReceived + byterecieved) / 1000).ToString("N2") + " Kb\nОтдано :     " + ((AllSent + bytesent) / 1000).ToString("N2") + " Kb");
            else if ((AllSent + bytesent) < 1000000000 || (AllReceived + byterecieved) < 1000000000)
                MessageBox.Show("Получено : " + ((AllReceived + byterecieved) / 1000000).ToString("N2") + " Mb\nОтдано :     " + ((AllSent + bytesent) / 1000000).ToString("N2") + " Mb");
            else MessageBox.Show("Получено : " + ((AllReceived + byterecieved) / 1000000000).ToString("N2") + " Gb\nОтдано :     " + ((AllSent + bytesent) / 1000000000).ToString("N2") + " Gb");
        }
        private void OpenSettings(object sender, EventArgs e)
        {
            if (tmpForm == null || tmpForm.IsDisposed)
            {
                tmpForm = new Form2(this);
                tmpForm.Show();
            }
            else
            {
                tmpForm.Focus();
            }
        }

        public void CheckLimits()
        {
            limit = double.Parse(INI.ReadINI("LimitConnection", "LimitSize"));
            int val = (int)((double)((AllReceived + (ulong)byterecieved + AllSent + (ulong)bytesent) / (limit *1000000000)) * 100);
            if (val <= 0)
                val = 1;
            if (val < 100)
                progressBar1.Value = val;
            else progressBar1.Value = 100;
            if (val < 75)
            {
                this.progressBar1.ForeColor = System.Drawing.Color.LightGreen;
                this.progressBar1.SetSecondTextColor(System.Drawing.Color.Black);
                this.progressBar1.SetTextColor(System.Drawing.Color.Black);
            }
            if (val >= 75 && val < 90)
            {
                this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
                this.progressBar1.SetSecondTextColor(System.Drawing.Color.Black);
                this.progressBar1.SetTextColor(System.Drawing.Color.Black);
            }
            if (val > 90)
            {
                this.progressBar1.ForeColor = System.Drawing.Color.Red;
                this.progressBar1.SetSecondTextColor(System.Drawing.Color.White);
                this.progressBar1.SetTextColor(System.Drawing.Color.White);
            }
        }

        private void FocusedForm(object sender, EventArgs e)
        {
            if (bool.Parse(INI.ReadINI("Interface", "OnTopOfWindows")) == true)
                this.Focus();
            else
            {
                this.TopMost = true;
                this.Focus();
                this.TopMost = false;
            }
        }
        private void thi_show(object sender, EventArgs e)
        {
            this.Show();
        }
        private void CloseForm(object sender, EventArgs e)
        {
            if (bool.Parse(INI.ReadINI("Interface", "ToTrayAtClosing")) == true)
            {
                this.Hide();
            }
            else Application.Exit();
        }
        private void this_close(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AboutProgramm(object sender, EventArgs e)
        {
            MessageBox.Show("InterMetr\nВерсия 0.5\nCopyright © 2015 - 2017\nГабдрахманов А.Г.", "О программе");
        }

        private void this_closed(object sender, EventArgs e)
        {

            AllReceived += (ulong)byterecieved;
            AllSent += (ulong)bytesent;
            //File.Delete(FileName);
            INI.Write("Traffic", "Download", AllReceived.ToString());
            INI.Write("Traffic", "Upload", AllSent.ToString());
        }
    }
}
