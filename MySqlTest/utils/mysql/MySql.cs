/** Author
 * @ author: tinke990
 * 
 * @ Application: MySql Test Connector
 * @ Date: 15/2/2021
 * @ Language: C#
 * @ IDE: Visual Studio
 * 
 * @ Nugets: MySql.data
 * 
 * # Not for commercial usage #
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///             THIS CLASS IS USED FOR DATABASE
///             OPEN CONNECTION AND CLOSE THE
///             CONNECTION TO CHECK IF CONNECTION
///             SUCCEED OR NOT.
///             
///             IN CASE CONNECTION WAS UNREACHABLE,
///             POSSIBLY REASON WILL BE PROVIDED BY
///             RECEIVED EXEPTION MESSAGE.
///             
///             # METHODS
///              - Connect()    | string
/// </summary>

namespace MySqlTest
{
    class MySql
    {

        // Declare mysql connector...
        private MySqlConnection connection;

        // Declare and initialize variables...
        private string host     = "datasource="; //= "datasource=192.168.x.x;";
        private string port     = "port=";       //= "port=3306;";
        private string database = "DATABASE=";   //= "DATABASE=database_name;";
        private string username = "username=";   //= "username=user@local;";
        private string password = "password=";   //= "password=password;";



        // Declare parameterized constructor...
        public MySql(TextBox[] _connectionData)
        {

            // Combine initialized variables with the user inputs...
            host        += _connectionData[0].Text + ";";
            port        += _connectionData[1].Text + ";";
            database    += _connectionData[2].Text + ";";
            username    += _connectionData[3].Text + ";";
            password    += _connectionData[4].Text + ";";

            
            /* Create connection string and constuct a new mysql connector */
            string connectionString = host + port + database + username + password;
            connection = new MySqlConnection(connectionString);
        }


        #region Connect region
        // Connect to the database...
        public string Connect()
        {
            try
            {
                connection.Open();
                return null;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex);
                return ex.ToString();
            }
        }
        #endregion
    }
}
