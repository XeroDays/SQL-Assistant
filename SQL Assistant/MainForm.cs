using SQL_Assistant.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Assistant
{
    public partial class MainForm : Form
    {
        int movX, movY;
        bool isMoving;

        public MainForm()
        {
            InitializeComponent();
        }

        private void init_Form()
        {
            cmbDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabaseToAdd.DropDownStyle = ComboBoxStyle.DropDownList;

            sysController.addDataTypes(cmbDataType);
            addNewField();
            dbController.createTxtFile();
            //updateTableNames();
            updateDAtabasesComboBox();

        }

         

        #region Methods

        private void addNewField()
        {
            txtFieldName.Text = "";
            cmbDataType.SelectedIndex = -1;
            txtLimit.Text = "";
            txtLimit.Enabled = false;
        }

        private string collectFieldDate()
        {
            string data = "";
            data += getFieldName() + ":" + getDataType();
            return data;
        }

        private string getFieldName()
        {
            string data = "";
            foreach (char item in txtFieldName.Text)
            {
                if (item != ' ')
                {
                    data += item;
                }
            }
            return data;
        }

        private string getDataType()
        {
            string type = "";
            if (txtLimit.Enabled)
            {
                if (cmbDataType.SelectedItem.ToString().Contains("Double"))
                {
                    type += cmbDataType.SelectedItem.ToString() + "(" + txtLimit.Text + ",3)";
                }
                else
                {
                    type += cmbDataType.SelectedItem.ToString() + "(" + txtLimit.Text + ")";
                }
                
            }
            else
            {
                type += cmbDataType.SelectedItem.ToString();
            }
            return type;
        }
        
        private void addNewTable()
        {
            txtTableName.Text = "";
            addNewField();
            clearListBOx();
        }

        private string collectAllDate()
        {
            string data = "";

            data += getTableName();
            foreach (string item in listBoxFields.Items)
            {
                data += ":" + item;
            }

            return data;
        }

        private string getTableName()
        {
            string data = "";
            foreach (char item in txtTableName.Text)
            {
                if (item != ' ')
                {
                    data += item;
                }
            }
            return data;
        }
        
        private void updateListOnTablename(string tableName,string databaseFile)
        {
            clearListBOx();
            if (dbController.isTableAlreadyExist(tableName, databaseFile))
            {
                string[] data = dbController.getDataOnTableName(tableName, databaseFile).Split(':');
                for (int i = 1; i < data.Length; i += 2)
                {
                    listBoxFields.Items.Add(data[i] + ":" + data[i + 1]);
                }
            }
            else
            {
                clearListBOx();
            }
        }

        private void clearListBOx()
        {
            listBoxFields.Items.Clear();
        }
        
        private bool addingValidation()
        {
            if (txtFieldName.Text == string.Empty)
            {
                txtFieldName.Focus();
                MessageBox.Show("Enter Field Name Please.");
                return false;
            }
            if (cmbDataType.SelectedIndex == -1)
            {

                MessageBox.Show("Please Select DateType for This Field.");
                cmbDataType.DroppedDown = true;
                return false;
            }
            if (txtLimit.Enabled && txtLimit.Text == string.Empty)
            {
                MessageBox.Show("Enter Add Total number of Characters");
                txtLimit.Focus();
                return false;
            }
            int test;
            if (txtLimit.Enabled && !int.TryParse(txtLimit.Text, out test))
            {
                MessageBox.Show("Please Enter A Valid Number in limits");
                txtLimit.Focus();
                return false;
            }

            return true;
        }
        


        private void updateTableNames(string dbNames)
        {
            cmbTableNames.Items.Clear();
            foreach (string tblName in dbController.getTableNames(dbNames))
            {
                cmbTableNames.Items.Add(tblName);
            }
        }

        private void updateDAtabasesComboBox()
        {
            cmbDatabases.Items.Clear();
            cmbDatabaseToAdd.Items.Clear();
            foreach (string database in dbController.getDatabases())
            {
                cmbDatabaseToAdd.Items.Add(database);
                cmbDatabases.Items.Add(database);
            }
        }

        #endregion

        #region Events


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            init_Form();
        }

        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDataType.SelectedIndex == -1)
            {
                txtLimit.Enabled = false;
                return;
            }

            if (cmbDataType.SelectedItem.ToString() == "nvarchar" || cmbDataType.SelectedItem.ToString() == "decimal")
            {
                txtLimit.Enabled = true;
            }
            else
            {
                txtLimit.Enabled = false;
            }
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addNewField();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addingValidation())
            {
                sysController.addItemToList(listBoxFields, collectFieldDate());
                addNewField();
                txtFieldName.Focus();
            }

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dbController.isTableAlreadyExist(getTableName(),cmbDatabaseToAdd.SelectedItem.ToString()))
            {
                dbController.addExistedTable(getTableName(), collectAllDate(),cmbDatabaseToAdd.SelectedItem.ToString());
            }
            else
            {
                dbController.addNewTable(collectAllDate(), cmbDatabaseToAdd.SelectedItem.ToString());
            }

            MessageBox.Show("Table Successfully Added!");
            addNewTable();
            updateTableNames(cmbDatabaseToAdd.SelectedItem.ToString());

        }

        private void cmbDataType_Enter(object sender, EventArgs e)
        {
            cmbDataType.DroppedDown = true;
        }

        private void txtTableName_Leave(object sender, EventArgs e)
        {
            if (cmbDatabaseToAdd.SelectedItem != null || cmbDatabaseToAdd.SelectedIndex != -1)
            {
                 updateListOnTablename(getTableName(),cmbDatabaseToAdd.SelectedItem.ToString());
            }
          
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            addNewTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFields.SelectedIndex != -1)
            {
                listBoxFields.Items.RemoveAt(listBoxFields.SelectedIndex);
            }



        }

        private void cmbTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTableName.Text = cmbTableNames.SelectedItem.ToString();
            updateListOnTablename(getTableName(),cmbDatabases.SelectedItem.ToString());

        }
        
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_CreateTable(dbController.getDataOnTableName(getTableName(),cmbDatabases.SelectedItem.ToString())));

        }

        private void btnMetaData_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_MetaData(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));

        }

        private void btnInsertProc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_Insert_Proc(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));

        }

        private void btnUpdateWithID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_UpdateWithID_Proc(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));

        }

        private void btnGetRecordWithId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_GetRecordWithID_Proc(getTableName()));

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutUsForm obj = new AboutUsForm();
            obj.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_createObjectCode(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_loadFormWithData(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));
        }



        private void btnAddDatabase_Click(object sender, EventArgs e)
        {
            dbController.createDatabase(txtDatabaseNew.Text.Trim());
            updateDAtabasesComboBox();
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            updateTableNames(cmbDatabases.SelectedItem.ToString());
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            DataGird_Main obj = new DataGird_Main();
            obj.ShowDialog();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            string GetText = Clipboard.GetText(); 
            string[] lines = GetText.Split('\n');
            string export = "";
            foreach (string line in lines)
            { 
                string[] dividedbyEqual = line.Split('=');
                if (dividedbyEqual.Length==2)
                {
                    export += cleanTerminator(dividedbyEqual[1]) + " = " + dividedbyEqual[0] + ";\n";
                }
              
            }
            Clipboard.SetText(export);
        }

        private string cleanTerminator(string stringWithTerminator)
	    {
            string joinUp = "";
            for (int i = stringWithTerminator.Length-1; 0 < stringWithTerminator.Length; i--)
            {
                if (stringWithTerminator[i]==';')
                {
                    for (int z = 0; z < i; z++)
                    {
                        joinUp += stringWithTerminator[z];
                       
                    }
                    return joinUp;
                }
            }

            return null;
	    }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataController.get_ResetFormDate(dbController.getDataOnTableName(getTableName(), cmbDatabases.SelectedItem.ToString())));
        }
        #endregion

    }


}
