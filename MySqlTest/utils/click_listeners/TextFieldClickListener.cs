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
///             CLASS IS USED TO LOAD ALL THE
///             TEXT FIELD CLICK LISTENERS TO
///             BEHAVE WETHER THE FIELD IS CLICKED
///             OR NOT.
///             ONCE ANY OF THE INPUT FIELDS WAS CLICKED
///             WHILE THE REQUIRED INPUT FIELD SYMBOLS
///             WAS ACTIVE, CLICKING ANY OF THE INPUT FIELDS
///             WILL HIDE ALL OF THEM.
///             
///             # METHODS
///              - LoadClickListeners()     | void
///              - ClearRequiredSymbols()   | void
/// </summary>

namespace MySqlTest
{
    class TextFieldClickListener
    {
        TextBox[] textFields;
        Label[] required;

        public TextFieldClickListener(TextBox[] _textFields, Label[] _required)
        {
            textFields = _textFields;
            required = _required;
        }

        #region LoadClickListeners region
        /* Load textfield click listeners to clear
         * symbols when any of the fields is clicked
         * by the user...
         */
        public void LoadClickListeners()
        {
            foreach(TextBox inputField in textFields)
            {
                inputField.Click += (sender, e) =>
                {
                    ClearRequiredSymbols();
                };
            }
        }
        #endregion


        #region ClearRequiredSymbols region
        /* Clear the required symbols... */
        private void ClearRequiredSymbols()
        {
            foreach(Label symbol in required)
            {
                symbol.Visible = false;
            }
        }
        #endregion

    }
}
