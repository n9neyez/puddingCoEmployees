namespace PuddinCoEmployees
{
    partial class Home_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.label_bigWelcome = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addPicture = new System.Windows.Forms.Button();
            this.label_puddingID = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_puddingID = new System.Windows.Forms.TextBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.toolTip_btns = new System.Windows.Forms.ToolTip(this.components);
            this.label_explain = new System.Windows.Forms.Label();
            this.btn_manageEmployees = new System.Windows.Forms.Button();
            this.btn_showContent = new System.Windows.Forms.Button();
            this.picture_adminImg = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_saveAdmin = new System.Windows.Forms.Button();
            this.btn_editAdmin = new System.Windows.Forms.Button();
            this.btn_credits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_adminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bigWelcome
            // 
            this.label_bigWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bigWelcome.AutoSize = true;
            this.label_bigWelcome.BackColor = System.Drawing.Color.Transparent;
            this.label_bigWelcome.Font = new System.Drawing.Font("Steelfish Rg", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bigWelcome.ForeColor = System.Drawing.Color.MistyRose;
            this.label_bigWelcome.Location = new System.Drawing.Point(1300, 100);
            this.label_bigWelcome.Name = "label_bigWelcome";
            this.label_bigWelcome.Size = new System.Drawing.Size(543, 144);
            this.label_bigWelcome.TabIndex = 0;
            this.label_bigWelcome.Text = "Welcome, Admin";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Purple;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatAppearance.BorderSize = 3;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(1386, 847);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(356, 77);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_addPicture
            // 
            this.btn_addPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addPicture.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addPicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_addPicture.FlatAppearance.BorderSize = 0;
            this.btn_addPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btn_addPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_addPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPicture.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addPicture.Location = new System.Drawing.Point(197, 665);
            this.btn_addPicture.Name = "btn_addPicture";
            this.btn_addPicture.Size = new System.Drawing.Size(301, 65);
            this.btn_addPicture.TabIndex = 11;
            this.btn_addPicture.Text = "Add New Picture";
            this.btn_addPicture.UseVisualStyleBackColor = false;
            this.btn_addPicture.Click += new System.EventHandler(this.btn_addPicture_Click);
            // 
            // label_puddingID
            // 
            this.label_puddingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_puddingID.AutoSize = true;
            this.label_puddingID.Font = new System.Drawing.Font("Steelfish Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puddingID.ForeColor = System.Drawing.Color.MistyRose;
            this.label_puddingID.Location = new System.Drawing.Point(626, 150);
            this.label_puddingID.Name = "label_puddingID";
            this.label_puddingID.Size = new System.Drawing.Size(193, 72);
            this.label_puddingID.TabIndex = 13;
            this.label_puddingID.Text = "Pudding ID:";
            // 
            // label_firstname
            // 
            this.label_firstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Steelfish Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.ForeColor = System.Drawing.Color.MistyRose;
            this.label_firstname.Location = new System.Drawing.Point(626, 245);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(192, 72);
            this.label_firstname.TabIndex = 14;
            this.label_firstname.Text = "First Name:";
            // 
            // label_lastname
            // 
            this.label_lastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Steelfish Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.ForeColor = System.Drawing.Color.MistyRose;
            this.label_lastname.Location = new System.Drawing.Point(630, 342);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(188, 72);
            this.label_lastname.TabIndex = 15;
            this.label_lastname.Text = "Last Name:";
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Steelfish Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.MistyRose;
            this.label_email.Location = new System.Drawing.Point(692, 443);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(127, 72);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "E-mail:";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Steelfish Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.MistyRose;
            this.label_title.Location = new System.Drawing.Point(717, 544);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(101, 72);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Title:";
            // 
            // textBox_puddingID
            // 
            this.textBox_puddingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_puddingID.Enabled = false;
            this.textBox_puddingID.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_puddingID.Location = new System.Drawing.Point(825, 158);
            this.textBox_puddingID.Name = "textBox_puddingID";
            this.textBox_puddingID.Size = new System.Drawing.Size(372, 64);
            this.textBox_puddingID.TabIndex = 18;
            this.textBox_puddingID.Text = "101";
            this.textBox_puddingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_firstname.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstname.Location = new System.Drawing.Point(824, 253);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(372, 64);
            this.textBox_firstname.TabIndex = 19;
            this.textBox_firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_lastname.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(825, 350);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(372, 64);
            this.textBox_lastname.TabIndex = 20;
            this.textBox_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_email.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(824, 451);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(372, 64);
            this.textBox_email.TabIndex = 21;
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_title.Enabled = false;
            this.textBox_title.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(824, 552);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(372, 64);
            this.textBox_title.TabIndex = 22;
            this.textBox_title.Text = "Director";
            this.textBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip_btns
            // 
            this.toolTip_btns.AutomaticDelay = 750;
            // 
            // label_explain
            // 
            this.label_explain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_explain.AutoSize = true;
            this.label_explain.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_explain.ForeColor = System.Drawing.Color.MistyRose;
            this.label_explain.Location = new System.Drawing.Point(1257, 276);
            this.label_explain.Name = "label_explain";
            this.label_explain.Size = new System.Drawing.Size(616, 138);
            this.label_explain.TabIndex = 26;
            this.label_explain.Text = resources.GetString("label_explain.Text");
            // 
            // btn_manageEmployees
            // 
            this.btn_manageEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_manageEmployees.BackColor = System.Drawing.Color.Tomato;
            this.btn_manageEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_manageEmployees.FlatAppearance.BorderSize = 3;
            this.btn_manageEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_manageEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_manageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageEmployees.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_manageEmployees.Location = new System.Drawing.Point(1386, 539);
            this.btn_manageEmployees.Name = "btn_manageEmployees";
            this.btn_manageEmployees.Size = new System.Drawing.Size(356, 77);
            this.btn_manageEmployees.TabIndex = 27;
            this.btn_manageEmployees.Text = "Manage Employees";
            this.btn_manageEmployees.UseVisualStyleBackColor = false;
            this.btn_manageEmployees.Click += new System.EventHandler(this.btn_manageEmployees_Click);
            // 
            // btn_showContent
            // 
            this.btn_showContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_showContent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_showContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_showContent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_showContent.FlatAppearance.BorderSize = 0;
            this.btn_showContent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btn_showContent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_showContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showContent.Font = new System.Drawing.Font("Steelfish Rg", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showContent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_showContent.Location = new System.Drawing.Point(576, 63);
            this.btn_showContent.Name = "btn_showContent";
            this.btn_showContent.Size = new System.Drawing.Size(233, 65);
            this.btn_showContent.TabIndex = 29;
            this.btn_showContent.Text = "Show Content";
            this.btn_showContent.UseVisualStyleBackColor = false;
            this.btn_showContent.Click += new System.EventHandler(this.btn_showContent_Click);
            // 
            // picture_adminImg
            // 
            this.picture_adminImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_adminImg.BackgroundImage")));
            this.picture_adminImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_adminImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_adminImg.Location = new System.Drawing.Point(106, 150);
            this.picture_adminImg.Name = "picture_adminImg";
            this.picture_adminImg.Size = new System.Drawing.Size(500, 500);
            this.picture_adminImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_adminImg.TabIndex = 28;
            this.picture_adminImg.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancel.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.cancel;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(1107, 665);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 65);
            this.btn_cancel.TabIndex = 25;
            this.toolTip_btns.SetToolTip(this.btn_cancel, "Cancel");
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_saveAdmin
            // 
            this.btn_saveAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_saveAdmin.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.diskette;
            this.btn_saveAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_saveAdmin.FlatAppearance.BorderSize = 0;
            this.btn_saveAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_saveAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_saveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveAdmin.Location = new System.Drawing.Point(825, 665);
            this.btn_saveAdmin.Name = "btn_saveAdmin";
            this.btn_saveAdmin.Size = new System.Drawing.Size(90, 65);
            this.btn_saveAdmin.TabIndex = 24;
            this.toolTip_btns.SetToolTip(this.btn_saveAdmin, "Save Changes");
            this.btn_saveAdmin.UseVisualStyleBackColor = false;
            this.btn_saveAdmin.Click += new System.EventHandler(this.btn_saveAdmin_Click);
            // 
            // btn_editAdmin
            // 
            this.btn_editAdmin.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_editAdmin.BackgroundImage = global::PuddinCoEmployees.Properties.Resources.writing;
            this.btn_editAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btn_editAdmin.FlatAppearance.BorderSize = 0;
            this.btn_editAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btn_editAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_editAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editAdmin.Location = new System.Drawing.Point(966, 665);
            this.btn_editAdmin.Name = "btn_editAdmin";
            this.btn_editAdmin.Size = new System.Drawing.Size(90, 65);
            this.btn_editAdmin.TabIndex = 23;
            this.toolTip_btns.SetToolTip(this.btn_editAdmin, "Edit Information");
            this.btn_editAdmin.UseVisualStyleBackColor = false;
            this.btn_editAdmin.Visible = false;
            // 
            // btn_credits
            // 
            this.btn_credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_credits.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_credits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_credits.FlatAppearance.BorderSize = 0;
            this.btn_credits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btn_credits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btn_credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credits.Font = new System.Drawing.Font("Steelfish Rg", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_credits.Location = new System.Drawing.Point(1448, 658);
            this.btn_credits.Name = "btn_credits";
            this.btn_credits.Size = new System.Drawing.Size(232, 77);
            this.btn_credits.TabIndex = 30;
            this.btn_credits.Text = "Credits";
            this.btn_credits.UseVisualStyleBackColor = false;
            this.btn_credits.Click += new System.EventHandler(this.btn_credits_Click);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1010);
            this.ControlBox = false;
            this.Controls.Add(this.btn_credits);
            this.Controls.Add(this.btn_showContent);
            this.Controls.Add(this.picture_adminImg);
            this.Controls.Add(this.btn_manageEmployees);
            this.Controls.Add(this.label_explain);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_saveAdmin);
            this.Controls.Add(this.btn_editAdmin);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.textBox_puddingID);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_puddingID);
            this.Controls.Add(this.btn_addPicture);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label_bigWelcome);
            this.Name = "Home_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Home";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_adminImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bigWelcome;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_addPicture;
        private System.Windows.Forms.Label label_puddingID;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_puddingID;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button btn_editAdmin;
        private System.Windows.Forms.Button btn_saveAdmin;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolTip toolTip_btns;
        private System.Windows.Forms.Label label_explain;
        private System.Windows.Forms.Button btn_manageEmployees;
        private System.Windows.Forms.PictureBox picture_adminImg;
        private System.Windows.Forms.Button btn_showContent;
        private System.Windows.Forms.Button btn_credits;
    }
}