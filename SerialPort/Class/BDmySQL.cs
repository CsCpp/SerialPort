using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SerialPortC.Class
{
    public  class BDmySQL
    {
        static string serverLH;
        public static string ServerLH { get { return serverLH; } set { serverLH = value; } }

        static  string usernameLH;
        static public string UsernameLH { get { return usernameLH; } set { usernameLH = value; } }

        static  string passwordLH;
        static public string PasswordLH { get { return usernameLH; } set { usernameLH = value; } }

        static  int portLH;
        static public int PortLH { get { return portLH; } set { portLH = value; } }

        static  string databaseLH;
        static public string DatabaseLH { get { return databaseLH; } set { databaseLH = value; } }

        static  string tableLH;
        static public string TableLH { get { return tableLH; } set { tableLH = value; } }

        private MySqlConnection myConnection;
        private MySqlCommand myCommand;

        private MySqlDataAdapter myDataAdapter;
        private DataSet myDataSet;

        public BDmySQL(
                        string serverLH = "localhost", 
                        string usernameLH = "root",
                        string passwordLH = "",
                        int portLH = 3306, 
                        string databaseLH = "database01",
                        string tableLH = "table1") 
        {
            this.serverLH = serverLH;
            this.usernameLH = usernameLH;
            this.passwordLH = passwordLH;
            this.portLH = portLH;
            this.databaseLH = databaseLH;
            this.tableLH = tableLH;
        }


        public void SaveDataToMySqlDataBase(string str)
        {
           
                try
                {
                    myConnection = new MySqlConnection($"server={serverLH}; username={usernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
                    myConnection.Open();

                    myCommand = new MySqlCommand(string.Format($"INSERT INTO {tableLH}" + " VALUES('{0}')", DateTime.Now + " : " + str), myConnection);
                    myCommand.ExecuteNonQuery();

                    myConnection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        public DataSet ReadDataToMySqlDataBase()
        {

            try
            {
                myConnection = new MySqlConnection($"server={serverLH}; username={usernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
                myConnection.Open();

                myCommand = new MySqlCommand($"SELECT * FROM {tableLH}", myConnection);
                myDataAdapter = new MySqlDataAdapter(myCommand);
                myDataSet = new DataSet();

                myDataAdapter.Fill(myDataSet, "Serial Data");
                

                myConnection.Close();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return myDataSet;

        }

        public void SetToMySql(string _serverLH = "localhost",
                        string _usernameLH = "root",
                        string _passwordLH = "",
                        int _portLH = 3306,
                        string _databaseLH = "database01",
                        string _tableLH = "table1")
        {
            serverLH = _serverLH;
            usernameLH = _usernameLH;
            passwordLH = _passwordLH;
            portLH = _portLH;
            databaseLH = _databaseLH;
            tableLH = _tableLH;
        }

        
    }
}
