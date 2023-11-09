using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using Guna.UI2.WinForms;

namespace NeedsHelp
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
            InitializeGUNA();
        }


        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        void InitializeGUNA()
        {
            guna2Elipse1 = new Guna2Elipse();
            guna2Elipse1.BorderRadius = 16; // Радиус скругления углов
            guna2Elipse1.TargetControl = this;
        }



        int currentImageIndex = 0;
        string[] imageResourceNames = { "one", "two", "three", "four", "five", "six" };
        //Timer Pause;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void FormLoad_Shown(object sender, EventArgs e)
        {
            TimerLoad.Start();
            TimerFon.Start();
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex >= imageResourceNames.Length)
                currentImageIndex = 0; // Возврат к первому изображению

            // Загружаю изображение из ресурсов
            string resourceName = imageResourceNames[currentImageIndex];
            PbxTicks.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
            currentImageIndex++;
            // ------------------
        }


        private void TimerFon_Tick(object sender, EventArgs e)
        {
            TimerFon.Stop();
            TimerLoad.Stop();
            FormMain Frm = new FormMain();
            this.Hide();
            Frm.ShowDialog();
            this.Close();
            //Show2SloiAnimated.Show(TbxLogin); для показа анимации))
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
