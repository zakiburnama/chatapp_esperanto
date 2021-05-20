using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatapp
{
    public partial class Selamat_Modul : Form
    {
        Percakapan prc = new Percakapan();

        public Selamat_Modul()
        {
            InitializeComponent();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            //int x = prc.finish;
            this.Hide();
            Form2 form2 = new Form2(1);
            form2.ShowDialog();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
