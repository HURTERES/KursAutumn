namespace NeedsHelp
{
    partial class FormEndedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndedList));
            this.PanelDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelData = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelMoreInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.DelEvent = new System.Windows.Forms.Button();
            this.TbxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.Tbxname = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblInform = new System.Windows.Forms.Label();
            this.LblInformation = new System.Windows.Forms.Label();
            this.DgvEvents = new System.Windows.Forms.DataGridView();
            this.IdEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsDate = new System.Windows.Forms.BindingSource(this.components);
            this.dBKurs23DataSet = new NeedsHelp.DBKurs23DataSet();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eventsTableAdapter = new NeedsHelp.DBKurs23DataSetTableAdapters.EventsTableAdapter();
            this.CMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelDown.SuspendLayout();
            this.PanelData.SuspendLayout();
            this.PanelMoreInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKurs23DataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.CMenuStrip.SuspendLayout();
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
            this.PanelDown.Size = new System.Drawing.Size(800, 450);
            this.PanelDown.TabIndex = 32;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 438);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(800, 12);
            this.guna2Panel3.TabIndex = 81;
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.White;
            this.PanelData.BorderColor = System.Drawing.Color.Transparent;
            this.PanelData.Controls.Add(this.PanelMoreInformation);
            this.PanelData.Controls.Add(this.LblInform);
            this.PanelData.Controls.Add(this.LblInformation);
            this.PanelData.Controls.Add(this.DgvEvents);
            this.PanelData.Location = new System.Drawing.Point(12, 36);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(776, 396);
            this.PanelData.TabIndex = 80;
            // 
            // PanelMoreInformation
            // 
            this.PanelMoreInformation.BackColor = System.Drawing.Color.White;
            this.PanelMoreInformation.BorderColor = System.Drawing.Color.Transparent;
            this.PanelMoreInformation.Controls.Add(this.guna2Panel6);
            this.PanelMoreInformation.Controls.Add(this.guna2Panel5);
            this.PanelMoreInformation.Controls.Add(this.guna2Panel4);
            this.PanelMoreInformation.Controls.Add(this.guna2Panel2);
            this.PanelMoreInformation.Controls.Add(this.LblDesc);
            this.PanelMoreInformation.Controls.Add(this.LblTitle);
            this.PanelMoreInformation.Controls.Add(this.BtnReturn);
            this.PanelMoreInformation.Controls.Add(this.DelEvent);
            this.PanelMoreInformation.Controls.Add(this.TbxDesc);
            this.PanelMoreInformation.Controls.Add(this.Tbxname);
            this.PanelMoreInformation.Location = new System.Drawing.Point(3, 3);
            this.PanelMoreInformation.Name = "PanelMoreInformation";
            this.PanelMoreInformation.Size = new System.Drawing.Size(770, 390);
            this.PanelMoreInformation.TabIndex = 40;
            this.PanelMoreInformation.Visible = false;
            this.PanelMoreInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMoreInformation_Paint);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Black;
            this.guna2Panel6.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel6.BorderRadius = 2;
            this.guna2Panel6.Location = new System.Drawing.Point(580, 17);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(154, 2);
            this.guna2Panel6.TabIndex = 84;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Black;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel5.BorderRadius = 2;
            this.guna2Panel5.Location = new System.Drawing.Point(28, 369);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(180, 2);
            this.guna2Panel5.TabIndex = 83;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 2;
            this.guna2Panel4.Location = new System.Drawing.Point(732, 17);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(2, 46);
            this.guna2Panel4.TabIndex = 82;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(28, 334);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(2, 36);
            this.guna2Panel2.TabIndex = 81;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDesc.Location = new System.Drawing.Point(46, 97);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(93, 20);
            this.LblDesc.TabIndex = 80;
            this.LblDesc.Text = "Desctiption:";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(311, 43);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(42, 20);
            this.LblTitle.TabIndex = 79;
            this.LblTitle.Text = "Title:";
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Gray;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(28, 36);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReturn.Size = new System.Drawing.Size(87, 33);
            this.BtnReturn.TabIndex = 78;
            this.BtnReturn.Text = "◀ Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelEvent
            // 
            this.DelEvent.BackColor = System.Drawing.Color.Gray;
            this.DelEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelEvent.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelEvent.ForeColor = System.Drawing.Color.White;
            this.DelEvent.Location = new System.Drawing.Point(449, 337);
            this.DelEvent.Name = "DelEvent";
            this.DelEvent.Size = new System.Drawing.Size(237, 33);
            this.DelEvent.TabIndex = 77;
            this.DelEvent.Text = "Hide ended";
            this.DelEvent.UseVisualStyleBackColor = false;
            this.DelEvent.Click += new System.EventHandler(this.DelEvent_Click);
            // 
            // TbxDesc
            // 
            this.TbxDesc.BorderColor = System.Drawing.Color.Black;
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
            this.TbxDesc.Location = new System.Drawing.Point(146, 87);
            this.TbxDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbxDesc.Multiline = true;
            this.TbxDesc.Name = "TbxDesc";
            this.TbxDesc.PasswordChar = '\0';
            this.TbxDesc.PlaceholderText = "";
            this.TbxDesc.ReadOnly = true;
            this.TbxDesc.SelectedText = "";
            this.TbxDesc.Size = new System.Drawing.Size(477, 232);
            this.TbxDesc.TabIndex = 46;
            // 
            // Tbxname
            // 
            this.Tbxname.BorderColor = System.Drawing.Color.Black;
            this.Tbxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tbxname.DefaultText = "";
            this.Tbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbxname.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.Tbxname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Tbxname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tbxname.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.Tbxname.Location = new System.Drawing.Point(364, 36);
            this.Tbxname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbxname.MaxLength = 30;
            this.Tbxname.Name = "Tbxname";
            this.Tbxname.PasswordChar = '\0';
            this.Tbxname.PlaceholderForeColor = System.Drawing.Color.White;
            this.Tbxname.PlaceholderText = "";
            this.Tbxname.ReadOnly = true;
            this.Tbxname.SelectedText = "";
            this.Tbxname.Size = new System.Drawing.Size(322, 33);
            this.Tbxname.TabIndex = 44;
            // 
            // LblInform
            // 
            this.LblInform.BackColor = System.Drawing.Color.Transparent;
            this.LblInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInform.Location = new System.Drawing.Point(633, 293);
            this.LblInform.Name = "LblInform";
            this.LblInform.Size = new System.Drawing.Size(140, 100);
            this.LblInform.TabIndex = 39;
            this.LblInform.Text = "No ended events";
            this.LblInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblInform.Visible = false;
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
            this.DgvEvents.AutoGenerateColumns = false;
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
            this.IdEvent,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.beginDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.DgvEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvEvents.DataSource = this.BsDate;
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
            this.DgvEvents.Leave += new System.EventHandler(this.DgvEvents_Leave);
            this.DgvEvents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvEvents_MouseClick);
            // 
            // IdEvent
            // 
            this.IdEvent.DataPropertyName = "IdEvent";
            this.IdEvent.HeaderText = "IdEvent";
            this.IdEvent.Name = "IdEvent";
            this.IdEvent.ReadOnly = true;
            this.IdEvent.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 238;
            // 
            // beginDateDataGridViewTextBoxColumn
            // 
            this.beginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.Name = "beginDateDataGridViewTextBoxColumn";
            this.beginDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginDateDataGridViewTextBoxColumn.Width = 190;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 190;
            // 
            // BsDate
            // 
            this.BsDate.DataMember = "Events";
            this.BsDate.DataSource = this.dBKurs23DataSet;
            this.BsDate.Filter = "State = \'Завершенное\'";
            this.BsDate.CurrentChanged += new System.EventHandler(this.BsDate_CurrentChanged);
            // 
            // dBKurs23DataSet
            // 
            this.dBKurs23DataSet.DataSetName = "DBKurs23DataSet";
            this.dBKurs23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.guna2Panel1.Size = new System.Drawing.Size(800, 30);
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
            this.BtnClose.Location = new System.Drawing.Point(728, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.Gray;
            this.BtnClose.ShadowDecoration.BorderRadius = 30;
            this.BtnClose.Size = new System.Drawing.Size(66, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "✖";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.PanelData;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // CMenuStrip
            // 
            this.CMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CMenuStrip.Name = "CMenuStrip";
            this.CMenuStrip.Size = new System.Drawing.Size(169, 26);
            this.CMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "More information";
            // 
            // FormEndedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEndedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEndedList";
            this.Load += new System.EventHandler(this.FormEndedList_Load);
            this.Shown += new System.EventHandler(this.FormEndedList_Shown);
            this.PanelDown.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            this.PanelMoreInformation.ResumeLayout(false);
            this.PanelMoreInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKurs23DataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.CMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelDown;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Panel PanelData;
        private System.Windows.Forms.Label LblInformation;
        public System.Windows.Forms.DataGridView DgvEvents;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.BindingSource BsDate;
        private DBKurs23DataSet dBKurs23DataSet;
        private DBKurs23DataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblInform;
        private Guna.UI2.WinForms.Guna2Panel PanelMoreInformation;
        public Guna.UI2.WinForms.Guna2TextBox TbxDesc;
        public Guna.UI2.WinForms.Guna2TextBox Tbxname;
        public System.Windows.Forms.Button DelEvent;
        private System.Windows.Forms.ContextMenuStrip CMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Button BtnReturn;
        public System.Windows.Forms.Label LblDesc;
        public System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
    }
}