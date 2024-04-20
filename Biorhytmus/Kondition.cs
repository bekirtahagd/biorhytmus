using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhytmus
{
    [Serializable()]
    public class Kondition
    {
        private int tageSeitGeburt;
        
        public int getTageSeitGeburt() { return tageSeitGeburt; }
        public void setTageSeitGeburt(int tageSeitGeburt) { this.tageSeitGeburt = tageSeitGeburt; }
        //---------------------------------------------------------------------
        public double berechneKonditionKoerperlich(int tageSeitHeute)
        {
            int koerperlicherRhythmus = 23;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) / koerperlicherRhythmus));
        }
        //--------------------------------------------------------------------- 
        public double berechneKonditionGeistig(int tageSeitHeute)
        {
            int geistigerRhythmus = 33;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            geistigerRhythmus));
        }
        //---------------------------------------------------------------------
        public double berechneKonditionPsychisch(int tageSeitHeute)
        {
            int psychischerRythmus = 28;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            psychischerRythmus));
        }
        //---------------------------------------------------------------------
        public DataGridView erzeugeKonditionPrognose(DataGridView tabelle, int tage, int verzug, bool positiv)
        {
            //Entferne vorherigen Inhalt
            tabelle.Rows.Clear();

            if (positiv)
            {
                //Erstelle Tabelle
                for (int t = 1; t <= tage; t++)
                {
                    int tag = t + verzug;

                    tabelle.Rows.Add(tag, (Math.Round(berechneKonditionKoerperlich(tag)) + "%"), (Math.Round(berechneKonditionGeistig(tag)) + "%"), (Math.Round(berechneKonditionGeistig(tag)) + "%"));
                }
            }
            else
            {
                //Erstelle Tabelle
                for (int t = verzug; t >= verzug - tage; t--)
                {
                    int tag = t * -1;
                    tabelle.Rows.Add(tag, (Math.Round(berechneKonditionKoerperlich(tag)) + "%"), (Math.Round(berechneKonditionGeistig(tag)) + "%"), (Math.Round(berechneKonditionGeistig(tag)) + "%"));
                }
            }


            return tabelle;
        }
        //-----------------------------------------------------------------------------------------------
        public void zeichneKonditionPrognose_60Tage(Graphics g)
        {
            float schriftgroesse = 9.5f;
            int xGroesse = 300;
   

            int koerperlich_1, geistig_1, psychisch_1;
            int koerperlich_2, geistig_2, psychisch_2;
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Pen penGreen = new Pen(Color.Green);
            Pen penBlack = new Pen(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.FillRectangle(whiteBrush, 0, 0, xGroesse, 145);
            g.DrawLine(penBlack, 0, 110, xGroesse, 110);
            g.DrawString("0", new Font("Arial", schriftgroesse), new SolidBrush(Color.Black), 10, 120);
            g.DrawString("30", new Font("Arial", schriftgroesse), new SolidBrush(Color.Black), (xGroesse / 2) - 10f, 120);
            g.DrawString("Tage", new Font("Arial", schriftgroesse), new SolidBrush(Color.Black), (xGroesse - (4 * 10f)), 120);

            float laenge = 4.95f;
            for (int t = 0; t <= 59; t++)
            {
                koerperlich_1 = (int)(110 - berechneKonditionKoerperlich(t));
                geistig_1 = (int)(110 - berechneKonditionGeistig(t));
                psychisch_1 = (int)(110 - berechneKonditionPsychisch(t));
                koerperlich_2 = (int)(110 - berechneKonditionKoerperlich(t + 1));
                geistig_2 = (int)(110 - berechneKonditionGeistig(t + 1));
                psychisch_2 = (int)(110 - berechneKonditionPsychisch(t + 1));
                g.DrawLine(penBlue, laenge * t, koerperlich_1, laenge * (t + 1), koerperlich_2);
                g.DrawLine(penRed, laenge * t, geistig_1, laenge * (t + 1), geistig_2);
                g.DrawLine(penGreen, laenge * t, psychisch_1, laenge * (t + 1), psychisch_2);
            }
        }

        public bool hatGeburtstag(Datum gebDatum, Datum heuteDatum)
        {
            return (gebDatum.getTag() == heuteDatum.getTag() && gebDatum.getMonat() == gebDatum.getMonat());
        }
    }
}
