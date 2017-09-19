namespace Project2_Database
{
    partial class RegistrationForm2
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
            System.Windows.Forms.Label parent_EmailLabel;
            System.Windows.Forms.Label parent_NumberLabel;
            System.Windows.Forms.Label parent_NameLabel;
            System.Windows.Forms.Label student_IDLabel;
            this.project2DataSet = new Project2_Database.Project2DataSet();
            this.parentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentTableAdapter = new Project2_Database.Project2DataSetTableAdapters.ParentTableAdapter();
            this.tableAdapterManager = new Project2_Database.Project2DataSetTableAdapters.TableAdapterManager();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new Project2_Database.Project2DataSetTableAdapters.AttendanceTableAdapter();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipTableAdapter = new Project2_Database.Project2DataSetTableAdapters.MembershipTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.parent_NameTextBox = new System.Windows.Forms.TextBox();
            this.parent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.parent_EmailTextBox = new System.Windows.Forms.TextBox();
            parent_EmailLabel = new System.Windows.Forms.Label();
            parent_NumberLabel = new System.Windows.Forms.Label();
            parent_NameLabel = new System.Windows.Forms.Label();
            student_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parent_EmailLabel
            // 
            parent_EmailLabel.AutoSize = true;
            parent_EmailLabel.Location = new System.Drawing.Point(6, 160);
            parent_EmailLabel.Name = "parent_EmailLabel";
            parent_EmailLabel.Size = new System.Drawing.Size(69, 13);
            parent_EmailLabel.TabIndex = 6;
            parent_EmailLabel.Text = "Parent Email:";
            // 
            // parent_NumberLabel
            // 
            parent_NumberLabel.AutoSize = true;
            parent_NumberLabel.Location = new System.Drawing.Point(6, 109);
            parent_NumberLabel.Name = "parent_NumberLabel";
            parent_NumberLabel.Size = new System.Drawing.Size(81, 13);
            parent_NumberLabel.TabIndex = 4;
            parent_NumberLabel.Text = "Parent Number:";
            // 
            // parent_NameLabel
            // 
            parent_NameLabel.AutoSize = true;
            parent_NameLabel.Location = new System.Drawing.Point(6, 57);
            parent_NameLabel.Name = "parent_NameLabel";
            parent_NameLabel.Size = new System.Drawing.Size(72, 13);
            parent_NameLabel.TabIndex = 2;
            parent_NameLabel.Text = "Parent Name:";
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(6, 25);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(61, 13);
            student_IDLabel.TabIndex = 8;
            student_IDLabel.Text = "Student ID:";
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parentBindingSource
            // 
            this.parentBindingSource.DataMember = "Parent";
            this.parentBindingSource.DataSource = this.project2DataSet;
            // 
            // parentTableAdapter
            // 
            this.parentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.ParentTableAdapter = this.parentTableAdapter;
            this.tableAdapterManager.RankingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project2_Database.Project2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.project2DataSet;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(95, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(student_IDLabel);
            this.groupBox1.Controls.Add(this.student_IDTextBox);
            this.groupBox1.Controls.Add(parent_NameLabel);
            this.groupBox1.Controls.Add(this.parent_NameTextBox);
            this.groupBox1.Controls.Add(parent_NumberLabel);
            this.groupBox1.Controls.Add(this.parent_NumberTextBox);
            this.groupBox1.Controls.Add(parent_EmailLabel);
            this.groupBox1.Controls.Add(this.parent_EmailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parents Details";
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parentBindingSource, "Student_ID", true));
            this.student_IDTextBox.Enabled = false;
            this.student_IDTextBox.Location = new System.Drawing.Point(73, 18);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(165, 20);
            this.student_IDTextBox.TabIndex = 1;
            // 
            // parent_NameTextBox
            // 
            this.parent_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parentBindingSource, "Parent_Name", true));
            this.parent_NameTextBox.Location = new System.Drawing.Point(6, 73);
            this.parent_NameTextBox.Name = "parent_NameTextBox";
            this.parent_NameTextBox.Size = new System.Drawing.Size(232, 20);
            this.parent_NameTextBox.TabIndex = 3;
            // 
            // parent_NumberTextBox
            // 
            this.parent_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parentBindingSource, "Parent_Number", true));
            this.parent_NumberTextBox.Location = new System.Drawing.Point(6, 125);
            this.parent_NumberTextBox.Name = "parent_NumberTextBox";
            this.parent_NumberTextBox.Size = new System.Drawing.Size(232, 20);
            this.parent_NumberTextBox.TabIndex = 5;
            // 
            // parent_EmailTextBox
            // 
            this.parent_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parentBindingSource, "Parent_Email", true));
            this.parent_EmailTextBox.Location = new System.Drawing.Point(6, 176);
            this.parent_EmailTextBox.Name = "parent_EmailTextBox";
            this.parent_EmailTextBox.Size = new System.Drawing.Size(232, 20);
            this.parent_EmailTextBox.TabIndex = 7;
            // 
            // RegistrationForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Page 2";
            this.Load += new System.EventHandler(this.RegistrationForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource parentBindingSource;
        private Project2DataSetTableAdapters.ParentTableAdapter parentTableAdapter;
        private Project2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Project2DataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private Project2DataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox parent_NameTextBox;
        private System.Windows.Forms.TextBox parent_NumberTextBox;
        private System.Windows.Forms.TextBox parent_EmailTextBox;
    }
}