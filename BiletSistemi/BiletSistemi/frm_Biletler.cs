using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BiletSistemi
{
    public partial class frm_Biletler : Form
    {
        public frm_Biletler()
        {
            InitializeComponent();
        }

        OtobusBiletEntities3 db = new OtobusBiletEntities3();


        void temizle()
        {
            cmbOtobus.Text = String.Empty;
            txtad.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            mskTel.Text = String.Empty;
            cmbCinsiyet.Text = String.Empty;
            txtkoltuk.Text = String.Empty;
            txtucret.Text = String.Empty;
            txtodeme.Text = String.Empty;
            txtsefer.Text = String.Empty;
        }
        int sayi = 0;
        void listele()
        {
            var l = from x in db.Sefer.Where(x => x.Silme == true && x.Tarih == DateTime.Today && x.DoluSayisi <= 31).OrderBy(x => x.Tarih)
                    select new
                    {
                        x.id,
                        x.NeredenNereye,
                        x.AraDurak,
                        x.SeferUcret,
                        x.Tarih,
                        x.Saat,
                        x.Otobus.Marka,
                        x.DoluSayisi

                    };
            dataGridView1.DataSource = l.ToList();

        }
        private void frm_Biletler_Load(object sender, EventArgs e)
        {

            ///


            //sefer bilgilerim{x.i}); gride çekme

            listele();
            //listview için listeleme
            using (OtobusBiletEntities3 db = new OtobusBiletEntities3())
            {
                var liste = db.Bilet.Where(x=>x.Silme==true).ToList();
                foreach (var b in liste)
                {


                    ListViewItem ekle = new ListViewItem(b.YolcuAd);
                    ekle.SubItems.Add(b.YolcuSoyad);
                    ekle.SubItems.Add(b.YolcuTel);
                    ekle.SubItems.Add(b.YolcuCinsiyet);
                    ekle.SubItems.Add(Convert.ToString(b.KoltukNo));
                    ekle.SubItems.Add(b.Sefer.NeredenNereye);
                    ekle.SubItems.Add(Convert.ToString(b.IslemTarih));
                    sefer.Items.Add(ekle);
                }
            }


            //  datagriedview de isim düzenleme.
            dataGridView1.Columns[0].HeaderText = "Sefer ID";
            dataGridView1.Columns[1].HeaderText = "Nereden/Nereye";
            dataGridView1.Columns[2].HeaderText = "Ara Duraklar";
            dataGridView1.Columns[3].HeaderText = "Sefer Ücret";
            dataGridView1.Columns[4].HeaderText = "Sefer Tarihi";
            dataGridView1.Columns[5].HeaderText = "Sefer Saat";
            dataGridView1.Columns[6].HeaderText = "Otobüs";
            dataGridView1.Columns[7].HeaderText = "Yolcu Sayısı";



        }


        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbOtobus.Text)
            {

                case "Travego":
                    KoltukDoldur(8, true);
                    break;
                case "Setra":
                    KoltukDoldur(8, true);
                    break;
                case "Neoplan":

                    KoltukDoldur(8, true);
                    break;

                default:
                    break;
            }
        }


        void KoltukDoldur(int sira, bool arkaBesliMi)
        {
        yavaslat:

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Kaydet")
                    {
                        continue;
                    }
                    else if (btn.Text == "Sil")
                    {
                        continue;
                    }
                    else if (btn.Text == "Güncelle")
                    {
                        continue;
                    }
                    else if (btn.Text == "A-Z")
                    {
                        continue;
                    }
                    else if (btn.Text == "Bilet Oluştur")
                    {
                        continue;
                    }
                    else if (btn.Text == "Bilet İşlemleri")
                    {
                        continue;
                    }
                    else if (btn.Text == "Dolu Seferler")
                    {
                        continue;
                    }
                    else if (btn.Text == "sil")
                    {
                        continue;
                    }




                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }

            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == sira / 2 && j > 2)
                    {
                        continue;
                    }
                    if (j == 2)
                    {
                        continue;
                    }
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += Koltuk_MouseDown;
                    koltuk.ForeColor = Color.White;
                    this.Controls.Add(koltuk);
                    try
                    {
                        Bilet b = new Bilet();
                        int seferid = Convert.ToInt32(txtsefer.Text);
                        var sorgu = db.Bilet.Where(x => x.SeferId == seferid).ToList();
                        foreach (var item in sorgu)
                        {
                            if (item.KoltukNo == Convert.ToInt32(koltuk.Text))
                            {
                                if (item.YolcuCinsiyet == "Erkek")
                                {
                                    koltuk.ForeColor = Color.White;
                                    koltuk.BackColor = Color.Blue;



                                }
                                else if (item.YolcuCinsiyet == "Kadın")
                                {
                                    koltuk.ForeColor = Color.White;
                                    koltuk.BackColor = Color.Pink;
                                }


                            }

                        }
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.ToString());
                    }



                }
            }
        }


        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            txtkoltuk.Text = btn.Text;
            if (cmbCinsiyet.Text == "Erkek")
            {
                btn.ForeColor = Color.Blue;

            }
            if (cmbCinsiyet.Text == "Kadın")
            {
                btn.ForeColor = Color.Pink;
            }
        }


        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtad.Text == string.Empty || cmbCinsiyet.Text == string.Empty)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm_yolcular fy = new frm_yolcular();
            fy.txtAd.Text = txtad.Text;
            fy.txtSoyad.Text = txtSoyad.Text;
            fy.mskTel.Text = mskTel.Text;
            fy.cmbCinsiyet.Text = cmbCinsiyet.Text;
            fy.ShowDialog();
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnBilet_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtad.Text == string.Empty && txtSoyad.Text == string.Empty)
                {
                    MessageBox.Show("Boş kayıt yapılamaz");
                }
                else
                {
                    int seferId = int.Parse(txtsefer.Text);
                    Bilet b = new Bilet();
                    var sorgu = db.Bilet.Where(x => x.SeferId == seferId).ToList();
                    int koltuk = 0;
                    foreach (var item in sorgu)
                    {
                        if (item.KoltukNo == Convert.ToInt32(txtkoltuk.Text))
                        {
                            koltuk = 1;
                        }

                    }
                    if (koltuk == 0)
                    {
                        string duraklar = "";

                        for (int i = 0; i < chkDurakSayisi.CheckedItems.Count; i++)

                        {
                            double sayi = 0;
                            sayi = 100 * chkDurakSayisi.CheckedItems.Count;
                            double ucreti = 0;
                            ucreti = Convert.ToDouble(txtucret.Text);                          
                            txtucret.Text = (ucreti - sayi).ToString();
                            b.Ucret = decimal.Parse(txtucret.Text);
                        }

                        ////
                        b.SeferId = int.Parse(txtsefer.Text);
                        b.KoltukNo = (byte)Convert.ToInt32(txtkoltuk.Text);
                        b.YolcuAd = txtad.Text;
                        b.YolcuSoyad = txtSoyad.Text;
                        b.YolcuTel = mskTel.Text;
                        b.YolcuCinsiyet = cmbCinsiyet.Text;

                        var query = from x in db.Bilet where x.YolcuAd == txtad.Text && x.YolcuSoyad == txtSoyad.Text select x;
                        if (query.Any())
                        {
                            double ucreti = 0;
                            ucreti = Convert.ToDouble(txtucret.Text);
                            ucreti = (ucreti - (ucreti * 20 / 100));
                            txtucret.Text = ucreti.ToString();
                            b.Ucret = decimal.Parse(txtucret.Text);
                            MessageBox.Show("Daha önceden bilet aldığınız için %20 indiriminiz uygulanmıştır :) ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            b.Ucret = decimal.Parse(txtucret.Text);
                        }

                        b.UcretTip = txtodeme.Text;
                        b.IslemTarih = Convert.ToDateTime(dateTimePicker1.Text);
                        b.Silme = false;
                        b.VarisDurak=cmbVaris.Text;
                        db.Bilet.Add(b);
                        //sefer tablosundaki dolusayisini artırır//
                        int k = Convert.ToInt32(txtsefer.Text);
                        var g = db.Sefer.Find(k);
                        g.DoluSayisi += 1;
                        db.SaveChanges();
                        db.SaveChanges();
                        listele();
                        MessageBox.Show("Bilet kaydı gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temizle();

                    }
                    else
                    {
                        MessageBox.Show("Koltuk Dolu");

                    }


                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }





        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frm_BiletIslemleri f = new frm_BiletIslemleri();
            f.ShowDialog();
        }


        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtsefer.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtucret.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbOtobus.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        private void txtSeferAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Sefer
                                        where (x.NeredenNereye.Contains(txtSeferAra.Text)  && x.Silme == true && x.Tarih >= DateTime.Today && x.DoluSayisi <= 31)
                                        select new
                                        {
                                            x.id,
                                            x.NeredenNereye,
                                            x.AraDurak,
                                            x.SeferUcret,
                                            x.Tarih,
                                            x.Saat,
                                            x.Otobus.Marka,
                                            x.DoluSayisi
                                        }).ToList();
        }

        
    }
}

