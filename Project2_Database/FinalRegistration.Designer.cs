namespace Project2_Database
{
    partial class FinalRegistration
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
            System.Windows.Forms.Label rank_NumberLabel;
            System.Windows.Forms.Label rank_ColorLabel;
            System.Windows.Forms.Label rank_RequirementLabel;
            System.Windows.Forms.Label rank_AssignedDateLabel;
            this.project2DataSet = new Project2_Database.Project2DataSet();
            this.rankingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankingTableAdapter = new Project2_Database.Project2DataSetTableAdapters.RankingTableAdapter();
            this.tableAdapterManager = new Project2_Database.Project2DataSetTableAdapters.TableAdapterManager();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.rank_NumberTextBox = new System.Windows.Forms.TextBox();
            this.rank_ColorTextBox = new System.Windows.Forms.TextBox();
            this.rank_RequirementTextBox = new System.Windows.Forms.TextBox();
            this.rank_AssignedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            rank_NumberLabel = new System.Windows.Forms.Label();
            rank_ColorLabel = new System.Windows.Forms.Label();
            rank_RequirementLabel = new System.Windows.Forms.Label();
            rank_AssignedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rankingBindingSource
            // 
            this.rankingBindingSource.DataMember = "Ranking";
            this.rankingBindingSource.DataSource = this.project2DataSet;
            // 
            // rankingTableAdapter
            // 
            this.rankingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.ParentTableAdapter = null;
            this.tableAdapterManager.RankingTableAdapter = this.rankingTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project2_Database.Project2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rankingBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Enabled = false;
            this.studentNumberTextBox.Location = new System.Drawing.Point(149, 51);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(81, 20);
            this.studentNumberTextBox.TabIndex = 2;
            // 
            // rank_NumberLabel
            // 
            rank_NumberLabel.AutoSize = true;
            rank_NumberLabel.Location = new System.Drawing.Point(12, 81);
            rank_NumberLabel.Name = "rank_NumberLabel";
            rank_NumberLabel.Size = new System.Drawing.Size(101, 13);
            rank_NumberLabel.TabIndex = 3;
            rank_NumberLabel.Text = "Your Rank Number:";
            // 
            // rank_NumberTextBox
            // 
            this.rank_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rankingBindingSource, "Rank_Number", true));
            this.rank_NumberTextBox.Enabled = false;
            this.rank_NumberTextBox.Location = new System.Drawing.Point(149, 78);
            this.rank_NumberTextBox.Name = "rank_NumberTextBox";
            this.rank_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.rank_NumberTextBox.TabIndex = 4;
            this.rank_NumberTextBox.Text = "100";
            // 
            // rank_ColorLabel
            // 
            rank_ColorLabel.AutoSize = true;
            rank_ColorLabel.Location = new System.Drawing.Point(12, 107);
            rank_ColorLabel.Name = "rank_ColorLabel";
            rank_ColorLabel.Size = new System.Drawing.Size(88, 13);
            rank_ColorLabel.TabIndex = 5;
            rank_ColorLabel.Text = "Your Rank Color:";
            // 
            // rank_ColorTextBox
            // 
            this.rank_ColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rankingBindingSource, "Rank_Color", true));
            this.rank_ColorTextBox.Enabled = false;
            this.rank_ColorTextBox.Location = new System.Drawing.Point(149, 104);
            this.rank_ColorTextBox.Name = "rank_ColorTextBox";
            this.rank_ColorTextBox.Size = new System.Drawing.Size(200, 20);
            this.rank_ColorTextBox.TabIndex = 6;
            this.rank_ColorTextBox.Text = "White Belt";
            // 
            // rank_RequirementLabel
            // 
            rank_RequirementLabel.AutoSize = true;
            rank_RequirementLabel.Location = new System.Drawing.Point(12, 133);
            rank_RequirementLabel.Name = "rank_RequirementLabel";
            rank_RequirementLabel.Size = new System.Drawing.Size(124, 13);
            rank_RequirementLabel.TabIndex = 7;
            rank_RequirementLabel.Text = "Next Rank Requirement:";
            // 
            // rank_RequirementTextBox
            // 
            this.rank_RequirementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rankingBindingSource, "Rank_Requirement", true));
            this.rank_RequirementTextBox.Enabled = false;
            this.rank_RequirementTextBox.Location = new System.Drawing.Point(149, 130);
            this.rank_RequirementTextBox.Name = "rank_RequirementTextBox";
            this.rank_RequirementTextBox.Size = new System.Drawing.Size(200, 20);
            this.rank_RequirementTextBox.TabIndex = 8;
            this.rank_RequirementTextBox.Text = "Rank : 200";
            // 
            // rank_AssignedDateLabel
            // 
            rank_AssignedDateLabel.AutoSize = true;
            rank_AssignedDateLabel.Location = new System.Drawing.Point(12, 162);
            rank_AssignedDateLabel.Name = "rank_AssignedDateLabel";
            rank_AssignedDateLabel.Size = new System.Drawing.Size(108, 13);
            rank_AssignedDateLabel.TabIndex = 9;
            rank_AssignedDateLabel.Text = "Rank Assigned Date:";
            // 
            // rank_AssignedDateDateTimePicker
            // 
            this.rank_AssignedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rankingBindingSource, "Rank_AssignedDate", true));
            this.rank_AssignedDateDateTimePicker.Enabled = false;
            this.rank_AssignedDateDateTimePicker.Location = new System.Drawing.Point(149, 156);
            this.rank_AssignedDateDateTimePicker.Name = "rank_AssignedDateDateTimePicker";
            this.rank_AssignedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rank_AssignedDateDateTimePicker.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Congratulation! Your registration is complete. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your Student number is :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(214, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinalRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(rank_NumberLabel);
            this.Controls.Add(this.rank_NumberTextBox);
            this.Controls.Add(rank_ColorLabel);
            this.Controls.Add(this.rank_ColorTextBox);
            this.Controls.Add(rank_RequirementLabel);
            this.Controls.Add(this.rank_RequirementTextBox);
            this.Controls.Add(rank_AssignedDateLabel);
            this.Controls.Add(this.rank_AssignedDateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FinalRegistration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Registration";
            this.Load += new System.EventHandler(this.FinalRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource rankingBindingSource;
        private Project2DataSetTableAdapters.RankingTableAdapter rankingTableAdapter;
        private Project2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.TextBox rank_NumberTextBox;
        private System.Windows.Forms.TextBox rank_ColorTextBox;
        private System.Windows.Forms.TextBox rank_RequirementTextBox;
        private System.Windows.Forms.DateTimePicker rank_AssignedDateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}