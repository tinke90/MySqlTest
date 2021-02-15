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
///             THIS IS A MAIN FORM
///             
///             # METHODS
///              - InitializeFieldTexts()           | void
///              - GetTextfields()                  | TextBox[]
///              - GetRequiredSymbols()             | Label[]
///              - Button_Connect()                 | void
///              - StartConnecting()                | void
///              - LoadRequiredSymbols()            | void
///              - LoadTextFieldClickListeners()    | void
/// </summary>

namespace MySqlTest
{
    public partial class Form1 : Form
    {

        /* Declare MySql class */
        MySql sql;


        public Form1()
        {
            InitializeComponent();

            InitializeFieldTexts();


            LoadRequiredSymbols();              // Hide required fields symbols

            LoadTextFieldClickListeners();      // Load Textfield click listeners

            Button_Connect();                   // Load connection button
        }


        #region InitializeFieldTexts region
        private void InitializeFieldTexts()
        {
            tf_host.Text = "192.168.0.11";
            tf_port.Text = "3306";
            tf_database.Text = "fintoy_web";
            tf_username.Text = "test";
            tf_password.Text = "test";
        }
        #endregion


        #region GetTextfields region
        /* Return the input fields... */
        private TextBox[] GetTextfields()
        {
            TextBox[] textfields = { tf_host, tf_port, tf_database, tf_username, tf_password };
            return textfields;
        }
        #endregion


        #region GetRequiredSymbols region
        /* Return the required fields notification symbols... */
        private Label[] GetRequiredSymbols()
        {
            Label[] requiredFields = { require_field_1, require_field_2, require_field_3,
                                            require_field_4,require_field_5};
            return requiredFields;
        }
        #endregion


        #region Button_Connect region
        /* Load the connect button click listener... */
        public void Button_Connect()
        {
            bt_connect.Click += (sender, e) => {
                StartConnecting();
            };
        }
        #endregion


        #region Start Connecting region
        /* Connect to the MySql... */
        private void StartConnecting()
        {
            Logs.Print("Start...");

            /* Get the inputFields to
             * use it in RequiredFieldsFilled...
             */
            TextBox[] inputFields = GetTextfields();


            /* Store inputField data in inputData
             * to use it in the RequiredFiledsFilled...
             */
            string[] inputData = { inputFields[0].Text, inputFields[1].Text,
                inputFields[2].Text, inputFields[3].Text, inputFields[4].Text, };


            // Check thats a single field was not left empty...
            bool lackOfInput = RequiredFieldsFilled.Check(inputData, GetRequiredSymbols());


            // Stop executing if field was found empty...
            if(lackOfInput)
            {
                ColorTransformation.ChangeForeColor(lb_result, Color.Red);
                LabelText.Set(lb_result, "Some fields was not filled at all.");
                return;
            }


            sql = new MySql(inputFields);


            // Change lb_result text fore color
            ColorTransformation.ChangeForeColor(lb_result, Color.Black);
            LabelText.Set(lb_result, "Connecting...");


            Logs.Print("Trying to connect...");


            string result = sql.Connect();


            Logs.Print("Connected / Disconnected...");


            if(result == null)
            {
                ColorTransformation.ChangeForeColor(lb_result, Color.Green);
                LabelText.Set(lb_result, "Connection achieved...");
            }
            else
            {
                ColorTransformation.ChangeForeColor(lb_result, Color.Red);
                LabelText.Set(lb_result, "Connection was not reachable...");

                ErrorWindow error = new ErrorWindow(result);
                error.Show();
            }


            Logs.Print("End...");
        }
        #endregion


        #region LoadRequiredSymbols region
        /* Load required symbols hisws in default... */
        private void LoadRequiredSymbols()
        {
            require_field_1.Visible = false;
            require_field_2.Visible = false;
            require_field_3.Visible = false;
            require_field_4.Visible = false;
            require_field_5.Visible = false;
        }
        #endregion


        #region LoadTextFieldClickListeners region
        /* Load textfields action click listeners
         * to clear the required symbols if one was 
         * provided, activate textfield and all the
         * required symbols will be cleared off...
         */
        private void LoadTextFieldClickListeners()
        {
            TextFieldClickListener load = new TextFieldClickListener(GetTextfields(), GetRequiredSymbols());
            load.LoadClickListeners();
        }
        #endregion
    }
}
