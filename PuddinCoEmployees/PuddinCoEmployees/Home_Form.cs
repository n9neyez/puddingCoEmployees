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
using System.IO;

namespace PuddinCoEmployees
{
    public partial class Home_Form : MetroForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PuddingAdminProfile;Integrated Security=True;");

        public Home_Form()
        {
            InitializeComponent();
            
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            loadStuff();
        }

        string imgLoc = "";
        string existingImgLoc = "";
        SqlCommand cmd;
        public void loadStuff()
        {
            textBox_puddingID.Text = "101";
            //textBox_firstname.Text = "";
            //textBox_lastname.Text = "";
            //textBox_email.Text = "";
            //textBox_title.Text = "Director";
            //picture_adminImg.Image = null;
            
            textBox_puddingID.Enabled = false;
            textBox_title.Enabled = false;

        }


        // Log Out button
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }

        // Cancel icon
        private void btn_cancel_Click(object sender, EventArgs e)
        {

            textBox_firstname.Text = "Please enter first";
            textBox_lastname.Text = "Please enter last name";
            textBox_email.Text = "Please enter an e-mail address";

            textBox_firstname.Enabled = true;
            textBox_lastname.Enabled = true;
            textBox_email.Enabled = true;
        }

        // MANAGE EMPLOYEES
        private void btn_manageEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_Form manage = new Manage_Form();
            manage.Show();
        }

        // SHOW CONTENT BUTTON
        private void btn_showContent_Click(object sender, EventArgs e)
        {
            if (textBox_puddingID.Text == "")
            {
                MessageBox.Show("Pudding ID is not valid.");
                loadStuff();
                return;
            }
            else
            {
                btn_saveAdmin.Enabled = true;

                string showQuery = "SELECT * FROM Profile WHERE PuddingID=" + textBox_puddingID.Text;
                conn.Open();
                cmd = new SqlCommand(showQuery, conn);

                try
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            // populate the fields
                            textBox_firstname.Text = reader[1].ToString();
                            textBox_lastname.Text = reader[2].ToString();
                            textBox_email.Text = reader[3].ToString();

                            // load the image
                            byte[] img = (byte[])(reader[5]);

                            if (img == null)
                            {
                                picture_adminImg.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picture_adminImg.Image = Image.FromStream(ms);
                            }

                            existingImgLoc = reader[6].ToString();

                        }
                        else
                        {
                            MessageBox.Show("This ID does not exist");
                            conn.Close();
                            loadStuff();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            conn.Close();

        } // END show btn click

        // add picture button
        private void btn_addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();

            fileSelect.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            fileSelect.Title = "Select Image";

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                imgLoc = fileSelect.FileName.ToString();
                picture_adminImg.ImageLocation = imgLoc;
            }
        }

        private void btn_saveAdmin_Click(object sender, EventArgs e)
        {
            byte[] myImage = null;
            conn.Open();

            try
            {
                if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_email.Text == "")
                {
                    MessageBox.Show("Please enter missing information.");
                    conn.Close();
                    return;
                }

                string showQuery = "SELECT PuddingID FROM Profile WHERE PuddingID=" + textBox_puddingID.Text;

                cmd = new SqlCommand(showQuery, conn);
                /*
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("ID already exists");
                        conn.Close();
                        return;
                    }
                }
                */
                if (imgLoc.Equals(""))
                {
                    MessageBox.Show("Please select and image to add");
                    conn.Close();
                    return;
                }
                else
                {
                    FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);
                    myImage = br.ReadBytes((int)fStream.Length);

                    string imgInsertQuery = "Insert into Profile(PuddingID,FirstName,LastName,Email,Title,Image,ImageLoc)Values('"
                                                            + textBox_puddingID.Text + "','" + textBox_firstname.Text + "','" + textBox_lastname.Text
                                                            + "','" + textBox_email.Text + "','" + textBox_title.Text + "',@myImage, '" + imgLoc + "')";

                    cmd = new SqlCommand(imgInsertQuery, conn);
                    cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Save successful");
                    conn.Close();
                    loadStuff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }        // end save button click

        private void btn_credits_Click(object sender, EventArgs e)
        {
            this.Close();
            Credits_Form credits = new Credits_Form();
            credits.Show();
        }
    }
}
