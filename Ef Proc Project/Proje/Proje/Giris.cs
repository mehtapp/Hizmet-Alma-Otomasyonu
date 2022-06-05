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
    public partial class Giris : Form
    {
        ProcProjeDbEntities db=new ProcProjeDbEntities();
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        { string kulAd, sifre;
            kulAd = log_username.Text;
            sifre = log_password.Text;
            if (!db.Calisanlogin(kulAd, sifre).Any())
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Tekrar deneyiniz.");
                log_password.Clear();
                log_username.Clear();
            }
            else
            {
                Form1 anasayfa= new Form1();
                anasayfa.Show();
                this.Hide();
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text!="" && txtPssword.Text!="")
                {
                    Calisans calisan1 = new Calisans();
                    calisan1.KulAd = txt_userName.Text;
                    calisan1.Sifre = txtPssword.Text;
                if (!db.CalisanKulAdKONTROL(calisan1.KulAd).Any())
                    {
                        db.Calisan_add(calisan1.KulAd, calisan1.Sifre);
                        db.SaveChanges();
                        Form1 anasayfa= new Form1();
                        anasayfa.Show();
                        this.Hide();

                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı alınmış. Başka seçiniz.");
                    txt_userName.Clear();
                }
                
                
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz.");
            }
            

          
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
