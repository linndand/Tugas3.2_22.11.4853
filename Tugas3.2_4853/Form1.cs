using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._2_4853
{
    public partial class FrmTugas32 : Form
    {
        public FrmTugas32()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0}, Hebat!!", pekerjaan);
        }
    }
}
