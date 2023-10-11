namespace Survey_Task_V2
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            nameTxtbox = new TextBox();
            surnameTxtbox = new TextBox();
            label3 = new Label();
            EmailTxtbox = new TextBox();
            label4 = new Label();
            phoneTextbox = new TextBox();
            label5 = new Label();
            BirthdatePicker = new DateTimePicker();
            label6 = new Label();
            Ankets = new ListBox();
            addBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            changeBtn = new Button();
            Loadbtn = new Button();
            SaveBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 1;
            label1.Text = "Survey";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.surveyy;
            pictureBox1.Location = new Point(185, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // nameTxtbox
            // 
            nameTxtbox.Location = new Point(135, 103);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.Size = new Size(152, 23);
            nameTxtbox.TabIndex = 2;
            // 
            // surnameTxtbox
            // 
            surnameTxtbox.Location = new Point(135, 132);
            surnameTxtbox.Name = "surnameTxtbox";
            surnameTxtbox.Size = new Size(152, 23);
            surnameTxtbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 131);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Surname";
            // 
            // EmailTxtbox
            // 
            EmailTxtbox.Location = new Point(135, 161);
            EmailTxtbox.Name = "EmailTxtbox";
            EmailTxtbox.Size = new Size(152, 23);
            EmailTxtbox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 160);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // phoneTextbox
            // 
            phoneTextbox.Location = new Point(135, 190);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(152, 23);
            phoneTextbox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 189);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // BirthdatePicker
            // 
            BirthdatePicker.Location = new Point(135, 220);
            BirthdatePicker.Name = "BirthdatePicker";
            BirthdatePicker.Size = new Size(192, 23);
            BirthdatePicker.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 222);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 10;
            label6.Text = "Birth Date";
            // 
            // Ankets
            // 
            Ankets.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ankets.FormattingEnabled = true;
            Ankets.ItemHeight = 17;
            Ankets.Location = new Point(471, 90);
            Ankets.Name = "Ankets";
            Ankets.Size = new Size(177, 242);
            Ankets.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(23, 24, 29);
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(-23, -29);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(189, 85);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(addBtn);
            panel2.Location = new Point(135, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 33);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(changeBtn);
            panel3.Location = new Point(135, 317);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 31);
            panel3.TabIndex = 14;
            // 
            // changeBtn
            // 
            changeBtn.BackColor = Color.FromArgb(23, 24, 29);
            changeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            changeBtn.ForeColor = Color.White;
            changeBtn.Location = new Point(-23, -29);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(189, 85);
            changeBtn.TabIndex = 12;
            changeBtn.Text = "Change";
            changeBtn.UseVisualStyleBackColor = false;
            changeBtn.Click += changeBtn_Click;
            // 
            // Loadbtn
            // 
            Loadbtn.BackColor = Color.FromArgb(23, 24, 29);
            Loadbtn.FlatStyle = FlatStyle.Popup;
            Loadbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Loadbtn.ForeColor = Color.White;
            Loadbtn.Location = new Point(471, 338);
            Loadbtn.Name = "Loadbtn";
            Loadbtn.Size = new Size(79, 23);
            Loadbtn.TabIndex = 16;
            Loadbtn.Text = "Load";
            Loadbtn.UseVisualStyleBackColor = false;
            Loadbtn.Click += Loadbtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(23, 24, 29);
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(568, 338);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(80, 23);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(535, 22);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 18;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 396);
            Controls.Add(SaveBtn);
            Controls.Add(Loadbtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Ankets);
            Controls.Add(label6);
            Controls.Add(BirthdatePicker);
            Controls.Add(phoneTextbox);
            Controls.Add(label5);
            Controls.Add(EmailTxtbox);
            Controls.Add(label4);
            Controls.Add(surnameTxtbox);
            Controls.Add(label3);
            Controls.Add(nameTxtbox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Survey";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox nameTxtbox;
        private TextBox surnameTxtbox;
        private Label label3;
        private TextBox EmailTxtbox;
        private Label label4;
        private TextBox phoneTextbox;
        private Label label5;
        private DateTimePicker BirthdatePicker;
        private Label label6;
        private ListBox Ankets;
        private Button addBtn;
        private Panel panel2;
        private Panel panel3;
        private Button changeBtn;
        private Button Loadbtn;
        private Button SaveBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}