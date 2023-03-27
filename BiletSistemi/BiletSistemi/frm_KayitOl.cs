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
    public partial class frm_KayitOl : Form
    {
        public frm_KayitOl()
        {
            InitializeComponent();
        }

        private void txtAd_MouseClick(object sender, MouseEventArgs e)
        {
            txtAd.Clear();
            panel1.BackColor = Color.FromArgb(0, 195, 195);
            txtAd.ForeColor = Color.FromArgb(0, 195, 195);
            panel2.BackColor = Color.White;
            txtSifre.ForeColor = Color.White;
        }

        private void txtSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtSifre.Clear();
            panel2.BackColor = Color.FromArgb(0, 195, 195);
            txtSifre.ForeColor = Color.FromArgb(0, 195, 195);
            panel1.BackColor = Color.White;
            txtAd.ForeColor = Color.White;
        }

        private void frm_KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

        }
    }
}
