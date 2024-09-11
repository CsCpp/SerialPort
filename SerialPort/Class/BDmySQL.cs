using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;

namespace SerialPortC.Class
{
    public class BDmySQL
    {

        static string serverLH;
        static public string ServerLH
        {

            get { return serverLH; }
            set { serverLH = value; }
        }

        static string usernameLH;
        static public string UsernameLH { get { return usernameLH; } set { usernameLH = value; } }

        static string passwordLH;
        static public string PasswordLH { get { return passwordLH; } set { passwordLH = value; } }

        static int portLH;
        static public int PortLH { get { return portLH; } set { portLH = value; } }

        static string databaseLH;
        static public string DatabaseLH { get { return databaseLH; } set { databaseLH = value; } }

        static string tableLH;
        static public string TableLH { get { return tableLH; } set { tableLH = value; } }

        private MySqlConnection myConnection;
        private MySqlCommand myCommand;

        private MySqlDataAdapter myDataAdapter;
        private DataSet myDataSet;

        public BDmySQL(){}
        static BDmySQL()
        {
            serverLH = "localhost";
            usernameLH = "root";
            passwordLH = "";
            portLH = 3306;
            databaseLH = "database01";
            tableLH = "table1";

        }


        public void SaveDataToMySqlDataBase(string str)
        {

            try
            {
                myConnection = new MySqlConnection($"server={ServerLH}; username={UsernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
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
                myConnection = new MySqlConnection($"server={ServerLH}; username={UsernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
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

        public void TestDataToMySqlDataBase()
        {
            try
            {
                myConnection = new MySqlConnection($"server={ServerLH}; username={UsernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
                myConnection.Open();

                myCommand = new MySqlCommand($"SELECT * FROM {tableLH}", myConnection);
                
                myConnection.Close();
                MessageBox.Show("MySQL data base is OK", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateTableMysql()
        {
            try
            {
                myConnection = new MySqlConnection($"server={ServerLH}; username={UsernameLH}; password={passwordLH}; port={Convert.ToString(portLH)}; database={databaseLH}");
                myConnection.Open();

                myCommand = new MySqlCommand(
                    "CREATE TABLE `database01`.`com9` (`DataIN` VARCHAR(100) NOT NULL, `DataOut` VARCHAR(100) NOT NULL) ENGINE = InnoDB;"
                    , myConnection);

                myCommand.ExecuteNonQuery();

                myCommand = new MySqlCommand(
                    " INSERT INTO `com9` (`DataIN`, `DataOut`) VALUES('Base is', 'create')"
                    , myConnection);

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
