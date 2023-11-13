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
            SqlCommand Cmd = new SqlCommand($"SELECT * from Events where State='Предстоящее'", Con);
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
        }

        private void FormAddEvent_Load(object sender, EventArgs e)
        {
            
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
            DateTime DT = DateTime.Now;

            string FormattedBeginDate = DT.ToString($"{LblDate.Text} {TbxBeginHour.Text}:00:00");
            if (CmbTimeBegin.SelectedIndex == 1)
                FormattedBeginDate = DT.ToString($"{LblDate.Text} {int.Parse(TbxBeginHour.Text)+12}:00:00");
            string FormattedEndDate = DT.ToString($"{LblDate.Text} {TbxEndHour.Text}:00:00");
            if (CmbTimeEnd.SelectedIndex == 1)
                FormattedEndDate = DT.ToString($"{LblDate.Text} {int.Parse(TbxEndHour.Text)+12}:00:00");

            SqlConnection Con = new SqlConnection(FormMain.TxtCon);

            SqlCommand Cmd = new SqlCommand($"insert into [Events] (IdEvent, Name, Description, BeginDate, EndDate, State) values ('{CountRows+1}', '{Tbxname.Text}','{TbxDesc.Text}','{FormattedBeginDate}','{FormattedEndDate}','Предстоящее')", Con);

            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();

            TbxDesc.Text=Cmd.CommandText;
        }
    }
}
