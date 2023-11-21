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
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += new EventHandler(exitMenuItem_Click);

            contextMenu.Items.Add(exitMenuItem);

            Org_Pro.ContextMenuStrip = contextMenu;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
            LblInformation.Dock= DockStyle.Fill;
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
            if (WindowState == FormWindowState.Minimized)
            {
               // ShowInTaskbar = false;
                Org_Pro.Visible = true;
            }
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
            if (RusLanguage.Checked)
            {
                if (monthName == "January")
                    monthName = "Январь";
                if (monthName == "February")
                    monthName = "Февраль";
                if (monthName == "March")
                    monthName = "Март";
                if (monthName == "April")
                    monthName = "Апрель";
                if (monthName == "May")
                    monthName = "Май";
                if (monthName == "June")
                    monthName = "Июнь";
                if (monthName == "July")
                    monthName = "Июль";
                if (monthName == "August")
                    monthName = "Август";
                if (monthName == "September")
                    monthName = "Сентябрь";
                if (monthName == "October")
                    monthName = "Октябрь";
                if (monthName == "November")
                    monthName = "Ноябрь";
                if (monthName == "December")
                    monthName = "Декабрь";
                LblYearMonth.Text = monthName + " " + year;
            }
            else 
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
            if (RusLanguage.Checked)
            {
                if (monthName == "January")
                    monthName = "Январь";
                if (monthName == "February")
                    monthName = "Февраль";
                if (monthName == "March")
                    monthName = "Март";
                if (monthName == "April")
                    monthName = "Апрель";
                if (monthName == "May")
                    monthName = "Май";
                if (monthName == "June")
                    monthName = "Июнь";
                if (monthName == "July")
                    monthName = "Июль";
                if (monthName == "August")
                    monthName = "Август";
                if (monthName == "September")
                    monthName = "Сентябрь";
                if (monthName == "October")
                    monthName = "Октябрь";
                if (monthName == "November")
                    monthName = "Ноябрь";
                if (monthName == "December")
                    monthName = "Декабрь";
                LblYearMonth.Text = monthName + " " + year;
            }
            else
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


        private void CMenuEdit_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem Item = e.ClickedItem;
            if (Item == редактироватьСобытиеToolStripMenuItem)
            {
                FormAddEvent Frm = new FormAddEvent();
                Frm.LblId.Text =IdEvent.ToString();
                Frm.LblDate.Text = $"{BeginDate} - {EndDate}";
                Frm.Tbxname.Text = $"{NameEvent}" ;
                Frm.TbxDesc.Text = $"{Desc}";
                //Frm.TbxBeginHour.Text = 
                Beg = BeginDate.Split(' ')[1];
                string Beg1 = Beg[0].ToString();
                Beg1 += Beg[1].ToString();

                End = EndDate.Split(' ')[1];
                string End1 = End[0].ToString();
                End1 += End[1].ToString();

                if (int.Parse(End1) > 12)
                {
                    Frm.CmbTimeEnd.SelectedIndex = 1;
                    Frm.TbxEndHour.Text = $"{int.Parse(End1) - 12}";
                }
                else Frm.TbxEndHour.Text = End1;

                if (int.Parse(Beg1) > 12)
                {
                    Frm.CmbTimeBegin.SelectedIndex = 1;
                    Frm.TbxBeginHour.Text = $"{int.Parse(Beg1) - 12}";
                }
                else Frm.TbxBeginHour.Text = Beg1;

                Frm.LblLength.Text = $"{Frm.TbxDesc.Text.Length-1} of 300";

                Frm.DelEvent.Visible = true;
                if (RusLanguage.Checked)
                    Frm.Check.Text ="1";
                Frm.ShowDialog();
                this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                DgvEvents.ClearSelection();
                if (DgvEvents.Rows.Count > 0)
                    LblInformation.Visible = false;
                else LblInformation.Visible = true;
            }
        }

        string IdEvent,NameEvent,Desc,BeginDate,EndDate, Beg, End;

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Org_Pro.Visible = true;
                e.Cancel = true;

                this.Hide();
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Org_Pro.Visible = false;
        }

        private void RusLanguage_CheckedChanged(object sender, EventArgs e)
        {
            if (RusLanguage.Checked)
            {
                FormAddEvent Frm = new FormAddEvent();
                Frm.label1.Text = "Название события: ";

                LblInformation.Text = "Нет предстоящих событий";
                string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
                if (RusLanguage.Checked)
                {
                    if (monthName == "January")
                        monthName = "Январь";
                    if (monthName == "February")
                        monthName = "Февраль";
                    if (monthName == "March")
                        monthName = "Март";
                    if (monthName == "April")
                        monthName = "Апрель";
                    if (monthName == "May")
                        monthName = "Май";
                    if (monthName == "June")
                        monthName = "Июнь";
                    if (monthName == "July")
                        monthName = "Июль";
                    if (monthName == "August")
                        monthName = "Август";
                    if (monthName == "September")
                        monthName = "Сентябрь";
                    if (monthName == "October")
                        monthName = "Октябрь";
                    if (monthName == "November")
                        monthName = "Ноябрь";
                    if (monthName == "December")
                        monthName = "Декабрь";
                    LblYearMonth.Text = monthName + " " + year;
                }

                label2.Text = "Пн";
                label3.Text = "Вт";
                label4.Text = "Ср";
                label5.Text = "Чт";
                label6.Text = "Пт";
                label7.Text = "Сб";
                label1.Text = "Вс";
                DgvEvents.Columns[1].HeaderText = "Название";
                DgvEvents.Columns[2].HeaderText = "Описание";
                DgvEvents.Columns[3].HeaderText = "Дата начала";
                DgvEvents.Columns[4].HeaderText = "Дата окончания";
                LblInformation.Text = "Нет предстоящих событий";
            }
            else
            {
                label2.Text = "Mo";
                label3.Text = "Tu";
                label4.Text = "We";
                label5.Text = "Th";
                label6.Text = "Fr";
                label7.Text = "Sa";
                label1.Text = "Su";
                string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
                LblYearMonth.Text = monthName + " " + year;
                DgvEvents.Columns[1].HeaderText = "Title";
                DgvEvents.Columns[2].HeaderText = "Description";
                DgvEvents.Columns[3].HeaderText = "BeginDate";
                DgvEvents.Columns[4].HeaderText = "EndDate";
                LblInformation.Text = "no upcoming events";
            }

        }

        private void DgvEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = DgvEvents.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    Point mouseArgs = Control.MousePosition;
                    IdEvent = DgvEvents.Rows[currentMouseOverRow].Cells["idEventDataGridViewTextBoxColumn"].Value.ToString();
                    NameEvent = DgvEvents.Rows[currentMouseOverRow].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                    Desc = DgvEvents.Rows[currentMouseOverRow].Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                    BeginDate = DgvEvents.Rows[currentMouseOverRow].Cells["beginDateDataGridViewTextBoxColumn"].Value.ToString();
                    EndDate = DgvEvents.Rows[currentMouseOverRow].Cells["endDateDataGridViewTextBoxColumn"].Value.ToString();
                    CMenuEdit.Show(mouseArgs);
                }
            }
        }

        private void CMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem Item = e.ClickedItem;
            if (Item == добавитьСобытиеToolStripMenuItem)
            {
                FormAddEvent Frm = new FormAddEvent();
                Frm.LblDate.Text =$"{year}-{month}-{Day}";
                if (RusLanguage.Checked)
                    Frm.Check.Text = "1";
                Frm.ShowDialog();
                this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                DgvEvents.ClearSelection();
                if (DgvEvents.Rows.Count > 0)
                    LblInformation.Visible = false;
            }

        }
    }
}
