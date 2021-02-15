/**  Author
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///             CLASS USED TO PRINT CUSTOM LOGS
///             
///             # METHODS
///              - Print(string)   | void
/// </summary>

namespace MySqlTest
{
    class Logs
    {
        public static void Print(string _str)
        {
            string prefix = "[CONSOLE]: ";
            Console.WriteLine(prefix+_str);
        }
    }
}
