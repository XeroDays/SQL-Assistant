using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Assistant
{
    class dataController
    {
        public static string get_CreateTable(string TableData)
        {
            string formattedString = "";
            string[] tblData = TableData.Split(':');
            formattedString += "create table " + tblData[0] + "\n(\n        ";

            for (int i = 1; i < tblData.Length; i+=2)
            {
                if (tblData[i]=="ID")
                {
                    formattedString += tblData[i] + " " + tblData[i + 1] + " Primary key identity";
                }
                else
                {
                    formattedString += tblData[i] + " " + tblData[i + 1];
                }

                if (i+2 != tblData.Length)
                {
                    formattedString += "," + "\n        ";
                }
        
            }

            formattedString += "\n)";

            return formattedString;
        }

        public static string get_MetaData(string TableData)
        {
            string[] data = TableData.Split(':');
            string formattedString = "\n    class " + data[0] + "_MetaData\n    {";
            for (int i = 1; i < data.Length; i+=2)
            {
                formattedString += "\n        ";
                if (data[i + 1].Contains("int"))
                {
                    formattedString += "public int " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("nvarchar"))
                {
                    formattedString += "public string " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("bit"))
                {
                    formattedString += "public bool " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("image"))
                {
                    formattedString += "public byte[] " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("datetime"))
                {
                    formattedString += "public DateTime " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("nvarchar"))
                {
                    formattedString += "public string " + data[i] + " { get; set; }";
                }
                else if (data[i + 1].Contains("decimal"))
                {
                    formattedString += "public decimal " + data[i] + " { get; set; }";
                }

            }

            formattedString += "\n    }";
            return formattedString;


        }

        public static string get_Insert_Proc(string TableData)
        {
            string[] data = TableData.Split(':');
            string SetToClipBoard = "public static string " + data[0] + "_AddRecord = \"" + data[0] + "_AddNewRecord\";";
            Clipboard.SetText(SetToClipBoard);
            
            string strng = "\ncreate proc " + data[0] + "_AddNewRecord\n(\n";
            for (int i = 1; i < data.Length; i += 2)
            {
                strng += "    @" + data[i] + " " + data[i + 1];
                if (i + 2 != data.Length)
                {
                    strng += ",\n";
                }
            }
            strng += ")\n AS\nBEGIN\n    INSERT INTO " + data[0] + "\n        (";
            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i] == "ID")
                {
                    continue;
                }
                strng += "[" + data[i] + "]";
                if (i + 2 != data.Length)
                {
                    strng += "," + "\n         ";
                }

            }
            strng += ")\n    VALUES\n        (";
            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i] == "ID")
                {
                    continue;
                }
                strng += "@" + data[i];
                if (i + 2 != data.Length)
                {
                    strng += "," + "\n         ";
                }
            }
            strng += ")\nEND";
            return strng;
        }

        public static string get_UpdateWithID_Proc(string TableData)
        {


            string[] data = TableData.Split(':');

            string SetToClipBoard = "public static string "+ data[0] + "_UpdateRecord = \"" + data[0] + "_UpdateWithID\";";
            Clipboard.SetText(SetToClipBoard);

            string strng = "\ncreate proc " + data[0] + "_UpdateWithID\n(\n";
            for (int i = 1; i < data.Length; i += 2)
            {
                strng += "    @" + data[i] + " " + data[i + 1];
                if (i + 2 != data.Length)
                {
                    strng += ",\n";
                }
            }
            strng += ")\n AS\nBEGIN\n    UPDATE " + data[0] + "\n    SET ";
            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i] == "ID")
                {
                    continue;
                }
                strng += "[" + data[i] + "] = @" + data[i];
                if (i + 2 != data.Length)
                {
                    strng += "\n       " + ",";
                }

            }

            strng += "\n        WHERE ID = @ID  \nEND";
            return strng;
        }

        public static string get_GetRecordWithID_Proc(string TableName)
        { 
            string strng = "\ncreate proc " + TableName + "_GetRecordWithID\n(\n";

            strng += "    @ID int\n";
               
           
            strng += ")\n AS\nBEGIN\n    SELECT * FROM " + TableName + " WHERE ID = @ID";
            strng += "\nEND";
            return strng;
        }

        public static string get_createObjectCode(string TableData)
        {
            string[] data = TableData.Split(':');
            string formattedString = "\n        " + data[0] + "_MetaData "+ data[0] + "_obj()\n        {";
            formattedString += "            "+ data[0] + "_MetaData obj = new " + data[0] + "_MetaData();";
            for (int i = 1; i < data.Length; i += 2)
            {
                formattedString += "\n            obj.";
                if (data[i + 1].Contains("int"))            // INT 
                {
                    if (data[i].Contains("added") || data[i].Contains("Added"))
                    {
                        formattedString += data[i] + " = dataController.UserID;";
                    }
                    else if (data[i] == "ID")
                    {
                        formattedString += data[i] + " = txtID.Text.Trim()==string.Empty? 0 :Convert.ToInt32(txt" + data[i] + ".Text);";
                    }
                    else
                    {
                        formattedString += data[i] + " = Convert.ToInt32(txt" + data[i] + ".Text);";
                    }
                    
                }
                else if (data[i + 1].Contains("nvarchar"))  // nvarchar
                {
                    formattedString += data[i] + " = txt" + data[i] + ".Text;";
                }
                else if (data[i + 1].Contains("bit"))    //bool bit
                {
                    formattedString += data[i] + " = (txt" + data[i] + ".Text == \"True\")?true:false;";
                }
                else if (data[i + 1].Contains("image"))   // image
                {
                    formattedString += data[i] + " = txtPictureBox.Image==txtPictureBox.InitialImage?null:ImageController.ImageToBytes(txtPictureBox);";
                }
                else if (data[i + 1].Contains("datetime")) // datetime
                {
                    formattedString += data[i] + " = Convert.ToDateTime(txt" + data[i] + ".Text);";
                }
                else if (data[i + 1].Contains("datetime")) // datetime
                {
                    formattedString += data[i] + " = Convert.ToDateTime(txt" + data[i] + ".Text);";
                }
                else if (data[i + 1].Contains("decimal")) // datetime
                {
                    formattedString += data[i] + " = Convert.ToDecimal(txt" + data[i] + ".Text);";
                }

            }
            formattedString += "\n                return obj;";
            formattedString += "\n            }";
            return formattedString;


        }

        public static string get_loadFormWithData(string TableData)
        {
            string[] data = TableData.Split(':');
            string formattedString = "\n       private void loadFormWithID(int ID)\n        {";
            formattedString += "            dbServer conn = new dbServer(AppSetting.connectionString());\n";
            formattedString += "            DataTable tbl = conn.getQueryList(\"SELECT * FROM "+data[0]+" WHERE ID = \" + ID);\n";
            formattedString += "            DataRow row = tbl.Rows[0];";

            for (int i = 1; i < data.Length; i += 2)
            {
                formattedString += "\n            txt" + data[i] + ".Text ";
                if (data[i + 1].Contains("int"))
                {
                    formattedString += "= Convert.ToInt32(row[\"" + data[i] + "\"]).ToString();";
                }
                else if (data[i + 1].Contains("nvarchar"))
                {
                    formattedString += "= row[\"" + data[i] + "\"].ToString();";
                }
                else if (data[i + 1].Contains("bit"))
                {
                    formattedString += "= Convert.ToBoolean(row[\"" + data[i] + "\"]).ToString();";
                }
                else if (data[i + 1].Contains("image"))
                {
                    formattedString = formattedString.Substring(0,formattedString.Length - 5);
                    formattedString += "Image ";
                    formattedString += "=  row[\"" + data[i] + "\"]== DBNull.Value?txtPicture.InitialImage:ImageController.bytesToImage((byte[])row[\"" + data[i] + "\"]);";

                }
                else if (data[i + 1].Contains("datetime"))
                {
                    formattedString += "= Convert.ToDateTime(row[\"" + data[i] + "\"]).ToString();";
                }
                else if (data[i + 1].Contains("decimal"))
                {
                    formattedString += "= Convert.ToDecimal(row[\"" + data[i] + "\"]).ToString();";
                }

            }
           
            formattedString += "\n            }";
            return formattedString;
        }

        public static string get_ResetFormDate(string TableData)
        {
            string[] data = TableData.Split(':');
            string formattedString = "\n       private void resetForm()\n        {";
            
            for (int i = 1; i < data.Length; i += 2)
            {
                formattedString += "\n            txt" + data[i] + ".Text ";
                if (data[i + 1].Contains("int"))
                {
                    formattedString += "= string.Empty;";
                }
                else if (data[i + 1].Contains("nvarchar"))
                {
                    formattedString += "= string.Empty;";
                }
                else if (data[i + 1].Contains("bit"))
                {
                    formattedString += "= string.Empty;";
                }
                else if (data[i + 1].Contains("image"))
                {
                    formattedString += "= txtPicture.InitialImage;";
                }
                else if (data[i + 1].Contains("datetime"))
                {
                    formattedString += "= string.Empty;";
                }
                else if (data[i + 1].Contains("decimal"))
                {
                    formattedString += "= string.Empty;";
                }

            }

            formattedString += "\n            }";
            return formattedString;
        }


      
    }
}
