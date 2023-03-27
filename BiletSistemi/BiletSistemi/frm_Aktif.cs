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
    public partial class frm_Aktif : Form
    {
        public frm_Aktif()
        {
            InitializeComponent();
        }
        OtobusBiletEntities3 db = new OtobusBiletEntities3();
        private void frm_Aktif_Load(object sender, EventArgs e)
        {
            using (OtobusBiletEntities3 db = new OtobusBiletEntities3())
            {
                var liste = from x in db.AktifSefer where (x.Sefer.Tarih >= DateTime.Today && x.Sefer.Silme==true)orderby x.Sefer.Tarih select x;
                foreach (var l in liste)
                {
                  

                    ListViewItem ekle = new ListViewItem(l.Sefer.Tarih.ToString());
                    ekle.SubItems.Add(l.Sefer.Muavin.MuavinAd);
                    ekle.SubItems.Add(l.Sefer.Muavin.TcNo);
                    ekle.SubItems.Add(l.Sefer.Kaptan.KaptanAd);
                    ekle.SubItems.Add(l.Sefer.Kaptan.TcNO);
                    ekle.SubItems.Add(l.Sefer.Otobus.Marka);
                    ekle.SubItems.Add(l.Sefer.Otobus.Plaka);
                    listView1.Items.Add(ekle);
                }
            }
        }
    }
}
