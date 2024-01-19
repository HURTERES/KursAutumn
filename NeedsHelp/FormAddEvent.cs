using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedsHelp
{
    public partial class FormAddEvent : Form
    {
        FormMain Frm = new FormMain();
        int CountRows;

        public FormAddEvent()
        {
            InitializeComponent();
            LblLength.Text = $"{TbxDesc.Text.Length} of 300";
            TbxBeginHour.Text = "00";
            TbxEndHour.Text = "00";
            CmbTimeBegin.SelectedIndex = 0;
            CmbTimeEnd.SelectedIndex = 0;

            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            SqlCommand Cmd = new SqlCommand($"SELECT * from Events where State='Предстоящее' or State='Ежедневное'", Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            Res.Read();
            if (Res.HasRows)
            {
                while(Res.Read())
                CountRows = int.Parse(Res["IdEvent"].ToString());
                
            }
            else CountRows = 1;
            Con.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TbxBeginHour_TextChanged(object sender, EventArgs e)
        {
            if (TbxBeginHour.Text != "")
            {
                if (int.Parse(TbxBeginHour.Text) > 12)
                    TbxBeginHour.Text = "12";
            }
        }

        private void TbxBeginHour_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void TbxBeginHour_Click_1(object sender, EventArgs e)
        {
            TbxBeginHour.Text = "";
            TbxBeginHour.BorderColor = Color.White;
        }

        private void FormAddEvent_Load(object sender, EventArgs e)
        {
            FindSymbols.Enabled = true;
        }

        private void TbxEndHour_TextChanged(object sender, EventArgs e)
        {
            if (TbxEndHour.Text != "")
            {
                if (int.Parse(TbxEndHour.Text) > 12)
                    TbxEndHour.Text = "12";
            }
        }

        private void TbxEndHour_Leave(object sender, EventArgs e)
        {
            if (TbxEndHour.Text == "")
                TbxEndHour.Text = "00";
        }

        private void TbxBeginHour_Leave(object sender, EventArgs e)
        {
            if (TbxBeginHour.Text == "")
                TbxBeginHour.Text = "00";
        }

        private void TbxEndHour_Click(object sender, EventArgs e)
        {
            TbxEndHour.Text = "";
            TbxEndHour.BorderColor = Color.White;
        }

        private void CbxFullDay_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxFullDay.Checked)
            {
                TbxEndHour.Enabled = false;
                CmbTimeEnd.SelectedIndex = 1;
                TbxEndHour.Text = "12";
            }
            else TbxEndHour.Enabled = true;
        }

        private void TbxDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblLength.Text = $"{TbxDesc.Text.Length} of 300";
            if (TbxDesc.Text.Length >= 300 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (Tbxname.Text == "" || TbxDesc.Text == "")
            {
                Point mouseArgs = Control.MousePosition;
                CMenuStrip.Show(mouseArgs);
                if(Tbxname.Text=="")
                Tbxname.BorderColor = Color.Red;
                if(TbxDesc.Text=="")
                TbxDesc.BorderColor = Color.Red;
            }
            else
            {
                DateTime DT = DateTime.Now;


                string FormattedBeginDate, FormattedEndDate;

                if (LblId.Text != "NULL")
                {
                    string year1, month1, day1, year2, month2, day2;
                    year2 = DateEnd.Split('/')[2];
                    month2 = DateEnd.Split('/')[1];
                    day2 = DateEnd.Split('/')[0];
                    year1 = DateBeg.Split('/')[2];
                    month1 = DateBeg.Split('/')[1];
                    day1 = DateBeg.Split('/')[0];


                    if ((((int.Parse(TbxBeginHour.Text) > int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 0 && CmbTimeEnd.SelectedIndex==0) && TbxBeginHour.Text != "00" && TbxEndHour.Text != "00") ||
                        ((int.Parse(TbxBeginHour.Text) >= int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 1 && CmbTimeEnd.SelectedIndex == 0) ||
                        ((int.Parse(TbxBeginHour.Text) >= int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 1 && CmbTimeEnd.SelectedIndex == 1))
                    {
                        TbxBeginHour.BorderColor = Color.Red;
                        TbxEndHour.BorderColor=Color.Red;
                        CMenuStrip.Items[0].Text = "Время указано некорректно";
                        Point mouseArgs = Control.MousePosition;
                        CMenuStrip.Show(mouseArgs);
                        return;
                    }
                    else CMenuStrip.Items[0].Text = "Не все поля заполнены";

                    SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                    FormattedBeginDate = DT.ToString($"{year1}/{month1}/{day1} {TbxBeginHour.Text}:00:00");
                    if (CmbTimeBegin.SelectedIndex == 1)
                        FormattedBeginDate = DT.ToString($"{year1}/{month1}/{day1} {int.Parse(TbxBeginHour.Text) + 12}:00:00");
                    FormattedEndDate = DT.ToString($"{year2}/{month2}/{day2} {TbxEndHour.Text}:00:00");
                    if (CmbTimeEnd.SelectedIndex == 1)
                        FormattedEndDate = DT.ToString($"{year2}/{month2}/{day2} {int.Parse(TbxEndHour.Text) + 12}:00:00");

                    if (TbxBeginHour.Text == "00" && TbxEndHour.Text == "00")
                        FormattedEndDate = DT.ToString($"{year2}/{month2}/{day2} 01:00:00");

                    if (CbxFullDay.Checked || TbxEndHour.Text == "12" && CmbTimeEnd.SelectedIndex == 1)
                        FormattedEndDate = $"{year2}-{month2}-{int.Parse(day2) + 1}";

                    SqlCommand Cmd = new SqlCommand();
                    if (CbxDaily.Checked)
                        Cmd = new SqlCommand($"update [Events] set Name='{Tbxname.Text}', Description='{TbxDesc.Text}', BeginDate='{FormattedBeginDate}', EndDate='{FormattedEndDate}', State='{"Ежедневное"}' where IdEvent='{LblId.Text}'", Con);
                    else
                       Cmd = new SqlCommand($"update [Events] set Name='{Tbxname.Text}', Description='{TbxDesc.Text}', BeginDate='{FormattedBeginDate}', EndDate='{FormattedEndDate}', State='{"Предстоящее"}' where IdEvent='{LblId.Text}'", Con);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    this.Close();
                }
                else
                {
                    string[] dateParts = LblDate.Text.Split('-');
                    string day = dateParts[2];
                    string month = dateParts[1];
                    string year = dateParts[0];

                    if ((((int.Parse(TbxBeginHour.Text) >= int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 0 && CmbTimeEnd.SelectedIndex == 0) && TbxBeginHour.Text != "00" && TbxEndHour.Text != "00") ||
   ((int.Parse(TbxBeginHour.Text) >= int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 1 && CmbTimeEnd.SelectedIndex == 0) ||
   ((int.Parse(TbxBeginHour.Text) >= int.Parse(TbxEndHour.Text)) && CmbTimeBegin.SelectedIndex == 1 && CmbTimeEnd.SelectedIndex == 1))
                    {
                        TbxBeginHour.BorderColor = Color.Red;
                        TbxEndHour.BorderColor = Color.Red;
                        CMenuStrip.Items[0].Text = "Время указано некорректно";
                        Point mouseArgs = Control.MousePosition;
                        CMenuStrip.Show(mouseArgs);
                        return;
                    }


                    FormattedBeginDate = DT.ToString($"{LblDate.Text} {TbxBeginHour.Text}:00:00");
                    if (CmbTimeBegin.SelectedIndex == 1)
                        FormattedBeginDate = DT.ToString($"{LblDate.Text} {int.Parse(TbxBeginHour.Text) + 12}:00:00");
                    FormattedEndDate = DT.ToString($"{LblDate.Text} {TbxEndHour.Text}:00:00");
                    if (CmbTimeEnd.SelectedIndex == 1)
                        FormattedEndDate = DT.ToString($"{LblDate.Text} {int.Parse(TbxEndHour.Text) + 12}:00:00");

                    if (TbxBeginHour.Text == "00" && TbxEndHour.Text == "00")
                        FormattedEndDate = DT.ToString($"{LblDate.Text} 01:00:00");

                    if (CbxFullDay.Checked || TbxEndHour.Text == "12" && CmbTimeEnd.SelectedIndex == 1)
                        FormattedEndDate = $"{year}-{month}-{int.Parse(day) + 1}";



                    SqlConnection Con = new SqlConnection(FormMain.TxtCon);

                    SqlCommand Cmd = new SqlCommand();
                    if (CbxDaily.Checked)
                         Cmd = new SqlCommand($"insert into [Events] (IdEvent, Name, Description, BeginDate, EndDate, State) values ('{CountRows + 1}', '{Tbxname.Text}','{TbxDesc.Text}','{FormattedBeginDate}','{FormattedEndDate}','Ежедневное')", Con);
                    else
                         Cmd = new SqlCommand($"insert into [Events] (IdEvent, Name, Description, BeginDate, EndDate, State) values ('{CountRows + 1}', '{Tbxname.Text}','{TbxDesc.Text}','{FormattedBeginDate}','{FormattedEndDate}','Предстоящее')", Con);
                       

                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();

                    this.Close();
                }
            }
        }

        private void Tbxname_Click(object sender, EventArgs e)
        {
            Tbxname.BorderColor = Color.White;
        }

        private void TbxDesc_Click(object sender, EventArgs e)
        {
            TbxDesc.BorderColor = Color.White;
        }

        int CurrTimeBeg, CurrTimeEnd;
        string DateBeg, DateEnd;

        private void FormAddEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Не работает anyway
            //FormMain Frm = new FormMain();
            //Frm.Org_Pro.Visible = false;
        }

        private void FindSymbols_Tick(object sender, EventArgs e)
        {
            LblLength.Text = $"{TbxDesc.Text.Length} of 300";
        }


        private void DelEvent_Click(object sender, EventArgs e)
        {
            DialogResult DR;
            if (Check.Text=="Check")
            DR = MessageBox.Show("You seriously want to delete this event?","Delete accept", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else DR = MessageBox.Show("Вы правда хотите удалить событие?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);

                SqlCommand Cmd = new SqlCommand($"delete from [Events] where IdEvent='{LblId.Text}'", Con);

                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();

                this.Close();
            }
        }

        private void FormAddEvent_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (LblId.Text != "NULL")
            {
                // Не нужно временно/нет
                //if (CmbTimeBegin.SelectedIndex == 0)
                //    CurrTimeBeg = int.Parse(TbxBeginHour.Text);
                //else CurrTimeBeg = int.Parse(TbxBeginHour.Text) + 12;

                //if (CmbTimeEnd.SelectedIndex == 0)
                //    CurrTimeEnd = int.Parse(TbxEndHour.Text);
                //else CurrTimeEnd= int.Parse(TbxEndHour.Text) + 12;

                DateBeg = LblDate.Text.Split(' ')[0];
                DateEnd = LblDate.Text.Split(' ')[3];
            }
            FormMain Frm= new FormMain();
            if (Check.Text=="1")
            {
                label1.Text ="Название:";
                CbxDaily.Text = "Ежедневно";
                label2.Text = "Описание:";
                label3.Text = "Начало:";
                label4.Text = "Окончание:";
                CbxFullDay.Text = "Целый день";
                label3.Location = new Point(23, 330);
                TbxBeginHour.Location = new Point(97, 328);
                CmbTimeBegin.Location = new Point(139, 328);
                label4.Location = new Point(206, 330);
                TbxEndHour.Location = new Point(306, 328);
                CmbTimeEnd.Location = new Point(349, 328);
                CbxDaily.Location = new Point(520, 330);
                if(LblId.Text=="NULL")
                BtnAddEvent.Text = "Добавить событие";
                else BtnAddEvent.Text = "Изменить событие";
                DelEvent.Text = "Удалить событие";
            }
        }
    }
}
