namespace SQL_Assistant.DataGrid
{
    partial class DataGird_Main
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
            this.txtSQLQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.listColumns = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddColumns = new System.Windows.Forms.Button();
            this.btnUpdateDataGrid = new System.Windows.Forms.Button();
            this.btnGetColumns = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.txtColumnToAdd = new System.Windows.Forms.TextBox();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddRowToGrid = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSQLQuery
            // 
            this.txtSQLQuery.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLQuery.Location = new System.Drawing.Point(24, 38);
            this.txtSQLQuery.Name = "txtSQLQuery";
            this.txtSQLQuery.Size = new System.Drawing.Size(588, 29);
            this.txtSQLQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paste SQL String HERE";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(615, 38);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 29);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // listColumns
            // 
            this.listColumns.FormattingEnabled = true;
            this.listColumns.Location = new System.Drawing.Point(24, 115);
            this.listColumns.Name = "listColumns";
            this.listColumns.Size = new System.Drawing.Size(141, 173);
            this.listColumns.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddColumns
            // 
            this.btnAddColumns.Location = new System.Drawing.Point(9, 39);
            this.btnAddColumns.Name = "btnAddColumns";
            this.btnAddColumns.Size = new System.Drawing.Size(111, 35);
            this.btnAddColumns.TabIndex = 4;
            this.btnAddColumns.Text = "Add Columns";
            this.btnAddColumns.UseVisualStyleBackColor = true;
            this.btnAddColumns.Click += new System.EventHandler(this.btnAddColumns_Click);
            // 
            // btnUpdateDataGrid
            // 
            this.btnUpdateDataGrid.Location = new System.Drawing.Point(126, 39);
            this.btnUpdateDataGrid.Name = "btnUpdateDataGrid";
            this.btnUpdateDataGrid.Size = new System.Drawing.Size(124, 35);
            this.btnUpdateDataGrid.TabIndex = 4;
            this.btnUpdateDataGrid.Text = "Update Rows To Grid";
            this.btnUpdateDataGrid.UseVisualStyleBackColor = true;
            this.btnUpdateDataGrid.Click += new System.EventHandler(this.btnUpdateDataGrid_Click);
            // 
            // btnGetColumns
            // 
            this.btnGetColumns.Location = new System.Drawing.Point(24, 294);
            this.btnGetColumns.Name = "btnGetColumns";
            this.btnGetColumns.Size = new System.Drawing.Size(141, 35);
            this.btnGetColumns.TabIndex = 4;
            this.btnGetColumns.Text = "Get columns";
            this.btnGetColumns.UseVisualStyleBackColor = true;
            this.btnGetColumns.Click += new System.EventHandler(this.btnGetColumns_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnAddColumn);
            this.panel1.Controls.Add(this.txtColumnToAdd);
            this.panel1.Controls.Add(this.btnRemoveColumn);
            this.panel1.Location = new System.Drawing.Point(171, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 173);
            this.panel1.TabIndex = 5;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(6, 142);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(141, 26);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(6, 117);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(141, 26);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(6, 35);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(141, 35);
            this.btnAddColumn.TabIndex = 4;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // txtColumnToAdd
            // 
            this.txtColumnToAdd.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnToAdd.Location = new System.Drawing.Point(6, 8);
            this.txtColumnToAdd.Name = "txtColumnToAdd";
            this.txtColumnToAdd.Size = new System.Drawing.Size(141, 24);
            this.txtColumnToAdd.TabIndex = 0;
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Location = new System.Drawing.Point(6, 76);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(141, 35);
            this.btnRemoveColumn.TabIndex = 4;
            this.btnRemoveColumn.Text = "Remove Column";
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "All Columns";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddRowToGrid);
            this.panel2.Controls.Add(this.btnUpdateDataGrid);
            this.panel2.Controls.Add(this.btnAddColumns);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(332, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 200);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Controller";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddRowToGrid
            // 
            this.btnAddRowToGrid.Location = new System.Drawing.Point(256, 39);
            this.btnAddRowToGrid.Name = "btnAddRowToGrid";
            this.btnAddRowToGrid.Size = new System.Drawing.Size(97, 35);
            this.btnAddRowToGrid.TabIndex = 4;
            this.btnAddRowToGrid.Text = "Add Row Function";
            this.btnAddRowToGrid.UseVisualStyleBackColor = true;
            this.btnAddRowToGrid.Click += new System.EventHandler(this.btnAddRowToGrid_Click);
            // 
            // DataGird_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetColumns);
            this.Controls.Add(this.listColumns);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQLQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataGird_Main";
            this.Text = "DataGird_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQLQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ListBox listColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddColumns;
        private System.Windows.Forms.Button btnUpdateDataGrid;
        private System.Windows.Forms.Button btnGetColumns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnRemoveColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColumnToAdd;
        private System.Windows.Forms.Button btnAddRowToGrid;
    }
}