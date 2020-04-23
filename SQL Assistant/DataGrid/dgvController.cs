using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assistant.DataGrid
{
    public class dgvController
    {
        public static List<string> getNamesFromSQL(string sqlQuery)
        {
            // EXampe SQL SQURY :    select id,name, Code,Email from Supplier

            List<string> myList = new List<string>();
            int fromIndex= getFromIndex(sqlQuery);
            if (fromIndex <0)
            {
                return null;
            }

            string sqlColumnsAll = sqlQuery.Substring(7, fromIndex);  // This wil Get the Middle Part (Columns) of the SQL Example :  id,name, Code,Email

            string[] sqlColumn = sqlColumnsAll.Split(',');
            int TotalColumns = sqlColumn.Length;
            
            foreach (string column in sqlColumn)
            {
                string refined = column.Trim();

                refined = refined.Split('.').Last();
                Console.WriteLine(refined);
                if (refined.Contains("as"))
                {
                    refined = refined.Replace(" ", "");
                    refined = refined.Split('\'').Last();

                }

                myList.Add(refined);
            }
           
        
            return myList;
        }

        private static int getFromIndex(string sqlQuery)
        {
            int index = sqlQuery.ToLower().IndexOf("from");
            return index - 7;
        }


        public static string getCode_ColumnsAdding(List<string> listdata)
        {
            string code = "";

            foreach (string columnName in listdata)
            {
                code += "            dgvDataGrid.Columns.Add(\"" + columnName + "\", \"" + columnName + "\");";
                code += Environment.NewLine;
            }

            return code;
        }

        public static string getCode_UpdateDataGrid(List<string> listdata)
        {
            string code = "";
            string allColumnsWithComma = "";
            code += "            foreach (DataRow row in tbl.Rows)\n            {";
            foreach (string columnName in listdata)
            {
                code += "                string " + columnName+ "= row[\""+columnName+"\"].ToString();";
                code += Environment.NewLine;
                allColumnsWithComma += columnName + ", ";
            }
            code += "            addRowToGrid(" + allColumnsWithComma.Substring(0,allColumnsWithComma.Length - 2) + ");\n";
            code += "            }";
            
            return code;
        }


       

        public static string getCode_AddRowToGrid(List<string> listdata)
        {
            string code = "";
            string allColumnsWithComma = "";
            code += "        private void addRowToGrid(";
            foreach (string columnName in listdata)
            {
                code += "string " + columnName + ", ";
                allColumnsWithComma += columnName + ", ";
            }
            code = code.Substring(0,code.Length - 2);
            code += ")\n        {";

            code += "dgvDataGrid.Rows.Add(" + allColumnsWithComma.Substring(0,allColumnsWithComma.Length - 2) + ");\n";
            code += "        }";
            return code;
        }
    }
}
