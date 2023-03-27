//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;


namespace BiletSistemi
{
    public partial class frm_BiletIslemleri : Form
    {
        public frm_BiletIslemleri()
        {
            InitializeComponent();
        }
        OtobusBiletEntities3 db = new OtobusBiletEntities3();

        void clear()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            mskTel.Text = string.Empty;
            mskKoltuk.Text = string.Empty;
            txtNereden.Text = string.Empty;
            txtAraDurak.Text = string.Empty;





        }
        void TarihListe()
        {
            var sorgu = from x in db.Bilet.Where(x => x.Sefer.Tarih == DateTime.Today && x.Silme == false)
                        select new
                        {
                            x.id,
                            x.SeferId,
                            x.YolcuAd,
                            x.YolcuSoyad,
                            x.Ucret,
                            x.YolcuTel,
                            x.KoltukNo,
                            x.Sefer.NeredenNereye,
                            x.VarisDurak,
                            x.Sefer.Tarih
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }


        private void frm_BiletIslemleri_Load(object sender, EventArgs e)
        {
            TarihListe();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Serfer ID";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "Ücret";
            dataGridView1.Columns[5].HeaderText = "Telefon No";
            dataGridView1.Columns[6].HeaderText = "Koltuk No";
            dataGridView1.Columns[7].HeaderText = "Güzergah";
            dataGridView1.Columns[8].HeaderText = "ineceği Durak";
            dataGridView1.Columns[9].HeaderText = "Tarih";




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSeferId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ucret.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                mskTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                mskKoltuk.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtNereden.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtAraDurak.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Silmek için lütfen bir kayıt seçin.");
                }
                else
                {
                    Bilet s = new Bilet();
                    int x = Convert.ToInt32(txtId.Text);
                    var silmeGuncelle = db.Bilet.Find(x);
                    db.Bilet.Remove(silmeGuncelle);
                    int k = Convert.ToInt32(txtSeferId.Text);
                    var g = db.Sefer.Find(k);
                    g.DoluSayisi -= 1;
                    db.SaveChanges();
                    db.SaveChanges();
                    clear();
                    TarihListe();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void btnSeferleri_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Bilet.Where(x => x.Sefer.Tarih >= DateTime.Today && x.Silme == false)
                        select new
                        {
                            x.id,
                            x.SeferId,
                            x.YolcuAd,
                            x.YolcuSoyad,
                            x.Ucret,
                            x.YolcuTel,
                            x.KoltukNo,
                            x.Sefer.NeredenNereye,
                            x.VarisDurak,
                            x.Sefer.Tarih
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            //Excel.Application excelDosya = new Excel.Application();
            //excelDosya.Visible = true;
            //object Missing = Type.Missing;
            //Workbook calismakitabi = excelDosya.Workbooks.Add(Missing);
            //Worksheet sheet1 = (Worksheet)calismakitabi.Sheets[1];
            //int sutun = 1;
            //int satır = 1;

            //for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //{
            //    Range myRange = (Range)sheet1.Cells[satır, sutun + j];
            //    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            //}
            //satır++;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        Range myrange = (Range)sheet1.Cells[satır + i, sutun + j];
            //        myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
            //        myrange.Select();
            //    }

            //}


        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtNereden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void txtAraDurak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskKoltuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Güncelleme işlemi için kayıt seçmelisiniz!");
                }
                else
                {
                    int x = Convert.ToInt32(txtId.Text);
                    var g = db.Bilet.Find(x);
                    g.YolcuAd = txtAd.Text;
                    g.YolcuSoyad = txtSoyad.Text;
                    g.YolcuTel = mskTel.Text;
                    g.KoltukNo = Convert.ToByte(mskKoltuk.Text);
                    db.SaveChanges();
                    clear();
                    TarihListe();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
    }
}
