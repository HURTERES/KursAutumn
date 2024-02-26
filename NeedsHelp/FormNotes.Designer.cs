namespace NeedsHelp
{
    partial class FormNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.PanelDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelData = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblInformation = new System.Windows.Forms.Label();
            this.DgvEvents = new System.Windows.Forms.DataGridView();
            this.IdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CMenuNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDown.SuspendLayout();
            this.PanelData.SuspendLayout();
            this.PanelScroll.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.CMenuNotes.SuspendLayout();
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
            this.PanelDown.TabIndex = 35;
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
            this.PanelScroll.Controls.Add(this.guna2ShadowPanel1);
            this.PanelScroll.Location = new System.Drawing.Point(5, 5);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(840, 463);
            this.PanelScroll.TabIndex = 1;
            this.PanelScroll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelScroll_MouseClick);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel2);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(22, 21);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(250, 200);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(18, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 0;
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
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.PanelData;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // CMenuNotes
            // 
            this.CMenuNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNote});
            this.CMenuNotes.Name = "CMenuEdit";
            this.CMenuNotes.Size = new System.Drawing.Size(124, 26);
            // 
            // AddNote
            // 
            this.AddNote.Image = global::NeedsHelp.Properties.Resources.EditPen;
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(123, 22);
            this.AddNote.Text = "Add note";
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 528);
            this.Controls.Add(this.PanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotes";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNotes_MouseDown);
            this.PanelDown.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            this.PanelScroll.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.CMenuNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelDown;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel PanelData;
        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.Label LblInformation;
        public System.Windows.Forms.DataGridView DgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.ContextMenuStrip CMenuNotes;
        private System.Windows.Forms.ToolStripMenuItem AddNote;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}