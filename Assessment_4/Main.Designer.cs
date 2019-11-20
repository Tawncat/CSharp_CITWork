namespace Assessment_4
{
    partial class frmMain
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
            this.frmMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.frmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMenu
            // 
            this.frmMenu.BackColor = System.Drawing.Color.DarkGray;
            this.frmMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.helpToolStripMenuItem});
            this.frmMenu.Location = new System.Drawing.Point(0, 0);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(573, 24);
            this.frmMenu.TabIndex = 0;
            this.frmMenu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.Transparent;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedListToolStripMenuItem,
            this.binaryTreeToolStripMenuItem,
            this.hashTablesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // linkedListToolStripMenuItem
            // 
            this.linkedListToolStripMenuItem.Name = "linkedListToolStripMenuItem";
            this.linkedListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkedListToolStripMenuItem.Text = "Linked List";
            this.linkedListToolStripMenuItem.Click += new System.EventHandler(this.LinkedListToolStripMenuItem_Click);
            // 
            // binaryTreeToolStripMenuItem
            // 
            this.binaryTreeToolStripMenuItem.Name = "binaryTreeToolStripMenuItem";
            this.binaryTreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binaryTreeToolStripMenuItem.Text = "Binary Tree";
            this.binaryTreeToolStripMenuItem.Click += new System.EventHandler(this.BinaryTreeToolStripMenuItem_Click);
            // 
            // hashTablesToolStripMenuItem
            // 
            this.hashTablesToolStripMenuItem.Name = "hashTablesToolStripMenuItem";
            this.hashTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hashTablesToolStripMenuItem.Text = "Hash Tables";
            this.hashTablesToolStripMenuItem.Click += new System.EventHandler(this.HashTablesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Grace Toyer\'s C# Assessment 4!\r\n\r\nSelect an application from the menu " +
    "to begin.\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmMenu);
            this.MainMenuStrip = this.frmMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment 4 - Grace Toyer";
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem linkedListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

