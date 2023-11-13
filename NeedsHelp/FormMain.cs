using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

       public static int month, Day;
       public static int year = 1;

        public static string TxtCon = "Data Source=213.155.192.79,3002;Initial Catalog=DBKurs23;User ID=u21levinsas;Password=ngh4";
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



                // Добавляем обработчик события Enter для UserControlDays
                ucDays.Enter += (enterSender, enterArgs) => UserControlDays_Enter(enterSender, enterArgs, i);

                DaysContainer.Controls.Add(ucDays);
            }
        }

        void FillForm()
        {
            try
            {
                SqlConnection Con = new SqlConnection(TxtCon);
                SqlCommand Cmd = new SqlCommand($"SELECT * from Events where State='Предстоящее'", Con);
                Con.Open();
                SqlDataReader Res = Cmd.ExecuteReader();
                Res.Read();
                if (Res.HasRows)
                {
                   // LblName.Text = Res["Name"].ToString();
                   // LblID.Text = "ID сотрудника: " + (Res["IdPredp"].ToString());
                }
                else LblInformation.Visible = true;
                Con.Close();
            }
            catch { LblInformation.Visible = true; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBKurs23DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
            DisplayDays();
            DgvEvents.AllowUserToResizeColumns = false;
            FillForm();
            DgvEvents.ClearSelection();
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


                // Добавляем обработчик события Enter для UserControlDays
                ucDays.Enter += (enterSender, enterArgs) => UserControlDays_Enter(enterSender, enterArgs, i);

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


                // Добавляем обработчик события Enter для UserControlDays
                ucDays.Enter += (enterSender, enterArgs) => UserControlDays_Enter(enterSender, enterArgs, i);


                DaysContainer.Controls.Add(ucDays);
            }
        }

        private void UserControlDays_Enter(object sender, EventArgs e, int day)
        {
            UserControlDays enteredControl = sender as UserControlDays;
            Day=int.Parse(enteredControl.BtnDay.Text);

            if (enteredControl != null)
            {
                Point mouseArgs = Control.MousePosition;
                CMenuStrip.Show(mouseArgs);
                //MessageBox.Show($"Вы перешли на {enteredControl} {Day} дня {year} года {month} месяца");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvEvents_Leave(object sender, EventArgs e)
        {
            DgvEvents.ClearSelection();
        }

        private void CMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem Item = e.ClickedItem;
            if (Item == добавитьСобытиеToolStripMenuItem)
            {
                FormAddEvent Frm = new FormAddEvent();
                Frm.LblDate.Text =$"{year}-{month}-{Day}";
                Frm.ShowDialog();
            }

        }
    }
}
