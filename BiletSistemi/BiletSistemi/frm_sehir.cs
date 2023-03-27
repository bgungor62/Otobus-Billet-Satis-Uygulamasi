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
    public partial class frm_sehir : Form
    {
        public frm_sehir()
        {
            InitializeComponent();
        }
        void mj()
        {
            MessageBox.Show("İşleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /////////////////////
            txtAd.Text = " ";

            ////////////////////

        }

        OtobusBiletEntities3 db = new OtobusBiletEntities3();
        void slist()
        {
            var list = from x in db.Sehir.OrderBy(x => x.SehirAd) select new { x.id, x.SehirAd };
            dataGridView1.DataSource = list.ToList();
        }
        void clear()
        {
            txtId.Text = "";
            txtAd.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text == string.Empty)
                {
                    MessageBox.Show("Boş kayıt yapılamaz");
                }
                else
                {
                    Sehir s = new Sehir();
                    s.SehirAd = txtAd.Text;

                    db.Sehir.Add(s);
                    db.SaveChanges();
                    mj();
                    slist();
                    clear();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void frm_sehir_Load(object sender, EventArgs e)
        {
            slist();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            slist();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtId.Text);
                var g = db.Sehir.Find(x);
                g.SehirAd = txtAd.Text;
                db.SaveChanges();
                mj();
                slist();
                clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Boş kayıt güncellenemz yapılamaz.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(txtId.Text);
                var d = db.Sehir.Find(s);
                db.Sehir.Remove(d);
                db.SaveChanges();
                mj();
                slist();
                clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Silmek için bir kayıt seçin");
            }

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
