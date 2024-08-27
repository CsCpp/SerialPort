using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SerialPortC
{
    internal class BDmySQL
    {
        private string serverLH;
        private string usernameLH;
        private string passwordLH;
        private int portLH;
        private string databaseLH;
        private string tableLH;

        private MySqlConnection myConnection;
        private MySqlCommand myCommand;

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

    }
}
