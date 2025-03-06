namespace baitap3tuan2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            openCtrlSToolStripMenuItem = new ToolStripMenuItem();
            saveCtrlSToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            alignToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            rightsToolStripMenuItem = new ToolStripMenuItem();
            centersToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 26);
            contextMenuStrip1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(107, 22);
            newToolStripMenuItem.Text = "New...";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(357, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openCtrlSToolStripMenuItem, saveCtrlSToolStripMenuItem, closeToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alignToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.BackColor = SystemColors.ButtonHighlight;
            newToolStripMenuItem1.ImageTransparentColor = Color.Transparent;
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(191, 22);
            newToolStripMenuItem1.Text = "New...              Ctrl + N";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // openCtrlSToolStripMenuItem
            // 
            openCtrlSToolStripMenuItem.Name = "openCtrlSToolStripMenuItem";
            openCtrlSToolStripMenuItem.Size = new Size(191, 22);
            openCtrlSToolStripMenuItem.Text = "Open...            Ctrl + O";
            // 
            // saveCtrlSToolStripMenuItem
            // 
            saveCtrlSToolStripMenuItem.Margin = new Padding(0, 0, 0, 5);
            saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            saveCtrlSToolStripMenuItem.Size = new Size(191, 22);
            saveCtrlSToolStripMenuItem.Text = "Save...              Ctrl + S";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(191, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(191, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // alignToolStripMenuItem
            // 
            alignToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, rightsToolStripMenuItem, centersToolStripMenuItem });
            alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            alignToolStripMenuItem.Size = new Size(180, 22);
            alignToolStripMenuItem.Text = "Align";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(180, 22);
            aToolStripMenuItem.Text = "Lefts";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            // 
            // rightsToolStripMenuItem
            // 
            rightsToolStripMenuItem.Name = "rightsToolStripMenuItem";
            rightsToolStripMenuItem.Size = new Size(180, 22);
            rightsToolStripMenuItem.Text = "Rights";
            // 
            // centersToolStripMenuItem
            // 
            centersToolStripMenuItem.Name = "centersToolStripMenuItem";
            centersToolStripMenuItem.Size = new Size(180, 22);
            centersToolStripMenuItem.Text = "Centers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 243);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MenuTest";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem openCtrlSToolStripMenuItem;
        private ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem alignToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem rightsToolStripMenuItem;
        private ToolStripMenuItem centersToolStripMenuItem;
    }
}
