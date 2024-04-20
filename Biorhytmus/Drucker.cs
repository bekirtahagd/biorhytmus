using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhytmus
{
    public class Drucker
    {
        //Variables
        Bitmap bmp;
        Control druckObjekt;

        //Getter und Setter
        public Bitmap getBmp()
        {
            return bmp;
        }

        //Methods
        private void GetDruckFläche(Control dObjekt)
        {
            bmp = new Bitmap(dObjekt.Width, dObjekt.Height);
            Rectangle rect = new Rectangle(0, 0, dObjekt.Width, dObjekt.Height);
            dObjekt.DrawToBitmap(bmp, rect);
        }
        public void EV_DruckSeite(PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 2) - (druckObjekt.Width / 2), druckObjekt.Location.Y);
        }
        public void Druck(Control dObjekt, PrintPreviewDialog ppd)
        {
            druckObjekt = dObjekt;
            GetDruckFläche(dObjekt);
            ppd.ShowDialog();
        }

    }
}


//Muss in vater klasse übernommen werden
/*        protected override void OnPaint(PaintEventArgs e)
        {
            if (bmp != null)
            {
                e.Graphics.DrawImage(bmp, 0, 0);
                base.OnPaint(e);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            drucker.EV_DruckSeite(e);
        }
*/