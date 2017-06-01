using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInterMetr
{
    public partial class Form2 : Form
    {
        private IniFile INI = new IniFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr\\config.ini");
        Form1 frm;

        public Form2(Form1 ths)
        {
            frm = ths;
            InitializeComponent();
            fillist();
            autoread();
            
        }
        private void autoread()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\InterMetr\\config.ini") == true)
            {
                Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                String value = (String)Key.GetValue("InterMetr");
                if (!String.IsNullOrEmpty(value))
                {
                    AutoStart.Checked = true;
                }
                else
                {
                    AutoStart.Checked = false;
                }
                Key.Close();
                INI.Write("Form", "AutoStartEnabled", AutoStart.Checked.ToString());
                
                ToTray.Checked = bool.Parse(INI.ReadINI("Interface", "ToTrayAtClosing"));
                OnTopOfWindows.Checked = bool.Parse(INI.ReadINI("Interface", "OnTopOfWindows")); 
                ShowTrafic.Checked = bool.Parse(INI.ReadINI("Interface", "ShowTraffic"));
                ToTray.Checked = bool.Parse(INI.ReadINI("Interface", "ToTrayAtClosing"));
                //OpacityNUD.Value = int.Parse(INI.ReadINI("Interface", "Opacity"));
                LimitConnect.Checked = bool.Parse(INI.ReadINI("LimitConnection", "Enabled"));
                if (LimitConnect.Checked == true)
                {
                    Timelapse.Value = int.Parse(INI.ReadINI("LimitConnection", "TimeLapse"));
                    limitsize.Value = decimal.Parse(INI.ReadINI("LimitConnection", "LimitSize"));
                }
                AutoInstallInterface.Checked = bool.Parse(INI.ReadINI("InternetSetting", "AutoSearchEnabled"));
                if (AutoInstallInterface.Checked == false)
                {
                    ListOfInterfaces.Enabled = true;
                    ListOfInterfaces.SelectedIndex = int.Parse(INI.ReadINI("InternetSetting", "AdapterIndex"));
                }
                else ListOfInterfaces.Enabled = false;
            }
        }
        private void autostartcheckchanged(object sender, EventArgs e)
        {
            if (AutoStart.Checked == true)
            {
                Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                Key.SetValue("InterMetr", Application.ExecutablePath);
                Key.Close();
            }
            else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("InterMetr", false);
                key.Close();
            }
            INI.Write("Form", "AutoStartEnabled", AutoStart.Checked.ToString());
        }

        private void fillist()
        {
            for (int i = 0; i < frm.nicArr.Length; i++)
                ListOfInterfaces.Items.Add(frm.nicArr[i].Name);
        }
        
        private void ExpandForm(object sender, EventArgs e)
        {
            if (ShowTrafic.Checked == true)
            {
                frm.Size = new System.Drawing.Size(180, 80);
            }
            else
            {
                frm.Size = new System.Drawing.Size(180, 55);
            }
            INI.Write("Interface", "ShowTraffic", ShowTrafic.Checked.ToString());
        }

        private void ChangeOpacity(object sender, EventArgs e)
        {
            frm.Opacity = (double)OpacityNUD.Value / 100;
            INI.Write("Interface", "Opacity", OpacityNUD.Value.ToString());
        }

        private void ResetButClick(object sender, EventArgs e)
        {
            frm.DefaultSettings();
            autoread();
        }

        private void formtotray(object sender, EventArgs e)
        {
            INI.Write("Interface", "ToTrayAtClosing", ToTray.Checked.ToString());
        }

        private void topfwindows(object sender, EventArgs e)
        {
            frm.TopMost = true;
            INI.Write("Interface", "OnTopOfWindows", OnTopOfWindows.Checked.ToString());
        }

        private void CloseButClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listnumberchanged(object sender, EventArgs e)
        {
            INI.Write("InternetSetting", "AdapterIndex", ListOfInterfaces.SelectedIndex.ToString());
            frm.InitializeNetworkInterface(sender, e);
        }

        private void autoinstall(object sender, EventArgs e)
        {
            INI.Write("InternetSetting", "AutoSearchEnabled", AutoInstallInterface.Checked.ToString());
            if (AutoInstallInterface.Checked == false)
            {
                ListOfInterfaces.SelectedIndex = int.Parse(INI.ReadINI("InternetSetting", "AdapterIndex"));
                ListOfInterfaces.Enabled = true;
            }
            else ListOfInterfaces.Enabled = false;
        }

        private void LimitEnabled(object sender, EventArgs e)
        {
            INI.Write("LimitConnection", "Enabled", LimitConnect.Checked.ToString());
            this.limitsize.Visible = LimitConnect.Checked;
            this.Timelapse.Visible = LimitConnect.Checked;
            this.label2.Visible = LimitConnect.Checked;
            this.label1.Visible = LimitConnect.Checked;
            Timelapse.Value = int.Parse(INI.ReadINI("LimitConnection", "TimeLapse"));
            limitsize.Value = decimal.Parse(INI.ReadINI("LimitConnection", "LimitSize"));
            frm.PrBarEnbd();
        }

        private void ChangeDay(object sender, EventArgs e)
        {
            INI.Write("LimitConnection", "TimeLapse", Timelapse.Value.ToString());
        }

        private void LimitChanged(object sender, EventArgs e)
        {
            INI.Write("LimitConnection", "LimitSize", limitsize.Value.ToString());
            frm.CheckLimits();
        }
    }
}
