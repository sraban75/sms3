namespace SMS
{
    partial class StudentEntryUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(446, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "City";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.cityBindingSource;
            this.cityComboBox.DisplayMember = "Name";
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(446, 52);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(174, 21);
            this.cityComboBox.TabIndex = 2;
            this.cityComboBox.ValueMember = "Id";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(SMS.Models.City);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(446, 111);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(542, 111);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditButton});
            this.StudentGridView.Location = new System.Drawing.Point(310, 187);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(424, 150);
            this.StudentGridView.TabIndex = 5;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "Edit";
            this.EditButton.Name = "EditButton";
            this.EditButton.Text = "Edit";
            // 
            // OpenCourseButton
            // 
            this.OpenCourseButton.Location = new System.Drawing.Point(130, 111);
            this.OpenCourseButton.Name = "OpenCourseButton";
            this.OpenCourseButton.Size = new System.Drawing.Size(75, 23);
            this.OpenCourseButton.TabIndex = 3;
            this.OpenCourseButton.Text = "Course";
            this.OpenCourseButton.UseVisualStyleBackColor = true;
            this.OpenCourseButton.Click += new System.EventHandler(this.OpenCourseButton_Click);
            // 
            // StudentEntryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 427);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.OpenCourseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentEntryUi";
            this.Text = "Student Entry Form";
            this.Load += new System.EventHandler(this.StudentEntryUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.Button OpenCourseButton;
    }
}

