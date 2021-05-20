using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace chatapp
{
    class Percakapan
    {
        public string perc { get; set; }
        public int finish { get; set; }

        private static System.Timers.Timer aTimer;

        private static void TriggerDialogModul()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += TriggeredEvent1;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        private static void TriggeredEvent1(Object source, ElapsedEventArgs e)
        {
            Selamat_Modul slmtmdl = new Selamat_Modul();
            slmtmdl.ShowDialog();
            aTimer.Stop();
            aTimer.Dispose();
        }

        private static void TriggerDialogLatihan()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += TriggeredEvent2;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        private static void TriggeredEvent2(Object source, ElapsedEventArgs e)
        {
            Selamat_Latihan slmtlthn = new Selamat_Latihan();
            slmtlthn.ShowDialog();
            aTimer.Stop();
            aTimer.Dispose();
        }

        // cek input modul 1
        public void cek(string teks)
        {
            string a = "saluton";
            string b = "bonvenon";
            string c = "kiel vi fartas";
            string d = "bone";
            string e = "dankon kaj vi";
            string f = "gis poste";
            string g = "mi gojas konatigi";
            string h = "mi bedauras";
            string i = "mi devas foriri";
            string j = "gis revido";


            if (String.Equals(teks, a))
            {
                perc = "Saluton Artinya 'Halo' \nSelanjutnya 'Bonvenon'";
            }

            else if (String.Equals(teks, b))
            {
                perc = "Bonvenon artinya 'Selamat Datang' \nSelanjutnya 'Kiel vi fartas'";
            }

            else if (String.Equals(teks, c))
            {
                perc = "Kiel vi fartas artinya 'Apa kabar' \n Selanjutnya 'Bone'";
            }

            else if (String.Equals(teks, d))
            {
                perc = "Bone 'Baik' \nSelanjutnya 'Dankon Kaj vi'";
            }

            else if (String.Equals(teks, e))
            {
                perc = "Dankon Kaj vi 'Baik Kalo Kamu' \nSelanjutnya 'gis poste'";
            }

            else if (String.Equals(teks, f))
            {
                perc = "Gis poste artinya 'Selamat tinggal' \nSelanjutnya 'Mi Gojas Konatigi'";
            }

            else if (String.Equals(teks, g))
            {
                perc = "Mi Gojas Konatigi artinya 'Senang bertemu denganmu' \nSelanjutnya 'Mi Bedauras'";
            }

            else if (String.Equals(teks, h))
            {
                perc = "Mi Bedauras artinya 'Saya minta maaf' \nSelanjutnya 'Mi Devas Foriri'";
            }

            else if (String.Equals(teks, i))
            {
                perc = "Mi Devas Foriri artinya 'Saya harus pergi' \nSelanjutnya 'Gis Revido'";
            }

            else if (String.Equals(teks, j))
            {
                perc = "Gis Revido artinya 'Sampai bertemu lagi' \nSelamat Anda Sudah menyelesaikan Modul I";

                finish = 1;

                TriggerDialogModul();
            }

            else
            {
                perc = "saya tidak mengerti";
            }
        }
        

        // cek input latihan
        public void ceklat1(string teks)
        {
            string a = "saluton";
            string b = "bonvenon";
            string c = "kiel vi fartas";
            string d = "bone";
            string e = "dankon kaj vi";
            string f = "gis poste";
            string g = "mi gojas konatigi";
            string h = "mi bedauras";
            string i = "mi devas foriri";
            string j = "gis revido";

            if (String.Equals(teks, a))
                perc = a + "\n" + c;
            else if (String.Equals(teks, d + " " + e))
                perc = d + "\n" + g + " " + h + " " + i;
            else if (String.Equals(teks, f))
            {
                perc = j;
                finish = 2;

                TriggerDialogLatihan();
            }

            //
            else
            {
                perc = "Pardonu?";
            }
        }

        public void cek2(string teks)
        {
            
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            string e = "";
            string f = "";
            string g = "";
            string h = "";
            string i = "";

            int n =0 ;
            if (String.Equals(teks, a))
            {
                n = 1;
            }

            else if (String.Equals(teks, b))
            {
                n = 2;
            }

            else if (String.Equals(teks, c))
            {
                n = 3;
            }

            else if (String.Equals(teks, d))
            {
                n = 4;
            }

            else if (String.Equals(teks, e))
            {
                n = 5;
            }

            else if (String.Equals(teks, f))
            {
                n = 6;
            }

            else if (String.Equals(teks, g))
            {
                n = 7;
            }

            else if (String.Equals(teks, h))
            {
                n = 8;
            }

            else if (String.Equals(teks, i))
            {
                n = 9;
            }

            //
            else
            {
                n = 0;
            }
        }
    }
}
