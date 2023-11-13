namespace NeedsHelp
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MiddleContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.PanelData = new Guna.UI2.WinForms.Guna2Panel();
            this.LblInformation = new System.Windows.Forms.Label();
            this.DgvEvents = new System.Windows.Forms.DataGridView();
            this.PanelDown = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LblYearMonth = new System.Windows.Forms.Label();
            this.DaysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnHide = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Show2SloiAnimated = new Guna.UI2.WinForms.Guna2Transition();
            this.CMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьСобытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dBKurs23DataSet = new NeedsHelp.DBKurs23DataSet();
            this.BsDate = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new NeedsHelp.DBKurs23DataSetTableAdapters.EventsTableAdapter();
            this.tableAdapterManager = new NeedsHelp.DBKurs23DataSetTableAdapters.TableAdapterManager();
            this.idEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleContainer.SuspendLayout();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).BeginInit();
            this.PanelCalendar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.CMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBKurs23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsDate)).BeginInit();
            this.SuspendLayout();
            // 
            // MiddleContainer
            // 
            this.MiddleContainer.BorderColor = System.Drawing.Color.Gray;
            this.MiddleContainer.BorderThickness = 1;
            this.MiddleContainer.Controls.Add(this.PanelData);
            this.MiddleContainer.Controls.Add(this.PanelDown);
            this.MiddleContainer.Controls.Add(this.PanelCalendar);
            this.MiddleContainer.Controls.Add(this.guna2Panel3);
            this.MiddleContainer.Controls.Add(this.guna2Panel1);
            this.Show2SloiAnimated.SetDecoration(this.MiddleContainer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MiddleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleContainer.FillColor = System.Drawing.Color.Gainsboro;
            this.MiddleContainer.Location = new System.Drawing.Point(0, 0);
            this.MiddleContainer.Name = "MiddleContainer";
            this.MiddleContainer.Size = new System.Drawing.Size(1200, 700);
            this.MiddleContainer.TabIndex = 2;
            this.MiddleContainer.Text = "guna2ContainerControl3";
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.White;
            this.PanelData.BorderColor = System.Drawing.Color.Transparent;
            this.PanelData.Controls.Add(this.LblInformation);
            this.PanelData.Controls.Add(this.DgvEvents);
            this.Show2SloiAnimated.SetDecoration(this.PanelData, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelData.Location = new System.Drawing.Point(359, 36);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(835, 646);
            this.PanelData.TabIndex = 30;
            // 
            // LblInformation
            // 
            this.Show2SloiAnimated.SetDecoration(this.LblInformation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInformation.Location = new System.Drawing.Point(102, 509);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(705, 100);
            this.LblInformation.TabIndex = 38;
            this.LblInformation.Text = "no upcoming events";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvEvents.ColumnHeadersHeight = 30;
            this.DgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEventDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.beginDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.DgvEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvEvents.DataSource = this.BsDate;
            this.Show2SloiAnimated.SetDecoration(this.DgvEvents, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEvents.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvEvents.EnableHeadersVisualStyles = false;
            this.DgvEvents.GridColor = System.Drawing.Color.White;
            this.DgvEvents.Location = new System.Drawing.Point(3, 3);
            this.DgvEvents.MultiSelect = false;
            this.DgvEvents.Name = "DgvEvents";
            this.DgvEvents.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvEvents.RowHeadersVisible = false;
            this.DgvEvents.RowTemplate.Height = 35;
            this.DgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEvents.Size = new System.Drawing.Size(826, 640);
            this.DgvEvents.TabIndex = 37;
            this.DgvEvents.Leave += new System.EventHandler(this.DgvEvents_Leave);
            // 
            // PanelDown
            // 
            this.PanelDown.BackColor = System.Drawing.Color.White;
            this.PanelDown.BorderColor = System.Drawing.Color.Transparent;
            this.Show2SloiAnimated.SetDecoration(this.PanelDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelDown.Location = new System.Drawing.Point(12, 417);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(341, 265);
            this.PanelDown.TabIndex = 29;
            // 
            // PanelCalendar
            // 
            this.PanelCalendar.BackColor = System.Drawing.Color.White;
            this.PanelCalendar.BorderColor = System.Drawing.Color.Transparent;
            this.PanelCalendar.Controls.Add(this.label5);
            this.PanelCalendar.Controls.Add(this.LblYearMonth);
            this.PanelCalendar.Controls.Add(this.DaysContainer);
            this.PanelCalendar.Controls.Add(this.label7);
            this.PanelCalendar.Controls.Add(this.guna2Button2);
            this.PanelCalendar.Controls.Add(this.label6);
            this.PanelCalendar.Controls.Add(this.guna2Button3);
            this.PanelCalendar.Controls.Add(this.label1);
            this.PanelCalendar.Controls.Add(this.label4);
            this.PanelCalendar.Controls.Add(this.label2);
            this.PanelCalendar.Controls.Add(this.label3);
            this.Show2SloiAnimated.SetDecoration(this.PanelCalendar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelCalendar.Location = new System.Drawing.Point(12, 36);
            this.PanelCalendar.Name = "PanelCalendar";
            this.PanelCalendar.Size = new System.Drawing.Size(341, 375);
            this.PanelCalendar.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Th";
            // 
            // LblYearMonth
            // 
            this.LblYearMonth.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.LblYearMonth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblYearMonth.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.LblYearMonth.Location = new System.Drawing.Point(52, 19);
            this.LblYearMonth.Name = "LblYearMonth";
            this.LblYearMonth.Size = new System.Drawing.Size(236, 32);
            this.LblYearMonth.TabIndex = 27;
            this.LblYearMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaysContainer
            // 
            this.DaysContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DaysContainer.BackColor = System.Drawing.Color.White;
            this.DaysContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Show2SloiAnimated.SetDecoration(this.DaysContainer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DaysContainer.Location = new System.Drawing.Point(12, 86);
            this.DaysContainer.Name = "DaysContainer";
            this.DaysContainer.Size = new System.Drawing.Size(312, 224);
            this.DaysContainer.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sa";
            // 
            // guna2Button2
            // 
            this.Show2SloiAnimated.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(200, 326);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(117, 28);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "🡺";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fr";
            // 
            // guna2Button3
            // 
            this.Show2SloiAnimated.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(22, 326);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Button3.Size = new System.Drawing.Size(117, 28);
            this.guna2Button3.TabIndex = 19;
            this.guna2Button3.Text = "🡸";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Su";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "We";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.Show2SloiAnimated.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tu";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderThickness = 1;
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 688);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1200, 12);
            this.guna2Panel3.TabIndex = 13;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.BtnHide);
            this.guna2Panel1.Controls.Add(this.BtnClose);
            this.Show2SloiAnimated.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1200, 30);
            this.guna2Panel1.TabIndex = 12;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // BtnHide
            // 
            this.BtnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnHide.Location = new System.Drawing.Point(1056, 3);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.PressedColor = System.Drawing.Color.Gray;
            this.BtnHide.ShadowDecoration.BorderRadius = 30;
            this.BtnHide.Size = new System.Drawing.Size(66, 24);
            this.BtnHide.TabIndex = 2;
            this.BtnHide.Text = "—";
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Animated = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.BorderRadius = 8;
            this.BtnClose.BorderThickness = 1;
            this.Show2SloiAnimated.SetDecoration(this.BtnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(1128, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.Gray;
            this.BtnClose.ShadowDecoration.BorderRadius = 30;
            this.BtnClose.Size = new System.Drawing.Size(66, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "✖";
            this.BtnClose.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.DragStartTransparencyValue = 1D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.DragStartTransparencyValue = 1D;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // Show2SloiAnimated
            // 
            this.Show2SloiAnimated.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
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
            // CMenuStrip
            // 
            this.Show2SloiAnimated.SetDecoration(this.CMenuStrip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСобытиеToolStripMenuItem});
            this.CMenuStrip.Name = "CMenuStrip";
            this.CMenuStrip.Size = new System.Drawing.Size(177, 26);
            this.CMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMenuStrip_ItemClicked);
            // 
            // добавитьСобытиеToolStripMenuItem
            // 
            this.добавитьСобытиеToolStripMenuItem.Name = "добавитьСобытиеToolStripMenuItem";
            this.добавитьСобытиеToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьСобытиеToolStripMenuItem.Text = "Добавить событие";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.PanelCalendar;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.PanelDown;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.PanelData;
            // 
            // dBKurs23DataSet
            // 
            this.dBKurs23DataSet.DataSetName = "DBKurs23DataSet";
            this.dBKurs23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsDate
            // 
            this.BsDate.DataMember = "Events";
            this.BsDate.DataSource = this.dBKurs23DataSet;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EventsTableAdapter = this.eventsTableAdapter;
            this.tableAdapterManager.UpdateOrder = NeedsHelp.DBKurs23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idEventDataGridViewTextBoxColumn
            // 
            this.idEventDataGridViewTextBoxColumn.DataPropertyName = "IdEvent";
            this.idEventDataGridViewTextBoxColumn.HeaderText = "IdEvent";
            this.idEventDataGridViewTextBoxColumn.Name = "idEventDataGridViewTextBoxColumn";
            this.idEventDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEventDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Title";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beginDateDataGridViewTextBoxColumn
            // 
            this.beginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.Name = "beginDateDataGridViewTextBoxColumn";
            this.beginDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.MiddleContainer);
            this.Show2SloiAnimated.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MiddleContainer.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEvents)).EndInit();
            this.PanelCalendar.ResumeLayout(false);
            this.PanelCalendar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.CMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBKurs23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContainerControl MiddleContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Button BtnHide;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Transition Show2SloiAnimated;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel DaysContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblYearMonth;
        private Guna.UI2.WinForms.Guna2Panel PanelCalendar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelDown;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel PanelData;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        public System.Windows.Forms.DataGridView DgvEvents;
        private System.Windows.Forms.ContextMenuStrip CMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьСобытиеToolStripMenuItem;
        private System.Windows.Forms.Label LblInformation;
        private DBKurs23DataSet dBKurs23DataSet;
        private System.Windows.Forms.BindingSource BsDate;
        private DBKurs23DataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private DBKurs23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}