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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///             CLASS USED TO CHANGE COLORS
///                 * BACKGROUND COLOR
///                 * FONT COLOR
///                 
///             # METHODS
///              - ChangeForeColor(Label, Color)        | void
///              - ChangeBackgroundColor(Label, Color)  | void
/// </summary>

namespace MySqlTest
{
    class ColorTransformation
    {

        // Change text color
        public static void ChangeForeColor(Label _label, Color _color)
        {
            _label.ForeColor = _color;
        }
        
        
        // Change background color
        public static void ChangeBackgroundColor(Label _label, Color _color)
        {
            _label.BackColor = _color;
        }
        
    }
}
