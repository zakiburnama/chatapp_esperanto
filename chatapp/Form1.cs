﻿using System;
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
    public partial class Form1 : Form
    {
        Percakapan prc = new Percakapan();

        public int temp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int x = prc.finish;
            this.Hide();
            Form2 f2 = new Form2(x);
            f2.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        public void Send()
        {
            // cek input ada diisi atau tidak
            if (txtPesan.Text.Trim().Length <= 0) return;

            // menampilakn inputan
            AddOutGoing(txtPesan.Text);
            string xx = txtPesan.Text;
            txtPesan.Text = String.Empty;

            // filter
            string x = xx.ToLower();

            // cek
            if (temp == 1)
                prc.cek(x);
            else if (temp == 2)
                prc.ceklat1(x);

            lblStatus.Text = "Sedang Mengetik...";
            timer1.Start();
        }

        int curTop = 10;

        public void AddIncomming(string message)
        {
            var bubble = new Chatitems.Incomming();
            pnlContainer.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = pnlContainer.Width+10;
            //bubble.BringToFront();
            bubble.Dock = DockStyle.Bottom;
            bubble.Message = message;
            pnlContainer.AutoScrollPosition = new Point(999, 999);
        }

        public void AddOutGoing(string message)
        {
            var bubble = new Chatitems.OutGoing();
            pnlContainer.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = pnlContainer.Width;
            //bubble.BringToFront();
            bubble.Dock = DockStyle.Bottom;
            bubble.Message = message;
            pnlContainer.AutoScrollPosition = new Point(999, 999);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblStatus.Text = "Online";
                        
            string p = prc.perc;

            AddIncomming(p);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if(temp == 1)
            {
                AddIncomming("Halo " + Environment.UserName);
                AddIncomming("Sekarang kita masuk ke modul perkenalan");
                AddIncomming("Ketik 'Saluton' untuk menyapa");
            }

            if (temp == 2)
            {
                AddIncomming("Mulai dengan Halo dalam Esperanto!");
            }
        }
    }
}
