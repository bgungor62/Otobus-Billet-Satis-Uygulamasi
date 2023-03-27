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
    public partial class frm_muavin : Form
    {
        public frm_muavin()
        {
            InitializeComponent();
        }
        OtobusBiletEntities3 bg = new OtobusBiletEntities3();

       
        void mj()
        {
            MessageBox.Show("İşleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void temizle()
        {
            txtId.Text = string.Empty;
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            mskTc.Text = string.Empty;
            mskTel.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            lblSnc.Text = string.Empty;

        }


        //listeleme için metod
        void listele()
        {


            var list = from x in bg.Muavin.OrderBy(x => x.MuavinAd).Where(x=>x.Silme==true)
                       select new
                       {
                           x.id,
                           x.MuavinAd,
                           x.MuavinSoyad,
                           x.TcNo,
                           x.TelNo,
                           x.Yas
                       };
            metroGrid1.DataSource = list.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text != string.Empty && txtId.Text == string.Empty)
                {
                    Muavin m = new Muavin();
                    m.MuavinAd = txtAd.Text;
                    m.MuavinSoyad = txtSoyad.Text;
                    m.TcNo = mskTc.Text;
                    m.TelNo = mskTel.Text;
                    m.Yas = Convert.ToDateTime(dateTimePicker1.Text);
                    m.Silme = true;
                    bg.Muavin.Add(m);
                    bg.SaveChanges();
                    mj();
                    listele();
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
                        MessageBox.Show("Boş kayıt yapılamaz!");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
          
           
        }

        private void frm_muavin_Load(object sender, EventArgs e)
        {
            listele();
            metroGrid1.Columns[0].HeaderText = "ID";
            metroGrid1.Columns[1].HeaderText = "AD";
            metroGrid1.Columns[2].HeaderText = "SOYAD";
            metroGrid1.Columns[3].HeaderText = "TC KİMLİK";
            metroGrid1.Columns[4].HeaderText = "TELEFON NO";
            metroGrid1.Columns[5].HeaderText = "DOĞUM TARİHİ";
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
                    var sil = bg.Muavin.Find(y);
                    sil.Silme = false;
                    bg.SaveChanges();
                    mj();
                    listele();
                    temizle();
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
                    MessageBox.Show("Güncellenecek kaydı seçiniz!");
                }
                else
                {
                    int x = Convert.ToInt32(txtId.Text);
                    var g = bg.Muavin.Find(x);
                    g.MuavinAd = txtAd.Text;
                    g.MuavinSoyad = txtSoyad.Text;
                    g.TcNo = mskTc.Text;
                    g.TelNo = mskTel.Text;
                    g.Yas = Convert.ToDateTime(dateTimePicker1.Text);
                    bg.SaveChanges();
                    mj();
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


        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            // ayrı ayrı parametre belirtmemin sebebi sefer adında bir sütunun gelmesi
            metroGrid1.DataSource = (from x in bg.Muavin where x.TcNo.Contains(mskTc.Text) select new { x.id, x.MuavinAd, x.MuavinSoyad, x.TcNo, x.TelNo, x.Yas }).ToList();
        }

        

      

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            mskTc.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            mskTel.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
            TimeSpan fark;
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            lblSnc.Text = "Muavin " + yas / 365 + " yaşında.";
        }
    }
}

