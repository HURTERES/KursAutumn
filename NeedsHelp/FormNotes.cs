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
using ExcelDataReader.Log.Logger;
using System.Security.Policy;

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

        static public int CountX = 0;
        static public int LabeId = 0;
        int Misses = 0;

        void Note(string title, string content, string time)
        {
            PanelScroll.AutoScrollPosition = new Point(0, 0);
            int x, y;
            Guna2ShadowPanel Note = new Guna2ShadowPanel();
            CountX = PanelScroll.Controls.Count;
            int CountY = PanelScroll.Controls.Count / 3;
            int CountXX = PanelScroll.Controls.Count / 3;


            Note.Name = $"Note_{CountX + 1}";
            Note.Size = new Size(250, 200);
            x = ((CountX + 1) - 3 * CountY) * 22 + (CountX - 3 * CountY) * 250;
            y = (CountY + 1) * 21 + CountY * 200;
            Note.Location = new Point(x, y);
            Note.BackColor = Color.White;
            Note.ForeColor = Color.Black;
            Note.Click += Note_Click;
            PanelScroll.Controls.Add(Note);
            PanelScroll.AutoScrollPosition = new Point(x, y);         

            Panel InnerTitle = new Panel();
            InnerTitle.Size = new Size(220, 30);
            InnerTitle.Location = new Point(15, 15);
            InnerTitle.Enabled = false;
            InnerTitle.ForeColor = Color.Black;
            Note.Controls.Add(InnerTitle);

            // Работает? не трогай!
            Label LabelId = new Label();
            LabelId.Location = new Point(20, 45);
            using (ExcelPackage Package = new ExcelPackage(new FileInfo(Application.StartupPath + "\\Notes.xlsx")))
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = Package.Workbook.Worksheets[0];
                for(int i=CountX+1+Misses; i < worksheet.Dimension.End.Row + 1;i++)
                if (worksheet.Cells[i, 1].Value != null)
                    {
                        LabelId.Text = (i).ToString();
                        LabeId = int.Parse(LabelId.Text);
                        InnerTitle.Controls.Add(LabelId);
                        break;
                    }
                    else Misses++;
            }


            Label LabelTitle = new Label();
            LabelTitle.Text = $"{FormAddNote.originalTitleText}{title}";
            LabelTitle.Font = new Font("Microsoft Sans Serif", 14);
            LabelTitle.Dock = DockStyle.Fill;
            InnerTitle.Controls.Add(LabelTitle);


            Guna2ShadowPanel InnerContent = new Guna2ShadowPanel();
            InnerContent.Size = new Size(210, 120);
            InnerContent.Location = new Point(20, 45);
            InnerContent.BackColor = Color.White;
            InnerContent.Enabled = false;
            InnerContent.ForeColor = Color.Black;
            InnerContent.Click += Note_Click;
            Note.Controls.Add(InnerContent);

            Label LabelContent = new Label();
            LabelContent.Text = $"{FormAddNote.originalContentText}{content}";
            LabelContent.Font = new Font("Microsoft Sans Serif", 12);
            LabelContent.Dock = DockStyle.Fill;
            LabelContent.ForeColor= Color.Black;
            InnerContent.Click += Note_Click;
            InnerContent.Controls.Add(LabelContent);


            Guna2ShadowPanel InnerDateTime = new Guna2ShadowPanel();

            InnerDateTime.Size = new Size(220, 20);
            InnerDateTime.Location = new Point(15, 170);
            InnerDateTime.BackColor = Color.White;
            InnerDateTime.Enabled = false;
            InnerDateTime.ForeColor = Color.Black;
            InnerDateTime.Click += Note_Click;
            Note.Controls.Add(InnerDateTime);

            Label LabelDateTime = new Label();
            LabelDateTime.Text = $"{FormAddNote.Time}{time}";
            LabelDateTime.Font = new Font("Microsoft Sans Serif", 8);
            LabelDateTime.Dock = DockStyle.Fill;
            LabelDateTime.Click += Note_Click;
            InnerDateTime.Controls.Add(LabelDateTime);

            Note.Tag = new { Title = title, Content = content, Time = time, Id=LabeId};
            LabelTitle.Tag = title;
            LabelContent.Tag = content;
            LabelDateTime.Tag = time;
            LabelId.Tag = LabeId;

        }
        static public int Id=0;
        private void Note_Click(object sender, EventArgs e)
        {
                var noteData = (sender as Guna2ShadowPanel)?.Tag as dynamic;
                var title = noteData?.Title;
                var content = noteData?.Content;
                var time = noteData?.Time;
                Id = noteData?.Id;
            FormAddNote Frm = new FormAddNote();
            FormAddNote.Time = time;
            FormAddNote.originalContentText = content;
            FormAddNote.originalTitleText = title;
            FormAddNote.OpenForEdit= true;
            MessageBox.Show($"{Id}");
            Frm.ShowDialog();

            if (Frm.DialogResult ==DialogResult.OK)
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(Application.StartupPath + "\\Notes.xlsx")))
                {
                    // Получаем объект для работы с листом Excel
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    if (worksheet.Dimension != null)
                    {
                        string DateNow = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        try
                        {
                            for (int i = 1; i < worksheet.Dimension.End.Row + 1; i++)
                            {
                                //string FormattedDate = (DateTime.ParseExact(time, "dd MMMM HH:mm", CultureInfo.InvariantCulture)).ToString("dd/MM/yyyy HH:mm");
                                if (i == Id)
                                {
                                    worksheet.Cells[i, 1].Value = FormAddNote.originalTitleText;
                                    worksheet.Cells[i, 2].Value = FormAddNote.originalContentText;
                                    worksheet.Cells[i, 3].Value = DateNow;
                                }
                            }
                        }
                        catch { }

                        // Сохраняем изменения
                        package.Save();
                    }
                }

            }
            FormAddNote.originalTitleText = "";
            FormAddNote.originalContentText = "";
            FormAddNote.Time = "";
            RefreshPanelScroll();
        }


        private void AddNote_Click(object sender, EventArgs e)
        {
            FormAddNote Frm = new FormAddNote();
            Frm.ShowDialog();
            if (Frm.DialogResult != DialogResult.No)
            {
                Note(FormAddNote.originalTitleText, FormAddNote.originalContentText, FormAddNote.Time);

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                string filePath = (Application.StartupPath + "\\Notes.xlsx");

                FileInfo file = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    // Получаем лист, с которым будем работать
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // Определяем индекс следующей доступной строки для записи данных
                    int lastRow=1;

                    if (worksheet.Dimension != null && worksheet.Dimension.End.Row != 0)
                        lastRow = worksheet.Dimension.End.Row+1;

                    if (NumOfNullRow != 0)
                    {
                        lastRow = NumOfNullRow;
                        NumOfNullRow = 0;
                    }

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
            RefreshPanelScroll();
        }

        private void FormNotes_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        public static int NumOfNullRow=0;

        void RefreshPanelScroll()
        {
            PanelScroll.Controls.Clear();
            // Open Excel File
            FileStream stream = File.Open(Application.StartupPath + "\\Notes.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader;
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();

            // Select 1 table from excel pages
            DataTable dt = result.Tables[0];

            // Close and clear memory
            excelReader.Close();

            int Count=0;
            // Не заполняется panel, если есть пустые поля
            // Если в таблице excel в дате указано "Все форматы", тогда считывает последнюю строку с этим форматом и записывает в последнюю строку со значениями => ОШИБКА
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    string Title = dt.Rows[i][0].ToString();
                    string Content = dt.Rows[i][1].ToString();

                    string dateString = dt.Rows[i][2].ToString();
                    DateTime date;
                    try
                    {
                        try { date = DateTime.ParseExact(dateString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); }
                        catch { date = DateTime.ParseExact(dateString, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture); }
                    } catch {  date = DateTime.ParseExact(dateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); }
                    string Time = date.Day.ToString() + " " + date.ToString("MMMM") + " " + date.ToString("HH:mm");
                    Note(Title, Content, Time);

                    // т.к. переменные статичные, нужно очищать их при каждом обращении к форме
                    Title = null; Content = null; Time = null;
                }
                catch { Count++;

                    if (Count != 2)
                    {
                        NumOfNullRow = i + 1;
                    }
 }
            }
            Misses = 0;
            PanelScroll.AutoScrollPosition = new Point(0, 0);
        }


        private void FormNotes_Load(object sender, EventArgs e)
        {
            RefreshPanelScroll();
            
            if (FormMain.LanguageState==1)
            {
                CMenuNotes.Items[0].Text = "Добавить заметку";
            }
        }
    }
}
