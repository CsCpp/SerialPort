using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SerialPortC
{
  public   class BDmySQL
    {
        private string serverLH { get ; set; }
        private string usernameLH { get; set; }
        private string passwordLH { get; set; }
        private int portLH { get; set; }
        private string databaseLH { get; set; }
        private string tableLH { get; set; }

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
