namespace Project2_Database
{
    partial class RegisterForm
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
            System.Windows.Forms.Label student_NumberLabel;
            System.Windows.Forms.Label student_FirstNameLabel;
            System.Windows.Forms.Label student_LastNameLabel;
            System.Windows.Forms.Label student_DoBLabel;
            System.Windows.Forms.Label student_JoinDateLabel;
            System.Windows.Forms.Label student_MobileNumberLabel;
            System.Windows.Forms.Label student_EmailLabel;
            System.Windows.Forms.Label student_AddressLabel;
            this.project2DataSet = new Project2_Database.Project2DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Project2_Database.Project2DataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Project2_Database.Project2DataSetTableAdapters.TableAdapterManager();
            this.student_NumberTextBox = new System.Windows.Forms.TextBox();
            this.student_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.student_DoBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.student_JoinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.student_MobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.student_EmailTextBox = new System.Windows.Forms.TextBox();
            this.student_AddressTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            student_NumberLabel = new System.Windows.Forms.Label();
            student_FirstNameLabel = new System.Windows.Forms.Label();
            student_LastNameLabel = new System.Windows.Forms.Label();
            student_DoBLabel = new System.Windows.Forms.Label();
            student_JoinDateLabel = new System.Windows.Forms.Label();
            student_MobileNumberLabel = new System.Windows.Forms.Label();
            student_EmailLabel = new System.Windows.Forms.Label();
            student_AddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // student_NumberLabel
            // 
            student_NumberLabel.AutoSize = true;
            student_NumberLabel.Location = new System.Drawing.Point(216, 55);
            student_NumberLabel.Name = "student_NumberLabel";
            student_NumberLabel.Size = new System.Drawing.Size(87, 13);
            student_NumberLabel.TabIndex = 1;
            student_NumberLabel.Text = "Student Number:";
            student_NumberLabel.Visible = false;
            // 
            // student_FirstNameLabel
            // 
            student_FirstNameLabel.AutoSize = true;
            student_FirstNameLabel.Location = new System.Drawing.Point(216, 94);
            student_FirstNameLabel.Name = "student_FirstNameLabel";
            student_FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            student_FirstNameLabel.TabIndex = 3;
            student_FirstNameLabel.Text = "First Name:";
            // 
            // student_LastNameLabel
            // 
            student_LastNameLabel.AutoSize = true;
            student_LastNameLabel.Location = new System.Drawing.Point(216, 133);
            student_LastNameLabel.Name = "student_LastNameLabel";
            student_LastNameLabel.Size = new System.Drawing.Size(61, 13);
            student_LastNameLabel.TabIndex = 5;
            student_LastNameLabel.Text = "Last Name:";
            // 
            // student_DoBLabel
            // 
            student_DoBLabel.AutoSize = true;
            student_DoBLabel.Location = new System.Drawing.Point(216, 180);
            student_DoBLabel.Name = "student_DoBLabel";
            student_DoBLabel.Size = new System.Drawing.Size(69, 13);
            student_DoBLabel.TabIndex = 7;
            student_DoBLabel.Text = "Date of Birth:";
            // 
            // student_JoinDateLabel
            // 
            student_JoinDateLabel.AutoSize = true;
            student_JoinDateLabel.Location = new System.Drawing.Point(216, 206);
            student_JoinDateLabel.Name = "student_JoinDateLabel";
            student_JoinDateLabel.Size = new System.Drawing.Size(55, 13);
            student_JoinDateLabel.TabIndex = 9;
            student_JoinDateLabel.Text = "Join Date:";
            // 
            // student_MobileNumberLabel
            // 
            student_MobileNumberLabel.AutoSize = true;
            student_MobileNumberLabel.Location = new System.Drawing.Point(216, 228);
            student_MobileNumberLabel.Name = "student_MobileNumberLabel";
            student_MobileNumberLabel.Size = new System.Drawing.Size(121, 13);
            student_MobileNumberLabel.TabIndex = 11;
            student_MobileNumberLabel.Text = "Student Mobile Number:";
            // 
            // student_EmailLabel
            // 
            student_EmailLabel.AutoSize = true;
            student_EmailLabel.Location = new System.Drawing.Point(216, 276);
            student_EmailLabel.Name = "student_EmailLabel";
            student_EmailLabel.Size = new System.Drawing.Size(75, 13);
            student_EmailLabel.TabIndex = 13;
            student_EmailLabel.Text = "Student Email:";
            // 
            // student_AddressLabel
            // 
            student_AddressLabel.AutoSize = true;
            student_AddressLabel.Location = new System.Drawing.Point(216, 315);
            student_AddressLabel.Name = "student_AddressLabel";
            student_AddressLabel.Size = new System.Drawing.Size(88, 13);
            student_AddressLabel.TabIndex = 15;
            student_AddressLabel.Text = "Student Address:";
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.project2DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.ParentTableAdapter = null;
            this.tableAdapterManager.RankingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project2_Database.Project2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_NumberTextBox
            // 
            this.student_NumberTextBox.AccessibleName = "";
            this.student_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Number", true));
            this.student_NumberTextBox.Enabled = false;
            this.student_NumberTextBox.Location = new System.Drawing.Point(219, 71);
            this.student_NumberTextBox.Name = "student_NumberTextBox";
            this.student_NumberTextBox.Size = new System.Drawing.Size(290, 20);
            this.student_NumberTextBox.TabIndex = 2;
            this.student_NumberTextBox.TextChanged += new System.EventHandler(this.student_NumberTextBox_TextChanged);
            // 
            // student_FirstNameTextBox
            // 
            this.student_FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_FirstName", true));
            this.student_FirstNameTextBox.Location = new System.Drawing.Point(219, 110);
            this.student_FirstNameTextBox.Name = "student_FirstNameTextBox";
            this.student_FirstNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.student_FirstNameTextBox.TabIndex = 4;
            // 
            // student_LastNameTextBox
            // 
            this.student_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_LastName", true));
            this.student_LastNameTextBox.Location = new System.Drawing.Point(219, 149);
            this.student_LastNameTextBox.Name = "student_LastNameTextBox";
            this.student_LastNameTextBox.Size = new System.Drawing.Size(290, 20);
            this.student_LastNameTextBox.TabIndex = 6;
            // 
            // student_DoBDateTimePicker
            // 
            this.student_DoBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Student_DoB", true));
            this.student_DoBDateTimePicker.Location = new System.Drawing.Point(311, 176);
            this.student_DoBDateTimePicker.Name = "student_DoBDateTimePicker";
            this.student_DoBDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.student_DoBDateTimePicker.TabIndex = 8;
            // 
            // student_JoinDateDateTimePicker
            // 
            this.student_JoinDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Student_JoinDate", true));
            this.student_JoinDateDateTimePicker.Location = new System.Drawing.Point(311, 200);
            this.student_JoinDateDateTimePicker.Name = "student_JoinDateDateTimePicker";
            this.student_JoinDateDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.student_JoinDateDateTimePicker.TabIndex = 10;
            // 
            // student_MobileNumberTextBox
            // 
            this.student_MobileNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_MobileNumber", true));
            this.student_MobileNumberTextBox.Location = new System.Drawing.Point(219, 244);
            this.student_MobileNumberTextBox.Name = "student_MobileNumberTextBox";
            this.student_MobileNumberTextBox.Size = new System.Drawing.Size(291, 20);
            this.student_MobileNumberTextBox.TabIndex = 12;
            // 
            // student_EmailTextBox
            // 
            this.student_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Email", true));
            this.student_EmailTextBox.Location = new System.Drawing.Point(219, 292);
            this.student_EmailTextBox.Name = "student_EmailTextBox";
            this.student_EmailTextBox.Size = new System.Drawing.Size(291, 20);
            this.student_EmailTextBox.TabIndex = 14;
            // 
            // student_AddressTextBox
            // 
            this.student_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Address", true));
            this.student_AddressTextBox.Location = new System.Drawing.Point(216, 331);
            this.student_AddressTextBox.Multiline = true;
            this.student_AddressTextBox.Name = "student_AddressTextBox";
            this.student_AddressTextBox.Size = new System.Drawing.Size(293, 61);
            this.student_AddressTextBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(392, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Proceed";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.project2DataSet;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.project2DataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project2_Database.Properties.Resources.judo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Welcome! Please enter the details to register.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 186);
            this.panel1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 179);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "One of the best Kung fu Club in Windsor.\r\n- Personal training.\r\n- Less students p" +
    "er session.\r\n- Reasonable fees.\r\n- Training by Kung Fu Master \"Stephanos\".\r\n";
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.project2DataSet;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(student_NumberLabel);
            this.Controls.Add(this.student_NumberTextBox);
            this.Controls.Add(student_FirstNameLabel);
            this.Controls.Add(this.student_FirstNameTextBox);
            this.Controls.Add(student_LastNameLabel);
            this.Controls.Add(this.student_LastNameTextBox);
            this.Controls.Add(student_DoBLabel);
            this.Controls.Add(this.student_DoBDateTimePicker);
            this.Controls.Add(student_JoinDateLabel);
            this.Controls.Add(this.student_JoinDateDateTimePicker);
            this.Controls.Add(student_MobileNumberLabel);
            this.Controls.Add(this.student_MobileNumberTextBox);
            this.Controls.Add(student_EmailLabel);
            this.Controls.Add(this.student_EmailTextBox);
            this.Controls.Add(student_AddressLabel);
            this.Controls.Add(this.student_AddressTextBox);
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Project2DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Project2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox student_NumberTextBox;
        private System.Windows.Forms.TextBox student_FirstNameTextBox;
        private System.Windows.Forms.TextBox student_LastNameTextBox;
        private System.Windows.Forms.DateTimePicker student_DoBDateTimePicker;
        private System.Windows.Forms.DateTimePicker student_JoinDateDateTimePicker;
        private System.Windows.Forms.TextBox student_MobileNumberTextBox;
        private System.Windows.Forms.TextBox student_EmailTextBox;
        private System.Windows.Forms.TextBox student_AddressTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource studentBindingSource3;
    }
}

