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
    public partial class Manage_Form : MetroForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pudding_Employees;Integrated Security=True;");


        public Manage_Form()
        {
            InitializeComponent();
            SetDefaultCellStyle();
        }

        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [employee_information]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid_employeeInfo.DataSource = dta;
            conn.Close();
        }

        private void Manage_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pudding_EmployeesDataSet.employee_information' table. You can move, or remove it, as needed.
            this.employee_informationTableAdapter1.Fill(this.pudding_EmployeesDataSet.employee_information);


        }

        // set default styles for DataGridView -- DataGridView inherits the font of the parent container (in this case Tab Control)
        // Visual Studio is resetting the font style every time program is done compiling//running\

        private void SetDefaultCellStyle()
        {
            // default
            this.dataGrid_employeeInfo.DefaultCellStyle.Font = new Font("Arial", 10);
            // column headers
            this.dataGrid_employeeInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 11, FontStyle.Bold);

        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_Form home = new Home_Form();
            home.Show();
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand sqcmd = new SqlCommand("SELECT * FROM [employee_information] WHERE PuddingID='"
                                                            + textBox_puddingID.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.Close();
                MessageBox.Show("That Pudding ID already exists!");
            }
            else
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [employee_information] (PuddingID, FirstName, LastName, Email, Title, HireDate, Salary) VALUES ('" +
                                                                textBox_puddingID.Text + " ','" + textBox_firstName.Text + " ','" + textBox_lastname.Text + " ','" +
                                                                textBox_email.Text + " ','" + textBox_title.Text + " ','" + textBox_hireDate.Text + " ','" + textBox_salary.Text + " ')";
                string[] fieldArr = { textBox_puddingID.Text, textBox_firstName.Text,
                                      textBox_lastname.Text, textBox_email.Text, textBox_title.Text,
                                      textBox_hireDate.Text, textBox_salary.Text};

                for (int x = 0; x < fieldArr.Length; x++)
                {
                    if (fieldArr[x]  == "")
                    {
                        MessageBox.Show("Please fill out missing information.");
                        return;
                    }
                }

                cmd.ExecuteNonQuery();
                conn.Close();
                textBox_puddingID.Text = "";
                textBox_firstName.Text = "";
                textBox_lastname.Text = "";
                textBox_email.Text = "";
                textBox_title.Text = "";
                textBox_hireDate.Text = "";
                textBox_salary.Text = "";
                display_data();
                MessageBox.Show("New has been employee added.");
            }
        }

        private void dataGrid_employeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid_employeeInfo.Rows[myindex];

            string puddingID = row.Cells[0].Value.ToString();
            string firstname = row.Cells[1].Value.ToString();
            string lastname = row.Cells[2].Value.ToString();
            string email = row.Cells[3].Value.ToString();
            string title = row.Cells[4].Value.ToString();
            string hiredate = row.Cells[5].Value.ToString();
            string salary = row.Cells[6].Value.ToString();

            textBox_puddingID.Text = puddingID;
            textBox_puddingID.Enabled = false;

            textBox_firstName.Text = firstname;
            textBox_lastname.Text = lastname;
            textBox_email.Text = email;
            textBox_title.Text = title;
            textBox_hireDate.Text = hiredate;
            textBox_salary.Text = salary;

            textBox_puddingID.Enabled = false;
            textBox_firstName.Enabled = false;
            textBox_lastname.Enabled = false;
            textBox_email.Enabled = false;
            textBox_title.Enabled = false;
            textBox_hireDate.Enabled = false;
            textBox_salary.Enabled = false;

            btn_addEmployee.Hide(); // hide the add employee icon
            btn_edit.Show(); // show all edit, save and cancel icons
            btn_delete.Hide();
            btn_save.Hide();
            btn_cancel.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            textBox_puddingID.Enabled = false;
            textBox_firstName.Enabled = true;
            textBox_lastname.Enabled = true;
            textBox_email.Enabled = true;
            textBox_title.Enabled = true;
            textBox_hireDate.Enabled = true;
            textBox_salary.Enabled = true;

            btn_delete.Show();
            btn_save.Show();
            btn_cancel.Show();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [employee_information] SET " +
                              "FirstName='" + textBox_firstName.Text +
                              "', LastName='" + textBox_lastname.Text +
                              "', Email='" + textBox_email.Text +
                              "', Title='" + textBox_title.Text +
                              "', HireDate='" + textBox_hireDate.Text +
                              "', Salary='" + textBox_salary.Text +
                              "' WHERE PuddingID='" + textBox_puddingID.Text + "'";

            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();

            // reset text fields
            //textBox_puddingID.Text = "";
            textBox_firstName.Text = "";
            textBox_lastname.Text = "";
            textBox_email.Text = "";
            textBox_title.Text = "";
            textBox_hireDate.Text = "";
            textBox_salary.Text = "";

            btn_save.Hide(); // hide save button after saving data
            btn_edit.Hide();
            btn_cancel.Hide();
            btn_delete.Hide();
            btn_addEmployee.Show();

            textBox_puddingID.Enabled = true ;

            MessageBox.Show("Employee has information saved.");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [employee_information] WHERE PuddingID='" + textBox_puddingID.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();

            // reset text fields
            textBox_puddingID.Text = "";
            textBox_firstName.Text = "";
            textBox_lastname.Text = "";
            textBox_email.Text = "";
            textBox_title.Text = "";
            textBox_hireDate.Text = "";
            textBox_salary.Text = "";

            btn_save.Hide(); // hide save button after saving data
            btn_edit.Hide();
            btn_cancel.Hide();
            btn_delete.Hide();
            btn_addEmployee.Show();

            textBox_puddingID.Enabled = true;

            MessageBox.Show("Employee deleted");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = textBox_search.Text;
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM [employee_information] WHERE FirstName LIKE '%"
                                                + search + "%' OR LastName LIKE '%" + search +
                                                "%' OR PuddingID LIKE '%" + search + "%' OR Title LIKE '%" + search + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGrid_employeeInfo.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No record found");
                conn.Close();
            }
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            conn.Close();
            display_data();
            textBox_puddingID.Text = "";
            textBox_firstName.Text = "";
            textBox_lastname.Text = "";
            textBox_email.Text = "";
            textBox_title.Text = "";
            textBox_hireDate.Text = "";
            textBox_salary.Text = "";

            btn_save.Hide();
            btn_edit.Hide();
            btn_cancel.Hide();
            btn_delete.Hide();
            btn_addEmployee.Show();

            textBox_puddingID.Enabled = true;
            textBox_firstName.Enabled = true;
            textBox_lastname.Enabled = true;
            textBox_email.Enabled = true;
            textBox_title.Enabled = true;
            textBox_hireDate.Enabled = true;
            textBox_salary.Enabled = true;

        }
    }
}
