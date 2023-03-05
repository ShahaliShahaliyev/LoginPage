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
    public partial class MyAccount : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server =.\SQLEXPRESS; Database=LoginPage; Trusted_Connection=true;TrustServerCertificate=true;");

        public MyAccount()
        {
            InitializeComponent();
        }

        //ENABLE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            HAd.Enabled = true;
            HSoyad.Enabled = true;
            HTel.Enabled = true;
            HAciqlama.Enabled = true;
            BtnYadda.Enabled = true;
        }
        //EXIT FROM ACCOUNT
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
        //LOAD
        private void MyAccount_Load(object sender, EventArgs e)
        {
            
            ReadInformation();
            HQeydler.DataSource = Qeyd();

            HAd.Enabled = false;
            HSoyad.Enabled = false;
            HTel.Enabled = false;
            HAciqlama.Enabled = false;
            BtnYadda.Enabled = false;

        }


        //UPDATE INFO
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
        //NEW NOTE
        public void YeniQeyd(MyProfile myProfile)
        {
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Profil values (@qeyd,@qeydTarixi) ", sqlConnection);
            
            cmd.Parameters.AddWithValue("Qeyd",myProfile.Qeyd);
            cmd.Parameters.AddWithValue("QeydTarixi", myProfile.QeydTarixi);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }


        //SAVE NEW NOTE
        private void HYeniQeyd_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Qeyd = HYeniAciq.Text;
            myProfile.QeydTarixi = DateTime.Now;
            YeniQeyd(myProfile);

            HYeniAciq.Clear();

            HQeydler.DataSource = Qeyd();

        }

        //READ INFO
        public List<MyProfile> ReadInformation()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from IstifadeciMelumati ", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<MyProfile> list = new List<MyProfile>();
            while (sqlDataReader.Read())
            {
                MyProfile myProfile = new MyProfile();

                myProfile.Id = Convert.ToInt32(sqlDataReader["ID"]);
                myProfile.Ad = sqlDataReader.GetString("Ad");
                myProfile.Soyad = sqlDataReader.GetString("Soyad");
                //myProfile.Telefon = Convert.ToInt32(sqlDataReader["Telefon"]);
                //myProfile.Aciqlama = sqlDataReader.GetString("Aciqlama");
                //myProfile.Qeyd = sqlDataReader.GetString("Qeyd");
                list.Add(myProfile);

                HAd.Text = myProfile.Ad;
                HSoyad.Text = myProfile.Soyad;
                HTel.Text =Convert.ToString( myProfile.Telefon);
                HAciqlama.Text = myProfile.Aciqlama;

            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }

        //READ NOTE
        public List<Qeydler> Qeyd()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select Qeyd,QeydTarixi from Profil where UserID = 8", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Qeydler> list = new List<Qeydler>();
            while (sqlDataReader.Read())
            {
                Qeydler qeydler = new Qeydler();
                qeydler.Qeyd = sqlDataReader.GetString(0);
                qeydler.QeydTarixi = DateTime.Now;
                list.Add(qeydler);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }

    }
}
