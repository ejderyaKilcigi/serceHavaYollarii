namespace UcusRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(223, 28);
            button2.Name = "button2";
            button2.Size = new Size(48, 61);
            button2.TabIndex = 6;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 29);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 4;
            label3.Text = "Tarih: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 3;
            label2.Text = "Nereye: ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Batman", "İstanbul", "Maraş", "Şırnak" });
            comboBox2.Location = new Point(89, 60);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Nereden: ";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Batman", "İstanbul", "Maraş", "Şırnak" });
            comboBox1.Location = new Point(89, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(303, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 137);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 100);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 11;
            label6.Text = "Telefon Nu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 66);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 10;
            label5.Text = "TC: ";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(108, 97);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(187, 29);
            maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 63);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(187, 29);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 29);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 31);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 6;
            label4.Text = "İsim Soyisim: ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(235, 273);
            button1.Name = "button1";
            button1.Size = new Size(129, 30);
            button1.TabIndex = 2;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 334);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(592, 109);
            listBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 112);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(438, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(426, 34);
            label7.TabIndex = 2;
            label7.Text = "SERÇE HAVA YOLLARI UÇURUR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 288);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 5;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 446);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label6;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button2;
        private Label label8;
    }
}