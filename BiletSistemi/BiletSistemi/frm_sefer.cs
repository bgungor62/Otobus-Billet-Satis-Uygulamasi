using MetroFramework.Controls;
//using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;
//using Excel = Microsoft.Office.Interop.Excel; //excel içi


namespace BiletSistemi
{

    public partial class frm_sefer : Form
    {
        //string[] elArray = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

        public frm_sefer()
        {
            InitializeComponent();
            //var dt = new DataTable();

            //dt.Columns.Add("Item", typeof(string));
            //dt.Columns.Add("Checked", typeof(bool));

            //foreach (var item in elArray) dt.Rows.Add(item, false);

            //dt.AcceptChanges();

            //chkAraDurak.DataSource = dt.DefaultView;
            //chkAraDurak.DisplayMember = "AraDurak";
            //chkAraDurak.ValueMember = "Item";

            //// If not already done by the designer...

            //chkAraDurak.ItemCheck += chkAraDurak_ItemCheck;

        }
        OtobusBiletEntities3 db = new OtobusBiletEntities3();

        void tumListe()
        {
            var l = from x in db.Sefer.Where(x => x.Silme == true).OrderBy(x => x.Saat)
                    select new
                    {
                        x.id,
                        x.NeredenNereye,
                        x.AraDurak,
                        Kaptan = x.Kaptan.KaptanAd + " Tc: " + x.Kaptan.TcNO,
                        Muavin = x.Muavin.MuavinAd + " Tc: " + x.Muavin.TcNo,
                        x.SeferUcret,
                        x.Tarih,
                        x.Saat
                    };
            dataGridView1.DataSource = l.ToList();
        }
        void Slist()
        {

            var l = from x in db.Sefer.Where(x => x.Silme == true && x.Tarih == DateTime.Today).OrderBy(x => x.Saat)
                    select new
                    {
                        x.id,
                        x.NeredenNereye,
                        x.AraDurak,
                        Kaptan = x.Kaptan.KaptanAd + " Tc: " + x.Kaptan.TcNO,
                        Muavin = x.Muavin.MuavinAd + " Tc: " + x.Muavin.TcNo,
                        x.SeferUcret,
                        x.Tarih,
                        x.Saat
                    };
            dataGridView1.DataSource = l.ToList();
        }
        void mesaj()
        {
            MessageBox.Show("İşleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //ücret hesaplama

        void clear()
        {
            while (chkAraDurak.CheckedIndices.Count > 0)
            {
                chkAraDurak.SetItemChecked(chkAraDurak.CheckedIndices[0], false);
            }
            txtNeredenNereye.Text = "";
            txtId.Text = "";
            CmbKalkis.Text = "";
            CmbVaris.Text = "";
            CmbOtobus.Text = "";
            CmbKaptan.Text = "";
            CmbMuavin.Text = "";
            TxtUcret.Text = "";
            dateTimePicker1.Text = "";
            MskSaat.Text = "";
        }

        private void frm_sefer_Load(object sender, EventArgs e)
        {
            //combobaxa otobüs bilgilerini getirme.
            var otobus = db.Otobus.Select(x => new
            {
                x.id,
                OtobusAd = x.Marka + " / " + x.Plaka
            }).ToList();
            CmbOtobus.DataSource = otobus;
            CmbOtobus.DisplayMember = "OtobusAd";
            CmbOtobus.ValueMember = "id";


            //kaptanları combobaxa getirme
            var kaptan = db.Kaptan.Select(x => new
            {
                x.id,
                KaptanAd = x.KaptanAd + " " + x.KaptanSoyad + " /" + " TC: " + x.TcNO

            }).ToList();
            CmbKaptan.DataSource = kaptan;
            CmbKaptan.DisplayMember = "KaptanAd";
            CmbKaptan.ValueMember = "id";


            //muavnleri combobaxa getirme
            var muaviin = db.Muavin.Select(x => new
            {
                x.id,
                MuavinAd = x.MuavinAd + " " + x.MuavinSoyad + " /" + " TC:" + x.TcNo
            }).ToList();
            CmbMuavin.DataSource = muaviin;
            CmbMuavin.DisplayMember = "MuavinAd";
            CmbMuavin.ValueMember = "id";

            //sehirleri çekme
            var sehir = (from x in db.Sehir select new { x.id, x.SehirAd }).ToList();
            CmbKalkis.ValueMember = "id";
            CmbKalkis.DisplayMember = "SehirAd";
            CmbKalkis.DataSource = sehir;

            var sehir2 = (from x in db.Sehir select new { x.id, x.SehirAd }).ToList();
            CmbVaris.ValueMember = "id";
            CmbVaris.DisplayMember = "SehirAd";
            CmbVaris.DataSource = sehir2;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            


            string sehirler = "";
            try
            {
                if (TxtUcret.Text != string.Empty && txtId.Text == string.Empty)
                {
                    if (CmbKalkis.Text == CmbVaris.Text)
                    {
                        MessageBox.Show("Seferler aynı yöne yapılamaz!");
                    }
                    else
                    { 
                        kmHesaplama();
                        AktifSefer a = new AktifSefer();
                        Sefer s = new Sefer();
                        s.NeredenNereye = CmbKalkis.Text + "-" + CmbVaris.Text;
                        s.KalkisId = int.Parse(CmbKalkis.SelectedValue.ToString());
                        s.VarisId = int.Parse(CmbVaris.SelectedValue.ToString());
                        for (int i = 0; i < chkAraDurak.CheckedItems.Count; i++)
                        {
                            sehirler += "- " + chkAraDurak.CheckedItems[i];
                            //ucretSayac = 100 * chkAraDurak.CheckedItems.Count;
                            //int toplam = ucretSayac + int.Parse(TxtUcret.Text);
                            //s.SeferUcret = decimal.Parse(toplam.ToString());
                        }
                       
                        s.AraDurak = sehirler.Substring(2);
                        s.SeferUcret = decimal.Parse(TxtUcret.Text);
                        s.OtobusId = int.Parse(CmbOtobus.SelectedValue.ToString());
                        s.KaptanId = int.Parse(CmbKaptan.SelectedValue.ToString());
                        s.MuavinId = int.Parse(CmbMuavin.SelectedValue.ToString());
                        s.Tarih = Convert.ToDateTime(dateTimePicker1.Text);
                        s.Saat = MskSaat.Text;
                        a.Id = s.id;
                        s.Silme = true;
                        s.DoluSayisi = 0;
                        db.Sefer.Add(s);
                        db.AktifSefer.Add(a);
                        db.SaveChanges();
                        mesaj();
                        Slist();
                        clear();
                    }

                }
                else
                {
                    if (txtId.Text != string.Empty)
                    {
                        MessageBox.Show("Mevcut bir sefer zaten var!");
                    }
                    if (txtId.Text == string.Empty)
                    {
                        MessageBox.Show("Boş sefer kaydı yapılamaz!");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagiridwievden verileri çekme.
            //txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtNeredenNereye.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtAraDurak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //CmbKaptan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //CmbMuavin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //TxtUcret.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //MskSaat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            tumListe();
            clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Silmek için lütfen bir kayıt seçin.");
                }
                else
                {
                    Bilet b = new Bilet();
                    AktifSefer s = new AktifSefer();
                    int x = Convert.ToInt32(txtId.Text);
                    var silmeGuncelle = db.Sefer.Find(x);
                    silmeGuncelle.Silme = false;
                    int seferId = int.Parse(txtId.Text);
                    var sorgu = db.Bilet.Where(d => d.SeferId == seferId).ToList();
                    foreach (var item in sorgu)
                    {
                        item.Silme = true;
                        db.SaveChanges();
                    }

                    db.SaveChanges();
                    mesaj();
                    Slist();
                    clear();
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
                if (txtId.Text == "")
                {
                    MessageBox.Show("Lütfen güncellenecek kaydı seçiniz!");
                }
                else
                {
                    int x = Convert.ToInt32(txtId.Text);
                    var g = db.Sefer.Find(x);

                    g.KaptanId = int.Parse(CmbKaptan.SelectedValue.ToString());
                    g.MuavinId = int.Parse(CmbMuavin.SelectedValue.ToString());
                    g.SeferUcret = decimal.Parse(TxtUcret.Text);
                    g.Tarih = Convert.ToDateTime(dateTimePicker1.Text);
                    g.Saat = MskSaat.Text;
                    db.SaveChanges();
                    mesaj();
                    Slist();
                    clear();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void TxtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void MskSaat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            frm_Aktif frm = new frm_Aktif();
            frm.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void txtNeredenNereye_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Sefer
                                        where (x.NeredenNereye.Contains(txtNeredenNereye.Text) && x.Silme == true && x.Tarih == DateTime.Today)
                                        select new
                                        {
                                            x.id,
                                            x.NeredenNereye,
                                            x.AraDurak,
                                            Kaptan = x.Kaptan.KaptanAd + " Tc: " + x.Kaptan.TcNO,
                                            Muavin = x.Muavin.MuavinAd + " Tc: " + x.Muavin.TcNo,
                                            x.SeferUcret,
                                            x.Tarih,
                                            x.Saat
                                        }).ToList();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = (from x in db.Sefer
            //                            where (x.Tarih.Contains(dateTimePicker2.Text) )
            //                            select new
            //                            {
            //                                x.id,
            //                                x.NeredenNereye,
            //                                x.AraDurak,
            //                                Kaptan = x.Kaptan.KaptanAd + " Tc: " + x.Kaptan.TcNO,
            //                                Muavin = x.Muavin.MuavinAd + " Tc: " + x.Muavin.TcNo,
            //                                x.SeferUcret,
            //                                x.Tarih,
            //                                x.Saat
            //                            }).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var dv = chkAraDurak.DataSource as DataView;
            //var filter = textBox1.Text.Trim().Length > 0
            //    ? $"Item LIKE '{textBox1.Text}*'"
            //    : null;

            //dv.RowFilter = filter;

            //for (var i = 0; i < chkAraDurak.Items.Count; i++)
            //{
            //    var drv = chkAraDurak.Items[i] as DataRowView;
            //    var chk = Convert.ToBoolean(drv["Checked"]);
            //    chkAraDurak.SetItemChecked(i, chk);
            //}
        }

        private void chkAraDurak_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //var dv = chkAraDurak.DataSource as DataView;
            //var drv = dv[e.Index];
            //drv["Checked"] = e.NewValue == CheckState.Checked ? true : false;
        }

        private void CmbKalkis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isim = CmbKalkis.Text;
            var sehir = db.Sehir.ToList();
            foreach (var item in sehir)
            {
                if (item.SehirAd == isim)
                {
                    tenlem1.Text = item.Enlem.ToString();
                    tboylam1.Text = item.Boylam.ToString();
                }
            }
        }

        private void kmHesaplama()
        {
            double enlem1 = Convert.ToDouble(tenlem1.Text);
            double enlem2 = Convert.ToDouble(txtenlem.Text);
            double boylam1 = -Convert.ToDouble(tboylam1.Text);
            double boylam2 = -Convert.ToDouble(txtboylam.Text);

            double R = 6371; // km
            double dLat = ToRadians(enlem2 - enlem1);
            double dLon = ToRadians(boylam2 - boylam1);
            enlem1 = ToRadians(enlem1);
            enlem2 = ToRadians(enlem2);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(enlem1) * Math.Cos(enlem2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = Math.Round(R * c, 0);
            MessageBox.Show(distance.ToString());
            var ucret = Convert.ToInt32(TxtUcret.Text);
            if (distance >=100 && distance <= 115)
            {
                int toplam = 100 + ucret;
                TxtUcret.Text = toplam.ToString();
            }
            else if (distance>=115 && distance<=350)
            {
                int toplam = 150 + ucret;
                TxtUcret.Text=toplam.ToString();
            }
            else if (distance>=350 && distance<=1000)
            {
                int toplam = 250 + ucret;
                TxtUcret.Text=toplam.ToString();
            }
            else if (distance>2000)
            {
                int toplam = 500 + ucret;
                TxtUcret.Text=toplam.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        static double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

        private void CmbVaris_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isim = CmbVaris.Text;
            var sehir = db.Sehir.ToList();
            foreach (var item in sehir)
            {
                if (item.SehirAd == isim)
                {
                    txtenlem.Text = item.Enlem.ToString();
                    txtboylam.Text = item.Boylam.ToString();
                }
            }
        }
    }
}
