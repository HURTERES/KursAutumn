using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExcelDataReader;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Tulpep.NotificationWindow;

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
                //if (BthDay == i && month == BthMonth)
                //{
                //        DaysContainer.Controls.Add(ucDays);
                //} else
                    DaysContainer.Controls.Add(ucDays);
            }
        }

        void FillForm()
        {
            try
            {
                SqlConnection Con = new SqlConnection(TxtCon);
                SqlCommand Cmd = new SqlCommand($"SELECT * from Events where State='Предстоящее' or State='Ежедневное'", Con);
                Con.Open();
                SqlDataReader Res = Cmd.ExecuteReader();
                Res.Read();
                if (Res.HasRows) { }
                else LblInformation.Visible = true;
                Con.Close();
            }
            catch { LblInformation.Visible = true; }
        }

        public string BthName;
        public int BthDay, BthMonth;

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBKurs23DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);

            // ТРУДНОСТИ С ДОБАВЛЕНИЕМ В UDAYS CONTAINER ДОПОЛНИТЕЛЬНЫХ СИМВОЛОВ !=INT + К ЭТОМУ ЗАТЕМ
            // СЧИТЫВАЕТСЯ ЗНАЧЕНИЕ ПОЛЯ(В СЛУЧАЕ ЕСЛИ ДОП СИМВОЛ !=INT, ТОГДА СНОВА ВЫДАЕТ ОШИБКУ)

            
            // Ошибка если файл открыт
            //FileStream stream = File.Open(Application.StartupPath + "\\Birhdays.xlsx", FileMode.Open, FileAccess.Read);
            //IExcelDataReader excelReader;
            //excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //// Читаем, получаем DataSet и работаем с ним как обычно.
            //DataSet result = excelReader.AsDataSet();
            //DataTable dt = result.Tables[0];
            //// После завершения чтения освобождаем ресурсы.
            //excelReader.Close();

            //BthName = dt.Rows[0][0].ToString();
            //BthDay= int.Parse((dt.Rows[0][1].ToString().Split(' ')[0]).Split('/')[0]);
            //BthMonth= int.Parse((dt.Rows[0][1].ToString().Split(' ')[0]).Split('/')[1]);
            //label9.Text = dt.Rows[0][0].ToString() + " " + (dt.Rows[0][1].ToString().Split(' ')[0]).Split('/')[0] + " " + (dt.Rows[0][1].ToString().Split(' ')[0]).Split('/')[1];


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
            }
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
                if(State=="Ежедневное")
                    Frm.CbxDaily.Checked = true ;
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
                Frm.BtnAddEvent.Text = "Edit event";

                Frm.ShowDialog();
                this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                DgvEvents.ClearSelection();
                if (DgvEvents.Rows.Count > 0)
                    LblInformation.Visible = false;
                else LblInformation.Visible = true;
            }
        }

        string IdEvent,NameEvent,Desc,BeginDate,EndDate, Beg, End, State;

        private void BtnManual_Click(object sender, EventArgs e)
        {
            FormUserManual Frm = new FormUserManual();
            Frm.ShowDialog();
        }

        private void BtnEndedEvents_Click(object sender, EventArgs e)
        {
            FormEndedList Frm = new FormEndedList();
            Frm.ShowDialog();
        }

        private void BtnNotes_Click(object sender, EventArgs e)
        {
            FormNotes Frm = new FormNotes();
            Frm.ShowDialog();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            FormPhoneBook Frm = new FormPhoneBook();
            Frm.ShowDialog();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            TimerAlarm.Enabled = true;
        }


        private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            if (DgvEvents.Rows.Count > 0)
            {
                string Name;
                string FormattedBeginDate, FormattedEndDate;
                DateTime DateNow= DateTime.Now;
                for (int i = 0; i < DgvEvents.Rows.Count;i++)
                {
                    string TimeBegin = (DgvEvents.Rows[i].Cells[3].Value.ToString());
                    DateTime TimeBegin1 = DateTime.Parse(DgvEvents.Rows[i].Cells[3].Value.ToString());
                    string TimeEnd = (DgvEvents.Rows[i].Cells[4].Value.ToString());
                    DateTime TimeEnd1 = DateTime.Parse(DgvEvents.Rows[i].Cells[4].Value.ToString());
                    // Сравнить дату из (DateNow >= DateTime.Parse(DgvEvents.Rows[i].Cells[4].Value.ToString())) с текущим днем, записать в переменную DateTime TimeBegin текущий день и добавить +1
                    string year1, month1, day1, year2, month2, day2, hour1, hour2;
                    year2 = TimeEnd.Split('/')[2];
                    year2 = year2.Split(' ')[0];
                    month2 = TimeEnd.Split('/')[1];
                    day2 = TimeEnd.Split('/')[0];
                    year1 = TimeBegin.Split('/')[2];
                    year1 = year1.Split(' ')[0];
                    month1 = TimeBegin.Split('/')[1];
                    day1 = TimeBegin.Split('/')[0];
                    hour1 = TimeBegin.Split(' ')[1];
                    hour2 = TimeEnd.Split(' ')[1];

                    if (DateNow >= TimeBegin1)
                    {
                        day1 = DateNow.Day.ToString();
                        day1 = (int.Parse(day1) + 1).ToString();
                    }

                    if (DateNow >= TimeEnd1)
                    {
                        day2 = DateNow.Day.ToString();
                        day2 = (int.Parse(day2) + 1).ToString();
                    }


                    FormattedBeginDate = DateNow.ToString($"{year1}/{month1}/{day1} {hour1}");
                    FormattedEndDate = DateNow.ToString($"{year2}/{month2}/{day2} {hour2}");

                    if (DgvEvents.Rows[i].Cells[1].Value.ToString().Length > 8)
                            Name = ((DgvEvents.Rows[i].Cells[1].Value.ToString()).Substring(0, 9)) + "...";
                        else Name = DgvEvents.Rows[i].Cells[1].Value.ToString();
                        PopupNotifier popup = new PopupNotifier();
                        popup.Size = new Size(460, 100);
                        popup.Image = Properties.Resources.WhiteBook;
                        popup.ImageSize = new Size(96, 96);
                        popup.TitleColor = Color.Gray;
                        popup.ShowGrip = false;
                        popup.GradientPower = 100;
                        popup.TitleFont = new System.Drawing.Font("Arial", 14);
                        popup.ContentFont = new System.Drawing.Font("Arial", 14);
                        popup.TitlePadding = new Padding(10, 10, 10, 0);
                        popup.ContentPadding = new Padding(10);
                        popup.ContentColor = Color.DarkGreen;
                        popup.HeaderColor = Color.Gray;
                        popup.BorderColor = Color.Gray;
                        popup.BodyColor = Color.White;
                        popup.ShowCloseButton = false;


                        SqlCommand Cmd = new SqlCommand();

                        SqlConnection Con = new SqlConnection(TxtCon);
                    if (DgvEvents.Rows[i].Cells[5].Value.ToString() == "Ежедневное" && DateNow >= DateTime.Parse(TimeEnd))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\audio-editor-output.wav");
                        if (RusLanguage.Checked)
                        {
                            popup.TitleText = "Поступила информация о событии:";
                            popup.ContentText = $"Событие {Name} завершено!";
                        }
                        else
                        {
                            popup.TitleText = "New information about event:";
                            popup.ContentText = $"Event {Name} completed!";
                        }
                        player.Play();
                        popup.Popup();

                        Cmd = new SqlCommand($"update [Events] set BeginDate='{FormattedBeginDate}', EndDate='{FormattedEndDate}' where IdEvent='{DgvEvents.Rows[i].Cells[0].Value}'", Con);
                        Con.Open();
                        Cmd.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (DateNow >= DateTime.Parse(TimeEnd))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\audio-editor-output.wav");
                        player.Play();
                        popup.Popup();
                        Cmd = new SqlCommand($"update [Events] set State='Завершенное' where IdEvent='{DgvEvents.Rows[i].Cells[0].Value}'", Con);
                        Con.Open();
                        Cmd.ExecuteNonQuery();
                        Con.Close();
                        if (RusLanguage.Checked)
                        {
                            popup.TitleText = "Поступила информация о событии:";
                            popup.ContentText = $"Событие {Name} завершено!";
                        }
                        else
                        {
                            popup.TitleText = "New information about event:";
                            popup.ContentText = $"Event {Name} completed!";
                        }
                        player.Play();
                        popup.Popup();
                    }
                    else { }
                }    
            }

            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
            this.eventsTableAdapter.Update(this.dBKurs23DataSet.Events);
            if (DgvEvents.Rows.Count == 0)
                LblInformation.Visible = true;
            DgvEvents.ClearSelection();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = true;
                Org_Pro.Visible = true;
            }
            else
            {
                ShowIcon = true;
                Org_Pro.Visible = false;
            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    Org_Pro.Visible = true;
            //    e.Cancel = true;

            //    this.Hide();
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Org_Pro.Visible = false;
        }

        public static int LanguageState=0;
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
                CMenuStrip.Items[0].Text = "Добавить событие";
                CMenuEdit.Items[0].Text = "Редактировать событие";
                BtnManual.Text = "Руководство пользователя";
                BtnEndedEvents.Text = "Завершенные события";
                BtnNotes.Text = "Заметки";
                BtnBook.Text = "Контакты";
                LanguageState = 1;
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
                LblInformation.Text = "No upcoming events";
                BtnManual.Text = "User manual";
                CMenuStrip.Items[0].Text = "Add event";
                CMenuEdit.Items[0].Text = "Edit event";
                BtnEndedEvents.Text = "Ended events";
                BtnNotes.Text = "Notes";
                BtnBook.Text = "Contacts";
                LanguageState = 0;
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
                    State = DgvEvents.Rows[currentMouseOverRow].Cells["stateDataGridViewTextBoxColumn"].Value.ToString();
                    CMenuEdit.Show(mouseArgs);
                }
            }
        }

        private void CMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem Item = e.ClickedItem;
            if (Item == добавитьСобытиеToolStripMenuItem)
            {
                DateTime Today= DateTime.Now;
                DateTime myDateTime = new DateTime(year, month, Day);
                FormAddEvent Frm = new FormAddEvent();
                Frm.LblDate.Text =$"{year}-{month}-{Day}";
                if (RusLanguage.Checked)
                    Frm.Check.Text = "1";
                if (Today < myDateTime)
                {
                    Frm.ShowDialog();
                    this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                    DgvEvents.ClearSelection();
                    if (DgvEvents.Rows.Count > 0)
                        LblInformation.Visible = false;
                }
                else MessageBox.Show("Нельзя планировать события задним числом!");
            }

        }
    }
}
