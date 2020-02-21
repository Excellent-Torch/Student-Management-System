namespace Student_Management_System
{
    partial class student_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_reg));
            this.label1 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.st_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.student_search = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.nic_no = new System.Windows.Forms.TextBox();
            this.tele_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.st_pw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.course_list = new System.Windows.Forms.ComboBox();
            this.studentdbDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentdbDataSet4 = new Student_Management_System.studentdbDataSet4();
            this.studentdbDataSet5 = new Student_Management_System.studentdbDataSet5();
            this.studentdbDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentRegView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRegView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(107, 333);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 1;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // st_id
            // 
            this.st_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.st_id.Location = new System.Drawing.Point(107, 34);
            this.st_id.MaxLength = 3;
            this.st_id.Name = "st_id";
            this.st_id.Size = new System.Drawing.Size(38, 20);
            this.st_id.TabIndex = 2;
            this.st_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.st_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.st_id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // student_search
            // 
            this.student_search.Location = new System.Drawing.Point(370, 35);
            this.student_search.MaxLength = 3;
            this.student_search.Name = "student_search";
            this.student_search.Size = new System.Drawing.Size(38, 20);
            this.student_search.TabIndex = 6;
            this.student_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.student_search_KeyPress);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(107, 70);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(131, 20);
            this.first_name.TabIndex = 7;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(107, 107);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(131, 20);
            this.last_name.TabIndex = 8;
            // 
            // nic_no
            // 
            this.nic_no.Location = new System.Drawing.Point(107, 145);
            this.nic_no.MaxLength = 10;
            this.nic_no.Name = "nic_no";
            this.nic_no.Size = new System.Drawing.Size(131, 20);
            this.nic_no.TabIndex = 9;
            this.nic_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nic_no_KeyPress);
            // 
            // tele_no
            // 
            this.tele_no.Location = new System.Drawing.Point(107, 182);
            this.tele_no.MaxLength = 10;
            this.tele_no.Name = "tele_no";
            this.tele_no.Size = new System.Drawing.Size(131, 20);
            this.tele_no.TabIndex = 10;
            this.tele_no.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.tele_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tele_no_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tele No.";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(107, 288);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(53, 19);
            this.rb_male.TabIndex = 12;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(171, 288);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(67, 19);
            this.rb_female.TabIndex = 14;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(347, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Password";
            // 
            // st_pw
            // 
            this.st_pw.Location = new System.Drawing.Point(107, 216);
            this.st_pw.MaxLength = 16;
            this.st_pw.Name = "st_pw";
            this.st_pw.PasswordChar = '*';
            this.st_pw.Size = new System.Drawing.Size(131, 20);
            this.st_pw.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.user_add_512;
            this.pictureBox1.Location = new System.Drawing.Point(307, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Course";
            // 
            // course_list
            // 
            this.course_list.FormattingEnabled = true;
            this.course_list.Items.AddRange(new object[] {
            "ACIT",
            "CINE",
            "CIH",
            "HNDL4",
            "HNDL5"});
            this.course_list.Location = new System.Drawing.Point(107, 252);
            this.course_list.Name = "course_list";
            this.course_list.Size = new System.Drawing.Size(131, 21);
            this.course_list.TabIndex = 23;
            // 
            // studentdbDataSet4BindingSource
            // 
            this.studentdbDataSet4BindingSource.DataSource = this.studentdbDataSet4;
            this.studentdbDataSet4BindingSource.Position = 0;
            // 
            // studentdbDataSet4
            // 
            this.studentdbDataSet4.DataSetName = "studentdbDataSet4";
            this.studentdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentdbDataSet5
            // 
            this.studentdbDataSet5.DataSetName = "studentdbDataSet5";
            this.studentdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentdbDataSet5BindingSource
            // 
            this.studentdbDataSet5BindingSource.DataSource = this.studentdbDataSet5;
            this.studentdbDataSet5BindingSource.Position = 0;
            // 
            // StudentRegView
            // 
            this.StudentRegView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.StudentRegView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRegView.Location = new System.Drawing.Point(485, 12);
            this.StudentRegView.Name = "StudentRegView";
            this.StudentRegView.Size = new System.Drawing.Size(420, 344);
            this.StudentRegView.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Enter ID";
            // 
            // student_reg
            // 
            this.AccessibleName = "student_reg";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(917, 369);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentRegView);
            this.Controls.Add(this.course_list);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.st_pw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tele_no);
            this.Controls.Add(this.nic_no);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.student_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.st_id);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "student_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.student_reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRegView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox st_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_search;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox nic_no;
        private System.Windows.Forms.TextBox tele_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox st_pw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox course_list;
        private System.Windows.Forms.BindingSource studentdbDataSet4BindingSource;
        private studentdbDataSet4 studentdbDataSet4;
        private System.Windows.Forms.BindingSource studentdbDataSet5BindingSource;
        private studentdbDataSet5 studentdbDataSet5;
        private System.Windows.Forms.DataGridView StudentRegView;
        private System.Windows.Forms.Label label10;
    }
}