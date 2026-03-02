namespace Activity1
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            btnmultbl = new Button();
            txtmultbl = new TextBox();
            listBox3 = new ListBox();
            btn = new Button();
            textBox3 = new TextBox();
            button4 = new Button();
            listBox4 = new ListBox();
            txtfibo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightPink;
            textBox1.Location = new Point(8, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Yellow;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 214);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(12, 309);
            button1.Name = "button1";
            button1.Size = new Size(265, 41);
            button1.TabIndex = 2;
            button1.Text = "LOOP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(821, 87);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(286, 214);
            listBox2.TabIndex = 3;
            // 
            // btnmultbl
            // 
            btnmultbl.BackColor = Color.LightGreen;
            btnmultbl.ForeColor = SystemColors.ControlText;
            btnmultbl.Location = new Point(821, 307);
            btnmultbl.Name = "btnmultbl";
            btnmultbl.Size = new Size(286, 42);
            btnmultbl.TabIndex = 4;
            btnmultbl.Text = "MULTIPLY";
            btnmultbl.UseVisualStyleBackColor = false;
            btnmultbl.Click += button2_Click;
            // 
            // txtmultbl
            // 
            txtmultbl.BackColor = Color.LightPink;
            txtmultbl.Location = new Point(821, 58);
            txtmultbl.Name = "txtmultbl";
            txtmultbl.Size = new Size(286, 23);
            txtmultbl.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.HotTrack;
            listBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 21;
            listBox3.Location = new Point(269, 89);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(278, 214);
            listBox3.TabIndex = 6;
            // 
            // btn
            // 
            btn.BackColor = Color.LightGreen;
            btn.Location = new Point(269, 309);
            btn.Name = "btn";
            btn.Size = new Size(278, 42);
            btn.TabIndex = 7;
            btn.Text = "CHECK";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightPink;
            textBox3.Location = new Point(269, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 23);
            textBox3.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGreen;
            button4.Location = new Point(543, 309);
            button4.Name = "button4";
            button4.Size = new Size(292, 42);
            button4.TabIndex = 9;
            button4.Text = "FIBONACCI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.MistyRose;
            listBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 21;
            listBox4.Location = new Point(543, 89);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(282, 214);
            listBox4.TabIndex = 10;
            // 
            // txtfibo
            // 
            txtfibo.BackColor = Color.LightPink;
            txtfibo.Location = new Point(543, 58);
            txtfibo.Name = "txtfibo";
            txtfibo.Size = new Size(282, 23);
            txtfibo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(62, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 12;
            label1.Text = "Activity1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.Location = new Point(337, 18);
            label2.Name = "label2";
            label2.Size = new Size(133, 37);
            label2.TabIndex = 13;
            label2.Text = "Activity2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.Location = new Point(612, 18);
            label3.Name = "label3";
            label3.Size = new Size(133, 37);
            label3.TabIndex = 14;
            label3.Text = "Activity3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label4.Location = new Point(902, 18);
            label4.Name = "label4";
            label4.Size = new Size(133, 37);
            label4.TabIndex = 15;
            label4.Text = "Activity4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtfibo);
            Controls.Add(listBox4);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(btn);
            Controls.Add(listBox3);
            Controls.Add(txtmultbl);
            Controls.Add(btnmultbl);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button btnmultbl;
        private TextBox txtmultbl;
        private ListBox listBox3;
        private Button btn;
        private TextBox textBox3;
        private Button button4;
        private ListBox listBox4;
        private TextBox txtfibo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
