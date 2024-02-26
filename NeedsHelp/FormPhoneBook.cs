using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace NeedsHelp
{
    public partial class FormPhoneBook : Form
    {
        public FormPhoneBook()
        {
            InitializeComponent();
        }

        private void PanelScroll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPhoneBook_Load(object sender, EventArgs e)
        {
            PanelScroll.AutoScroll = false;
            PanelScroll.HorizontalScroll.Enabled = false;
            PanelScroll.VerticalScroll.Enabled =true;
            PanelScroll.HorizontalScroll.Maximum = 0;
            PanelScroll.VerticalScroll.Maximum = 0;
            PanelScroll.AutoScroll = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblName_MouseEnter(object sender, EventArgs e)
        {
            if(LblName.Text.Length>20)
            ShowNamePopup.SetToolTip(LblName, $"{LblName.Text}");
        }

        private void LblContent_MouseEnter(object sender, EventArgs e)
        {
            if (LblContent.Text.Length > 50)
                ShowNamePopup.SetToolTip(LblContent, $"{LblContent.Text}");
        }
    }
}
