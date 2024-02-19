namespace NeedsHelp
{
    partial class FormAddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNote));
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.TbxTitle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCountSim = new System.Windows.Forms.Label();
            this.TbxText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.FindSymbols = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LblCloseWithoutSave = new System.Windows.Forms.Label();
            this.PanelScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelScroll
            // 
            this.PanelScroll.AutoScroll = true;
            this.PanelScroll.BackColor = System.Drawing.Color.White;
            this.PanelScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelScroll.Controls.Add(this.LblCloseWithoutSave);
            this.PanelScroll.Controls.Add(this.TbxTitle);
            this.PanelScroll.Controls.Add(this.label2);
            this.PanelScroll.Controls.Add(this.LblCountSim);
            this.PanelScroll.Controls.Add(this.TbxText);
            this.PanelScroll.Controls.Add(this.label3);
            this.PanelScroll.Controls.Add(this.label1);
            this.PanelScroll.Controls.Add(this.LblTime);
            this.PanelScroll.Location = new System.Drawing.Point(6, 6);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(374, 449);
            this.PanelScroll.TabIndex = 2;
            // 
            // TbxTitle
            // 
            this.TbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTitle.ForeColor = System.Drawing.Color.Gray;
            this.TbxTitle.Location = new System.Drawing.Point(13, 34);
            this.TbxTitle.Multiline = false;
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TbxTitle.Size = new System.Drawing.Size(347, 39);
            this.TbxTitle.TabIndex = 7;
            this.TbxTitle.Text = "Заголовок";
            this.TbxTitle.Enter += new System.EventHandler(this.TbxTitle_Enter_1);
            this.TbxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxTitle_KeyPress);
            this.TbxTitle.Leave += new System.EventHandler(this.TbxTitle_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "🠔";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblCountSim
            // 
            this.LblCountSim.AutoSize = true;
            this.LblCountSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCountSim.Location = new System.Drawing.Point(236, 83);
            this.LblCountSim.Name = "LblCountSim";
            this.LblCountSim.Size = new System.Drawing.Size(16, 16);
            this.LblCountSim.TabIndex = 5;
            this.LblCountSim.Text = "S";
            // 
            // TbxText
            // 
            this.TbxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxText.ForeColor = System.Drawing.Color.Gray;
            this.TbxText.Location = new System.Drawing.Point(13, 114);
            this.TbxText.Name = "TbxText";
            this.TbxText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TbxText.Size = new System.Drawing.Size(347, 326);
            this.TbxText.TabIndex = 4;
            this.TbxText.Text = "Начните ввод\n";
            this.TbxText.Enter += new System.EventHandler(this.TbxText_Enter);
            this.TbxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxText_KeyPress);
            this.TbxText.Leave += new System.EventHandler(this.TbxText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(161, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Символов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "|";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTime.Location = new System.Drawing.Point(22, 83);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(44, 16);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "label1";
            // 
            // FindSymbols
            // 
            this.FindSymbols.Tick += new System.EventHandler(this.FindSymbols_Tick);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.DragStartTransparencyValue = 1D;
            this.guna2DragControl2.TargetControl = this;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // LblCloseWithoutSave
            // 
            this.LblCloseWithoutSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCloseWithoutSave.Location = new System.Drawing.Point(336, 6);
            this.LblCloseWithoutSave.Name = "LblCloseWithoutSave";
            this.LblCloseWithoutSave.Size = new System.Drawing.Size(26, 20);
            this.LblCloseWithoutSave.TabIndex = 9;
            this.LblCloseWithoutSave.Text = "✖";
            this.LblCloseWithoutSave.Click += new System.EventHandler(this.LblCloseWithoutSave_Click);
            // 
            // FormAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 461);
            this.Controls.Add(this.PanelScroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAddNote";
            this.Load += new System.EventHandler(this.FormAddNote_Load);
            this.Shown += new System.EventHandler(this.FormAddNote_Shown);
            this.PanelScroll.ResumeLayout(false);
            this.PanelScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TbxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCountSim;
        private System.Windows.Forms.Timer FindSymbols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TbxTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Label LblCloseWithoutSave;
    }
}