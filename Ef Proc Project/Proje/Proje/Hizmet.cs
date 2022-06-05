using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class Hizmet : Form
    {
        ProcProjeDbEntities db = new ProcProjeDbEntities();
        public Hizmet()
        {
            InitializeComponent();
        }
        public void HizmetListele()
        {
            dataGridView1.DataSource = db.hizmet_Select();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HizmetListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizmetlers hizmet1 = new Hizmetlers();
            hizmet1.HizmetAdi = txtHAd.Text;
            hizmet1.HizmetTanimi = txtHTanim.Text;
            hizmet1.HizmetFiyat = Convert.ToInt32(txtHFiyat.Text);
            db.Hizmetler_add(hizmet1.HizmetAdi, hizmet1.HizmetTanimi, hizmet1.HizmetFiyat);
            db.SaveChanges();


        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri musteriSayfa = new Musteri();
            musteriSayfa.Show();
            this.Hide();
        }

        private void hizmetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hizmet hizmetiSayfa = new Hizmet();
            hizmetiSayfa.Show();
            this.Hide();
        }

        private void taleplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Talep talepSayfa = new Talep();
            talepSayfa.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TumHizmetler()
        {
            dataGridView1.DataSource = db.HizmetlerList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            TumHizmetler();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hizmetlers hizmets = new Hizmetlers();
            hizmets.HizmetAdi = txtHAd.Text;
            hizmets.HizmetTanimi = txtHTanim.Text;
            hizmets.HizmetFiyat = Convert.ToInt32(txtHFiyat.Text);
            db.Hizmetler_add(hizmets.HizmetAdi, hizmets.HizmetTanimi, hizmets.HizmetFiyat);
            db.SaveChanges();
            TumHizmetler();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hizmetlers hizmet = new Hizmetlers();
            hizmet.HizmetAdi = txtHAd.Text;
            hizmet.HizmetTanimi = txtHTanim.Text;
            hizmet.HizmetFiyat = Convert.ToInt32(txtHFiyat.Text);
            hizmet.HizmetNo = Convert.ToInt32(txtHAd.Tag);
            db.Hizmetler_up(hizmet.HizmetNo, hizmet.HizmetAdi, hizmet.HizmetTanimi, hizmet.HizmetFiyat);
            db.SaveChanges();
            TumHizmetler();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtHAd.Tag = row.Cells["HizmetNo"].Value;
            txtHAd.Text = row.Cells["HizmetAdi"].Value.ToString();
            txtHTanim.Text = row.Cells["HizmetTanimi"].Value.ToString();
            txtHFiyat.Text = row.Cells["HizmetFiyat"].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Hizmetlers hizmet = new Hizmetlers();
            db.Hizmetler_Del(Convert.ToInt32(txtHAd.Tag));
            db.SaveChanges();
            TumHizmetler();
        }
    }
}
