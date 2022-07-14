using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server =.\SQLEXPRESS; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
        }

        private void BDaxil_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection sqlConnection = new SqlConnection(@"Server =.\SQLEXPRESS; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;"))
                {
                    string query = "Select * from IstifadeciMelumati where IstifadeciAdi = '" + LIstAd.Text.Trim() + "' AND Sifre = '" + LSif.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MyAccount account = new MyAccount();
                        account.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("HESAB TAPILMADI!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        public bool IsValid()
        {
            if (LIstAd.Text.TrimStart() == string.Empty || LSif.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("XƏTALI GİRİŞ \r\n " +
                                "İSTİFADƏÇİ ADI VƏ YA ŞİFRƏ YANLIŞDIR! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnShow_MouseEnter(object sender, EventArgs e)
        {
                LSif.UseSystemPasswordChar = true;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            LSif.UseSystemPasswordChar = false;
        }
    }
}
