namespace SQL_Assistant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsertProc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateWithID = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnGetRecordWithId = new System.Windows.Forms.Button();
            this.btnMetaData = new System.Windows.Forms.Button();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.cmbTableNames = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddDatabase = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.cmbDatabaseToAdd = new System.Windows.Forms.ComboBox();
            this.listBoxFields = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatbaseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtDatabaseNew = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(950, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Assistant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInsertProc);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnUpdateWithID);
            this.panel1.Controls.Add(this.btnCreateTable);
            this.panel1.Controls.Add(this.btnGetRecordWithId);
            this.panel1.Controls.Add(this.btnMetaData);
            this.panel1.Controls.Add(this.cmbDatabases);
            this.panel1.Controls.Add(this.cmbTableNames);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(531, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 441);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRevert);
            this.panel3.Controls.Add(this.btnDataGrid);
            this.panel3.Location = new System.Drawing.Point(10, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 100);
            this.panel3.TabIndex = 14;
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Location = new System.Drawing.Point(6, 3);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(120, 35);
            this.btnDataGrid.TabIndex = 13;
            this.btnDataGrid.Text = "Data Grid Manager";
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.btnDataGrid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "Create Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertProc
            // 
            this.btnInsertProc.Location = new System.Drawing.Point(256, 140);
            this.btnInsertProc.Name = "btnInsertProc";
            this.btnInsertProc.Size = new System.Drawing.Size(121, 35);
            this.btnInsertProc.TabIndex = 13;
            this.btnInsertProc.TabStop = false;
            this.btnInsertProc.Text = "Insert proc";
            this.btnInsertProc.UseVisualStyleBackColor = true;
            this.btnInsertProc.Click += new System.EventHandler(this.btnInsertProc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(138, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 13;
            this.button2.TabStop = false;
            this.button2.Text = "Load Form With Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateWithID
            // 
            this.btnUpdateWithID.Location = new System.Drawing.Point(17, 181);
            this.btnUpdateWithID.Name = "btnUpdateWithID";
            this.btnUpdateWithID.Size = new System.Drawing.Size(120, 35);
            this.btnUpdateWithID.TabIndex = 13;
            this.btnUpdateWithID.TabStop = false;
            this.btnUpdateWithID.Text = "Update With ID";
            this.btnUpdateWithID.UseVisualStyleBackColor = true;
            this.btnUpdateWithID.Click += new System.EventHandler(this.btnUpdateWithID_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(17, 140);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(120, 35);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.TabStop = false;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnGetRecordWithId
            // 
            this.btnGetRecordWithId.Location = new System.Drawing.Point(135, 181);
            this.btnGetRecordWithId.Name = "btnGetRecordWithId";
            this.btnGetRecordWithId.Size = new System.Drawing.Size(123, 35);
            this.btnGetRecordWithId.TabIndex = 13;
            this.btnGetRecordWithId.TabStop = false;
            this.btnGetRecordWithId.Text = "Get Record on ID";
            this.btnGetRecordWithId.UseVisualStyleBackColor = true;
            this.btnGetRecordWithId.Click += new System.EventHandler(this.btnGetRecordWithId_Click);
            // 
            // btnMetaData
            // 
            this.btnMetaData.Location = new System.Drawing.Point(135, 140);
            this.btnMetaData.Name = "btnMetaData";
            this.btnMetaData.Size = new System.Drawing.Size(123, 35);
            this.btnMetaData.TabIndex = 13;
            this.btnMetaData.TabStop = false;
            this.btnMetaData.Text = "Meta Data";
            this.btnMetaData.UseVisualStyleBackColor = true;
            this.btnMetaData.Click += new System.EventHandler(this.btnMetaData_Click);
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(147, 46);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(219, 26);
            this.cmbDatabases.TabIndex = 12;
            this.cmbDatabases.TabStop = false;
            this.cmbDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbDatabases_SelectedIndexChanged);
            // 
            // cmbTableNames
            // 
            this.cmbTableNames.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableNames.FormattingEnabled = true;
            this.cmbTableNames.Location = new System.Drawing.Point(114, 80);
            this.cmbTableNames.Name = "cmbTableNames";
            this.cmbTableNames.Size = new System.Drawing.Size(252, 26);
            this.cmbTableNames.TabIndex = 12;
            this.cmbTableNames.TabStop = false;
            this.cmbTableNames.SelectedIndexChanged += new System.EventHandler(this.cmbTableNames_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Database Name";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Get Source Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Table Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnAddDatabase);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnTable);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.cmbDataType);
            this.panel2.Controls.Add(this.cmbDatabaseToAdd);
            this.panel2.Controls.Add(this.listBoxFields);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblDatbaseName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLimit);
            this.panel2.Controls.Add(this.txtFieldName);
            this.panel2.Controls.Add(this.txtDatabaseNew);
            this.panel2.Controls.Add(this.txtTableName);
            this.panel2.Location = new System.Drawing.Point(15, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 441);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add Table";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(154, 217);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 32);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddDatabase
            // 
            this.btnAddDatabase.Location = new System.Drawing.Point(219, 380);
            this.btnAddDatabase.Name = "btnAddDatabase";
            this.btnAddDatabase.Size = new System.Drawing.Size(48, 23);
            this.btnAddDatabase.TabIndex = 0;
            this.btnAddDatabase.TabStop = false;
            this.btnAddDatabase.Text = "Add";
            this.btnAddDatabase.UseVisualStyleBackColor = true;
            this.btnAddDatabase.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(418, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 21);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(61, 228);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(87, 21);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "New Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(116, 164);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbDataType
            // 
            this.cmbDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(68, 123);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(124, 21);
            this.cmbDataType.TabIndex = 2;
            this.cmbDataType.SelectedIndexChanged += new System.EventHandler(this.cmbDataType_SelectedIndexChanged);
            this.cmbDataType.Enter += new System.EventHandler(this.cmbDataType_Enter);
            // 
            // cmbDatabaseToAdd
            // 
            this.cmbDatabaseToAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabaseToAdd.FormattingEnabled = true;
            this.cmbDatabaseToAdd.Location = new System.Drawing.Point(93, 46);
            this.cmbDatabaseToAdd.Name = "cmbDatabaseToAdd";
            this.cmbDatabaseToAdd.Size = new System.Drawing.Size(174, 26);
            this.cmbDatabaseToAdd.TabIndex = 12;
            // 
            // listBoxFields
            // 
            this.listBoxFields.FormattingEnabled = true;
            this.listBoxFields.Location = new System.Drawing.Point(272, 47);
            this.listBoxFields.Name = "listBoxFields";
            this.listBoxFields.Size = new System.Drawing.Size(233, 355);
            this.listBoxFields.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Database :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Field Name";
            // 
            // lblDatbaseName
            // 
            this.lblDatbaseName.AutoSize = true;
            this.lblDatbaseName.Location = new System.Drawing.Point(3, 386);
            this.lblDatbaseName.Name = "lblDatbaseName";
            this.lblDatbaseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatbaseName.TabIndex = 1;
            this.lblDatbaseName.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table Name";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimit.Location = new System.Drawing.Point(192, 123);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(74, 21);
            this.txtLimit.TabIndex = 3;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldName.Location = new System.Drawing.Point(68, 101);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(198, 21);
            this.txtFieldName.TabIndex = 1;
            // 
            // txtDatabaseNew
            // 
            this.txtDatabaseNew.Location = new System.Drawing.Point(93, 382);
            this.txtDatabaseNew.Name = "txtDatabaseNew";
            this.txtDatabaseNew.Size = new System.Drawing.Size(120, 20);
            this.txtDatabaseNew.TabIndex = 0;
            this.txtDatabaseNew.TabStop = false;
            this.txtDatabaseNew.Leave += new System.EventHandler(this.txtTableName_Leave);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(72, 75);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(194, 20);
            this.txtTableName.TabIndex = 0;
            this.txtTableName.Leave += new System.EventHandler(this.txtTableName_Leave);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::SQL_Assistant.Properties.Resources.Boss;
            this.btnAbout.Location = new System.Drawing.Point(880, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(28, 27);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = " ";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SQL_Assistant.Properties.Resources.Delete;
            this.btnClose.Location = new System.Drawing.Point(912, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(127, 3);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(120, 35);
            this.btnRevert.TabIndex = 13;
            this.btnRevert.Text = "Revert on Equals";
            this.toolTip1.SetToolTip(this.btnRevert, "Get Data From Clipboard and Revert it on \'=\' and send back it to Clipboard");
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(950, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.ListBox listBoxFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTableNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertProc;
        private System.Windows.Forms.Button btnUpdateWithID;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnGetRecordWithId;
        private System.Windows.Forms.Button btnMetaData;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddDatabase;
        private System.Windows.Forms.Label lblDatbaseName;
        private System.Windows.Forms.TextBox txtDatabaseNew;
        private System.Windows.Forms.ComboBox cmbDatabaseToAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}