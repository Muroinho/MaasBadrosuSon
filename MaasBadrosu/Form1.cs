using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBadrosu
{
    public partial class frmMaasBordrosu : Form
    {
        public frmMaasBordrosu()
        {
            InitializeComponent();
        }

        private void yetkiliKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliKullanici frm = new YetkiliKullanici();
            frm.Show();
        }
    }
}
