namespace Project2_Database
{
    partial class RegistrationForm3
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
            System.Windows.Forms.Label studentNumberLabel;
            System.Windows.Forms.Label attendance_LevelLabel;
            System.Windows.Forms.Label attendance_TimeLabel;
            this.project2DataSet = new Project2_Database.Project2DataSet();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new Project2_Database.Project2DataSetTableAdapters.AttendanceTableAdapter();
            this.tableAdapterManager = new Project2_Database.Project2DataSetTableAdapters.TableAdapterManager();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.attendance_LevelTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.attendance_TimeTextBox = new System.Windows.Forms.TextBox();
            studentNumberLabel = new System.Windows.Forms.Label();
            attendance_LevelLabel = new System.Windows.Forms.Label();
            attendance_TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.project2DataSet;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = this.attendanceTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.ParentTableAdapter = null;
            this.tableAdapterManager.RankingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project2_Database.Project2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(12, 41);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 0;
            studentNumberLabel.Text = "Student Number:";
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Enabled = false;
            this.studentNumberTextBox.Location = new System.Drawing.Point(112, 38);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberTextBox.TabIndex = 1;
            this.studentNumberTextBox.TextChanged += new System.EventHandler(this.studentNumberTextBox_TextChanged);
            // 
            // attendance_LevelLabel
            // 
            attendance_LevelLabel.AutoSize = true;
            attendance_LevelLabel.Location = new System.Drawing.Point(12, 81);
            attendance_LevelLabel.Name = "attendance_LevelLabel";
            attendance_LevelLabel.Size = new System.Drawing.Size(94, 13);
            attendance_LevelLabel.TabIndex = 2;
            attendance_LevelLabel.Text = "Attendance Level:";
            // 
            // attendance_LevelTextBox
            // 
            this.attendance_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Attendance_Level", true));
            this.attendance_LevelTextBox.Location = new System.Drawing.Point(112, 78);
            this.attendance_LevelTextBox.Name = "attendance_LevelTextBox";
            this.attendance_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.attendance_LevelTextBox.TabIndex = 3;
            this.attendance_LevelTextBox.Text = "eg. 100 (Beginner)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(33, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attendance_TimeLabel
            // 
            attendance_TimeLabel.AutoSize = true;
            attendance_TimeLabel.Location = new System.Drawing.Point(15, 126);
            attendance_TimeLabel.Name = "attendance_TimeLabel";
            attendance_TimeLabel.Size = new System.Drawing.Size(91, 13);
            attendance_TimeLabel.TabIndex = 6;
            attendance_TimeLabel.Text = "Attendance Time:";
            // 
            // attendance_TimeTextBox
            // 
            this.attendance_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Attendance_Time", true));
            this.attendance_TimeTextBox.Location = new System.Drawing.Point(112, 123);
            this.attendance_TimeTextBox.Name = "attendance_TimeTextBox";
            this.attendance_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.attendance_TimeTextBox.TabIndex = 7;
            // 
            // RegistrationForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(attendance_TimeLabel);
            this.Controls.Add(this.attendance_TimeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(studentNumberLabel);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(attendance_LevelLabel);
            this.Controls.Add(this.attendance_LevelTextBox);
            this.Name = "RegistrationForm3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Page 3";
            this.Load += new System.EventHandler(this.RegistrationForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Project2DataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private Project2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.TextBox attendance_LevelTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox attendance_TimeTextBox;
    }
}