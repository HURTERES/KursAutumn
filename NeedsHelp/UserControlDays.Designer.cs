namespace NeedsHelp
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnDay
            // 
            this.BtnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDay.FillColor = System.Drawing.Color.White;
            this.BtnDay.Font = new System.Drawing.Font("Arial", 7F);
            this.BtnDay.ForeColor = System.Drawing.Color.Black;
            this.BtnDay.Location = new System.Drawing.Point(-1, -1);
            this.BtnDay.Name = "BtnDay";
            this.BtnDay.Size = new System.Drawing.Size(40, 40);
            this.BtnDay.TabIndex = 0;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(38, 38);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button BtnDay;
    }
}
