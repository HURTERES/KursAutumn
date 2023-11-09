namespace NeedsHelp
{
    partial class FormLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoad));
            this.TimerFon = new System.Windows.Forms.Timer(this.components);
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnHide = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.Show2SloiAnimated = new Guna.UI2.WinForms.Guna2Transition();
            this.PbxTicks = new System.Windows.Forms.PictureBox();
            this.PbxFon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.GunaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFon)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerFon
            // 
            this.TimerFon.Interval = 2200;
            this.TimerFon.Tick += new System.EventHandler(this.TimerFon_Tick);
            // 
            // TimerLoad
            // 
            this.TimerLoad.Interval = 900;
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel5;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel5.Controls.Add(this.BtnHide);
            this.guna2Panel5.Controls.Add(this.BtnCloseForm);
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Location = new System.Drawing.Point(10, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(941, 30);
            this.guna2Panel5.TabIndex = 10;
            // 
            // BtnHide
            // 
            this.BtnHide.Animated = true;
            this.BtnHide.BackColor = System.Drawing.Color.Transparent;
            this.BtnHide.BorderColor = System.Drawing.Color.White;
            this.BtnHide.BorderRadius = 8;
            this.BtnHide.BorderThickness = 1;
            this.Show2SloiAnimated.SetDecoration(this.BtnHide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHide.FillColor = System.Drawing.Color.White;
            this.BtnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHide.ForeColor = System.Drawing.Color.Black;
            this.BtnHide.Location = new System.Drawing.Point(803, 0);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.PressedColor = System.Drawing.Color.Gray;
            this.BtnHide.ShadowDecoration.BorderRadius = 30;
            this.BtnHide.Size = new System.Drawing.Size(66, 27);
            this.BtnHide.TabIndex = 1;
            this.BtnHide.Text = "-";
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Animated = true;
            this.BtnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnCloseForm.BorderColor = System.Drawing.Color.White;
            this.BtnCloseForm.BorderRadius = 8;
            this.BtnCloseForm.BorderThickness = 1;
            this.Show2SloiAnimated.SetDecoration(this.BtnCloseForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnCloseForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCloseForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCloseForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCloseForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCloseForm.FillColor = System.Drawing.Color.White;
            this.BtnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.BtnCloseForm.Location = new System.Drawing.Point(875, 0);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.PressedColor = System.Drawing.Color.Gray;
            this.BtnCloseForm.ShadowDecoration.BorderRadius = 30;
            this.BtnCloseForm.Size = new System.Drawing.Size(66, 27);
            this.BtnCloseForm.TabIndex = 0;
            this.BtnCloseForm.Text = "X";
            this.BtnCloseForm.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(951, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(10, 570);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.Controls.Add(this.guna2Panel2);
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 560);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(951, 10);
            this.guna2Panel3.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(941, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(10, 10);
            this.guna2Panel2.TabIndex = 7;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel4.Controls.Add(this.GunaPanel);
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(10, 560);
            this.guna2Panel4.TabIndex = 9;
            // 
            // GunaPanel
            // 
            this.GunaPanel.BackColor = System.Drawing.Color.Gray;
            this.GunaPanel.BorderColor = System.Drawing.Color.Gray;
            this.GunaPanel.Controls.Add(this.BtnClose);
            this.Show2SloiAnimated.SetDecoration(this.GunaPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GunaPanel.FillColor = System.Drawing.Color.Transparent;
            this.GunaPanel.Location = new System.Drawing.Point(0, 0);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(10, 30);
            this.GunaPanel.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Animated = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BorderColor = System.Drawing.Color.Gray;
            this.BtnClose.BorderThickness = 3;
            this.Show2SloiAnimated.SetDecoration(this.BtnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(947, -2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.Gray;
            this.BtnClose.ShadowDecoration.BorderRadius = 30;
            this.BtnClose.Size = new System.Drawing.Size(48, 25);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            // 
            // Show2SloiAnimated
            // 
            this.Show2SloiAnimated.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.Show2SloiAnimated.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Show2SloiAnimated.DefaultAnimation = animation2;
            this.Show2SloiAnimated.Interval = 30;
            this.Show2SloiAnimated.MaxAnimationTime = 1000;
            this.Show2SloiAnimated.TimeStep = 0.05F;
            // 
            // PbxTicks
            // 
            this.PbxTicks.BackColor = System.Drawing.Color.Transparent;
            this.Show2SloiAnimated.SetDecoration(this.PbxTicks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PbxTicks.Image = global::NeedsHelp.Properties.Resources.full;
            this.PbxTicks.Location = new System.Drawing.Point(252, 239);
            this.PbxTicks.Name = "PbxTicks";
            this.PbxTicks.Size = new System.Drawing.Size(98, 98);
            this.PbxTicks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxTicks.TabIndex = 5;
            this.PbxTicks.TabStop = false;
            // 
            // PbxFon
            // 
            this.PbxFon.BackColor = System.Drawing.Color.Transparent;
            this.Show2SloiAnimated.SetDecoration(this.PbxFon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PbxFon.Image = global::NeedsHelp.Properties.Resources.Fon;
            this.PbxFon.ImageRotate = 0F;
            this.PbxFon.Location = new System.Drawing.Point(10, 33);
            this.PbxFon.Name = "PbxFon";
            this.PbxFon.Size = new System.Drawing.Size(942, 524);
            this.PbxFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxFon.TabIndex = 4;
            this.PbxFon.TabStop = false;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 570);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PbxTicks);
            this.Controls.Add(this.PbxFon);
            this.Show2SloiAnimated.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormLoad_Shown);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.GunaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxTicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerFon;
        public System.Windows.Forms.Timer TimerLoad;
        private Guna.UI2.WinForms.Guna2PictureBox PbxFon;
        public System.Windows.Forms.PictureBox PbxTicks;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button BtnCloseForm;
        private Guna.UI2.WinForms.Guna2Button BtnHide;
        private Guna.UI2.WinForms.Guna2Transition Show2SloiAnimated;
    }
}

