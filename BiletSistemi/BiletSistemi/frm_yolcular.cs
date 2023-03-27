using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSistemi
{
    public partial class frm_yolcular : Form
    {
        public frm_yolcular()
        {
            InitializeComponent();
        }

        OtobusBiletEntities3 db = new OtobusBiletEntities3();

        /// <metod>
        void listele()
        {
            var sorgu = from x in db.Yolcu.Where(x => x.Silme == true)
                        select new
                        {

                            x.id,
                            x.YolcuAd,
                            x.YolcuSoyad,
                            x.TelNO,
                            x.TcNo,
                            x.YolcuMail,
                            x.Cinsiyet
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        void temizle()
        {
            txtId.Text = String.Empty;
            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            mskTel.Text = String.Empty;
            mskTc.Text = String.Empty;
            txtMail.Text = String.Empty;
            cmbCinsiyet.Text = String.Empty;
        }
        /// </metod>



        private void frm_yolcular_Load(object sender, EventArgs e)
        {
            listele();

            //datagridview isim düzenleme
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Yolcu Ad";
            dataGridView1.Columns[2].HeaderText = "Yolcu Soyad";
            dataGridView1.Columns[3].HeaderText = "Telefon No";
            dataGridView1.Columns[4].HeaderText = "TC No";
            dataGridView1.Columns[5].HeaderText = "Yolcu e-Mail";
            dataGridView1.Columns[6].HeaderText = "Cinsiyet";



        }
       
        /// <Crud>
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                Yolcu y = new Yolcu();
                var sorgu = from x in db.Yolcu where x.TcNo == mskTc.Text select x;
                if (sorgu.Any())
                {
                    MessageBox.Show("Böyle bir kayıt mevcut.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtAd.Text==string.Empty && mskTc.Text==string.Empty)
                {
                    MessageBox.Show("Boş kayıt yapılamaz");
                }
                else
                {


                    y.YolcuAd = txtAd.Text;
                    y.YolcuSoyad = txtSoyad.Text;
                    y.TcNo = mskTc.Text;
                    y.TelNO = mskTc.Text;
                    y.YolcuMail = txtMail.Text;
                    y.Cinsiyet = cmbCinsiyet.Text;
                    y.Silme = true;
                    db.Yolcu.Add(y);
                    db.SaveChanges();
                    MessageBox.Show("Yolcu kaydınız gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                    this.Hide();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }


        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text==string.Empty)
                {
                    MessageBox.Show("Bir kayıt seçmelisiniz!");
                }
                else
                {
                    int x = Convert.ToInt32(txtId.Text);
                    var sil = db.Yolcu.Find(x);
                    sil.Silme = false;
                    db.SaveChanges();
                    listele();
                    temizle();
                }
               
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }


        }
        /// </crud>



        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void mskTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                mskTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                mskTc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text==string.Empty)
                {
                    MessageBox.Show("Bir kayıt seçmelisiniz!");
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var guncelle = db.Yolcu.Find(id);
                    guncelle.YolcuAd = txtAd.Text;
                    guncelle.YolcuSoyad = txtSoyad.Text;
                    guncelle.TcNo = mskTc.Text;
                    guncelle.TelNO = mskTel.Text;
                    guncelle.YolcuMail = txtMail.Text;
                    guncelle.Cinsiyet = cmbCinsiyet.Text;
                    db.SaveChanges();
                    listele();
                    temizle();
                }
               

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            temizle();
            listele();
        }
    }
}
