﻿namespace baitap2tuan2
{
    partial class Listbox1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            cat = new ListBox();
            dog = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(164, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(164, 128);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(164, 174);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            cat.FormattingEnabled = true;
            cat.ItemHeight = 15;
            cat.Location = new Point(12, 43);
            cat.Name = "cat";
            cat.Size = new Size(119, 154);
            cat.TabIndex = 4;
            cat.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dog
            // 
            dog.FormattingEnabled = true;
            dog.ItemHeight = 15;
            dog.Location = new Point(270, 44);
            dog.Name = "dog";
            dog.Size = new Size(119, 154);
            dog.TabIndex = 5;
            // 
            // Listbox1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 235);
            Controls.Add(dog);
            Controls.Add(cat);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.InfoText;
            Name = "Listbox1";
            Text = "Listbox";
            Load += Listbox_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox cat;
        private ListBox dog;
    }
}
