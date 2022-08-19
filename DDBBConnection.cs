using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCRUDOperations
{
    /*  Class to manage DDBB Connection
     *  and CRUD operations
     */
    class DDBBConnection
    {
        /*  This method sets the connection
         *  Uses a constant string for part 
         *  of the connection string for security
         *  Receives two strings, user and pass,
         *  from the user input
         *  Returns a MySqlConnection object
         *  to use in Main
         */
        public MySqlConnection Connect(string user, string pass)
        {
            string strConnectionUser = Constants.strConnection + " User ID=" + user + "; Password=" + pass + ";";
            try
            {
                using (MySqlConnection connection = new(strConnectionUser))
                {

                    connection.Open();
                    //Just to show connection is open
                    MessageBox.Show(connection.State.ToString());
                    return connection;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("User/Password are not correct.");
                return null;
            }
        }

        //HERE TODO CRUD METHODS
    }
}
