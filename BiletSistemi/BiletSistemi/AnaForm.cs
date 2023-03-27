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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void forms(Form frm)
        {
            panel4.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel4.Controls.Add(frm);
            frm.Show();
        }
        private void btnMuavin_Click(object sender, EventArgs e)
        {
            frm_muavin muavin = new frm_muavin();
            forms(muavin);
            
        }

        private void btnOtobus_Click(object sender, EventArgs e)
        {
            frm_otobus otobus= new frm_otobus();
            forms(otobus);           
        }

        private void btnSehir_Click(object sender, EventArgs e)
        {
            frm_sehir sehir= new frm_sehir();
            forms(sehir);          
        }

       
      
       
        private void btnSefer_Click(object sender, EventArgs e)
        {
            frm_sefer sefer= new frm_sefer();
            forms(sefer);                      
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKaptan_Click(object sender, EventArgs e)
        {
            frm_Kaptan kaptan = new frm_Kaptan();
            forms(kaptan);
        }

        private void btnYolcu_Click(object sender, EventArgs e)
        {
            frm_yolcular yolcu = new frm_yolcular();
            forms(yolcu);
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            frm_Biletler frm= new frm_Biletler();
            forms(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
