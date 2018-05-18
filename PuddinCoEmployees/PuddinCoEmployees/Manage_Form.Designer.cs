namespace PuddinCoEmployees
{
    partial class Manage_Form
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
            this.dataGrid_employeeInfo = new System.Windows.Forms.DataGridView();
            this.puddingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeinformationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pudding_EmployeesDataSet = new PuddinCoEmployees.Pudding_EmployeesDataSet();
            this.employeeinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pudding_Employees_DataSet = new PuddinCoEmployees.Pudding_Employees_DataSet();
            this.textBox_puddingID = new System.Windows.Forms.TextBox();
            this.label_puddingID = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_firstname = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label_lastname = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_hireDate = new System.Windows.Forms.TextBox();
            this.label_hireDate = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.toolTip_btns = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.employee_informationTableAdapter = new PuddinCoEmployees.Pudding_Employees_DataSetTableAdapters.employee_informationTableAdapter();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.employee_informationTableAdapter1 = new PuddinCoEmployees.Pudding_EmployeesDataSetTableAdapters.employee_informationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinformationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_EmployeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_Employees_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_employeeInfo
            // 
            this.dataGrid_employeeInfo.AllowUserToDeleteRows = false;
            this.dataGrid_employeeInfo.AllowUserToResizeRows = false;
            this.dataGrid_employeeInfo.AutoGenerateColumns = false;
            this.dataGrid_employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_employeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.puddingIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGrid_employeeInfo.DataSource = this.employeeinformationBindingSource1;
            this.dataGrid_employeeInfo.Location = new System.Drawing.Point(23, 173);
            this.dataGrid_employeeInfo.Name = "dataGrid_employeeInfo";
            this.dataGrid_employeeInfo.RowTemplate.Height = 24;
            this.dataGrid_employeeInfo.Size = new System.Drawing.Size(979, 548);
            this.dataGrid_employeeInfo.TabIndex = 0;
            this.dataGrid_employeeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_employeeInfo_CellContentClick);
            // 
            // puddingIDDataGridViewTextBoxColumn
            // 
            this.puddingIDDataGridViewTextBoxColumn.DataPropertyName = "PuddingID";
            this.puddingIDDataGridViewTextBoxColumn.HeaderText = "PuddingID";
            this.puddingIDDataGridViewTextBoxColumn.Name = "puddingIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // employeeinformationBindingSource1
            // 
            this.employeeinformationBindingSource1.DataMember = "employee_information";
            this.employeeinformationBindingSource1.DataSource = this.pudding_EmployeesDataSet;
            // 
            // pudding_EmployeesDataSet
            // 
            this.pudding_EmployeesDataSet.DataSetName = "Pudding_EmployeesDataSet";
            this.pudding_EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeinformationBindingSource
            // 
            this.employeeinformationBindingSource.DataMember = "employee_information";
            this.employeeinformationBindingSource.DataSource = this.pudding_Employees_DataSet;
            // 
            // pudding_Employees_DataSet
            // 
            this.pudding_Employees_DataSet.DataSetName = "Pudding_Employees_DataSet";
            this.pudding_Employees_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_puddingID
            // 
            this.textBox_puddingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_puddingID.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_puddingID.Location = new System.Drawing.Point(1176, 173);
            this.textBox_puddingID.Name = "textBox_puddingID";
            this.textBox_puddingID.Size = new System.Drawing.Size(372, 59);
            this.textBox_puddingID.TabIndex = 20;
            this.textBox_puddingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_puddingID
            // 
            this.label_puddingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_puddingID.AutoSize = true;
            this.label_puddingID.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puddingID.ForeColor = System.Drawing.Color.MistyRose;
            this.label_puddingID.Location = new System.Drawing.Point(1020, 173);
            this.label_puddingID.Name = "label_puddingID";
            this.label_puddingID.Size = new System.Drawing.Size(157, 57);
            this.label_puddingID.TabIndex = 19;
            this.label_puddingID.Text = "Pudding ID:";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_firstName.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstName.Location = new System.Drawing.Point(1176, 255);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(372, 59);
            this.textBox_firstName.TabIndex = 22;
            this.textBox_firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_firstname
            // 
            this.label_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.ForeColor = System.Drawing.Color.MistyRose;
            this.label_firstname.Location = new System.Drawing.Point(1020, 255);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(155, 57);
            this.label_firstname.TabIndex = 21;
            this.label_firstname.Text = "First Name:";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_lastname.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(1176, 335);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(372, 59);
            this.textBox_lastname.TabIndex = 24;
            this.textBox_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_lastname
            // 
            this.label_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.ForeColor = System.Drawing.Color.MistyRose;
            this.label_lastname.Location = new System.Drawing.Point(1020, 335);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(152, 57);
            this.label_lastname.TabIndex = 23;
            this.label_lastname.Text = "Last Name:";
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_email.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(1176, 413);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(372, 59);
            this.textBox_email.TabIndex = 26;
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.MistyRose;
            this.label_email.Location = new System.Drawing.Point(1068, 416);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(102, 57);
            this.label_email.TabIndex = 25;
            this.label_email.Text = "E-mail:";
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_title.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(1176, 492);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(372, 59);
            this.textBox_title.TabIndex = 28;
            this.textBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.MistyRose;
            this.label_title.Location = new System.Drawing.Point(1089, 495);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(80, 57);
            this.label_title.TabIndex = 27;
            this.label_title.Text = "Title:";
            // 
            // textBox_hireDate
            // 
            this.textBox_hireDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hireDate.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hireDate.Location = new System.Drawing.Point(1176, 571);
            this.textBox_hireDate.Name = "textBox_hireDate";
            this.textBox_hireDate.Size = new System.Drawing.Size(372, 59);
            this.textBox_hireDate.TabIndex = 30;
            this.textBox_hireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_hireDate
            // 
            this.label_hireDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_hireDate.AutoSize = true;
            this.label_hireDate.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hireDate.ForeColor = System.Drawing.Color.MistyRose;
            this.label_hireDate.Location = new System.Drawing.Point(1036, 574);
            this.label_hireDate.Name = "label_hireDate";
            this.label_hireDate.Size = new System.Drawing.Size(136, 57);
            this.label_hireDate.TabIndex = 29;
            this.label_hireDate.Text = "Hire Date:";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_salary.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_salary.Location = new System.Drawing.Point(1176, 651);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(372, 59);
            this.textBox_salary.TabIndex = 35;
            this.textBox_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_salary
            // 
            this.label_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.ForeColor = System.Drawing.Color.MistyRose;
            this.label_salary.Location = new System.Drawing.Point(1067, 654);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(104, 57);
            this.label_salary.TabIndex = 34;
            this.label_salary.Text = "Salary:";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_search.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(292, 727);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(437, 59);
            this.textBox_search.TabIndex = 37;
            this.textBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_search
            // 
            this.label_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.MistyRose;
            this.label_search.Location = new System.Drawing.Point(184, 730);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(106, 57);
            this.label_search.TabIndex = 36;
            this.label_search.Text = "Search";
            // 
            // toolTip_btns
            // 
            this.toolTip_btns.AutomaticDelay = 750;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.trash;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(1458, 774);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 65);
            this.btn_delete.TabIndex = 40;
            this.toolTip_btns.SetToolTip(this.btn_delete, "Delete Employee");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addEmployee.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_addEmployee.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.social;
            this.btn_addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_addEmployee.FlatAppearance.BorderSize = 0;
            this.btn_addEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_addEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Location = new System.Drawing.Point(1176, 774);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(90, 65);
            this.btn_addEmployee.TabIndex = 39;
            this.toolTip_btns.SetToolTip(this.btn_addEmployee, "Add Employee");
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancel.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.cancel;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(1317, 861);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 65);
            this.btn_cancel.TabIndex = 33;
            this.toolTip_btns.SetToolTip(this.btn_cancel, "Cancel");
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.diskette;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(1176, 774);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 65);
            this.btn_save.TabIndex = 32;
            this.toolTip_btns.SetToolTip(this.btn_save, "Save Changes");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_edit.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.writing;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(1317, 774);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 65);
            this.btn_edit.TabIndex = 31;
            this.toolTip_btns.SetToolTip(this.btn_edit, "Edit Information");
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.left_arrow;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(23, 87);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 80);
            this.btn_back.TabIndex = 41;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.search_interface_symbol;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(735, 727);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 61);
            this.btn_search.TabIndex = 38;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // employee_informationTableAdapter
            // 
            this.employee_informationTableAdapter.ClearBeforeFill = true;
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.SystemColors.Control;
            this.btn_showAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_showAll.FlatAppearance.BorderSize = 2;
            this.btn_showAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_showAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showAll.Font = new System.Drawing.Font("Steelfish Rg", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_showAll.Location = new System.Drawing.Point(824, 122);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(178, 45);
            this.btn_showAll.TabIndex = 42;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // employee_informationTableAdapter1
            // 
            this.employee_informationTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Steelfish Rg", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(526, 789);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search By: ID, Name, or Title";
            // 
            // Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 1010);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox_hireDate);
            this.Controls.Add(this.label_hireDate);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.textBox_puddingID);
            this.Controls.Add(this.label_puddingID);
            this.Controls.Add(this.dataGrid_employeeInfo);
            this.Name = "Manage_Form";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Manage Employees";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manage_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinformationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_EmployeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_Employees_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_employeeInfo;
        private System.Windows.Forms.TextBox textBox_puddingID;
        private System.Windows.Forms.Label label_puddingID;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_hireDate;
        private System.Windows.Forms.Label label_hireDate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolTip toolTip_btns;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private Pudding_Employees_DataSet pudding_Employees_DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn puddingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeinformationBindingSource;
        private Pudding_Employees_DataSetTableAdapters.employee_informationTableAdapter employee_informationTableAdapter;
        private System.Windows.Forms.Button btn_showAll;
        private Pudding_EmployeesDataSet pudding_EmployeesDataSet;
        private System.Windows.Forms.BindingSource employeeinformationBindingSource1;
        private Pudding_EmployeesDataSetTableAdapters.employee_informationTableAdapter employee_informationTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}