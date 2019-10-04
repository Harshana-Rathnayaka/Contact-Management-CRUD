namespace SAD_Project01
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.composeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.composeToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(97, 173);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInformationToolStripMenuItem,
            this.enterContactsToolStripMenuItem,
            this.updateContactsToolStripMenuItem});
            this.contactsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(97, 35);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // viewInformationToolStripMenuItem
            // 
            this.viewInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.parentsToolStripMenuItem});
            this.viewInformationToolStripMenuItem.Name = "viewInformationToolStripMenuItem";
            this.viewInformationToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.viewInformationToolStripMenuItem.Text = "View Contacts";
            this.viewInformationToolStripMenuItem.Click += new System.EventHandler(this.viewInformationToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // parentsToolStripMenuItem
            // 
            this.parentsToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.parentsToolStripMenuItem.Name = "parentsToolStripMenuItem";
            this.parentsToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.parentsToolStripMenuItem.Text = "Parents";
            this.parentsToolStripMenuItem.Click += new System.EventHandler(this.parentsToolStripMenuItem_Click);
            // 
            // enterContactsToolStripMenuItem
            // 
            this.enterContactsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem1,
            this.parentsToolStripMenuItem1});
            this.enterContactsToolStripMenuItem.Name = "enterContactsToolStripMenuItem";
            this.enterContactsToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.enterContactsToolStripMenuItem.Text = "Enter Contacts";
            this.enterContactsToolStripMenuItem.Click += new System.EventHandler(this.enterContactsToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem1
            // 
            this.studentsToolStripMenuItem1.BackColor = System.Drawing.Color.Goldenrod;
            this.studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            this.studentsToolStripMenuItem1.Size = new System.Drawing.Size(156, 30);
            this.studentsToolStripMenuItem1.Text = "Students";
            this.studentsToolStripMenuItem1.Click += new System.EventHandler(this.studentsToolStripMenuItem1_Click);
            // 
            // parentsToolStripMenuItem1
            // 
            this.parentsToolStripMenuItem1.BackColor = System.Drawing.Color.Goldenrod;
            this.parentsToolStripMenuItem1.Name = "parentsToolStripMenuItem1";
            this.parentsToolStripMenuItem1.Size = new System.Drawing.Size(156, 30);
            this.parentsToolStripMenuItem1.Text = "Parents";
            this.parentsToolStripMenuItem1.Click += new System.EventHandler(this.parentsToolStripMenuItem1_Click);
            // 
            // updateContactsToolStripMenuItem
            // 
            this.updateContactsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem2,
            this.parentsToolStripMenuItem2});
            this.updateContactsToolStripMenuItem.Name = "updateContactsToolStripMenuItem";
            this.updateContactsToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.updateContactsToolStripMenuItem.Text = "Update Contacts";
            this.updateContactsToolStripMenuItem.Click += new System.EventHandler(this.updateContactsToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem2
            // 
            this.studentsToolStripMenuItem2.BackColor = System.Drawing.Color.Goldenrod;
            this.studentsToolStripMenuItem2.Name = "studentsToolStripMenuItem2";
            this.studentsToolStripMenuItem2.Size = new System.Drawing.Size(156, 30);
            this.studentsToolStripMenuItem2.Text = "Students";
            this.studentsToolStripMenuItem2.Click += new System.EventHandler(this.studentsToolStripMenuItem2_Click);
            // 
            // parentsToolStripMenuItem2
            // 
            this.parentsToolStripMenuItem2.BackColor = System.Drawing.Color.Goldenrod;
            this.parentsToolStripMenuItem2.Name = "parentsToolStripMenuItem2";
            this.parentsToolStripMenuItem2.Size = new System.Drawing.Size(156, 30);
            this.parentsToolStripMenuItem2.Text = "Parents";
            this.parentsToolStripMenuItem2.Click += new System.EventHandler(this.parentsToolStripMenuItem2_Click);
            // 
            // composeToolStripMenuItem
            // 
            this.composeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.composeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.composeToolStripMenuItem.Name = "composeToolStripMenuItem";
            this.composeToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.composeToolStripMenuItem.Text = "Send a Message";
            this.composeToolStripMenuItem.ToolTipText = "Send a text message to any contact";
            this.composeToolStripMenuItem.Click += new System.EventHandler(this.composeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(99, 35);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 35);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(498, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 53);
            this.label1.TabIndex = 44;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.time_lbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.Color.Red;
            this.time_lbl.Location = new System.Drawing.Point(280, 122);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(54, 21);
            this.time_lbl.TabIndex = 45;
            this.time_lbl.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 441);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                          SMS POR" +
    "TAL :       MAIN MENU";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem updateContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem2;

    }
}