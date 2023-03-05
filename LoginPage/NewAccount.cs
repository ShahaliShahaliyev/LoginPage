using System;
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
    public partial class NewAccount : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server =localhost\SQLEXPRESS; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;");

        public NewAccount()
        {
            InitializeComponent();
        }


        //CREATE ACCOUNT
        private void BHesabYar_Click(object sender, EventArgs e)
        {

            User user = new User();

            user.Ad = NAAd.Text;
            user.Soyad = NASoyAd.Text;
            user.DogumTarixi = NADT.Value;
            user.Telefon = "+994" + NAT.Text;
            user.Cins = Cins;
            user.IstifadeciAdi = NAIsAd.Text;
            user.Sifre = NASifr.Text;

            if (user.Sifre.Length < 8 || user.IstifadeciAdi.Length == 0)
            {
                MessageBox.Show("İSTİFADƏÇİ ADI OLMALIDIR VƏ ŞİFRƏ ƏN AZ 8 SİMVOL OLMALIDIR!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "ən az 8 simvol daxil edin!";

                if (user.Ad.Length == 0 || user.Soyad.Length == 0 || user.Cins.Length == 0)
                {
                    MessageBox.Show("DAXİL EDİLƏNLƏRİN DÜZGÜNLÜYÜNÜ YOXLAYIN!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (user.Telefon.ToString().Length == 0)
                {
                    MessageBox.Show("TELEFON NÖMRƏSİ DAXİL EDİN!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

            }
            else
            {
                label1.Text = "";

                CreateNewAccount(user);

                MessageBox.Show("Hesab Yaradıldı");


                Form1 form1 = new Form1();
                form1.ShowDialog();
                Application.Exit();
            }

        }

        public void CreateNewAccount(User user)
        {
            sqlConnection.Open();

            SqlCommand command =
                new SqlCommand(
                    "insert into IstifadeciMelumati values (@ad,@soyad,@dogumTarixi,@telefon,@cins,@istifadeciAdi,@sifre)", sqlConnection);
            command.Parameters.AddWithValue("Ad", user.Ad);
            command.Parameters.AddWithValue("Soyad", user.Soyad);
            command.Parameters.AddWithValue("DogumTarixi", user.DogumTarixi);
            command.Parameters.AddWithValue("Telefon", user.Telefon);
            command.Parameters.AddWithValue("Cins", user.Cins);
            command.Parameters.AddWithValue("IstifadeciAdi", user.IstifadeciAdi);
            command.Parameters.AddWithValue("Sifre", user.Sifre);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }


        //GENDER
        private string Cins;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Cins = "Kişi";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Cins = "Qadın";
        }


        //SUGGESTIONS
        private void NAIsAd_Click(object sender, EventArgs e)
        {
            NAIsAd.Items.Clear();

            NAIsAd.Items.Add(NAAd.Text + NASoyAd.Text);
            NAIsAd.Items.Add(NAAd.Text + NADT.Value.Year);
            NAIsAd.Items.Add(NASoyAd.Text + NADT.Value.Year);
        }


        //SHOW PASSWORD
        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.CheckState == CheckState.Checked)
            {
                NASifr.UseSystemPasswordChar = true;
                cbShow.Text = "Gizlət";
            }else if (cbShow.CheckState == CheckState.Unchecked)
            {
                NASifr.UseSystemPasswordChar = false;
                cbShow.Text = "Göstər";
            }
        }



        //DARK
        private void rbIsiqli_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox4.BackColor = Color.DeepSkyBlue;
            groupBox5.BackColor = Color.DeepSkyBlue;
            groupBox7.BackColor = Color.DeepSkyBlue;
            NACins.BackColor = Color.DeepSkyBlue;
            NAIstAd.BackColor = Color.DeepSkyBlue;
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            groupBox4.ForeColor = Color.Black;
            groupBox5.ForeColor = Color.Black;
            groupBox7.ForeColor = Color.Black;
            NACins.ForeColor = Color.Black;
            NAIstAd.ForeColor = Color.Black;
        }

        private void rbqara_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Black;
            groupBox2.BackColor = Color.Black;
            groupBox4.BackColor = Color.Black;
            groupBox5.BackColor = Color.Black;
            groupBox7.BackColor = Color.Black;
            NACins.BackColor = Color.Black;
            NAIstAd.BackColor = Color.Black;
            groupBox1.ForeColor = Color.Red;
            groupBox2.ForeColor = Color.Red;
            groupBox4.ForeColor = Color.Red;
            groupBox5.ForeColor = Color.Red;
            groupBox7.ForeColor = Color.Red;
            NACins.ForeColor = Color.Red;
            NAIstAd.ForeColor = Color.Red;
        }
    }
}
