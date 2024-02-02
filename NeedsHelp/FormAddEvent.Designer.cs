namespace NeedsHelp
{
    partial class FormAddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEvent));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelDown = new Guna.UI2.WinForms.Guna2Panel();
            this.CbxDaily = new System.Windows.Forms.CheckBox();
            this.Check = new System.Windows.Forms.Label();
            this.DelEvent = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.LblLength = new System.Windows.Forms.Label();
            this.BtnAddEvent = new System.Windows.Forms.Button();
            this.CbxFullDay = new System.Windows.Forms.CheckBox();
            this.CmbTimeEnd = new System.Windows.Forms.ComboBox();
            this.TbxEndHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbTimeBegin = new System.Windows.Forms.ComboBox();
            this.TbxBeginHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbxname = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьСобытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindSymbols = new System.Windows.Forms.Timer(this.components);
            this.PanelDown.SuspendLayout();
            this.CMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PanelDown
            // 
            this.PanelDown.BackColor = System.Drawing.Color.Transparent;
            this.PanelDown.BorderColor = System.Drawing.Color.Gray;
            this.PanelDown.BorderThickness = 1;
            this.PanelDown.Controls.Add(this.CbxDaily);
            this.PanelDown.Controls.Add(this.Check);
            this.PanelDown.Controls.Add(this.DelEvent);
            this.PanelDown.Controls.Add(this.LblId);
            this.PanelDown.Controls.Add(this.LblLength);
            this.PanelDown.Controls.Add(this.BtnAddEvent);
            this.PanelDown.Controls.Add(this.CbxFullDay);
            this.PanelDown.Controls.Add(this.CmbTimeEnd);
            this.PanelDown.Controls.Add(this.TbxEndHour);
            this.PanelDown.Controls.Add(this.CmbTimeBegin);
            this.PanelDown.Controls.Add(this.TbxBeginHour);
            this.PanelDown.Controls.Add(this.label5);
            this.PanelDown.Controls.Add(this.label4);
            this.PanelDown.Controls.Add(this.label3);
            this.PanelDown.Controls.Add(this.panel2);
            this.PanelDown.Controls.Add(this.TbxDesc);
            this.PanelDown.Controls.Add(this.label2);
            this.PanelDown.Controls.Add(this.Tbxname);
            this.PanelDown.Controls.Add(this.panel1);
            this.PanelDown.Controls.Add(this.LblDate);
            this.PanelDown.Controls.Add(this.label1);
            this.PanelDown.Location = new System.Drawing.Point(0, 0);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(623, 397);
            this.PanelDown.TabIndex = 31;
            // 
            // CbxDaily
            // 
            this.CbxDaily.AutoSize = true;
            this.CbxDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxDaily.Location = new System.Drawing.Point(540, 330);
            this.CbxDaily.Name = "CbxDaily";
            this.CbxDaily.Size = new System.Drawing.Size(59, 22);
            this.CbxDaily.TabIndex = 78;
            this.CbxDaily.Text = "Daily";
            this.CbxDaily.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(269, 11);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(38, 13);
            this.Check.TabIndex = 77;
            this.Check.Text = "Check";
            this.Check.Visible = false;
            // 
            // DelEvent
            // 
            this.DelEvent.BackColor = System.Drawing.Color.Brown;
            this.DelEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelEvent.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelEvent.ForeColor = System.Drawing.Color.White;
            this.DelEvent.Location = new System.Drawing.Point(27, 358);
            this.DelEvent.Name = "DelEvent";
            this.DelEvent.Size = new System.Drawing.Size(185, 28);
            this.DelEvent.TabIndex = 76;
            this.DelEvent.Text = "Delete Event";
            this.DelEvent.UseVisualStyleBackColor = false;
            this.DelEvent.Visible = false;
            this.DelEvent.Click += new System.EventHandler(this.DelEvent_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(347, 13);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 13);
            this.LblId.TabIndex = 75;
            this.LblId.Text = "NULL";
            this.LblId.Visible = false;
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLength.Location = new System.Drawing.Point(23, 281);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(69, 20);
            this.LblLength.TabIndex = 74;
            this.LblLength.Text = "Symbols";
            // 
            // BtnAddEvent
            // 
            this.BtnAddEvent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEvent.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddEvent.ForeColor = System.Drawing.Color.White;
            this.BtnAddEvent.Location = new System.Drawing.Point(414, 358);
            this.BtnAddEvent.Name = "BtnAddEvent";
            this.BtnAddEvent.Size = new System.Drawing.Size(185, 28);
            this.BtnAddEvent.TabIndex = 73;
            this.BtnAddEvent.Text = "Create Event";
            this.BtnAddEvent.UseVisualStyleBackColor = false;
            this.BtnAddEvent.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CbxFullDay
            // 
            this.CbxFullDay.AutoSize = true;
            this.CbxFullDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxFullDay.Location = new System.Drawing.Point(414, 330);
            this.CbxFullDay.Name = "CbxFullDay";
            this.CbxFullDay.Size = new System.Drawing.Size(121, 22);
            this.CbxFullDay.TabIndex = 53;
            this.CbxFullDay.Text = "Full Day Event";
            this.CbxFullDay.UseVisualStyleBackColor = true;
            this.CbxFullDay.CheckedChanged += new System.EventHandler(this.CbxFullDay_CheckedChanged);
            // 
            // CmbTimeEnd
            // 
            this.CmbTimeEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbTimeEnd.FormattingEnabled = true;
            this.CmbTimeEnd.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.CmbTimeEnd.Location = new System.Drawing.Point(350, 328);
            this.CmbTimeEnd.Name = "CmbTimeEnd";
            this.CmbTimeEnd.Size = new System.Drawing.Size(52, 26);
            this.CmbTimeEnd.TabIndex = 52;
            // 
            // TbxEndHour
            // 
            this.TbxEndHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxEndHour.DefaultText = "12";
            this.TbxEndHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxEndHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxEndHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEndHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEndHour.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TbxEndHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxEndHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbxEndHour.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.TbxEndHour.Location = new System.Drawing.Point(308, 328);
            this.TbxEndHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbxEndHour.MaxLength = 36;
            this.TbxEndHour.Name = "TbxEndHour";
            this.TbxEndHour.PasswordChar = '\0';
            this.TbxEndHour.PlaceholderText = "";
            this.TbxEndHour.SelectedText = "";
            this.TbxEndHour.Size = new System.Drawing.Size(35, 26);
            this.TbxEndHour.TabIndex = 51;
            this.TbxEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxEndHour.TextChanged += new System.EventHandler(this.TbxEndHour_TextChanged);
            this.TbxEndHour.Click += new System.EventHandler(this.TbxEndHour_Click);
            this.TbxEndHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBeginHour_KeyPress);
            this.TbxEndHour.Leave += new System.EventHandler(this.TbxEndHour_Leave);
            // 
            // CmbTimeBegin
            // 
            this.CmbTimeBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTimeBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbTimeBegin.FormattingEnabled = true;
            this.CmbTimeBegin.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.CmbTimeBegin.Location = new System.Drawing.Point(159, 328);
            this.CmbTimeBegin.Name = "CmbTimeBegin";
            this.CmbTimeBegin.Size = new System.Drawing.Size(52, 26);
            this.CmbTimeBegin.TabIndex = 50;
            // 
            // TbxBeginHour
            // 
            this.TbxBeginHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxBeginHour.DefaultText = "12";
            this.TbxBeginHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxBeginHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxBeginHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxBeginHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxBeginHour.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TbxBeginHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxBeginHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbxBeginHour.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.TbxBeginHour.Location = new System.Drawing.Point(117, 328);
            this.TbxBeginHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbxBeginHour.MaxLength = 36;
            this.TbxBeginHour.Name = "TbxBeginHour";
            this.TbxBeginHour.PasswordChar = '\0';
            this.TbxBeginHour.PlaceholderText = "";
            this.TbxBeginHour.SelectedText = "";
            this.TbxBeginHour.Size = new System.Drawing.Size(35, 26);
            this.TbxBeginHour.TabIndex = 49;
            this.TbxBeginHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxBeginHour.TextChanged += new System.EventHandler(this.TbxBeginHour_TextChanged);
            this.TbxBeginHour.Click += new System.EventHandler(this.TbxBeginHour_Click_1);
            this.TbxBeginHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBeginHour_KeyPress);
            this.TbxBeginHour.Leave += new System.EventHandler(this.TbxBeginHour_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(581, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "✖";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Begin Date: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 2);
            this.panel2.TabIndex = 43;
            // 
            // TbxDesc
            // 
            this.TbxDesc.BorderColor = System.Drawing.Color.White;
            this.TbxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDesc.DefaultText = "";
            this.TbxDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDesc.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TbxDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbxDesc.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.TbxDesc.Location = new System.Drawing.Point(122, 79);
            this.TbxDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbxDesc.Multiline = true;
            this.TbxDesc.Name = "TbxDesc";
            this.TbxDesc.PasswordChar = '\0';
            this.TbxDesc.PlaceholderText = "";
            this.TbxDesc.SelectedText = "";
            this.TbxDesc.Size = new System.Drawing.Size(477, 232);
            this.TbxDesc.TabIndex = 42;
            this.TbxDesc.Click += new System.EventHandler(this.TbxDesc_Click);
            this.TbxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxDesc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description: ";
            // 
            // Tbxname
            // 
            this.Tbxname.BorderColor = System.Drawing.Color.White;
            this.Tbxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tbxname.DefaultText = "";
            this.Tbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbxname.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.Tbxname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tbxname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tbxname.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.Tbxname.Location = new System.Drawing.Point(122, 41);
            this.Tbxname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbxname.MaxLength = 30;
            this.Tbxname.Name = "Tbxname";
            this.Tbxname.PasswordChar = '\0';
            this.Tbxname.PlaceholderText = "";
            this.Tbxname.SelectedText = "";
            this.Tbxname.Size = new System.Drawing.Size(322, 33);
            this.Tbxname.TabIndex = 40;
            this.Tbxname.Click += new System.EventHandler(this.Tbxname_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 2);
            this.panel1.TabIndex = 39;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDate.Location = new System.Drawing.Point(23, 9);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(41, 20);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event title: ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelDown;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // CMenuStrip
            // 
            this.CMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСобытиеToolStripMenuItem});
            this.CMenuStrip.Name = "CMenuStrip";
            this.CMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMenuStrip.Size = new System.Drawing.Size(205, 26);
            // 
            // добавитьСобытиеToolStripMenuItem
            // 
            this.добавитьСобытиеToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.добавитьСобытиеToolStripMenuItem.Enabled = false;
            this.добавитьСобытиеToolStripMenuItem.Name = "добавитьСобытиеToolStripMenuItem";
            this.добавитьСобытиеToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавитьСобытиеToolStripMenuItem.Text = "Не все поля заполнены";
            this.добавитьСобытиеToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FindSymbols
            // 
            this.FindSymbols.Tick += new System.EventHandler(this.FindSymbols_Tick);
            // 
            // FormAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 398);
            this.Controls.Add(this.PanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEvent_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEvent_Load);
            this.Shown += new System.EventHandler(this.FormAddEvent_Shown);
            this.PanelDown.ResumeLayout(false);
            this.PanelDown.PerformLayout();
            this.CMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelDown;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LblDate;
        public System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.ContextMenuStrip CMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьСобытиеToolStripMenuItem;
        public Guna.UI2.WinForms.Guna2TextBox Tbxname;
        public Guna.UI2.WinForms.Guna2TextBox TbxBeginHour;
        public Guna.UI2.WinForms.Guna2TextBox TbxEndHour;
        public Guna.UI2.WinForms.Guna2TextBox TbxDesc;
        public System.Windows.Forms.Label LblId;
        public System.Windows.Forms.ComboBox CmbTimeBegin;
        public System.Windows.Forms.ComboBox CmbTimeEnd;
        public System.Windows.Forms.Button DelEvent;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox CbxFullDay;
        public System.Windows.Forms.Button BtnAddEvent;
        public System.Windows.Forms.Label Check;
        private System.Windows.Forms.NotifyIcon notifier;
        public System.Windows.Forms.CheckBox CbxDaily;
        private System.Windows.Forms.Timer FindSymbols;
    }
}