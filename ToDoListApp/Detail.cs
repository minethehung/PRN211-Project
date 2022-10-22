using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9_Project
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            txtName.Enabled = false;
            txtTitle.Enabled = false;
            txtRemind.Enabled = false;
            dateTimeDeadline.Enabled = false;
            comboImportant.Enabled = false;
            txtRepeat.Enabled = false;
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtTitle.Enabled = true;
            txtRemind.Enabled = true;
            dateTimeDeadline.Enabled = true;
            comboImportant.Enabled = true;
            txtRepeat.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
