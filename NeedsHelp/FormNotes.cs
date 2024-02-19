using ExcelDataReader;
using Guna.UI2.WinForms;
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
using OfficeOpenXml;
using System.Globalization;

namespace NeedsHelp
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelScroll_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouseArgs = Control.MousePosition;
            CMenuNotes.Show(mouseArgs);
        }

        void Note(string title, string content, string time)
        {
            PanelScroll.AutoScrollPosition = new Point(0, 0);
            int x, y;
            Guna2ShadowPanel Note = new Guna2ShadowPanel();
            int CountX = PanelScroll.Controls.Count;
            int CountY = (PanelScroll.Controls.Count) / 3;
            int CountXX = (PanelScroll.Controls.Count) / 3;

            Note.Name = $"Note_{CountX + 1}";
            Note.Size = new Size(250, 200);
            x = ((CountX + 1) - 3 * CountY) * 22 + (CountX - 3 * CountY) * 250;
            y = (CountY + 1) * 21 + CountY * 200;
            Note.Location = new Point(x, y);
            Note.BackColor = Color.White;
            Note.ForeColor = Color.Black;
            PanelScroll.Controls.Add(Note);
            PanelScroll.AutoScrollPosition = new Point(x, y);

            Panel InnerTitle = new Panel();

            InnerTitle.Size = new Size(220, 30);
            InnerTitle.Location = new Point(15, 15);
            InnerTitle.BackColor = Color.White;
            InnerTitle.ForeColor = Color.Black;
            Note.Controls.Add(InnerTitle);

            Label LabelTitle = new Label();
            LabelTitle.Text = $"{FormAddNote.originalTitleText}{title}";
            LabelTitle.Font = new Font("Microsoft Sans Serif", 14); ;
            LabelTitle.Dock = DockStyle.Fill;
            InnerTitle.Controls.Add(LabelTitle);


            Guna2ShadowPanel InnerContent = new Guna2ShadowPanel();

            InnerContent.Size = new Size(210, 120);
            InnerContent.Location = new Point(20, 45);
            InnerContent.BackColor = Color.White;
            InnerContent.ForeColor = Color.Black;
            Note.Controls.Add(InnerContent);

            Label LabelContent = new Label();
            LabelContent.Text = $"{FormAddNote.originalContentText}{content}";
            LabelContent.Font = new Font("Microsoft Sans Serif", 12); ;
            LabelContent.Dock = DockStyle.Fill;
            InnerContent.Controls.Add(LabelContent);


            Guna2ShadowPanel InnerDateTime = new Guna2ShadowPanel();

            InnerDateTime.Size = new Size(220, 20);
            InnerDateTime.Location = new Point(15, 170);
            InnerDateTime.BackColor = Color.White;
            InnerDateTime.ForeColor = Color.Black;
            Note.Controls.Add(InnerDateTime);

            Label LabelDateTime = new Label();
            LabelDateTime.Text = $"{FormAddNote.Time}{time}";
            LabelDateTime.Font = new Font("Microsoft Sans Serif", 8); ;
            LabelDateTime.Dock = DockStyle.Fill;
            InnerDateTime.Controls.Add(LabelDateTime);

        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            FormAddNote Frm = new FormAddNote();
            Frm.ShowDialog();
            if (Frm.DialogResult != DialogResult.No)
            {
                Note(null, null, null);

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                string filePath = (Application.StartupPath + "\\Notes.xlsx");

                FileInfo file = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    // Получаем лист, с которым будем работать
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // Определяем индекс следующей доступной строки для записи данных
                    int lastRow = worksheet.Dimension.End.Row + 1;

                    worksheet.Cells[lastRow, 1].Value = FormAddNote.originalTitleText;
                    worksheet.Cells[lastRow, 2].Value = FormAddNote.originalContentText;

                    string[] parts = FormAddNote.Time.Split(' ');
                    string dateString = parts[0];
                    string monthString = parts[1];
                    string timeString = parts[2];
                    DateTime parsedDate = DateTime.ParseExact(monthString, "MMMM", CultureInfo.InvariantCulture);
                    worksheet.Cells[lastRow, 3].Value = $"{dateString}/{parsedDate.Month:D2}/{DateTime.Now.Year} {timeString}";

                    package.Save();
                }
            }
            FormAddNote.originalTitleText = "";
            FormAddNote.originalContentText = "";
            FormAddNote.Time = "";
        }

        private void FormNotes_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {

            // Open Excel File
            FileStream stream = File.Open(Application.StartupPath + "\\Notes.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();

            // Select 1 table from excel pages
            DataTable dt = result.Tables[0];

            // Close and clear memory
            excelReader.Close();

            // Не заполняется panel, если есть пустые поля
            // Если в таблице excel в дате указано "Все форматы", тогда считывает последнюю строку с этим форматом и записывает в последнюю строку со значениями => ОШИБКА
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string Title = dt.Rows[i][0].ToString();
                    string Content = dt.Rows[i][1].ToString();
                    string Time = dt.Rows[i][2].ToString().Split('/')[0] + " " + (new DateTime(int.Parse(dt.Rows[i][2].ToString().Split('/')[1])).ToString("MMMM")).ToString() +
                        " " + dt.Rows[i][2].ToString().Split(' ')[1].Split(':')[0] + ":" + dt.Rows[i][2].ToString().Split(' ')[1].Split(':')[1];
                    Note(Title, Content, Time);

                    // т.к. переменные статичные, нужно очищать их при каждом обращении к форме
                    Title = null; Content = null; Time = null;
                }
            }
            catch { }
            PanelScroll.AutoScrollPosition = new Point(0, 0);
            
            if (FormMain.LanguageState==1)
            {
                CMenuNotes.Items[0].Text = "Добавить заметку";
            }
        }
    }
}
