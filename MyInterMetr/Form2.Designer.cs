namespace MyInterMetr
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.ToTray = new System.Windows.Forms.CheckBox();
            this.ShowTrafic = new System.Windows.Forms.CheckBox();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListOfInterfaces = new System.Windows.Forms.ListBox();
            this.AutoInstallInterface = new System.Windows.Forms.CheckBox();
            this.ResetBut = new System.Windows.Forms.Button();
            this.ApplyBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TaskBarSpeed = new System.Windows.Forms.CheckBox();
            this.OnTopOfWindows = new System.Windows.Forms.CheckBox();
            this.OpacityNUD = new System.Windows.Forms.NumericUpDown();
            this.ConnectType = new System.Windows.Forms.GroupBox();
            this.Timelapse = new System.Windows.Forms.NumericUpDown();
            this.limitsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitConnect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityNUD)).BeginInit();
            this.ConnectType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timelapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitsize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LanguageLabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.AutoStart);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Программа";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(7, 44);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(35, 13);
            this.LanguageLabel.TabIndex = 3;
            this.LanguageLabel.Text = "Язык";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(7, 20);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(185, 17);
            this.AutoStart.TabIndex = 1;
            this.AutoStart.Text = "Запускать при старте системы";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.CheckedChanged += new System.EventHandler(this.autostartcheckchanged);
            // 
            // ToTray
            // 
            this.ToTray.AutoSize = true;
            this.ToTray.Location = new System.Drawing.Point(5, 47);
            this.ToTray.Name = "ToTray";
            this.ToTray.Size = new System.Drawing.Size(199, 17);
            this.ToTray.TabIndex = 2;
            this.ToTray.Text = "Сворачивать в трей при закрытии";
            this.ToTray.UseVisualStyleBackColor = true;
            this.ToTray.CheckedChanged += new System.EventHandler(this.formtotray);
            // 
            // ShowTrafic
            // 
            this.ShowTrafic.AutoSize = true;
            this.ShowTrafic.Location = new System.Drawing.Point(5, 24);
            this.ShowTrafic.Name = "ShowTrafic";
            this.ShowTrafic.Size = new System.Drawing.Size(129, 17);
            this.ShowTrafic.TabIndex = 3;
            this.ShowTrafic.Text = "Показывать трафик";
            this.ShowTrafic.UseVisualStyleBackColor = true;
            this.ShowTrafic.CheckedChanged += new System.EventHandler(this.ExpandForm);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(4, 96);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(79, 13);
            this.OpacityLabel.TabIndex = 4;
            this.OpacityLabel.Text = "Прозрачность";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListOfInterfaces);
            this.groupBox3.Controls.Add(this.AutoInstallInterface);
            this.groupBox3.Location = new System.Drawing.Point(289, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 188);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сетевые настройки";
            // 
            // ListOfInterfaces
            // 
            this.ListOfInterfaces.FormattingEnabled = true;
            this.ListOfInterfaces.Location = new System.Drawing.Point(7, 44);
            this.ListOfInterfaces.Name = "ListOfInterfaces";
            this.ListOfInterfaces.Size = new System.Drawing.Size(383, 134);
            this.ListOfInterfaces.TabIndex = 7;
            this.ListOfInterfaces.SelectedIndexChanged += new System.EventHandler(this.listnumberchanged);
            // 
            // AutoInstallInterface
            // 
            this.AutoInstallInterface.Location = new System.Drawing.Point(7, 21);
            this.AutoInstallInterface.Name = "AutoInstallInterface";
            this.AutoInstallInterface.Size = new System.Drawing.Size(229, 17);
            this.AutoInstallInterface.TabIndex = 8;
            this.AutoInstallInterface.Text = "Автоматическое определение адаптера";
            this.AutoInstallInterface.UseVisualStyleBackColor = true;
            this.AutoInstallInterface.CheckedChanged += new System.EventHandler(this.autoinstall);
            // 
            // ResetBut
            // 
            this.ResetBut.Location = new System.Drawing.Point(521, 382);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(83, 35);
            this.ResetBut.TabIndex = 9;
            this.ResetBut.Text = "Сбросить настройки";
            this.ResetBut.UseVisualStyleBackColor = true;
            this.ResetBut.Click += new System.EventHandler(this.ResetButClick);
            // 
            // ApplyBut
            // 
            this.ApplyBut.Location = new System.Drawing.Point(529, 344);
            this.ApplyBut.Name = "ApplyBut";
            this.ApplyBut.Size = new System.Drawing.Size(75, 35);
            this.ApplyBut.TabIndex = 10;
            this.ApplyBut.Text = "Применить";
            this.ApplyBut.UseVisualStyleBackColor = true;
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(610, 382);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 35);
            this.CloseBut.TabIndex = 11;
            this.CloseBut.Text = "Закрыть";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseButClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TaskBarSpeed);
            this.groupBox4.Controls.Add(this.OnTopOfWindows);
            this.groupBox4.Controls.Add(this.ShowTrafic);
            this.groupBox4.Controls.Add(this.ToTray);
            this.groupBox4.Location = new System.Drawing.Point(13, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 229);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Интерфейс";
            // 
            // TaskBarSpeed
            // 
            this.TaskBarSpeed.AutoSize = true;
            this.TaskBarSpeed.Location = new System.Drawing.Point(5, 95);
            this.TaskBarSpeed.Name = "TaskBarSpeed";
            this.TaskBarSpeed.Size = new System.Drawing.Size(205, 17);
            this.TaskBarSpeed.TabIndex = 16;
            this.TaskBarSpeed.Text = "Показать скорость в панели задач";
            this.TaskBarSpeed.UseVisualStyleBackColor = true;
            this.TaskBarSpeed.Visible = false;
            // 
            // OnTopOfWindows
            // 
            this.OnTopOfWindows.AutoSize = true;
            this.OnTopOfWindows.Location = new System.Drawing.Point(5, 71);
            this.OnTopOfWindows.Name = "OnTopOfWindows";
            this.OnTopOfWindows.Size = new System.Drawing.Size(147, 17);
            this.OnTopOfWindows.TabIndex = 15;
            this.OnTopOfWindows.Text = "Поверх остальных окон";
            this.OnTopOfWindows.UseVisualStyleBackColor = true;
            this.OnTopOfWindows.CheckedChanged += new System.EventHandler(this.topfwindows);
            // 
            // OpacityNUD
            // 
            this.OpacityNUD.Location = new System.Drawing.Point(154, 94);
            this.OpacityNUD.Name = "OpacityNUD";
            this.OpacityNUD.Size = new System.Drawing.Size(66, 20);
            this.OpacityNUD.TabIndex = 16;
            this.OpacityNUD.ValueChanged += new System.EventHandler(this.ChangeOpacity);
            // 
            // ConnectType
            // 
            this.ConnectType.Controls.Add(this.Timelapse);
            this.ConnectType.Controls.Add(this.limitsize);
            this.ConnectType.Controls.Add(this.label2);
            this.ConnectType.Controls.Add(this.label1);
            this.ConnectType.Controls.Add(this.LimitConnect);
            this.ConnectType.Location = new System.Drawing.Point(289, 223);
            this.ConnectType.Name = "ConnectType";
            this.ConnectType.Size = new System.Drawing.Size(396, 114);
            this.ConnectType.TabIndex = 13;
            this.ConnectType.TabStop = false;
            this.ConnectType.Text = "Тип подключения";
            // 
            // Timelapse
            // 
            this.Timelapse.Location = new System.Drawing.Point(184, 42);
            this.Timelapse.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Timelapse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timelapse.Name = "Timelapse";
            this.Timelapse.Size = new System.Drawing.Size(47, 20);
            this.Timelapse.TabIndex = 2;
            this.Timelapse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timelapse.Visible = false;
            this.Timelapse.ValueChanged += new System.EventHandler(this.ChangeDay);
            // 
            // limitsize
            // 
            this.limitsize.DecimalPlaces = 1;
            this.limitsize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.limitsize.Location = new System.Drawing.Point(94, 69);
            this.limitsize.Name = "limitsize";
            this.limitsize.Size = new System.Drawing.Size(51, 20);
            this.limitsize.TabIndex = 4;
            this.limitsize.Visible = false;
            this.limitsize.ValueChanged += new System.EventHandler(this.LimitChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Лимит трафика                    Гб";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Платежный период, начинается с                   числа";
            this.label1.Visible = false;
            // 
            // LimitConnect
            // 
            this.LimitConnect.AutoSize = true;
            this.LimitConnect.Location = new System.Drawing.Point(7, 20);
            this.LimitConnect.Name = "LimitConnect";
            this.LimitConnect.Size = new System.Drawing.Size(147, 17);
            this.LimitConnect.TabIndex = 0;
            this.LimitConnect.Text = "Лимитное подключение";
            this.LimitConnect.UseVisualStyleBackColor = true;
            this.LimitConnect.CheckedChanged += new System.EventHandler(this.LimitEnabled);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(692, 429);
            this.Controls.Add(this.ConnectType);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.ResetBut);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityNUD)).EndInit();
            this.ConnectType.ResumeLayout(false);
            this.ConnectType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timelapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ToTray;
        private System.Windows.Forms.CheckBox ShowTrafic;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListOfInterfaces;
        private System.Windows.Forms.CheckBox AutoInstallInterface;
        private System.Windows.Forms.Button ResetBut;
        private System.Windows.Forms.Button ApplyBut;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox OnTopOfWindows;
        public System.Windows.Forms.NumericUpDown OpacityNUD;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox TaskBarSpeed;
        private System.Windows.Forms.GroupBox ConnectType;
        private System.Windows.Forms.NumericUpDown limitsize;
        private System.Windows.Forms.NumericUpDown Timelapse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LimitConnect;
    }
}