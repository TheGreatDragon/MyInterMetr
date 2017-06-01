using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyInterMetr
{
    class IniFile
    {
        string Path; //Имя файла.

        [DllImport("kernel32")] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        // С помощью конструктора записываем пусть до файла и его имя.
        public IniFile(string IniPath)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        //Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
        public string ReadINI(string Section, string Key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        //Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //Удаляем ключ из выбранной секции.
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Section, Key, null);
        }
        //Удаляем выбранную секцию
        public void DeleteSection(string Section = null)
        {
            Write(Section, null, null);
        }
        //Проверяем, есть ли такой ключ, в этой секции
        public bool KeyExists(string Key, string Section = null)
        {
            return ReadINI(Section, Key).Length > 0;
        }
    }
    
    class CustomProgressBar : ProgressBar
    {
        //Property to hold the custom text
        public String CustomText { get; set; }
        public String CustomSecondText { get; set; }

        private SolidBrush brush = null, brus = null;
        private SolidBrush Sbrus = null;
        private int textwidth, textheight;
        private int Stextwidth, Stextheight;

        public CustomProgressBar()
        {
            brus = new SolidBrush(Color.White);
            Sbrus = new SolidBrush(Color.White);
            textwidth = 0;
            textheight = 0;
            Stextwidth = 0;
            Stextheight = 0;
            // Modify the ControlStyles flags
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public void SetTextColor(Color dr)
        {
            brus.Color = dr;
        }
        public void SetTextLocation(int x, int y)
        {
            textwidth = x;
            textheight = y;
        }
        public void SetSecondTextColor(Color dr)
        {
            Sbrus.Color = dr;
        }
        public void SetSecondTextLocation(int x, int y)
        {
            Stextwidth = x;
            Stextheight = y;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            if (brush == null || brush.Color != this.ForeColor)
                brush = new SolidBrush(this.ForeColor);
           
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(g, rect);

            rect.Width = (int)(rect.Width * ((double)Value / Maximum)) - 2;
            rect.Height = rect.Height - 2;
            e.Graphics.FillRectangle(brush, 1, 1, rect.Width, rect.Height);

            using (Font f = new Font("Tahoma", 10F, System.Drawing.FontStyle.Bold))
            {
                SizeF len = g.MeasureString(CustomText, f);
                Point location = new Point(textwidth, textheight);
                e.Graphics.DrawString(CustomText, f, brus, location);
            }

            using (Font f = new Font("Tahoma", 10F, System.Drawing.FontStyle.Bold))
            {
                SizeF len = g.MeasureString(CustomSecondText, f);
                Point location = new Point(Stextwidth, Stextheight);
                e.Graphics.DrawString(CustomSecondText, f, Sbrus, location);
            }

        }
    }

}

