﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Create frmCreate = new Create();
            this.Hide();
            frmCreate.ShowDialog();

        }
    }
}
