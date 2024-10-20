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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChronoLog
{
    public partial class ChronoControlCenter : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        ProgramData progdata = new ProgramData();

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader rd;
        public ChronoControlCenter()
        {
            InitializeComponent();
        }

        private void ChronoControlCenter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chronoLogDBDataSet1.ChronoLogDB' table. You can move, or remove it, as needed.
            this.chronoLogDBTableAdapter.Fill(this.chronoLogDBDataSet1.ChronoLogDB);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = conn.GetConnection();
            cn.Open();

            string query = "SELECT * FROM ChronoLogDB WHERE [User Name] = @userName";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                dataGridView1.DataSource = null;

                // Parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@userName", searchBox.Text);  // Assuming textbox1 contains the username to search

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                // Fill the DataTable with the query result
                adapter.Fill(table);

                // Check if any rows were returned
                if (table.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No results found for this search.");
                }
            }
            /** using (SqlDataReader reader = cmd.ExecuteReader())
             {
                 if (reader.Read())
                 {
                     string userName = reader["User Name"].ToString();
                     string timeStart = reader["Time Start"].ToString();
                     string timeEnd = reader["Time End"].ToString();

                     MessageBox.Show($"User: {userName}\nTime Start: {timeStart}\nTime End: {timeEnd}");
                 }
                 else
                 {
                     MessageBox.Show("User not found.");
                 }
             } */
       
            cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
