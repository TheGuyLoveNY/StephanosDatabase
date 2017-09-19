namespace Project2_Database
{
    partial class RegistrationForm4
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
            System.Windows.Forms.Label membership_FeesLabel;
            System.Windows.Forms.Label membership_YearsLabel;
            System.Windows.Forms.Label membership_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm4));
            this.project2DataSet = new Project2_Database.Project2DataSet();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipTableAdapter = new Project2_Database.Project2DataSetTableAdapters.MembershipTableAdapter();
            this.tableAdapterManager = new Project2_Database.Project2DataSetTableAdapters.TableAdapterManager();
            this.membershipBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.membershipBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.membership_FeesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.membership_YearsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.membership_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            studentNumberLabel = new System.Windows.Forms.Label();
            membership_FeesLabel = new System.Windows.Forms.Label();
            membership_YearsLabel = new System.Windows.Forms.Label();
            membership_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingNavigator)).BeginInit();
            this.membershipBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membership_FeesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_YearsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(12, 46);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 1;
            studentNumberLabel.Text = "Student Number:";
            // 
            // membership_FeesLabel
            // 
            membership_FeesLabel.AutoSize = true;
            membership_FeesLabel.Location = new System.Drawing.Point(12, 77);
            membership_FeesLabel.Name = "membership_FeesLabel";
            membership_FeesLabel.Size = new System.Drawing.Size(93, 13);
            membership_FeesLabel.TabIndex = 3;
            membership_FeesLabel.Text = "Membership Fees:";
            // 
            // membership_YearsLabel
            // 
            membership_YearsLabel.AutoSize = true;
            membership_YearsLabel.Location = new System.Drawing.Point(12, 113);
            membership_YearsLabel.Name = "membership_YearsLabel";
            membership_YearsLabel.Size = new System.Drawing.Size(97, 13);
            membership_YearsLabel.TabIndex = 5;
            membership_YearsLabel.Text = "Membership Years:";
            // 
            // membership_DateLabel
            // 
            membership_DateLabel.AutoSize = true;
            membership_DateLabel.Location = new System.Drawing.Point(12, 155);
            membership_DateLabel.Name = "membership_DateLabel";
            membership_DateLabel.Size = new System.Drawing.Size(93, 13);
            membership_DateLabel.TabIndex = 7;
            membership_DateLabel.Text = "Membership Date:";
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembershipTableAdapter = this.membershipTableAdapter;
            this.tableAdapterManager.ParentTableAdapter = null;
            this.tableAdapterManager.RankingTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project2_Database.Project2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membershipBindingNavigator
            // 
            this.membershipBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membershipBindingNavigator.BindingSource = this.membershipBindingSource;
            this.membershipBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membershipBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membershipBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.membershipBindingNavigatorSaveItem});
            this.membershipBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.membershipBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membershipBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membershipBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membershipBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membershipBindingNavigator.Name = "membershipBindingNavigator";
            this.membershipBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membershipBindingNavigator.Size = new System.Drawing.Size(323, 25);
            this.membershipBindingNavigator.TabIndex = 0;
            this.membershipBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // membershipBindingNavigatorSaveItem
            // 
            this.membershipBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membershipBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membershipBindingNavigatorSaveItem.Image")));
            this.membershipBindingNavigatorSaveItem.Name = "membershipBindingNavigatorSaveItem";
            this.membershipBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.membershipBindingNavigatorSaveItem.Text = "Save Data";
            this.membershipBindingNavigatorSaveItem.Click += new System.EventHandler(this.membershipBindingNavigatorSaveItem_Click);
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Enabled = false;
            this.studentNumberTextBox.Location = new System.Drawing.Point(115, 43);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentNumberTextBox.TabIndex = 2;
            // 
            // membership_FeesNumericUpDown
            // 
            this.membership_FeesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipBindingSource, "Membership_Fees", true));
            this.membership_FeesNumericUpDown.Location = new System.Drawing.Point(115, 77);
            this.membership_FeesNumericUpDown.Name = "membership_FeesNumericUpDown";
            this.membership_FeesNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.membership_FeesNumericUpDown.TabIndex = 4;
            // 
            // membership_YearsNumericUpDown
            // 
            this.membership_YearsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipBindingSource, "Membership_Years", true));
            this.membership_YearsNumericUpDown.Location = new System.Drawing.Point(115, 113);
            this.membership_YearsNumericUpDown.Name = "membership_YearsNumericUpDown";
            this.membership_YearsNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.membership_YearsNumericUpDown.TabIndex = 6;
            // 
            // membership_DateDateTimePicker
            // 
            this.membership_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipBindingSource, "Membership_Date", true));
            this.membership_DateDateTimePicker.Location = new System.Drawing.Point(115, 151);
            this.membership_DateDateTimePicker.Name = "membership_DateDateTimePicker";
            this.membership_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.membership_DateDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(80, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Proceed >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(studentNumberLabel);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(membership_FeesLabel);
            this.Controls.Add(this.membership_FeesNumericUpDown);
            this.Controls.Add(membership_YearsLabel);
            this.Controls.Add(this.membership_YearsNumericUpDown);
            this.Controls.Add(membership_DateLabel);
            this.Controls.Add(this.membership_DateDateTimePicker);
            this.Controls.Add(this.membershipBindingNavigator);
            this.Name = "RegistrationForm4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Page 4";
            this.Load += new System.EventHandler(this.RegistrationForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingNavigator)).EndInit();
            this.membershipBindingNavigator.ResumeLayout(false);
            this.membershipBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membership_FeesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_YearsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private Project2DataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private Project2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membershipBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton membershipBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.NumericUpDown membership_FeesNumericUpDown;
        private System.Windows.Forms.NumericUpDown membership_YearsNumericUpDown;
        private System.Windows.Forms.DateTimePicker membership_DateDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}