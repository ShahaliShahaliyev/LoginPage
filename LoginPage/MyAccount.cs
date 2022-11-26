﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class MyAccount : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server =localhost; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;");

        public MyAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HAd.Enabled = true;
            HSoyad.Enabled = true;
            HTel.Enabled = true;
            HAciqlama.Enabled = true;
            BtnYadda.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("HESABDAN ÇIXMAQ İSTƏYİRSİZ?", "QUESTION", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Application.Exit();
            }
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {

            HAd.Enabled = false;
            HSoyad.Enabled = false;
            HTel.Enabled = false;
            HAciqlama.Enabled = false;
            BtnYadda.Enabled = false;
        }

        private void BtnYadda_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Məlumatlar yenilənsin?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

            }

            HAd.Enabled = false;
            HSoyad.Enabled = false;
            HTel.Enabled = false;
            HAciqlama.Enabled = false;
            BtnYadda.Enabled = false;

        }
    }
}
