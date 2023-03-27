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
    public partial class frm_otobus : Form
    {
        public frm_otobus()
        {
            InitializeComponent();
        }
        OtobusBiletEntities3 db = new OtobusBiletEntities3();
        void temizle()
        {
            txtKoltuk.Text = " ";
            cmbOtobus.Text = " ";
            mskPlaka.Text = " ";
        }
        void mj()
        {
            MessageBox.Show("İşleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /////////////////////
            
           
            

            ////////////////////
            var list = from x in db.Otobus
                       select new
                       {
                           x.id,
                           x.Marka,
                           x.KoltukSayısı,
                           x.Plaka

                       };
            metroGrid1.DataSource = list.ToList();

        }



        private void frm_otobus_Load(object sender, EventArgs e)
        {
            //class'lar ile çalış.
            var list = from x in db.Otobus
                       select new
                       {
                           x.id,
                           x.Marka,
                           x.KoltukSayısı,
                           x.Plaka

                       };
            metroGrid1.DataSource = list.ToList();

            metroGrid1.Columns[0].HeaderText = "ID";
            metroGrid1.Columns[1].HeaderText = "MARKA";
            metroGrid1.Columns[2].HeaderText = "PLAKA";
            metroGrid1.Columns[3].HeaderText = "KOLTUK SAYISI";


        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtId.Text);
                var sil = db.Otobus.Find(x);
                db.Otobus.Remove(sil);
                db.SaveChanges();
                mj();
            }
            catch (Exception )
            {

                MessageBox.Show("Silmek için bir kayıt seçiniz");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtId.Text);
                var guncelle = db.Otobus.Find(x);
                guncelle.Marka = cmbOtobus.Text;
                guncelle.KoltukSayısı = txtKoltuk.Text;
                guncelle.Plaka = mskPlaka.Text;
                db.SaveChanges();
                mj();
            }
            catch (Exception )
            {

                MessageBox.Show("Güncellemek için bir kayıt seçiniz");
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskPlaka.Text==string.Empty && cmbOtobus.Text==string.Empty)
                {
                    MessageBox.Show("Girdiğiniz plaka numarasını kontrol ediniz");
                }
                else
                {
                    Otobus o = new Otobus();
                    o.Marka = cmbOtobus.Text;
                    o.KoltukSayısı = txtKoltuk.Text;
                    o.Plaka = mskPlaka.Text;
                    db.Otobus.Add(o);
                    db.SaveChanges();
                    mj();
                }
              
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }



        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            string y = cmbOtobus.Text;
            var sorgu = from x in db.Otobus where x.Marka.Contains(y) select x;
            metroGrid1.DataSource = sorgu.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var az = db.Otobus.OrderBy(a => a.Marka).ToList();
            metroGrid1.DataSource = az;
            temizle();
        }


        private void txtKoltuk_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKoltuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            cmbOtobus.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtKoltuk.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            mskPlaka.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
