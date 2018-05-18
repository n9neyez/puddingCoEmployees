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
    public partial class Credits_Form : MetroForm
    {
        public Credits_Form()
        {
            InitializeComponent();
        }

        private void Credits_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_Form home = new Home_Form();
            home.Show();
        }
    }
}
