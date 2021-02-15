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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///             THIS CLASS IS USED TO PROVIDE
///             THE CONNECTION ERROR IF ONE
///             WAS RESEIVED.
/// </summary>

namespace MySqlTest
{
    public partial class ErrorWindow : Form
    {

        public ErrorWindow(string _str)
        {
            InitializeComponent();


            rcb_error.Text = _str;
        }

    }
}
