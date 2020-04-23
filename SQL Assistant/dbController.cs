using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assistant
{
    class dbController
    {
        private static string FolderName = "SQL Assistant";
        public static string localPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), FolderName);
       
        
        

        public static void createTxtFile()
        {
            DirectoryInfo folder = Directory.CreateDirectory(localPath);
          
        }

     /*   public static void addNewTable(string dataToAdd)
        {
            File.AppendAllText(dbPath, dataToAdd + Environment.NewLine);
        }*/

        public static void addNewTable(string dataToAdd,string database)
        {
            File.AppendAllText(localPath + "//" + database + ".txt", dataToAdd + Environment.NewLine);
        } // added

    /*    public static void addExistedTable(string tableName,string NEwData)
        {
            string[] allLines = readFromFile();
            File.WriteAllText(dbPath, "");
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                if (data.First().ToLower() == tableName.ToLower())
                {
                    File.AppendAllText(dbPath, NEwData + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(dbPath, line + Environment.NewLine);
                }
            }
        }*/

        public static void addExistedTable(string tableName, string NEwData,string database)
        {
            string[] allLines = readFromFile(database);
            File.WriteAllText(@localPath + "//" + database + ".txt", "");
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                if (data.First().ToLower() == tableName.ToLower())
                {
                    File.AppendAllText(@localPath + "//" + database + ".txt", NEwData + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(@localPath + "//" + database + ".txt", line + Environment.NewLine);
                }
            }
        } // added

   /*     public static string[] readFromFile()
        {
            string[] data;
            data = File.ReadAllLines(dbPath);
            return data;
        }*/

        public static string[] readFromFile(string fileName)  // added
        {
            string[] data;
            data = File.ReadAllLines(localPath + "//" + fileName + ".txt");
            return data;
        }

    /*    public static void checkDataInFile()
        {
            string data="";
            foreach (string item in readFromFile())
            {
                data += item + Environment.NewLine;
            }

            System.Windows.Forms.MessageBox.Show(data);
        }*/
        
        public static bool isTableAlreadyExist(string tableName,string database)
        {
            if (tableName == string.Empty)
            {
                return false;
            }
            string[] allLines = readFromFile(database);
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                if (data.First().ToLower() == tableName.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        public static string getDataOnTableName(string tableName,string database)
        {
            string output="";
            if (tableName == string.Empty)
            {
                return "4004 Error Table Not FOund";
            }
            string[] allLines = readFromFile(database);
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                if (data.First().ToLower() == tableName.ToLower())
                {
                    output = line;
                    return output;
                }
            }
            return "404 Error Table Not FOund";
        }

   /*     public static string[] getTableNames()
        {
            List<string> tableNames = new List<string>();
            string[] allLines = readFromFile();
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                tableNames.Add(data.First());
            }

            return tableNames.ToArray();
        }*/

        public static string[] getTableNames(string databaseName) // added
        {
            List<string> tableNames = new List<string>();
            string[] allLines = readFromFile(databaseName);
            foreach (string line in allLines)
            {
                string[] data = line.Split(':');
                tableNames.Add(data.First());
            }

            return tableNames.ToArray();
        }   // added

        public static void createDatabase(string dbName)
        {
            string db = @localPath + "//" + dbName + ".txt";
            if (!File.Exists(db))
            {
                File.Create(db).Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Already Exist");
            }
        }

        public static string[] getDatabases()
        {
            
            FileInfo[] allFiles = new DirectoryInfo(@localPath).GetFiles("*.txt");
            string[] databases  = new string[allFiles.Length];
            int i = 0;
            foreach(FileInfo file in allFiles)
            {
                databases[i] = file.Name.Split('.').First();
                i++;
            }

            return databases;
        }
    }
}
