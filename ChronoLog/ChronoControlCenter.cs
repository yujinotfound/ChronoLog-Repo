using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChronoLog
{
    public partial class ChronoControlCenter : Form
    {
        public ChronoControlCenter()
        {
            InitializeComponent();
        }

        private void AdMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chronoLogDBDataSet1.ChronoLogDB' table. You can move, or remove it, as needed.
            this.chronoLogDBTableAdapter.Fill(this.chronoLogDBDataSet1.ChronoLogDB);

        }

        private void logoName_Click(object sender, EventArgs e)
        {

        }
    }
}
