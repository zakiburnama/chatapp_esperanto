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
    public partial class OutGoing : UserControl
    {
        public OutGoing()
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
            label1.Height = Utils.GetTextHeight(label1) + 7;

            bunifuUserControl1.Height = label1.Top + bunifuUserControl1.Top + label1.Height;

            this.Height = bunifuUserControl1.Bottom + 10;
        }

   
        public void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void OutGoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
