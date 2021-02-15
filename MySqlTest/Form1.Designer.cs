
namespace MySqlTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_connect = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.tf_host = new System.Windows.Forms.TextBox();
            this.title_host = new System.Windows.Forms.Label();
            this.title_port = new System.Windows.Forms.Label();
            this.tf_port = new System.Windows.Forms.TextBox();
            this.title_database = new System.Windows.Forms.Label();
            this.tf_database = new System.Windows.Forms.TextBox();
            this.title_username = new System.Windows.Forms.Label();
            this.tf_username = new System.Windows.Forms.TextBox();
            this.title_password = new System.Windows.Forms.Label();
            this.tf_password = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.require_field_1 = new System.Windows.Forms.Label();
            this.require_field_2 = new System.Windows.Forms.Label();
            this.require_field_3 = new System.Windows.Forms.Label();
            this.require_field_4 = new System.Windows.Forms.Label();
            this.require_field_5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(95, 290);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(141, 32);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect";
            this.toolTip1.SetToolTip(this.bt_connect, "Connect to the MySql database");
            this.bt_connect.UseVisualStyleBackColor = true;
            // 
            // lb_result
            // 
            this.lb_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.Location = new System.Drawing.Point(11, 338);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(309, 62);
            this.lb_result.TabIndex = 1;
            this.lb_result.Text = "Waiting to connect...";
            this.lb_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tf_host
            // 
            this.tf_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_host.Location = new System.Drawing.Point(54, 30);
            this.tf_host.Name = "tf_host";
            this.tf_host.Size = new System.Drawing.Size(227, 23);
            this.tf_host.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tf_host, "Enter ip address");
            // 
            // title_host
            // 
            this.title_host.Location = new System.Drawing.Point(54, 9);
            this.title_host.Name = "title_host";
            this.title_host.Size = new System.Drawing.Size(227, 18);
            this.title_host.TabIndex = 3;
            this.title_host.Text = "Host:";
            // 
            // title_port
            // 
            this.title_port.Location = new System.Drawing.Point(54, 64);
            this.title_port.Name = "title_port";
            this.title_port.Size = new System.Drawing.Size(227, 18);
            this.title_port.TabIndex = 5;
            this.title_port.Text = "Port:";
            // 
            // tf_port
            // 
            this.tf_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_port.Location = new System.Drawing.Point(54, 85);
            this.tf_port.Name = "tf_port";
            this.tf_port.Size = new System.Drawing.Size(227, 23);
            this.tf_port.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tf_port, "Enter mysql port");
            // 
            // title_database
            // 
            this.title_database.Location = new System.Drawing.Point(54, 122);
            this.title_database.Name = "title_database";
            this.title_database.Size = new System.Drawing.Size(227, 18);
            this.title_database.TabIndex = 7;
            this.title_database.Text = "Database:";
            // 
            // tf_database
            // 
            this.tf_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_database.Location = new System.Drawing.Point(54, 143);
            this.tf_database.Name = "tf_database";
            this.tf_database.Size = new System.Drawing.Size(227, 23);
            this.tf_database.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tf_database, "Enter database name");
            // 
            // title_username
            // 
            this.title_username.Location = new System.Drawing.Point(54, 181);
            this.title_username.Name = "title_username";
            this.title_username.Size = new System.Drawing.Size(227, 18);
            this.title_username.TabIndex = 9;
            this.title_username.Text = "Username:";
            // 
            // tf_username
            // 
            this.tf_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_username.Location = new System.Drawing.Point(54, 202);
            this.tf_username.Name = "tf_username";
            this.tf_username.Size = new System.Drawing.Size(227, 23);
            this.tf_username.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tf_username, "Enter mysql username");
            // 
            // title_password
            // 
            this.title_password.Location = new System.Drawing.Point(54, 240);
            this.title_password.Name = "title_password";
            this.title_password.Size = new System.Drawing.Size(227, 18);
            this.title_password.TabIndex = 11;
            this.title_password.Text = "Password:";
            // 
            // tf_password
            // 
            this.tf_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_password.Location = new System.Drawing.Point(54, 261);
            this.tf_password.Name = "tf_password";
            this.tf_password.PasswordChar = '*';
            this.tf_password.Size = new System.Drawing.Size(227, 23);
            this.tf_password.TabIndex = 10;
            this.tf_password.Text = "test";
            this.toolTip1.SetToolTip(this.tf_password, "Enter mysql user password");
            // 
            // require_field_1
            // 
            this.require_field_1.AutoSize = true;
            this.require_field_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.require_field_1.ForeColor = System.Drawing.Color.Red;
            this.require_field_1.Location = new System.Drawing.Point(287, 30);
            this.require_field_1.Name = "require_field_1";
            this.require_field_1.Size = new System.Drawing.Size(15, 20);
            this.require_field_1.TabIndex = 12;
            this.require_field_1.Text = "*";
            this.toolTip1.SetToolTip(this.require_field_1, "This field is required");
            // 
            // require_field_2
            // 
            this.require_field_2.AutoSize = true;
            this.require_field_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.require_field_2.ForeColor = System.Drawing.Color.Red;
            this.require_field_2.Location = new System.Drawing.Point(287, 88);
            this.require_field_2.Name = "require_field_2";
            this.require_field_2.Size = new System.Drawing.Size(15, 20);
            this.require_field_2.TabIndex = 13;
            this.require_field_2.Text = "*";
            this.toolTip1.SetToolTip(this.require_field_2, "This field is required");
            // 
            // require_field_3
            // 
            this.require_field_3.AutoSize = true;
            this.require_field_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.require_field_3.ForeColor = System.Drawing.Color.Red;
            this.require_field_3.Location = new System.Drawing.Point(287, 146);
            this.require_field_3.Name = "require_field_3";
            this.require_field_3.Size = new System.Drawing.Size(15, 20);
            this.require_field_3.TabIndex = 14;
            this.require_field_3.Text = "*";
            this.toolTip1.SetToolTip(this.require_field_3, "This field is required");
            // 
            // require_field_4
            // 
            this.require_field_4.AutoSize = true;
            this.require_field_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.require_field_4.ForeColor = System.Drawing.Color.Red;
            this.require_field_4.Location = new System.Drawing.Point(287, 205);
            this.require_field_4.Name = "require_field_4";
            this.require_field_4.Size = new System.Drawing.Size(15, 20);
            this.require_field_4.TabIndex = 15;
            this.require_field_4.Text = "*";
            this.toolTip1.SetToolTip(this.require_field_4, "This field is required");
            // 
            // require_field_5
            // 
            this.require_field_5.AutoSize = true;
            this.require_field_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.require_field_5.ForeColor = System.Drawing.Color.Red;
            this.require_field_5.Location = new System.Drawing.Point(287, 261);
            this.require_field_5.Name = "require_field_5";
            this.require_field_5.Size = new System.Drawing.Size(15, 20);
            this.require_field_5.TabIndex = 16;
            this.require_field_5.Text = "*";
            this.toolTip1.SetToolTip(this.require_field_5, "This field is required");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 409);
            this.Controls.Add(this.require_field_5);
            this.Controls.Add(this.require_field_4);
            this.Controls.Add(this.require_field_3);
            this.Controls.Add(this.require_field_2);
            this.Controls.Add(this.require_field_1);
            this.Controls.Add(this.title_password);
            this.Controls.Add(this.tf_password);
            this.Controls.Add(this.title_username);
            this.Controls.Add(this.tf_username);
            this.Controls.Add(this.title_database);
            this.Controls.Add(this.tf_database);
            this.Controls.Add(this.title_port);
            this.Controls.Add(this.tf_port);
            this.Controls.Add(this.title_host);
            this.Controls.Add(this.tf_host);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.bt_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySql Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tf_host;
        private System.Windows.Forms.Label title_host;
        private System.Windows.Forms.Label title_port;
        private System.Windows.Forms.TextBox tf_port;
        private System.Windows.Forms.Label title_database;
        private System.Windows.Forms.TextBox tf_database;
        private System.Windows.Forms.Label title_username;
        private System.Windows.Forms.TextBox tf_username;
        private System.Windows.Forms.Label title_password;
        private System.Windows.Forms.TextBox tf_password;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label require_field_1;
        private System.Windows.Forms.Label require_field_2;
        private System.Windows.Forms.Label require_field_3;
        private System.Windows.Forms.Label require_field_4;
        private System.Windows.Forms.Label require_field_5;
    }
}

