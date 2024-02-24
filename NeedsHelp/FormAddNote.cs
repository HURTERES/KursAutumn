﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedsHelp
{
    public partial class FormAddNote : Form
    {
        public FormAddNote()
        {
            InitializeComponent();
        }
        string Day = DateTime.Now.ToString("dd");
        string MMMM = DateTime.Now.ToString("MMMM");
        string Tm = DateTime.Now.ToString("H:mm");

        static public string originalTitleText = "";
        static public string originalContentText = "";
        static public string Time = "";
        static public bool OpenForEdit = false;



        private void FormAddNote_Load(object sender, EventArgs e)
        {
            if (OpenForEdit == true)
            {
                if (FormMain.LanguageState == 1)
                    Delnote.Text = "Удалить заметку";
                else Delnote.Text = "Delete note";
                Delnote.Visible = true;
                LblTime.Text = Time;
                OpenForEdit = false;
            }
            else
            {
                if (FormMain.LanguageState == 1)
                {
                    originalTitleText = "Заголовок";
                    originalContentText = "Начните ввод";
                }
                else
                {
                    originalTitleText = "Title";
                    originalContentText = "Start typing";
                }

                LblTime.Text = $"{Day} {MMMM} {Tm}";
            }

                Point mousePosition = Cursor.Position;
            this.Location = new Point(mousePosition.X - this.Width / 2+180, mousePosition.Y - this.Height / 2+230);

            TbxTitle.Text = originalTitleText;
            TbxText.Text = originalContentText;

            Time=LblTime.Text;
            FindSymbols.Enabled = true;
            TbxText.MouseWheel += TbxText_MouseWheel;
        }

        private void TbxText_MouseWheel(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            TbxText.SelectionStart = Math.Max(0, TbxText.SelectionStart + numberOfTextLinesToMove);
        }

        private void FindSymbols_Tick(object sender, EventArgs e)
        {
            LblCountSim.Text = TbxText.Text.Length.ToString();
            if (FormMain.LanguageState == 1)
            {
                if (TbxText.Text == "Начните ввод")
                    LblCountSim.Text = "0";
            }
            else {
                if (TbxText.Text == "Start typing")
                    LblCountSim.Text = "0";
            }
        }

        private void TbxText_Enter(object sender, EventArgs e)
        {
            if (TbxText.Text == originalContentText)
                TbxText.Text = "";
        }

        private void TbxText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxText.Text))
                TbxText.Text = originalContentText;
        }


        private void TbxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TbxText.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (TbxText.Text.Trim() == "")
            {
                if (FormMain.LanguageState == 1)
                    originalContentText = "Начните ввод";
                else
                    originalContentText = "Start typing";
            }
            else originalContentText = TbxText.Text;

            if (TbxTitle.Text.Trim() == "")
            {
                if (FormMain.LanguageState == 1)
                    originalTitleText = "Заголовок";
                else
                    originalTitleText = "Title";
            }
            else originalTitleText = TbxTitle.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void FormAddNote_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void TbxTitle_Enter_1(object sender, EventArgs e)
        {
            if (TbxTitle.Text == originalTitleText)
                TbxTitle.Text = "";
        }

        private void TbxTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxTitle.Text))
                    TbxTitle.Text = originalTitleText;
        }

        private void TbxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TbxTitle.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void LblCloseWithoutSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void Delnote_Click(object sender, EventArgs e)
        {
            using (ExcelPackage Package = new ExcelPackage(new FileInfo(Application.StartupPath + "\\Notes.xlsx")))
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = Package.Workbook.Worksheets[0];

                // Устанавливаем значение ячейки в null
                worksheet.Cells[FormNotes.Id, 1].Clear();
                worksheet.Cells[FormNotes.Id, 2].Clear();
                worksheet.Cells[FormNotes.Id, 3].Clear();

                // Сохраняем изменения в файле Excel
                Package.Save();
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}