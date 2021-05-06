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
    public partial class Form2 : Form
    {
        Percakapan p = new Percakapan();
        public int siap = 0;

        public Form2()
        {
            //
            InitializeComponent();
            //
            btnLatMod1.Enabled = false;
            btnModul2.Enabled = false;
            btnLatMod2.Enabled = false;
            btnModul3.Enabled = false;
            btnLatMod3.Enabled = false;
            btnModul4.Enabled = false;
            btnLatMod4.Enabled = false;
            //
            int a = p.finish;
            //a = siap;
            if (a == 1)
                btnLatMod1.Enabled = true;
            else if (a == 2)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
            }
            else if (a == 3)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
                btnLatMod2.Enabled = true;
            }
            else if (a == 4)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
                btnLatMod2.Enabled = true;
                btnModul3.Enabled = true;
            }
            else if (a == 5)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
                btnLatMod2.Enabled = true;
                btnModul3.Enabled = true;
                btnLatMod3.Enabled = true;
            }
            else if (a == 6)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
                btnLatMod2.Enabled = true;
                btnModul3.Enabled = true;
                btnLatMod3.Enabled = true;
                btnModul4.Enabled = true;
            }
            else if (a == 7)
            {
                btnLatMod1.Enabled = true;
                btnModul2.Enabled = true;
                btnLatMod2.Enabled = true;
                btnModul3.Enabled = true;
                btnLatMod3.Enabled = true;
                btnModul4.Enabled = true;
                btnLatMod4.Enabled = true;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formm = new Form1();
            formm.temp = 1;
            formm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLatMod1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formm = new Form1();
            formm.temp = 2;
            formm.ShowDialog();
        }
    }
}
