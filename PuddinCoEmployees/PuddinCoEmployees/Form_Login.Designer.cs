namespace PuddinCoEmployees
{
    partial class Form_Login
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
            if (disposing && (components != null))
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_admin = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.metro_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.label_errorMsg = new System.Windows.Forms.Label();
            this.label_showLogin = new System.Windows.Forms.Label();
            this.timer_login = new System.Windows.Forms.Timer(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_puddingIcon = new MetroFramework.Controls.MetroPanel();
            this.panel_title = new MetroFramework.Controls.MetroPanel();
            this.toolTip_easterEgg = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Steelfish Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.MistyRose;
            this.label_username.Location = new System.Drawing.Point(719, 561);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(129, 48);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Steelfish Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.MistyRose;
            this.label_password.Location = new System.Drawing.Point(719, 630);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(129, 48);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password:";
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_username.Font = new System.Drawing.Font("Steelfish Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(854, 561);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(383, 55);
            this.textBox_username.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("Steelfish Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(854, 630);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(383, 55);
            this.textBox_password.TabIndex = 6;
            // 
            // label_admin
            // 
            this.label_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_admin.AutoSize = true;
            this.label_admin.BackColor = System.Drawing.Color.Transparent;
            this.label_admin.Font = new System.Drawing.Font("Steelfish Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin.ForeColor = System.Drawing.Color.MistyRose;
            this.label_admin.Location = new System.Drawing.Point(1724, 942);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(173, 48);
            this.label_admin.TabIndex = 7;
            this.label_admin.Text = "Admin Version";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.Purple;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(727, 761);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(510, 77);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Steelfish Rg", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.MistyRose;
            this.label_welcome.Location = new System.Drawing.Point(453, 688);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(153, 40);
            this.label_welcome.TabIndex = 9;
            this.label_welcome.Text = "Welcome, Admin!";
            // 
            // metro_spinner
            // 
            this.metro_spinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metro_spinner.BackColor = System.Drawing.Color.Black;
            this.metro_spinner.Location = new System.Drawing.Point(941, 855);
            this.metro_spinner.Maximum = 100;
            this.metro_spinner.Name = "metro_spinner";
            this.metro_spinner.Size = new System.Drawing.Size(84, 80);
            this.metro_spinner.Speed = 3F;
            this.metro_spinner.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metro_spinner.TabIndex = 10;
            this.metro_spinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metro_spinner.UseSelectable = true;
            // 
            // label_errorMsg
            // 
            this.label_errorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_errorMsg.AutoSize = true;
            this.label_errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errorMsg.ForeColor = System.Drawing.Color.Red;
            this.label_errorMsg.Location = new System.Drawing.Point(692, 716);
            this.label_errorMsg.Name = "label_errorMsg";
            this.label_errorMsg.Size = new System.Drawing.Size(570, 32);
            this.label_errorMsg.TabIndex = 11;
            this.label_errorMsg.Text = "Please check your username and password.";
            // 
            // label_showLogin
            // 
            this.label_showLogin.AutoSize = true;
            this.label_showLogin.Font = new System.Drawing.Font("Steelfish Rg", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showLogin.ForeColor = System.Drawing.Color.MistyRose;
            this.label_showLogin.Location = new System.Drawing.Point(198, 515);
            this.label_showLogin.Name = "label_showLogin";
            this.label_showLogin.Size = new System.Drawing.Size(359, 40);
            this.label_showLogin.TabIndex = 12;
            this.label_showLogin.Text = "Username: Admin | Password: wonderbread";
            // 
            // timer_login
            // 
            this.timer_login.Interval = 3000;
            this.timer_login.Tick += new System.EventHandler(this.timer_login_Tick);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_exit.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.exit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(928, 855);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exit.Size = new System.Drawing.Size(112, 77);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_puddingIcon
            // 
            this.panel_puddingIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_puddingIcon.BackColor = System.Drawing.Color.Transparent;
            this.panel_puddingIcon.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.mr_pudding_cup_logo;
            this.panel_puddingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_puddingIcon.HorizontalScrollbarBarColor = true;
            this.panel_puddingIcon.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_puddingIcon.HorizontalScrollbarSize = 10;
            this.panel_puddingIcon.Location = new System.Drawing.Point(460, 488);
            this.panel_puddingIcon.Name = "panel_puddingIcon";
            this.panel_puddingIcon.Size = new System.Drawing.Size(262, 197);
            this.panel_puddingIcon.TabIndex = 1;
            this.toolTip_easterEgg.SetToolTip(this.panel_puddingIcon, "Greetings Earthlings, it is I Mr. Pudding Head!\r\n");
            this.panel_puddingIcon.VerticalScrollbarBarColor = true;
            this.panel_puddingIcon.VerticalScrollbarHighlightOnWheel = false;
            this.panel_puddingIcon.VerticalScrollbarSize = 10;
            // 
            // panel_title
            // 
            this.panel_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.paint_stroke_logo;
            this.panel_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_title.HorizontalScrollbarBarColor = true;
            this.panel_title.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_title.HorizontalScrollbarSize = 10;
            this.panel_title.Location = new System.Drawing.Point(460, 83);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1000, 450);
            this.panel_title.TabIndex = 2;
            this.panel_title.VerticalScrollbarBarColor = true;
            this.panel_title.VerticalScrollbarHighlightOnWheel = false;
            this.panel_title.VerticalScrollbarSize = 10;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1010);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label_showLogin);
            this.Controls.Add(this.label_errorMsg);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.metro_spinner);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label_admin);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.panel_puddingIcon);
            this.Controls.Add(this.panel_title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisplayHeader = false;
            this.Name = "Form_Login";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Pudding Co. Employees";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_puddingIcon;
        private MetroFramework.Controls.MetroPanel panel_title;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_admin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label_welcome;
        private MetroFramework.Controls.MetroProgressSpinner metro_spinner;
        private System.Windows.Forms.Label label_errorMsg;
        private System.Windows.Forms.Label label_showLogin;
        private System.Windows.Forms.Timer timer_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ToolTip toolTip_easterEgg;
    }
}

