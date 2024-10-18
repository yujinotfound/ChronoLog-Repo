using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ChronoLog {
    public partial class LogInGUI : Form {

        DatabaseConnection conn = new DatabaseConnection();
        ProgramData progdata = new ProgramData();

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader rd;
        
        public LogInGUI() {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e) {
            if (userIDInput.Text == "admin.uwu.ph" && passwordInput.Text == "Admin1234")
            {
                new ChronoControlCenter().Show();
                this.Hide();
            }
            else if (userIDInput.Text ==  "student.uwu.ph"&& passwordInput.Text == "Student1234")
            {
                cn = conn.GetConnection();
                cn.Open();

                progdata.UsageTimeStart = DateTime.Now;
                string timeStartString = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                cmd = new SqlCommand("");
                cmd.Parameters.AddWithValue("@Time Start", timeStartString);
                
            }
            else
            {
                MessageBox.Show("User Name and Password is incorrect");
                userIDInput.Clear();
                passwordInput.Clear();
                userIDInput.Focus();
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
