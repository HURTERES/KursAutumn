namespace NeedsHelp
{
    partial class FormUserManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManual));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelData = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblManual = new System.Windows.Forms.Label();
            this.LblInformation = new System.Windows.Forms.Label();
            this.DgvEvents = new System.Windows.Forms.DataGridView();
            this.IdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.PanelDown.SuspendLayout();
            this.PanelData.SuspendLayout();
            this.PanelScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDown
            // 
            this.PanelDown.BackColor = System.Drawing.Color.Transparent;
            this.PanelDown.BorderColor = System.Drawing.Color.Gray;
            this.PanelDown.BorderThickness = 1;
            this.PanelDown.Controls.Add(this.guna2Panel3);
            this.PanelDown.Controls.Add(this.PanelData);
            this.PanelDown.Controls.Add(this.guna2Panel1);
            this.PanelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDown.Location = new System.Drawing.Point(0, 0);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(876, 528);
            this.PanelDown.TabIndex = 34;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 516);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(876, 12);
            this.guna2Panel3.TabIndex = 81;
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.White;
            this.PanelData.BorderColor = System.Drawing.Color.Transparent;
            this.PanelData.Controls.Add(this.PanelScroll);
            this.PanelData.Controls.Add(this.LblInformation);
            this.PanelData.Controls.Add(this.DgvEvents);
            this.PanelData.Location = new System.Drawing.Point(12, 36);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(852, 474);
            this.PanelData.TabIndex = 80;
            // 
            // PanelScroll
            // 
            this.PanelScroll.AutoScroll = true;
            this.PanelScroll.Controls.Add(this.label3);
            this.PanelScroll.Controls.Add(this.label2);
            this.PanelScroll.Controls.Add(this.label1);
            this.PanelScroll.Controls.Add(this.LblManual);
            this.PanelScroll.Location = new System.Drawing.Point(5, 5);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(840, 463);
            this.PanelScroll.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 175);
            this.label3.TabIndex = 31;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 175);
            this.label2.TabIndex = 30;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Добро пожаловать в руководство по использованию приложения!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblManual
            // 
            this.LblManual.AutoSize = true;
            this.LblManual.BackColor = System.Drawing.Color.White;
            this.LblManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblManual.Location = new System.Drawing.Point(94, 14);
            this.LblManual.Name = "LblManual";
            this.LblManual.Size = new System.Drawing.Size(609, 50);
            this.LblManual.TabIndex = 28;
            this.LblManual.Text = "Руководство пользователя\r\n для системного приложения \"Календарь-органайзер\".";
            this.LblManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInformation
            // 
            this.LblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInformation.Location = new System.Drawing.Point(689, 543);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(140, 100);
            this.LblInformation.TabIndex = 38;
            this.LblInformation.Text = "No upcoming events";
            this.LblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblInformation.Visible = false;
            // 
            // DgvEvents
            // 
            this.DgvEvents.AllowUserToAddRows = false;
            this.DgvEvents.AllowUserToDeleteRows = false;
            this.DgvEvents.AllowUserToResizeColumns = false;
            this.DgvEvents.AllowUserToResizeRows = false;
            this.DgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.DgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEvents.ColumnHeadersHeight = 30;
            this.DgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEvent});
            this.DgvEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEvents.EnableHeadersVisualStyles = false;
            this.DgvEvents.GridColor = System.Drawing.Color.White;
            this.DgvEvents.Location = new System.Drawing.Point(3, 3);
            this.DgvEvents.MultiSelect = false;
            this.DgvEvents.Name = "DgvEvents";
            this.DgvEvents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEvents.RowHeadersVisible = false;
            this.DgvEvents.RowTemplate.Height = 35;
            this.DgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEvents.Size = new System.Drawing.Size(770, 390);
            this.DgvEvents.TabIndex = 37;
            // 
            // IdEvent
            // 
            this.IdEvent.DataPropertyName = "IdEvent";
            this.IdEvent.HeaderText = "IdEvent";
            this.IdEvent.Name = "IdEvent";
            this.IdEvent.ReadOnly = true;
            this.IdEvent.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.BtnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(876, 30);
            this.guna2Panel1.TabIndex = 79;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Animated = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.BorderRadius = 8;
            this.BtnClose.BorderThickness = 1;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(804, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.Gray;
            this.BtnClose.ShadowDecoration.BorderRadius = 30;
            this.BtnClose.Size = new System.Drawing.Size(66, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "✖";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormUserManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 528);
            this.Controls.Add(this.PanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserManual";
            this.PanelDown.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            this.PanelScroll.ResumeLayout(false);
            this.PanelScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelDown;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel PanelData;
        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblManual;
        private System.Windows.Forms.Label LblInformation;
        public System.Windows.Forms.DataGridView DgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}