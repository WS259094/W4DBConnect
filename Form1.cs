using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace W4DBConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

            // is a connection
            //server, username, database, password of the database (that you used to get into phpmyadmin)
            string conString = "server=server1.logicalview.co.uk;user=c444WS259094;database=c444WS259094Colab;password=Friday@63;CharSet=utf8;";

            MySqlConnection sqlCon = new MySqlConnection(conString);

            //try code, if condition is met, output code

            try
            {

                sqlCon.Open();
                lblConnection.Text = "Yes!";
                lblConnection.ForeColor = Color.Green;


            }
            catch(Exception ex)
            {
                lblConnection.Text = "No!\n" + ex;
                lblConnection.ForeColor = Color.Red;
            }
            sqlCon.Close();
        }
    }
}
