using System;
using System.Drawing;
using System.Windows.Forms;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace chatapp
{
    public static class Utils
    {
        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 650);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
