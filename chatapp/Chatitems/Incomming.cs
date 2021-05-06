using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatapp.Chatitems
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        public string Message 
        { 
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;

                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            bunifuPictureBox1.Location = new Point(4, 3);
            label1.Height = Utils.GetTextHeight(label1) + 7;

            bunifuUserControl1.Height = label1.Top + bunifuUserControl1.Top + label1.Height;

            this.Height = bunifuUserControl1.Bottom + 10;
        }

        public Image Avatar { get => bunifuPictureBox1.Image; set => bunifuPictureBox1.Image = value; }

        public void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

    }
}
