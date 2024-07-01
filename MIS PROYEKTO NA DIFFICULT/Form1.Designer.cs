namespace MIS_PROYEKTO_NA_DIFFICULT
{
    partial class Form1
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.idLbl = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.BdayLbl = new System.Windows.Forms.Label();
            this.sexLbl = new System.Windows.Forms.Label();
            this.fulltimeLbl = new System.Windows.Forms.Label();
            this.fulltimeCheckbox = new System.Windows.Forms.CheckBox();
            this.BdayBox = new System.Windows.Forms.DateTimePicker();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.employeeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ListDataSet = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSet();
            this.employee_ListTableAdapter = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSetTableAdapters.Employee_ListTableAdapter();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullTimeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.employee_ListDataSet1 = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSet1();
            this.employeeListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ListTableAdapter1 = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSet1TableAdapters.Employee_ListTableAdapter();
            this.employee_ListDataSet2 = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSet2();
            this.employeeListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_ListTableAdapter2 = new MIS_PROYEKTO_NA_DIFFICULT.Employee_ListDataSet2TableAdapters.Employee_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AutoGenerateColumns = false;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.fullTimeDataGridViewCheckBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvEmployeeList.DataSource = this.employeeListBindingSource2;
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(520, 501);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellContentClick);
            this.dgvEmployeeList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellEnter);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(565, 169);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(67, 13);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "Employee ID";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(642, 166);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(112, 20);
            this.idBox.TabIndex = 2;
            this.idBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(642, 192);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(112, 20);
            this.LNameBox.TabIndex = 4;
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Location = new System.Drawing.Point(565, 195);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(58, 13);
            this.LNameLbl.TabIndex = 3;
            this.LNameLbl.Text = "Last Name";
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(642, 218);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(112, 20);
            this.FNameBox.TabIndex = 6;
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Location = new System.Drawing.Point(565, 221);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FNameLbl.TabIndex = 5;
            this.FNameLbl.Text = "First Name";
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(643, 244);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(112, 20);
            this.positionBox.TabIndex = 8;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(565, 247);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(44, 13);
            this.positionLbl.TabIndex = 7;
            this.positionLbl.Text = "Position";
            // 
            // BdayLbl
            // 
            this.BdayLbl.AutoSize = true;
            this.BdayLbl.Location = new System.Drawing.Point(565, 273);
            this.BdayLbl.Name = "BdayLbl";
            this.BdayLbl.Size = new System.Drawing.Size(54, 13);
            this.BdayLbl.TabIndex = 9;
            this.BdayLbl.Text = "Birth Date";
            // 
            // sexLbl
            // 
            this.sexLbl.AutoSize = true;
            this.sexLbl.Location = new System.Drawing.Point(565, 299);
            this.sexLbl.Name = "sexLbl";
            this.sexLbl.Size = new System.Drawing.Size(25, 13);
            this.sexLbl.TabIndex = 11;
            this.sexLbl.Text = "Sex";
            // 
            // fulltimeLbl
            // 
            this.fulltimeLbl.AutoSize = true;
            this.fulltimeLbl.Location = new System.Drawing.Point(565, 325);
            this.fulltimeLbl.Name = "fulltimeLbl";
            this.fulltimeLbl.Size = new System.Drawing.Size(49, 13);
            this.fulltimeLbl.TabIndex = 14;
            this.fulltimeLbl.Text = "Full Time";
            // 
            // fulltimeCheckbox
            // 
            this.fulltimeCheckbox.AutoSize = true;
            this.fulltimeCheckbox.Location = new System.Drawing.Point(689, 322);
            this.fulltimeCheckbox.Name = "fulltimeCheckbox";
            this.fulltimeCheckbox.Size = new System.Drawing.Size(32, 17);
            this.fulltimeCheckbox.TabIndex = 15;
            this.fulltimeCheckbox.Text = "?";
            this.fulltimeCheckbox.UseVisualStyleBackColor = true;
            this.fulltimeCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BdayBox
            // 
            this.BdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BdayBox.Location = new System.Drawing.Point(643, 271);
            this.BdayBox.Name = "BdayBox";
            this.BdayBox.Size = new System.Drawing.Size(112, 20);
            this.BdayBox.TabIndex = 20;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(642, 106);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(163, 20);
            this.searchBox.TabIndex = 22;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(564, 109);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(41, 13);
            this.searchLbl.TabIndex = 21;
            this.searchLbl.Text = "Search";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(568, 364);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 25;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(649, 364);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(730, 364);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // employeeListBindingSource
            // 
            this.employeeListBindingSource.DataMember = "Employee List";
            this.employeeListBindingSource.DataSource = this.employee_ListDataSet;
            // 
            // employee_ListDataSet
            // 
            this.employee_ListDataSet.DataSetName = "Employee_ListDataSet";
            this.employee_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_ListTableAdapter
            // 
            this.employee_ListTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullTimeDataGridViewCheckBoxColumn
            // 
            this.fullTimeDataGridViewCheckBoxColumn.DataPropertyName = "Full Time";
            this.fullTimeDataGridViewCheckBoxColumn.HeaderText = "Full Time";
            this.fullTimeDataGridViewCheckBoxColumn.Name = "fullTimeDataGridViewCheckBoxColumn";
            this.fullTimeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(642, 296);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(112, 20);
            this.sexBox.TabIndex = 28;
            // 
            // employee_ListDataSet1
            // 
            this.employee_ListDataSet1.DataSetName = "Employee_ListDataSet1";
            this.employee_ListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeListBindingSource1
            // 
            this.employeeListBindingSource1.DataMember = "Employee_List";
            this.employeeListBindingSource1.DataSource = this.employee_ListDataSet1;
            // 
            // employee_ListTableAdapter1
            // 
            this.employee_ListTableAdapter1.ClearBeforeFill = true;
            // 
            // employee_ListDataSet2
            // 
            this.employee_ListDataSet2.DataSetName = "Employee_ListDataSet2";
            this.employee_ListDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeListBindingSource2
            // 
            this.employeeListBindingSource2.DataMember = "Employee_List";
            this.employeeListBindingSource2.DataSource = this.employee_ListDataSet2;
            // 
            // employee_ListTableAdapter2
            // 
            this.employee_ListTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 525);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.BdayBox);
            this.Controls.Add(this.fulltimeCheckbox);
            this.Controls.Add(this.fulltimeLbl);
            this.Controls.Add(this.sexLbl);
            this.Controls.Add(this.BdayLbl);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.FNameLbl);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.LNameLbl);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.dgvEmployeeList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_ListDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private Employee_ListDataSet employee_ListDataSet;
        private System.Windows.Forms.BindingSource employeeListBindingSource;
        private Employee_ListDataSetTableAdapters.Employee_ListTableAdapter employee_ListTableAdapter;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label BdayLbl;
        private System.Windows.Forms.Label sexLbl;
        private System.Windows.Forms.Label fulltimeLbl;
        private System.Windows.Forms.CheckBox fulltimeCheckbox;
        private System.Windows.Forms.DateTimePicker BdayBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fullTimeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox sexBox;
        private Employee_ListDataSet1 employee_ListDataSet1;
        private System.Windows.Forms.BindingSource employeeListBindingSource1;
        private Employee_ListDataSet1TableAdapters.Employee_ListTableAdapter employee_ListTableAdapter1;
        private Employee_ListDataSet2 employee_ListDataSet2;
        private System.Windows.Forms.BindingSource employeeListBindingSource2;
        private Employee_ListDataSet2TableAdapters.Employee_ListTableAdapter employee_ListTableAdapter2;
    }
}

