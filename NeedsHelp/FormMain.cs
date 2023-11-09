using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;

namespace NeedsHelp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        int month;
        int year = 1;

        void DisplayDays()
        {
            DateTime Now = DateTime.Now;

            month =Now.Month;
            year=Now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month-1];
            LblYearMonth.Text = monthName + " " + year;

            DateTime StartOfMonth = new DateTime(year, month, 1);
            int Days = DateTime.DaysInMonth(Now.Year, Now.Month);
            int DaysOfWeek = Convert.ToInt32(StartOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < DaysOfWeek; i++)
            {
                UserControlBlank ucblank= new UserControlBlank();
                DaysContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= Days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DaysContainer.Controls.Add(ucDays);
            }
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            MiddleContainer.BorderRadius = 20;
            MiddleContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MiddleContainer.ShadowDecoration.Depth = 50;
            MiddleContainer.BackColor = Color.Gray;

            LeftContainer.BorderRadius = 20;
            LeftContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LeftContainer.ShadowDecoration.Depth = 50;
            LeftContainer.BackColor = Color.Gray;

            HideContainer.BorderRadius = 20;
            HideContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            HideContainer.ShadowDecoration.Depth = 50;
            HideContainer.BackColor = Color.Gray;

            DisplayDays();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
     
        }






        Stopwatch st = new Stopwatch();
        MouseButtons mb = MouseButtons.None;

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            if (HideContainer.Visible == false)
            {
                Show2SloiAnimated.Show(HideContainer);
                HideContainer.Enabled = true;
            }
            else HideContainer.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HideContainer.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (HideContainer.Visible == false)
            { 
                LblShow.Visible = false;
                RightContainer.FillColor = Color.Gray;
                //Show2SloiAnimated.Show(HideContainer);
               HideContainer.Visible= true;
            }
            else HideContainer.Visible = false;
        }

        private void LblHide_Click_1(object sender, EventArgs e)
        {
            HideContainer.Visible = false;
            RightContainer.FillColor = Color.White;
            LblShow.Visible = true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            month++;
            DaysContainer.Controls.Clear();
            if (month == 13)
            {
                month = 1;
                year++;
            }
            
            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month-1];
            LblYearMonth.Text= monthName+ " " + year;


            DateTime StartOfMonth = new DateTime(year, month, 1);
            int Days = DateTime.DaysInMonth(year, month);
            int DaysOfWeek = Convert.ToInt32(StartOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < DaysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DaysContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= Days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DaysContainer.Controls.Add(ucDays);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            month--;
            DaysContainer.Controls.Clear();
            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            LblYearMonth.Text = monthName + " " + year;


            DateTime StartOfMonth = new DateTime(year, month, 1);
            int Days = DateTime.DaysInMonth(year, month);
            int DaysOfWeek = Convert.ToInt32(StartOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < DaysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DaysContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= Days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DaysContainer.Controls.Add(ucDays);
            }
        }
    }
}
