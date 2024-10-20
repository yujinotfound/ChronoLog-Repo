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

                cn = conn.GetConnection();
                cn.Open();

                // Step 2: Capture the current time as a string (formatted for the varchar column)
                string timeStartString = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                string timeEndString = DateTime.Now.ToString("dd MMM yyy HH:mm:ss");

                // Step 3: Prepare the SQL query with the parameter placeholder
                string query = "INSERT INTO ChronoLogDB ([User Name],[Time Start],[Time End]) VALUES (@userIDInput, @TimeStart, @TimeEnd)";
                cmd = new SqlCommand(query, cn);

                // Step 4: Use AddWithValue to insert the string (formatted datetime) into the database
                cmd.Parameters.AddWithValue("@userIDInput", userIDInput.Text);
                cmd.Parameters.AddWithValue("@TimeStart", timeStartString);
                cmd.Parameters.AddWithValue("@TimeEnd", timeEndString);

                // Step 5: Execute the command to perform the insert
                cmd.ExecuteNonQuery();

                // Step 6: Show a success message
                MessageBox.Show("Login successful");
            }
            else if (userIDInput.Text ==  "student.uwu.ph"&& passwordInput.Text == "Student1234")
            {
                    // Step 1: Get the connection and open it
                    cn = conn.GetConnection();
                    cn.Open();

                    // Step 2: Capture the current time as a string (formatted for the varchar column)
                    string timeStartString = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                string timeEndString = DateTime.Now.ToString("dd MMM yyy HH:mm:ss");

                    // Step 3: Prepare the SQL query with the parameter placeholder
                    string query = "INSERT INTO ChronoLogDB ([User Name],[Time Start],[Time End]) VALUES (@userIDInput, @TimeStart, @TimeEnd)";
                    cmd = new SqlCommand(query, cn);

                    // Step 4: Use AddWithValue to insert the string (formatted datetime) into the database
                    cmd.Parameters.AddWithValue("@userIDInput", userIDInput.Text);
                    cmd.Parameters.AddWithValue("@TimeStart", timeStartString);
                    cmd.Parameters.AddWithValue("@TimeEnd", timeEndString);

                    // Step 5: Execute the command to perform the insert
                    cmd.ExecuteNonQuery();

                    // Step 6: Show a success message
                    MessageBox.Show("Login successful");
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
