namespace Notepad.UI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Rtbx = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LineSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoulmnSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_Tsmi,
            this.Open_Tsmi,
            this.Save_Tsmi});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // New_Tsmi
            // 
            this.New_Tsmi.Name = "New_Tsmi";
            this.New_Tsmi.Size = new System.Drawing.Size(158, 34);
            this.New_Tsmi.Text = "New";
            this.New_Tsmi.Click += new System.EventHandler(this.New_Tsmi_Click);
            // 
            // Open_Tsmi
            // 
            this.Open_Tsmi.Name = "Open_Tsmi";
            this.Open_Tsmi.Size = new System.Drawing.Size(158, 34);
            this.Open_Tsmi.Text = "Open";
            this.Open_Tsmi.Click += new System.EventHandler(this.Open_Tsmi_Click);
            // 
            // Save_Tsmi
            // 
            this.Save_Tsmi.Name = "Save_Tsmi";
            this.Save_Tsmi.Size = new System.Drawing.Size(158, 34);
            this.Save_Tsmi.Text = "Save";
            this.Save_Tsmi.Click += new System.EventHandler(this.Save_Tsmi_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo_Tsmi,
            this.Redo_Tsmi,
            this.Cut_Tsmi,
            this.Copy_Tsmi,
            this.Paste_Tsmi,
            this.Delete_Tsmi});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.formatToolStripMenuItem.Text = "Edit";
            // 
            // Undo_Tsmi
            // 
            this.Undo_Tsmi.Name = "Undo_Tsmi";
            this.Undo_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Undo_Tsmi.Text = "Undo";
            this.Undo_Tsmi.Click += new System.EventHandler(this.Undo_Tsmi_Click);
            // 
            // Redo_Tsmi
            // 
            this.Redo_Tsmi.Name = "Redo_Tsmi";
            this.Redo_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Redo_Tsmi.Text = "Redo";
            this.Redo_Tsmi.Click += new System.EventHandler(this.Redo_Tsmi_Click);
            // 
            // Cut_Tsmi
            // 
            this.Cut_Tsmi.Name = "Cut_Tsmi";
            this.Cut_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Cut_Tsmi.Text = "Cut";
            this.Cut_Tsmi.Click += new System.EventHandler(this.Cut_Tsmi_Click);
            // 
            // Copy_Tsmi
            // 
            this.Copy_Tsmi.Name = "Copy_Tsmi";
            this.Copy_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Copy_Tsmi.Text = "Copy";
            this.Copy_Tsmi.Click += new System.EventHandler(this.Copy_Tsmi_Click);
            // 
            // Paste_Tsmi
            // 
            this.Paste_Tsmi.Name = "Paste_Tsmi";
            this.Paste_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Paste_Tsmi.Text = "Paste";
            this.Paste_Tsmi.Click += new System.EventHandler(this.Paste_Tsmi_Click);
            // 
            // Delete_Tsmi
            // 
            this.Delete_Tsmi.Name = "Delete_Tsmi";
            this.Delete_Tsmi.Size = new System.Drawing.Size(270, 34);
            this.Delete_Tsmi.Text = "Delete";
            this.Delete_Tsmi.Click += new System.EventHandler(this.Delete_Tsmi_Click);
            // 
            // Rtbx
            // 
            this.Rtbx.Location = new System.Drawing.Point(0, 36);
            this.Rtbx.Name = "Rtbx";
            this.Rtbx.Size = new System.Drawing.Size(1019, 611);
            this.Rtbx.TabIndex = 1;
            this.Rtbx.Text = "";
            this.Rtbx.TextChanged += new System.EventHandler(this.Rtbx_TextChanged);
            this.Rtbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rtbx_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineSsl,
            this.CoulmnSsl,
            this.WordSsl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1019, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LineSsl
            // 
            this.LineSsl.Name = "LineSsl";
            this.LineSsl.Size = new System.Drawing.Size(57, 25);
            this.LineSsl.Text = "Line : ";
            // 
            // CoulmnSsl
            // 
            this.CoulmnSsl.Name = "CoulmnSsl";
            this.CoulmnSsl.Size = new System.Drawing.Size(88, 25);
            this.CoulmnSsl.Text = "Column : ";
            // 
            // WordSsl
            // 
            this.WordSsl.Name = "WordSsl";
            this.WordSsl.Size = new System.Drawing.Size(70, 25);
            this.WordSsl.Text = "Word : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 712);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Rtbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mini Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Open_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Save_Tsmi;
        private System.Windows.Forms.RichTextBox Rtbx;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LineSsl;
        private System.Windows.Forms.ToolStripStatusLabel CoulmnSsl;
        private System.Windows.Forms.ToolStripStatusLabel WordSsl;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Undo_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Redo_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Cut_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Copy_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Paste_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Delete_Tsmi;
    }
}

