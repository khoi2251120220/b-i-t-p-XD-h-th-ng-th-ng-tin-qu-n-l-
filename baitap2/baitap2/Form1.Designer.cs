namespace baitap2
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
            txtten = new Label();
            txtcmnd = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioTh = new RadioButton();
            radioTr = new RadioButton();
            radioS = new RadioButton();
            groupBox2 = new GroupBox();
            checkAnUong = new CheckBox();
            checkHDV = new CheckBox();
            checkXe = new CheckBox();
            txtsngay = new Label();
            txtTientra = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtten
            // 
            txtten.AutoSize = true;
            txtten.Location = new Point(44, 27);
            txtten.Name = "txtten";
            txtten.Size = new Size(90, 15);
            txtten.TabIndex = 0;
            txtten.Text = "Tên khách hàng";
            txtten.Click += label1_Click;
            // 
            // txtcmnd
            // 
            txtcmnd.AutoSize = true;
            txtcmnd.Location = new Point(47, 69);
            txtcmnd.Name = "txtcmnd";
            txtcmnd.Size = new Size(55, 15);
            txtcmnd.TabIndex = 1;
            txtcmnd.Text = "Số CCCD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioTh);
            groupBox1.Controls.Add(radioTr);
            groupBox1.Controls.Add(radioS);
            groupBox1.Location = new Point(44, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại phòng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioTh
            // 
            radioTh.AutoSize = true;
            radioTh.Location = new Point(20, 65);
            radioTh.Name = "radioTh";
            radioTh.Size = new Size(66, 19);
            radioTh.TabIndex = 2;
            radioTh.TabStop = true;
            radioTh.Text = "Thường";
            radioTh.UseVisualStyleBackColor = true;
            // 
            // radioTr
            // 
            radioTr.AutoSize = true;
            radioTr.Location = new Point(20, 41);
            radioTr.Name = "radioTr";
            radioTr.Size = new Size(55, 19);
            radioTr.TabIndex = 1;
            radioTr.TabStop = true;
            radioTr.Text = "Trung";
            radioTr.UseVisualStyleBackColor = true;
            radioTr.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioS
            // 
            radioS.AutoSize = true;
            radioS.Location = new Point(20, 16);
            radioS.Name = "radioS";
            radioS.Size = new Size(51, 19);
            radioS.TabIndex = 0;
            radioS.TabStop = true;
            radioS.Text = "Sang";
            radioS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkAnUong);
            groupBox2.Controls.Add(checkHDV);
            groupBox2.Controls.Add(checkXe);
            groupBox2.Location = new Point(278, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại dịch vụ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // checkAnUong
            // 
            checkAnUong.AutoSize = true;
            checkAnUong.BackColor = Color.Transparent;
            checkAnUong.Location = new Point(22, 65);
            checkAnUong.Name = "checkAnUong";
            checkAnUong.Size = new Size(72, 19);
            checkAnUong.TabIndex = 9;
            checkAnUong.Text = "Ăn uống";
            checkAnUong.UseVisualStyleBackColor = false;
            checkAnUong.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkHDV
            // 
            checkHDV.AutoSize = true;
            checkHDV.Location = new Point(22, 40);
            checkHDV.Name = "checkHDV";
            checkHDV.Size = new Size(111, 19);
            checkHDV.TabIndex = 8;
            checkHDV.Text = "Hướng dẫn viên";
            checkHDV.UseVisualStyleBackColor = true;
            // 
            // checkXe
            // 
            checkXe.AutoSize = true;
            checkXe.Location = new Point(22, 16);
            checkXe.Name = "checkXe";
            checkXe.Size = new Size(67, 19);
            checkXe.TabIndex = 7;
            checkXe.Text = "Thuê xe";
            checkXe.UseVisualStyleBackColor = true;
            // 
            // txtsngay
            // 
            txtsngay.AutoSize = true;
            txtsngay.Location = new Point(44, 283);
            txtsngay.Name = "txtsngay";
            txtsngay.Size = new Size(49, 15);
            txtsngay.TabIndex = 7;
            txtsngay.Text = "Số ngày";
            // 
            // txtTientra
            // 
            txtTientra.AutoSize = true;
            txtTientra.Location = new Point(231, 283);
            txtTientra.Name = "txtTientra";
            txtTientra.Size = new Size(86, 15);
            txtTientra.TabIndex = 8;
            txtTientra.Text = "Số tiền phải trả";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(48, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(323, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(59, 360);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 11;
            button1.Text = "Tính tiền";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(206, 360);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 12;
            button2.Text = "Tiếp tục";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(350, 360);
            button3.Name = "button3";
            button3.Size = new Size(96, 33);
            button3.TabIndex = 13;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(510, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtTientra);
            Controls.Add(txtsngay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtcmnd);
            Controls.Add(txtten);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtten;
        private Label txtcmnd;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioTh;
        private RadioButton radioTr;
        private RadioButton radioS;
        private CheckBox checkAnUong;
        private CheckBox checkHDV;
        private CheckBox checkXe;
        private Label txtsngay;
        private Label txtTientra;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
