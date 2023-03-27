using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSistemi
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        OtobusBiletEntities3 db = new OtobusBiletEntities3();




        private void frm_Login_Load(object sender, EventArgs e)
        {

        }


        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                var query = from x in db.Admin where x.Ad == txtAd.Text && x.Sifre == txtSifre.Text select x;
                if (query.Any())
                {
                    AnaForm form = new AnaForm();
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                var query = from x in db.Admin where x.Ad == txtAd.Text select x;
                if (query.Any())
                {
                    MessageBox.Show("Bu kullanıcı Adı ile bir kayıt var", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Admin a = new Admin();
                    a.Ad = txtAd.Text;
                    a.Sifre = txtSifre.Text;
                    db.Admin.Add(a);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt gerçekleşmiştri");
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void btnGiris_Click_2(object sender, EventArgs e)
        {
            try
            {
                var sorgu = from x in db.Admin where x.Ad == txtAd.Text && x.Sifre == txtSifre.Text select x;
                if (sorgu.Any())
                {

                    AnaForm form1 = new AnaForm();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre veya Kullanıcı adı!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void txtAd_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtAd.Clear();
            panel1.BackColor = Color.FromArgb(0, 195, 195);
            txtAd.ForeColor = Color.FromArgb(0, 195, 195);
            panel2.BackColor = Color.White;
            txtSifre.ForeColor = Color.White;
        }

        private void txtSifre_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtSifre.Clear();
            panel2.BackColor = Color.FromArgb(0, 195, 195);
            txtSifre.ForeColor = Color.FromArgb(0, 195, 195);
            panel1.BackColor = Color.White;
            txtAd.ForeColor = Color.White;
        }
    }
}
