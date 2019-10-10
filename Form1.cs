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
//using project.foldername
using W4DBConnect.DatabaseBehaviors;
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
             clsDatabase objDatabase = new clsDatabase();
            // is a connection
            //server, username, database, password of the database (that you used to get into phpmyadmin

              //try code, if condition is met, output code
              
              try
              {

                objDatabase.UpdateName();

                  lblConnection.Text = "Yes!";
                  lblConnection.ForeColor = Color.Green;


              }
              catch(Exception ex)
              {
                  lblConnection.Text = "No!\n" + ex;
                  lblConnection.ForeColor = Color.Red;
              }
              

           objDatabase.UpdateName();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            clsDatabase objDatabase = new clsDatabase();
            string sName = txtNewUser.Text;

               try
            {
                objDatabase.InsertUser(sName);
                lblConnection.Text = "Done!";
                lblConnection.ForeColor = Color.Green;
            }
            catch(Exception ex)
            {
                lblConnection.Text = "Failed!\n" + ex;
                lblConnection.ForeColor = Color.Red;
            }
            




        }
    }
}
