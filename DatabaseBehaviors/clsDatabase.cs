using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace W4DBConnect.DatabaseBehaviors
{
    class clsDatabase
    {
        private static string conString = "server=server1.logicalview.co.uk;user=c444WS259094;database=c444WS259094Colab;password=Friday@63;CharSet=utf8;";

        public void UpdateName()
        {
            MySqlConnection sqlCon = new MySqlConnection(conString);

            //try code, if condition is met, output code

            try
            {
                sqlCon.Open();

                string sqlStatement = "UPDATE `tbl_Test` SET `Name`= 'Bob' WHERE `ID` = 1";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlCon);
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();

                


            }
            catch (Exception ex)
            {
                
            }

            
        }

        public void InsertUser(string sUsername)
        {
            MySqlConnection sqlCon = new MySqlConnection(conString);
            try
            {

                sqlCon.Open();

                string sqlStatement = "INSERT INTO `tbl_Test`(`Name`) VALUES ('" + sUsername + "')";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlCon);
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();

            }
            catch(Exception ex)
            {

            }
        }
    }
}
