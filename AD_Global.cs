using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace UpdateDataBase
{
    public static class AD_Global
    {
        #region Variables

        public static System.Data.SqlClient.SqlCommand cmd;
        public static SqlConnection ConStr;

        #endregion

        #region Null&Farsi String

        public static string ToStringNullSafe(this object value)
        {
            return (value ?? string.Empty).ToString();
        }

        public static string N2S(string value)
        {
            if (value == null) { return ""; }
            else
            { return value; }
        }

        public static string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ک");
        }

        #endregion

        #region License Key

        

      

       
        public static List<string> GetDatabaseList(string serverName, string username, string password)
        {
            List<string> list = new List<string>();
            if(serverName!="" && username!="" && password != "")
            {
                try
                {
                    // Open connection to the database
                    string conString = $"server={serverName};uid={username};pwd={password};";

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        // Set up a command with the given query and associate
                        // this with the current connection.
                        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases Where database_id > 4", con))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    list.Add(dr[0].ToString());
                                }
                            }
                        }
                    }
                    return list;
                }
                catch (Exception)
                {

                    return list;
                }
            }
            else
            {
                return list;
            }
            
           
           

        }

        // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        // This constant is used to determine the keysize of the encryption algorithm.
        private const int keysize = 256;

        public static string Encrypt(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
            {
                byte[] keyBytes = password.GetBytes(keysize / 8);
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.Mode = CipherMode.CBC;
                    using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                byte[] cipherTextBytes = memoryStream.ToArray();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
                {
                    byte[] keyBytes = password.GetBytes(keysize / 8);
                    using (RijndaelManaged symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.Mode = CipherMode.CBC;
                        using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                        {
                            using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return "";
            }
        }


        #endregion



        #region SQL Command

        public static SqlConnection MakeConnectionString(string DBPassword, string DBUsername, string DBServerIP, string Database)
        {
            try
            {
                return new SqlConnection("Password=" + DBPassword + ";Persist Security Info=True;User ID=" + DBUsername + ";Connection TimeOut = 15000;Initial Catalog=" + Database + " ;Data Source=" + DBServerIP);
            }
            catch (Exception ex)
            {
                Savelog("خطا در ساخت پارامترهای ارتباط با پایگاه داده :\n" + ex.Message.ToString() + "\nپارامترهای ارتباط با پایگاه داده : \n" + "Password=######;Persist Security Info=True;User ID=" + DBUsername + ";Initial Catalog=" + Database + " ;Data Source=" + DBServerIP);
                return null;
            }
        }

        public static DataTable LoadData(String Query, SqlConnection SqlCon)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Query, SqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Savelog("خطا در خواندن اطلاعات : \n" + ex.Message.ToString() + "\n دستور ارسالی : \n" + Query + "\nمشخصات ارتباط با پایگاه داده : \n" + SqlCon.ConnectionString.Substring(SqlCon.ConnectionString.IndexOf("Persist")));
                AD_Global.Savelog(Query);
                return null;
            }
        }

        public static string RunSQLCommand(String Query, SqlConnection ConStr)
        {
            try
            {
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, ConStr);
                if (ConStr.State != ConnectionState.Closed) { ConStr.Close(); }
                ConStr.Open(); cmd.ExecuteNonQuery(); ConStr.Close();
                return "true";
            }
            catch (Exception ex)
            {

                if (ConStr.State != ConnectionState.Closed) { ConStr.Close(); }
                return "false : خطا در ذخیره اطلاعات : \n" + ex.Message.ToString() + "\nدستور ارسالی : \n" + Query + "\nمشخصات ارتباط با پایگاه داده : \n" + ConStr.ConnectionString.Substring(ConStr.ConnectionString.IndexOf("Persist"));
            }
        }

        #endregion

        #region System log

        public static void Savelog(string LogText)
        {
            string path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            path = "C:\\BARG System";
            try
            {
                if (File.Exists(path + "\\LicenseSystem.log"))
                {
                    long length = new System.IO.FileInfo(path + "\\LicenseSystem.log").Length;
                    if (length < 1100000)
                    {
                        string[] lines = { DateTime.Now.ToString() + "***#####***" + LogText };
                        File.AppendAllLines(path + "\\LicenseSystem.log", lines);
                    }
                    else
                    {
                        string[] lines = { DateTime.Now.ToString() + "***#####***" + LogText };
                        File.WriteAllLines(path + "\\LicenseSystem.log", lines);
                    }
                }
                else
                {
                    string[] lines = { DateTime.Now.ToString() + "***#####***" + LogText };
                    File.WriteAllLines(path + "\\LicenseSystem.log", lines);
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(path + "\\LogFileError.log", ex.Message.ToString());
            }
        }

        public static void Clearlog()
        {
            string path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            try
            {
                string[] lines = { "" };
                File.WriteAllLines(path + "\\LicenseSystem.log", lines);

            }
            catch (Exception ex)
            {
                File.WriteAllText(path + "\\LogFileError.log", ex.Message.ToString());
            }
        }

        public static List<Model.TableInfo> GetTableInfos(string TableName,SqlConnection connection)
        {
            List<Model.TableInfo> tableInfosList = new List<Model.TableInfo>();
            string query =$@"SELECT COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = '{TableName}'";
            DataTable dt = LoadData(query, connection);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tableInfosList.Add(new Model.TableInfo
                {
                    ColumnName=dt.Rows[i][0].ToString(),
                    IsNullable=dt.Rows[i][1].ToString(),
                    DataType = dt.Rows[i][2].ToString(),
                    CharacterMaximumLength = dt.Rows[i][3].ToString()
                });

            }
            return tableInfosList;
        }
        public static List<string> GetDataBaseTable(SqlConnection connection)
        {
            List<string> tableNames = new List<string>();
            string query = $@"SELECT TABLE_Name FROM INFORMATION_SCHEMA.TABLES 
                                where TABLE_TYPE='BASE Table' and TABLE_NAME like 'Barg%' order by Table_name";
            DataTable dt = LoadData(query, connection);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tableNames.Add(dt.Rows[i][0].ToString());

            }
            return tableNames;
        }
        public static string MakeBaseTableStringBuilder(string TableName,string ColumnName,string ColumnType,bool Isnull,string maxlength)
        {
            string createQuery = "";
            if (Isnull)
            {
                if (maxlength == null || maxlength=="")
                {
                    createQuery = $"CREATE TABLE {TableName} ( {ColumnName} {ColumnType} ({maxlength}) not NULL)";
                }
                else
                {
                    createQuery = $"CREATE TABLE {TableName} ( {ColumnName} {ColumnType} not NULL)";
                }
            }
            else
            {
                if (maxlength != null)
                {
                    createQuery = $"CREATE TABLE {TableName} ( {ColumnName} {ColumnType} ({maxlength}) NULL)";
                }
                else
                {
                    createQuery = $"CREATE TABLE {TableName} ( {ColumnName} {ColumnType} NULL)";
                }

            }
            return createQuery;

        }
        public static string AddColumnToTableStringBuilder(string TableName, string ColumnName, string ColumnType, bool Isnull, string maxlength,string DefaultValue)
        {
            string createQuery = "";
            if (maxlength == null || maxlength=="")
            {
                

                if (Isnull)
                {
                    createQuery = $"Alter Table {TableName} Add {ColumnName} {ColumnType} null";
                }
                else
                {
                    createQuery = $@"Alter Table {TableName} Add {ColumnName} {ColumnType}
update {TableName} set {ColumnName}={DefaultValue} 
Alter Table {TableName} Alter Column {ColumnName} {ColumnType} not null";

                }

            }
            else
            {
                if (Isnull)
                {
                    createQuery = $"Alter Table {TableName} Add {ColumnName} {ColumnType}({maxlength}) null";
                }
                else
                {
                    createQuery = $@"Alter Table {TableName} Add {ColumnName} {ColumnType}({maxlength}) 
update {TableName} set {ColumnName}={DefaultValue} 
Alter Table {TableName} Alter Column {ColumnName} {ColumnType}({maxlength}) not null";

                }
            }
          
            return createQuery;
        }
        public static void SaveQuery(string TableName,string Query)
        {
            string path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            path = "C:\\BARG System";
            try
            {
                if (File.Exists(path + $"\\{TableName}.txt"))
                {
                        string[] lines = {Query };
                        File.AppendAllLines(path + $"\\{TableName}.txt", lines);    
                }
                else
                {
                    string[] lines = { Query };
                    File.WriteAllLines(path + $"\\{TableName}.txt", lines);
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(path + $"\\{TableName}.txt", ex.Message.ToString());
            }
        }

        public static void MakeCreateTableFile(SqlConnection connection,string TableName)
        {
            List<Model.TableInfo> tableInfosList = new List<Model.TableInfo>();
            tableInfosList = GetTableInfos(TableName, connection);
            string createTableQuery = MakeBaseTableStringBuilder(TableName, tableInfosList[0].ColumnName, tableInfosList[0].DataType, tableInfosList[0].IsNullable == "YES", tableInfosList[0].CharacterMaximumLength);
            SaveQuery(TableName, createTableQuery);
            string addColumnQuery = "";
            for (int i = 1; i < tableInfosList.Count; i++)
            {
                addColumnQuery = AddColumnToTableStringBuilder(TableName, tableInfosList[i].ColumnName, tableInfosList[i].DataType, tableInfosList[i].IsNullable == "YES", tableInfosList[i].CharacterMaximumLength, "0");
                SaveQuery(TableName, addColumnQuery);

            }
        }

        public static void ExecQueryFromFile(string path,string filename,SqlConnection connection)
        {
            string[] Config;
            try
            {
                if (System.IO.File.Exists(path + "\\" + filename+".txt"))
                {
                    Config = System.IO.File.ReadAllLines(path + "\\" + filename + ".txt");
                    

                }
            }
            catch (Exception ex)
            {
                Savelog("خطا در خواندن فایل تنظیمات  : \n" + ex.Message.ToString());
            }
        }
        

        #endregion

        #region Date functions

        public static string Shamsi(String Miladi, SqlConnection ConStr)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = LoadData("select SHAMSI from BARG_DateConverter where MILADI=cast('" + Miladi.Replace("ق.ظ", "AM").Replace("ب.ظ", "PM") + "' as Date)", ConStr);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["SHAMSI"].ToString();
                }
                else
                {
                    return "Date Not Valid:" + Miladi;
                }
            }
            catch (Exception ex)
            {
                Savelog("خطا در تبدیل تاریخ میلادی به شمسی : \n" + ex.Message.ToString() + "\n" + "select SHAMSI from BARG_DateConverter where MILADI=CONVERT(datetime,'" + Miladi.Replace("ق.ظ", "AM").Replace("ب.ظ", "PM") + "')");
                return "Date Not Valid" + Miladi;
            }
        }

        public static string Miladi(String Shamsi, SqlConnection ConStr)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = LoadData("select Miladi from BARG_DateConverter where SHAMSI='" + Shamsi + "'", ConStr);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Miladi"].ToString().Replace("ق.ظ", "AM").Replace("ب.ظ", "PM");
                }
                else
                {
                    return "Date Not Valid:" + Shamsi;
                }
            }
            catch (Exception ex)
            {
                Savelog("خطا در تبدیل تاریخ شمسی به میلادی : \n" + ex.Message.ToString() + "\n" + "select Miladi from BARG_DateConverter where SHAMSI='" + Shamsi + "'");
                return "Date Not Valid" + Shamsi;
            }
        }

        #endregion

        #region Create Standard Tables

        public static Boolean CreateTables()
        {
            Boolean Flag = false;
            try
            {
                string path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                string[] query = File.ReadAllLines(path + "\\DateConverter.ini");
                DataTable dt = AD_Global.LoadData(query[0], AD_Global.ConStr);
                if (dt.Rows.Count == 0)
                {
                    for (int i = 1; i < query.Length; i++)
                    {
                        if (query[i] != "")
                        {
                            if (query[i].Substring(0, 7) != "--Print")
                            {
                                AD_Global.RunSQLCommand(query[i], AD_Global.ConStr);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Savelog("مشکل در ایجاد توابع تاریخ : " + ex.Message.ToString());

            }
            return Flag;
        }

        #endregion

    }

    public static class AD_Web
    {
      

     

        #region GenerateError
        public class ErrorResult
        {
            public int status;
            public int code;
            public String message;
            public String description;
            public String service;
            public String developerMessage;
        }
       
        #endregion


   

        public class DataInfo
        {
            public string DBServer;
            public string DBName;
            public string DBUserName;
            public string DBPassword;
            public string CompanyCode;
            public string PeriodCode;
            public SqlConnection ConStr;
        }
        #region MakeParameters
        public static DataInfo MakeParameters(string ConnectionNo)
        {
            DataInfo CmpnyInfo = new DataInfo();
            //string path = System.Web.HttpContext.Current.Server.MapPath("~") + "\\"; // "C:\\BargSystem\\";
            string[] Config = new string[10];
            string path = "C:\\Barg System\\";
            try
            {
                if (Directory.Exists(path) == false)
                {
                }

                if (System.IO.File.Exists(path + "Setting_" + ConnectionNo + ".ini"))
                {
                    Config = System.IO.File.ReadAllLines(path + "Setting_" + ConnectionNo + ".ini");
                    CmpnyInfo.DBServer = Config[0].Substring(11);
                    CmpnyInfo.DBName = Config[1].Substring(9);
                    CmpnyInfo.DBUserName = Config[2].Substring(13);
                    if (Config[3].Substring(13, 3).ToUpper() == "NEW")
                    {
                        CmpnyInfo.DBPassword = Config[3].Substring(16);
                        Config[3] = "[DBPassword]=" + AD_Global.Encrypt(CmpnyInfo.DBPassword, "kjdfcpbnwerz93n47fndyfd9sgyfms");
                    }
                    else { CmpnyInfo.DBPassword = AD_Global.Decrypt(Config[3].Substring(13), "kjdfcpbnwerz93n47fndyfd9sgyfms"); }
                    CmpnyInfo.CompanyCode = Config[4].Substring(14);
                    CmpnyInfo.PeriodCode = Config[5].Substring(13);
                    Config[7] = "Write New Password with NEW at begining. For Example for password 123 write NEW123";
                }
                else
                {
                    Config[0] = "[DBServer]=";
                    Config[1] = "[DBName]=";
                    Config[2] = "[DBUserName]=";
                    Config[3] = "[DBPassword]=";
                    Config[4] = "[LOGOCompany]=";
                    Config[5] = "[LOGOPeriod]=";
                    Config[6] = "Write New Password with NEW at begining. For Example for password 123 write NEW123";
                }
                System.IO.File.WriteAllLines(path + "Setting_" + ConnectionNo + ".ini", Config);
            }

            catch (Exception ex)
            {
                AD_Global.Savelog("خطا در خواندن فایل تنظیمات  : \n" + ex.Message.ToString());
            }
            try
            {
                CmpnyInfo.ConStr = new SqlConnection("Password=" + CmpnyInfo.DBPassword + ";Persist Security Info=True;User ID=" + CmpnyInfo.DBUserName + ";Connection Timeout=1800;Initial Catalog=" + CmpnyInfo.DBName + " ;Data Source=" + CmpnyInfo.DBServer);
                //DatabaseHelper.init(CmpnyInfo.ConStr.ConnectionString);
                return CmpnyInfo;
            }
            catch (Exception ex)
            {
                AD_Global.Savelog("خطا در ساخت پارامترهای پایگاه داده  : \n" + ex.Message.ToString());
                return null;
            }


        }
        #endregion



    }
}
