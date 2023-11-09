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
            this.LblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Location = new System.Drawing.Point(4, 4);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(35, 13);
            this.LblDay.TabIndex = 0;
            this.LblDay.Text = "label1";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(105, 79);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDay;
    }
}
