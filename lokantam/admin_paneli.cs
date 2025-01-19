using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ders_baslangic
{
    public partial class admin_paneli : Form
    {
        public admin_paneli()
        {
            InitializeComponent();
        }
         

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglati.baglan.Open();
                SqlCommand uyeol = new SqlCommand("insert into anayemekler (anayemek) values (@anayemek) ", baglati.baglan);
                uyeol.Parameters.AddWithValue("@anayemek", textBox1.Text); 

                uyeol.ExecuteNonQuery();

                baglati.baglan.Close();

                MessageBox.Show("anayemek eklendi"); 

            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglati.baglan.Open();
                SqlCommand uyeol = new SqlCommand("insert into tatlilar (tatli) values (@tatli) ", baglati.baglan);
                uyeol.Parameters.AddWithValue("@tatli", textBox1.Text); 

                uyeol.ExecuteNonQuery();

                baglati.baglan.Close();

                MessageBox.Show("tatlı eklendi"); 

            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglati.baglan.Open();
                SqlCommand uyeol = new SqlCommand("insert into corbalar (corba) values (@corba) ", baglati.baglan);
                uyeol.Parameters.AddWithValue("@corba", textBox1.Text); 

                uyeol.ExecuteNonQuery();

                baglati.baglan.Close();

                MessageBox.Show("çorba eklendi");

                 

            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
        }
 

        private void button5_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox4.Text);

            var result = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                var result2 = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    baglati.baglan.Open();
                    SqlCommand sil = new SqlCommand("delete from ders1 where kullanici_id=" + sil_id, baglati.baglan);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("kullanici silindi");

                    baglati.baglan.Close();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();


                textBox5.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçilmedi");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int idverisi = int.Parse(textBox4.Text);

            baglati.baglan.Open();

            SqlCommand sifreguncelle = new SqlCommand("update anayemekler set anayemek=@anayemek where id=" + idverisi, baglati.baglan);

            sifreguncelle.Parameters.AddWithValue("@anayemek", textBox5.Text);

            sifreguncelle.ExecuteNonQuery();

            baglati.baglan.Close();

            MessageBox.Show("anayemekler güncellendi");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idverisi = int.Parse(textBox6.Text);

            baglati.baglan.Open();

            SqlCommand sifreguncelle = new SqlCommand("update tatlilar set tatli=@tatli where id=" + idverisi, baglati.baglan);

            sifreguncelle.Parameters.AddWithValue("@tatli", textBox3.Text);

            sifreguncelle.ExecuteNonQuery();

            baglati.baglan.Close();

            MessageBox.Show("tatli güncellendi");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int idverisi = int.Parse(textBox7.Text);

            baglati.baglan.Open();

            SqlCommand sifreguncelle = new SqlCommand("update corbalar set corba=@corba where id=" + idverisi, baglati.baglan);

            sifreguncelle.Parameters.AddWithValue("@corba", textBox2.Text);

            sifreguncelle.ExecuteNonQuery();

            baglati.baglan.Close();

            MessageBox.Show("corba güncellendi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idverisi = int.Parse(textBox4.Text);

            try
            {
                baglati.baglan.Open();

                // Delete related records in 'yemek' first
                SqlCommand deleteYemek = new SqlCommand("DELETE FROM yemek WHERE anayemek = @id", baglati.baglan);
                deleteYemek.Parameters.AddWithValue("@id", idverisi);
                deleteYemek.ExecuteNonQuery();

                // Now delete from 'anayemekler'
                SqlCommand deleteAnayemek = new SqlCommand("DELETE FROM anayemekler WHERE id = @id", baglati.baglan);
                deleteAnayemek.Parameters.AddWithValue("@id", idverisi);
                deleteAnayemek.ExecuteNonQuery();

                baglati.baglan.Close();
                MessageBox.Show("anayemekler silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox6.Text);

            var result = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                var result2 = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    baglati.baglan.Open();
                    SqlCommand sil = new SqlCommand("delete from tatlilar where id=" + sil_id, baglati.baglan);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("tatlilar silindi");

                    baglati.baglan.Close();

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int sil_id = int.Parse(textBox4.Text);

            var result = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                var result2 = MessageBox.Show("Bak emin misin", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    baglati.baglan.Open();
                    SqlCommand sil = new SqlCommand("delete from corbalar where id=" + sil_id, baglati.baglan);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("corba silindi");

                    baglati.baglan.Close();

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = search.Text;
                string komut = @"
    select * 
    from yemek
    inner join ders1 on yemek.kullanici = ders1.kullanici_id 
    inner join anayemekler on yemek.anayemek = anayemekler.id 
    inner join corbalar on yemek.corba = corbalar.id 
    inner join tatlilar on yemek.tatli = tatlilar.id 
    where anayemekler.anayemek like @arama";

                //"select * from ders1 where ad like '%" + arama + "%'"

               
                baglati.baglan.Open();
                SqlCommand ara = new SqlCommand(komut, baglati.baglan);
                ara.Parameters.AddWithValue("@arama", "%" + arama + "%");
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                baglati.baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("hata çikti", "!!hata!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Close();

            }
             
        }



    }
 
}
