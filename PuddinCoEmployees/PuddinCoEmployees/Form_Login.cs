using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient; // import sql namespace

namespace PuddinCoEmployees
{
    public partial class Form_Login : MetroForm
    {
        public Form_Login()
        {
            InitializeComponent();

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            // initially hide all of these messages and spinner
            label_welcome.Hide();
            metro_spinner.Hide();
            label_errorMsg.Hide();
            label_showLogin.Hide();
        }

        // Log In button click
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            // connect to the pudding_admin_login database
            SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pudding_admin_login;Integrated Security=True;");

            connect.Open();
            // compare what is typed into the username and password fields/textboxes to the LoginDetails Talble
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM LoginDetails WHERE UserName='" + textBox_username.Text
                                              + "' and Password='" + textBox_password.Text + "'", connect);

            SqlDataAdapter adapter = new SqlDataAdapter(sqcmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                label_welcome.Show();
                metro_spinner.Show();
                label_errorMsg.Hide(); // won't show unless failed login
                label_showLogin.Hide(); // won't show unless failed login
                btn_exit.Hide();
                timer_login.Enabled = true; // timer will give false loading, and display the new Home Page
                //this.Hide();

            }
            else
            {
                label_errorMsg.Show(); // give error message
                label_showLogin.Show(); // show login information for sake of project
                label_welcome.Hide(); // won't show the welcome message unless successful login 
                metro_spinner.Hide(); // won't show loading spinner unless successful login

            }
            connect.Close();
        }

        // timer for clicking login button, if successful will take user to main content page
        private void timer_login_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Home_Form home = new Home_Form();
            home.Show();
            timer_login.Enabled = false;
            
            // clear controls
            textBox_username.Text = null;
            textBox_password.Text = null;
            label_welcome.Hide();
            metro_spinner.Hide();
            btn_exit.Show();
        }

        // exit button closes the program...obviously
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // end timer
    }
}
