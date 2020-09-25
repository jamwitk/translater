using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE2Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=arge-dev\\sql2014;Initial Catalog=Stajyer_Egitim;Persist Security Info=True;User ID=Lgn_Egitim ; Password = Egitim123!");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (txtGiris.Text == "")
            //    txtCeviri.Text = "";
            lstCeviri.Items.Clear();
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select RUSSIAN From Words where TURKISH like '" + txtGiris.Text.ToString() + "%'", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                if (txtGiris.Text == ""  || txtGiris.Text=="Türkçe..")
                    txtCeviri.Text = "Çeviri";
                if (txtGiris.Text!="")
                  txtCeviri.Text = dr["RUSSIAN"].ToString();
               
                }
                else
                {
                  txtCeviri.Text = "";
                }
            baglanti.Close();
            
        }

        private void txtCikis_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtOkunus_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtGiris_Enter(object sender, EventArgs e)
        {
            if(txtGiris.Text=="Türkçe..")
            {
                txtGiris.Text = "";
               
                txtGiris.ForeColor = Color.Black;
            }
            else if(txtCeviri.Text=="Çeviri")
            {
                txtCeviri.Text = "";
                txtCeviri.ForeColor = Color.Black;
            }
        }

        private void txtGiris_Leave(object sender, EventArgs e)
        {
            if (txtGiris.Text == "")
            {
                txtGiris.Text = "Türkçe..";
               
                txtGiris.ForeColor = Color.Gray;
            }
            else if (txtCeviri.Text == "")
            {
                txtCeviri.Text = "Çeviri";
                txtCeviri.ForeColor = Color.Gray;
            }
        }

        
        private void cikistxt_Leave(object sender, EventArgs e)
        {
            if (txtGiris.Text == "")
            {
                txtGiris.Text = "Okunuþu";
                txtGiris.ForeColor = Color.Black;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDonwn)
            {
               mouseX = MousePosition.X - 200;
                mouse = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouse);
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDonwn = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDonwn = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int mouseX = 0, mouse = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kelime_Ekle ekle = new Kelime_Ekle();
            ekle.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            //SqlCommand komut = new SqlCommand("SELECT Okunus from Sozcuk where Turkish = '" + txtGiris.Text.ToString() + "'", baglanti);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    cikistxt.ForeColor = Color.Black;
            //    cikistxt.Text = dr[0].ToString();

            //}
            //    komut = new SqlCommand("SELECT Russian,Okunus from Sozcuk where Turkish = '" + lstCeviri.SelectedItem.ToString() + "'", baglanti);
            //    while (dr.Read())
            //    {
            //        cikistxt.ForeColor = Color.Black;
            //        cikistxt.Text = dr[1].ToString();

            //    }
            //    baglanti.Close();
        }

        private void lstCeviri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(607,430);
            
            lstCeviri.Visible = true;
            lstCeviri.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select TURKISH,RUSSIAN From Words", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
            //    cmd.CommandText = "select RUSSIAN from Words where TURKISH = '"+txtGiris.Text+"'";
            //    cmd.ExecuteReader();
            //    while(dr.Read())
            //    {
            //        //cikistxt.Text = dr["RUSSIAN"].ToString();
               //}
            lstCeviri.Items.Add(dr["TURKISH"].ToString() + " - " + dr["RUSSIAN"].ToString());
            }

            baglanti.Close();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
           
        }

        private void btngizle_Click(object sender, EventArgs e)
        {
            this.Size = new Size(607, 220);
            lstCeviri.Items.Clear();
            lstCeviri.Visible = false;
        }

        private void txtCeviri_TextChanged(object sender, EventArgs e)
        {

        }

        

        bool mouseDonwn;

        
    }
}
