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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///             CLASS USED TO SET TEXT TO THE LABEL
///             
///             # METHODS
///              - Set(Label, string)  | void
/// </summary>

namespace MySqlTest
{
    class LabelText
    {

        // Set label text...
        public static void Set(Label _label, string _text)
        {
            _label.Text = _text;
        }
    }
}
