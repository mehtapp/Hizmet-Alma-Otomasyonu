using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Musteri : Form
    {
        ProcProjeDbEntities db= new ProcProjeDbEntities();  
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }
        public void musListele()
        {
            dataGridView1.DataSource = db.Mus_Select();
        }
        private void button1_Click(object sender, EventArgs e) //list
        {
            musListele();
        }

        private void button3_Click(object sender, EventArgs e) //add
        {
            Musterilers mus= new Musterilers();
            mus.AdSoyad = txt_adSoyad.Text;
            mus.Telefon = maskedTextBoxTel.Text;
            mus.Adres = txt_adres.Text;
            mus.Mail=txt_mail.Text;
            db.SaveChanges();
            musListele();
        }

        private void button2_Click(object sender, EventArgs e) //update
        {
            Musterilers mus = new Musterilers();
           // mus.MusteriNo = txt_adSoyad.Tag;
            mus.AdSoyad = txt_adSoyad.Text;
            mus.Telefon = maskedTextBoxTel.Text;
            mus.Adres = txt_adres.Text;
            mus.Mail = txt_mail.Text;
            //db.Musteriler_up(mus.MusteriNo, mus.AdSoyad, mus.Telefon, mus.Adres, mus.Mail);
        }

        private void button4_Click(object sender, EventArgs e)  //del
        {

        }
       
        private void radioB_kadin_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioBErkek_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txt_adSoyad.Tag = row.Cells["MusteriNo"].Value.ToString();
            txt_adSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
            txt_mail.Text = row.Cells["Mail"].Value.ToString();
            maskedTextBoxTel.Text = row.Cells["Telefon"].Value.ToString();
            txt_adres.Text = row.Cells["Adres"].Value.ToString();
           
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taleplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Talep talepSayfa = new Talep();
            talepSayfa.Show();
            this.Hide();
        }

        private void hizmetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hizmet hizmetiSayfa = new Hizmet();
            hizmetiSayfa.Show();
            this.Hide();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri musteriSayfa = new Musteri();
            musteriSayfa.Show();
            this.Hide();
        }
        private void TumMusteriler()
        {
            dataGridView1.DataSource = db.MusteriList().ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            TumMusteriler();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Musterilers mus = new Musterilers();
            mus.AdSoyad = txt_adSoyad.Text;
            mus.Adres = txt_adres.Text;
            mus.Mail= txt_mail.Text;
            mus.Telefon= maskedTextBoxTel.Text;
            db.Musteri_add(mus.AdSoyad, mus.Telefon, mus.Mail, mus.Adres);
            db.SaveChanges();
            TumMusteriler();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Musterilers mus = new Musterilers();
            mus.AdSoyad = txt_adSoyad.Text;
            mus.Adres= txt_adres.Text;
            mus.Mail = txt_mail.Text;
            mus.Telefon = maskedTextBoxTel.Text;
            mus.MusteriNo =Convert.ToInt32(txt_adSoyad.Tag);
            db.Musteriler_up(mus.MusteriNo, mus.AdSoyad, mus.Telefon, mus.Mail, mus.Adres);
            db.SaveChanges();
            TumMusteriler();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Musterilers mus = new Musterilers();
            db.Musteriler_del(Convert.ToInt32(txt_adSoyad.Tag));
            TumMusteriler();
        }
    }
}
