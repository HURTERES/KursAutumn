using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace NeedsHelp
{
    public partial class FormEndedList : Form
    {
        public FormEndedList()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormEndedList_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvEvents.Rows.Count; i++)
            {
                DateTime dateTime = DateTime.Now;
                DateTime TimeEnd = DateTime.Parse(DgvEvents.Rows[i].Cells[4].Value.ToString());
                string Dt = dateTime.ToString("yyyy");
                if (int.Parse(Dt) > int.Parse(TimeEnd.ToString("yyyy")))
                {
                    SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                    SqlCommand Cmd = new SqlCommand($"delete   [Events] where IdEvent='{DgvEvents.Rows[i].Cells[0].Value}'", Con);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                }
                else 
                {
                    Dt = dateTime.ToString("MM");
                    if (int.Parse(Dt) - int.Parse(TimeEnd.ToString("MM")) > 0)
                    {

                        SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                        SqlCommand Cmd = new SqlCommand($"delete   [Events] where IdEvent='{DgvEvents.Rows[i].Cells[0].Value}'", Con);
                        Con.Open();
                        Cmd.ExecuteNonQuery();
                        Con.Close();
                        this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                    }
                    else
                    {
                        Dt = dateTime.ToString("dd");
                        if ((int.Parse(Dt) - int.Parse(TimeEnd.ToString("dd"))) > 3)
                        {
                            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                            SqlCommand Cmd = new SqlCommand($"delete   [Events] where IdEvent='{DgvEvents.Rows[i].Cells[0].Value}'", Con);
                            Con.Open();
                            Cmd.ExecuteNonQuery();
                            Con.Close();
                            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
                        }
                    }
                } 
            }
                try
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                SqlCommand Cmd = new SqlCommand($"SELECT * from Events where State='Завершенное'", Con);
                Con.Open();
                SqlDataReader Res = Cmd.ExecuteReader();
                Res.Read();
                Con.Close();
            }
            catch {  }   
            DgvEvents.ClearSelection();
            if (FormMain.LanguageState == 1)
            {
                DgvEvents.Columns[1].HeaderText = "Название";
                DgvEvents.Columns[2].HeaderText = "Описание";
                DgvEvents.Columns[3].HeaderText = "Дата начала";
                DgvEvents.Columns[4].HeaderText = "Дата окончания";
                LblInform.Text = "Нет завершенных событий";
                LblDesc.Text = "Описание:";
                LblTitle.Text = "Название:";
                LblTitle.Location = new Point(270, 43);
                DelEvent.Text = "Скрыть событие";
                BtnReturn.Text = "◀ Назад";
                CMenuStrip.Items[0].Text = "Больше информации";
            }
            if (DgvEvents.Rows.Count == 0)
            {
                LblInform.Dock = DockStyle.Fill;
                LblInform.Visible = true;
            }

        }

        private void FormEndedList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBKurs23DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);

        }

        private void BsDate_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DgvEvents_Leave(object sender, EventArgs e)
        {
            DgvEvents.ClearSelection();
        }

        private void CMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem Item = e.ClickedItem;
            if (Item == toolStripMenuItem1)
            {
                PanelMoreInformation.Visible = true;
                Tbxname.Text = NameEvent;
                TbxDesc.Text = Desc;
                Tbxname.BackColor = Color.White;
            }
        }

        string IdEvents, NameEvent, Desc;

        private void DelEvent_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            SqlCommand Cmd = new SqlCommand($"delete   [Events] where IdEvent='{IdEvents}'", Con);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
            this.eventsTableAdapter.Fill(this.dBKurs23DataSet.Events);
            PanelMoreInformation.Visible = false;
        }

        private void PanelMoreInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelMoreInformation.Visible = false;
        }

        private void DgvEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = DgvEvents.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    Point mouseArgs = Control.MousePosition;
                    IdEvents = DgvEvents.Rows[currentMouseOverRow].Cells["IdEvent"].Value.ToString();
                    NameEvent = DgvEvents.Rows[currentMouseOverRow].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                    Desc = DgvEvents.Rows[currentMouseOverRow].Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                    CMenuStrip.Show(mouseArgs);
                }
            }
        }
    }
}
