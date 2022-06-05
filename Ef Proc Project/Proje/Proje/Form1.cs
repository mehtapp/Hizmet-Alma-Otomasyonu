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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteriSayfa= new Musteri();
            musteriSayfa.Show();
            this.Hide();

        }

        private void btnHizmet_Click(object sender, EventArgs e)
        {
            Hizmet hizmetiSayfa= new Hizmet();
            hizmetiSayfa.Show();
            this.Hide();
        }

        private void btnTalep_Click(object sender, EventArgs e)
        {
            Talep talepSayfa= new Talep();
            talepSayfa.Show();
            this.Hide();
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
    }
}
