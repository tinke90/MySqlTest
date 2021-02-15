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
///             THIS CLASS IS USED TO CHECK WETHER
///             THE USER DID FILL ALL THE REQUIRED
///             INPUT FIELDS.
///             
///             IN CASE USER DID NOT FILL
///             ALL THE REQUIRED INPUT FIELDS, USER WILL
///             BE NOTED IN REQUIRED INPUT FIELD SYMBOLS *
///             CLICKING ANY OF THE TEXT FIELDS WILL MAKE
///             THE SYMBOLS DISAPPEAR AGAIN.
///             
///             # METHODS
///              - Check(string[], Label[]) | bool
/// </summary>

namespace MySqlTest
{
    class RequiredFieldsFilled
    {

        #region Check (required input fields) region
        /* Check if not all the input fields was not filled */
        public static bool Check(string[] _data, Label[] _required)
        {
            bool lackOfData = false;

            /* 
             * Check each input data, if null or empty was
             * found, enable required symbol
             */
            for(int i = 0; i < _data.Length; i++)
            {
                if(string.IsNullOrEmpty(_data[i]))
                {
                    _required[i].Visible = true;
                    lackOfData = true;
                }
            }

            // If a single input field was null or empty...
            if(lackOfData)
            {
                return true;
            }

            return false;
        }
        #endregion

    }
}
