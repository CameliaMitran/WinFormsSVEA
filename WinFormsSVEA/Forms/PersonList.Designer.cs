namespace WinFormsSVEA
{
    partial class PersonListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridPerson = new System.Windows.Forms.DataGridView();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPerson
            // 
            this.GridPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPerson.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPerson.GridColor = System.Drawing.Color.White;
            this.GridPerson.Location = new System.Drawing.Point(12, 21);
            this.GridPerson.MultiSelect = false;
            this.GridPerson.Name = "GridPerson";
            this.GridPerson.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.GridPerson.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPerson.Size = new System.Drawing.Size(477, 288);
            this.GridPerson.TabIndex = 0;
            this.GridPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPerson_CellContentClick);
            this.GridPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPerson_CellDoubleClick);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(166, 326);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(115, 31);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(574, 228);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 18;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(513, 167);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 17;
            this.DepartmentLabel.Text = "Department";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(513, 117);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(54, 13);
            this.BirthDateLabel.TabIndex = 16;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(513, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Name";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(513, 21);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 14;
            this.IdLabel.Text = "ID";
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Items.AddRange(new object[] {
            "HR",
            "Dev",
            "QA"});
            this.comboDept.Location = new System.Drawing.Point(516, 183);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(200, 21);
            this.comboDept.TabIndex = 13;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(516, 133);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(516, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(516, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 10;
            // 
            // PersonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 382);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.GridPerson);
            this.Name = "PersonListForm";
            this.Text = "PersonsList";
            this.Load += new System.EventHandler(this.PersonListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProcessButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.DataGridView GridPerson;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.ComboBox comboDept;
        public System.Windows.Forms.DateTimePicker datePicker;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtID;
    }
}

