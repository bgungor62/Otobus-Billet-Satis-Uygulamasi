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
    public partial class frm_Kaptan : Form
    {
        public frm_Kaptan()
        {
            InitializeComponent();
        }

        OtobusBiletEntities3 db = new OtobusBiletEntities3();
        void list()
        {
            var klist = from x in db.Kaptan.OrderBy(x => x.KaptanAd).Where(x=>x.Silme==true) select new { x.id, x.KaptanAd, x.KaptanSoyad, x.TcNO, x.TelNO, x.Yas };
            dataGridView2.DataSource = klist.ToList();
        }
        void mj()
        {
            MessageBox.Show("İşleminiz gerçekleşmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void temizle()
        {
            txtId.Text = "";
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTc.Text = "";
            mskTel.Text = "";
            dateTimePicker1.Text = "";
            lblSnc.Text = "";

        }
        private void frm_Kaptan_Load(object sender, EventArgs e)
        {
            list();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "AD";
            dataGridView2.Columns[2].HeaderText = "SOYAD";
            dataGridView2.Columns[3].HeaderText = "TC KİMLİK";
            dataGridView2.Columns[4].HeaderText = "TELEFON NO";
            dataGridView2.Columns[5].HeaderText = "DOĞUM TARİHİ";
        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            mskTc.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            mskTel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            TimeSpan fark;
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            lblSnc.Text = "Kaptan " + yas / 365 + " yaşında.";
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (mskTc.Text != string.Empty && txtId.Text == string.Empty)
                {
                    Kaptan k = new Kaptan();
                    k.KaptanAd = txtAd.Text;
                    k.KaptanSoyad = txtSoyad.Text;
                    k.TcNO = mskTc.Text;
                    k.TelNO = mskTel.Text;
                    k.Yas = Convert.ToDateTime(dateTimePicker1.Text);
                    k.Silme = true;

                    db.Kaptan.Add(k);
                    db.SaveChanges();
                    mj();
                    list();
                    temizle();
                }
                else
                {
                    if (txtId.Text != string.Empty)
                    {
                        MessageBox.Show("Mevcut bir kayıt zaten var!");
                    }
                    if (txtId.Text == string.Empty)
                    {
                        MessageBox.Show("Boş kayıt geçilemez!");
                    }
                }
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
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("Güncelle işlemi için kayıt seçmelisiniz!");
                }
                else
                {
                    int x = Convert.ToInt32(txtId.Text);
                    var g = db.Kaptan.Find(x);
                    g.KaptanAd = txtAd.Text;
                    g.KaptanSoyad = txtSoyad.Text;
                    g.TcNO = mskTc.Text;
                    g.TelNO = mskTel.Text;
                    g.Yas = Convert.ToDateTime(dateTimePicker1.Text);
                    db.SaveChanges();
                    mj();
                    list();
                    temizle();
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
                if (txtId.Text == "")
                {
                    MessageBox.Show("Silme işlemi için kayıt seçmelisiniz!");
                }
                else
                {
                    int y = Convert.ToInt32(txtId.Text);
                    var sil = db.Kaptan.Find(y);
                    sil.Silme = false;
                    db.SaveChanges();
                    mj();
                    list();
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
            list();
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            mskTc.Text = string.Empty;
            mskTel.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = (from x in db.Kaptan
                                        where x.TcNO.Contains(mskTc.Text)
                                        select new
                                        { x.id, x.KaptanAd, x.KaptanSoyad, x.TcNO, x.TelNO, x.Yas }).ToList();

        }

       

        private void mskTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
