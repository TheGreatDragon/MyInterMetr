using System;
using System.Windows.Forms;

namespace MyInterMetr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DownSpeed = new System.Windows.Forms.Label();
            this.UpSpeed = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Downloaded = new System.Windows.Forms.Label();
            this.Uploaded = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Trafficlabel = new System.Windows.Forms.Label();
            this.progressBar1 = new CustomProgressBar();
            this.Textlabel = new System.Windows.Forms.Label();
            this.Textslabel = new System.Windows.Forms.Label();
            this.Textlabel2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownSpeed
            // 
            this.DownSpeed.AutoSize = true;
            this.DownSpeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DownSpeed.ForeColor = System.Drawing.Color.White;
            this.DownSpeed.Location = new System.Drawing.Point(71, 15);
            this.DownSpeed.Name = "DownSpeed";
            this.DownSpeed.Size = new System.Drawing.Size(0, 19);
            this.DownSpeed.TabIndex = 0;
            this.DownSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.DownSpeed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.DownSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // UpSpeed
            // 
            this.UpSpeed.AutoSize = true;
            this.UpSpeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.UpSpeed.ForeColor = System.Drawing.Color.White;
            this.UpSpeed.Location = new System.Drawing.Point(71, 34);
            this.UpSpeed.Name = "UpSpeed";
            this.UpSpeed.Size = new System.Drawing.Size(0, 19);
            this.UpSpeed.TabIndex = 1;
            this.UpSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.UpSpeed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.UpSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 92);
            // 
            // StatisticToolStripMenuItem
            // 
            this.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem";
            this.StatisticToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.StatisticToolStripMenuItem.Text = "Статистика";
            this.StatisticToolStripMenuItem.Click += new System.EventHandler(this.OpenStatistic);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramm);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.OpenSettings);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // Downloaded
            // 
            this.Downloaded.AutoSize = true;
            this.Downloaded.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Downloaded.ForeColor = System.Drawing.Color.White;
            this.Downloaded.Location = new System.Drawing.Point(71, 55);
            this.Downloaded.Name = "Downloaded";
            this.Downloaded.Size = new System.Drawing.Size(73, 17);
            this.Downloaded.TabIndex = 2;
            this.Downloaded.Text = "Скачано ";
            this.Downloaded.Visible = false;
            this.Downloaded.Click += new System.EventHandler(this.ShowShortTrafik);
            this.Downloaded.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.Downloaded.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.Downloaded.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // Uploaded
            // 
            this.Uploaded.AutoSize = true;
            this.Uploaded.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Uploaded.ForeColor = System.Drawing.Color.White;
            this.Uploaded.Location = new System.Drawing.Point(71, 73);
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.Size = new System.Drawing.Size(75, 17);
            this.Uploaded.TabIndex = 3;
            this.Uploaded.Text = "Отдано   ";
            this.Uploaded.Visible = false;
            this.Uploaded.Click += new System.EventHandler(this.ShowShortTrafik);
            this.Uploaded.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.Uploaded.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.Uploaded.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MyInterMetr";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.FocusedForm);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.thi_show);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.statisticToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.thi_show);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.OpenSettings);
            // 
            // statisticToolStripMenuItem1
            // 
            this.statisticToolStripMenuItem1.Name = "statisticToolStripMenuItem1";
            this.statisticToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.statisticToolStripMenuItem1.Text = "Statistic";
            this.statisticToolStripMenuItem1.Click += new System.EventHandler(this.OpenStatistic);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.this_close);
            // 
            // Trafficlabel
            // 
            this.Trafficlabel.AutoSize = true;
            this.Trafficlabel.BackColor = System.Drawing.Color.Transparent;
            this.Trafficlabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Trafficlabel.ForeColor = System.Drawing.Color.White;
            this.Trafficlabel.Location = new System.Drawing.Point(71, 55);
            this.Trafficlabel.Name = "Trafficlabel";
            this.Trafficlabel.Size = new System.Drawing.Size(0, 17);
            this.Trafficlabel.TabIndex = 5;
            this.Trafficlabel.Click += new System.EventHandler(this.ShowDetailTrafik);
            this.Trafficlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.Trafficlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.Trafficlabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // progressBar1
            // 
            this.progressBar1.Visible = false;
            this.progressBar1.Location = new System.Drawing.Point(0, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 25);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.CustomSecondText = "Трафик";
            this.progressBar1.SetSecondTextColor(System.Drawing.Color.Black);
            this.progressBar1.SetTextColor(System.Drawing.Color.Black);
            this.progressBar1.SetTextLocation(72, 3);
            this.progressBar1.SetSecondTextLocation(0, 3);
            this.progressBar1.Click += new System.EventHandler(this.ShowDetailTrafik);
            this.progressBar1.CustomText = Trafficlabel.Text;
            // 
            // Textlabel
            // 
            this.Textlabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Textlabel.ForeColor = System.Drawing.Color.White;
            this.Textlabel.Location = new System.Drawing.Point(0, 55);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(70, 35);
            this.Textlabel.TabIndex = 6;
            this.Textlabel.Text = "Трафик";
            this.Textlabel.Click += new System.EventHandler(this.ShowDetailTrafik);
            // 
            // Textslabel
            // 
            this.Textslabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Textslabel.ForeColor = System.Drawing.Color.White;
            this.Textslabel.Location = new System.Drawing.Point(0, 0);
            this.Textslabel.Name = "Textslabel";
            this.Textslabel.Size = new System.Drawing.Size(75, 50);
            this.Textslabel.TabIndex = 4;
            this.Textslabel.Text = "Скорость\nПриема\nОтдачи";
            this.Textslabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.Textslabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.Textslabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            // 
            // Textlabel2
            // 
            this.Textlabel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Textlabel2.ForeColor = System.Drawing.Color.White;
            this.Textlabel2.Location = new System.Drawing.Point(0, 55);
            this.Textlabel2.Name = "Textlabel2";
            this.Textlabel2.Size = new System.Drawing.Size(70, 35);
            this.Textlabel2.TabIndex = 7;
            this.Textlabel2.Text = "Скачано\nОтдано";
            this.Textlabel2.Visible = false;
            this.Textlabel2.Click += new System.EventHandler(this.ShowShortTrafik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Textslabel);
            this.Controls.Add(this.Textlabel);
            this.Controls.Add(this.Textlabel2);
            this.Controls.Add(this.Trafficlabel);
            this.Controls.Add(this.Uploaded);
            this.Controls.Add(this.Downloaded);
            this.Controls.Add(this.UpSpeed);
            this.Controls.Add(this.DownSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InterMetr";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.This_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DownSpeed;
        private Label UpSpeed;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem StatisticToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private Label Downloaded;
        private Label Uploaded;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem statisticToolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private Label Trafficlabel;
        private Label Textslabel;
        private Label Textlabel;
        private Label Textlabel2;
        private CustomProgressBar progressBar1;
    }
}

