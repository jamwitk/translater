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
    public partial class Kelime_Ekle : Form
    {
        public Kelime_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source = arge-dev\\sql2014; Initial Catalog = Stajyer_Egitim; Persist Security Info=True;User ID = Lgn_Egitim; Password = Egitim123!");
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Sozcuk values ('"+txturkce.Text.ToString()+"','"+txtrusca.Text.ToString()+"','"+txtokunus.Text.ToString()+")",bag);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Kelime başarıyla eklendi!");
            txturkce.Text = "";
            txtrusca.Text = "";
            txtokunus.Text = "";
            bag.Close();
        }
    }
}
