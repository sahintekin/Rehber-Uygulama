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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace RehberProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True");
        void listele()
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter( " Select * From Kisiler",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        
        }

        void temizle()
        {        
             textID.Text = "";
             textAD.Text = "";
             textSOYAD.Text = "";
             mtextTel.Text = "";
             textMAIL.Text= "@gmail.com";            
            textAD.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {  
                try
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("Insert Into Kisiler(Ad, Soyad ,Telefon ,Mail) values (@P1,@P2,@P3,@P4)", baglanti);
                    komut.Parameters.AddWithValue("@P1", textAD.Text);
                    komut.Parameters.AddWithValue("@P2", textSOYAD.Text);
                    komut.Parameters.AddWithValue("@P3", mtextTel.Text);
                    komut.Parameters.AddWithValue("@P4", textMAIL.Text);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("KİŞİ SİSTEME KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
                     temizle();
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mtextTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textMAIL.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kişiyi Rehberden silmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Kisiler where ID=" + textID.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
                temizle();
            }
                else if (result == DialogResult.No)
                  {
                
                   }

            listele();
            temizle();

            }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kisiler set Ad=@P1,Soyad=@P2,Telefon=@P3,Mail=@P4 WHERE ID=@P5",baglanti);
            komut.Parameters.AddWithValue("@P1", textAD.Text);
            komut.Parameters.AddWithValue("@P2", textSOYAD.Text);
            komut.Parameters.AddWithValue("@P3", mtextTel.Text);
            komut.Parameters.AddWithValue("@P4", textMAIL.Text);
            komut.Parameters.AddWithValue("@P5", textID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }
    }
  }
    

