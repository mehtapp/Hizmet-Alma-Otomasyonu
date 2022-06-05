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
    public partial class Talep : Form
    {
        ProcProjeDbEntities db = new ProcProjeDbEntities();

        public Talep()
        {
            InitializeComponent();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void TumTalepler()
        {
            dataGridView1.DataSource = db.TalepList().ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            TumTalepler();
        }

        private void checkBoxOnay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Talep_Load(object sender, EventArgs e)
        {
            comboBoxMusteri.DataSource = db.MusteriList().ToList();
            comboBoxMusteri.DisplayMember = "AdSoyad";
            comboBoxMusteri.ValueMember = "MusteriNo";
            comboBoxMusteri.SelectedIndex = -1;

            comboBoxHizmet.DataSource = db.HizmetlerList().ToList();
            comboBoxHizmet.DisplayMember = "HizmetAdi";
            comboBoxHizmet.ValueMember = "HizmetNo";    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtMusteriNot.Tag= row.Cells["TalepNo"].Value.ToString();
            int musNo= Convert.ToInt32(row.Cells["MusteriNo"].Value);
            comboBoxMusteri.Text = db.MusteriList().First(m => m.MusteriNo == musNo).AdSoyad;
            int hizmetNo = Convert.ToInt32(row.Cells["HizmetNo"].Value);
            comboBoxHizmet.Text = db.HizmetlerList().First(h => h.HizmetNo == hizmetNo).HizmetAdi;
            if (row.Cells["TalepDurumu"].Value.ToString()=="True")
            {
                checkBoxOnay.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxOnay.CheckState = CheckState.Unchecked;
            }

            txtMusteriNot.Text = row.Cells["MusteriNot"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Taleps talep = new Taleps();
            talep.MusteriNo = Convert.ToInt32(comboBoxMusteri.SelectedValue);
            talep.HizmetNo = Convert.ToInt32(comboBoxHizmet.SelectedValue);
            talep.MusteriNot = txtMusteriNot.Text;
            if (checkBoxOnay.Checked)
            {
                talep.TalepDurumu = true;
            }
            else
            {
                talep.TalepDurumu= false;
            }
            db.TalepAdd(talep.HizmetNo, talep.MusteriNo, talep.MusteriNot, talep.TalepDurumu);
            db.SaveChanges();
            TumTalepler();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Taleps talep = new Taleps();
            talep.TalepNo = Convert.ToInt32(txtMusteriNot.Tag);
            talep.HizmetNo = Convert.ToInt32(comboBoxHizmet.SelectedValue);
            talep.MusteriNo= Convert.ToInt32(comboBoxMusteri.SelectedValue);
            talep.MusteriNot = txtMusteriNot.Text;
            if (checkBoxOnay.Checked)
            {
                talep.TalepDurumu = true;
            }
            else
            {
                talep.TalepDurumu = false;
            }
            db.TalepUpdate(talep.TalepNo, talep.HizmetNo, talep.MusteriNo, talep.MusteriNot, talep.TalepDurumu);
            db.SaveChanges();
            TumTalepler();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Taleps talep = new Taleps();
            talep.TalepNo = Convert.ToInt32(txtMusteriNot.Tag);
            db.TalepDel(talep.TalepNo);
            db.SaveChanges();
            TumTalepler();
        }
    }
}
