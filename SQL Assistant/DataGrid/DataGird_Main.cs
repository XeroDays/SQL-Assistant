using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Assistant.DataGrid
{
    public partial class DataGird_Main : Form
    {
        public DataGird_Main()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtSQLQuery.Text = Clipboard.GetText();
        }

        private void btnGetColumns_Click(object sender, EventArgs e)
        {
            if (!txtSQLQuery.Text.ToLower().Contains("select")  || !txtSQLQuery.Text.ToLower().Contains("from"))
            {
                return;
            }
          

            foreach (string item in dgvController.getNamesFromSQL(txtSQLQuery.Text))
            {
                if (item.Trim() != string.Empty)
                {
                    listColumns.Items.Add(item);
                }
              
            }

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string item = txtColumnToAdd.Text.Trim();

            if (item.Trim() != string.Empty)
            {
                listColumns.Items.Add(item);
            }

            txtColumnToAdd.Text = "";
            txtColumnToAdd.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.ActiveControl == txtColumnToAdd && (keyData == Keys.Return || keyData == Keys.Enter))
            {
                btnAddColumn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            listColumns.Items.RemoveAt(listColumns.SelectedIndex);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int selectedindex = listColumns.SelectedIndex;
            HashSet<KeyValuePair<int, object>> ItemsToMove = new HashSet<KeyValuePair<int, object>>();

            foreach (object o in listColumns.SelectedItems)
                ItemsToMove.Add(new KeyValuePair<int, object>(listColumns.Items.IndexOf(o), o));

            foreach (KeyValuePair<int, object> kvp in ItemsToMove)
            {
                if (kvp.Key > 0) // check if its the first item before moving
                {
                    listColumns.Items.Remove(kvp.Value);
                    listColumns.Items.Insert(kvp.Key - 1, kvp.Value);
                }
            }


            if (listColumns.SelectedIndex < 0 )
            {
                listColumns.SelectedIndex = selectedindex - 1;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int selectedindex = listColumns.SelectedIndex;
            HashSet<KeyValuePair<int, object>> ItemsToMove = new HashSet<KeyValuePair<int, object>>();

            foreach (object o in listColumns.SelectedItems)
                ItemsToMove.Add(new KeyValuePair<int, object>(listColumns.Items.IndexOf(o), o));

            foreach (KeyValuePair<int, object> kvp in ItemsToMove)
            {
                if (kvp.Key < listColumns.Items.Count - 1) // check if its the last item before moving
                {
                    listColumns.Items.Remove(kvp.Value);
                    listColumns.Items.Insert(kvp.Key + 1, kvp.Value);
                }
            }

            if (selectedindex +1 <listColumns.Items.Count)
            {
                listColumns.SelectedIndex = selectedindex + 1;
            }
            
        }



        private void btnAddColumns_Click(object sender, EventArgs e)
        {
            List<string> columns = new List<string>();

            columns = listColumns.Items.Cast<string>().ToList();
            string myCode = dgvController.getCode_ColumnsAdding(columns);

            Clipboard.SetText(myCode);
   
        }

        private void btnUpdateDataGrid_Click(object sender, EventArgs e)
        {
            List<string> columns = new List<string>();

            columns = listColumns.Items.Cast<string>().ToList();
            string myCode = dgvController.getCode_UpdateDataGrid(columns);

            Clipboard.SetText(myCode);
        }

        private void btnAddRowToGrid_Click(object sender, EventArgs e)
        {
            List<string> columns = new List<string>();

            columns = listColumns.Items.Cast<string>().ToList();
            string myCode = dgvController.getCode_AddRowToGrid(columns);

            Clipboard.SetText(myCode);
        }
    }
}
