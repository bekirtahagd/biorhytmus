using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhytmus
{
    [Serializable()]
    public class Datum
    {
        // Variables
        #region Variables



        private int jahr;
        private int monat;
        private int tag;



        #endregion




        //Constructor
        #region Constructor



        public Datum(int pJahr, int pMonat, int pTag)
        {
            jahr = pJahr;
            monat = pMonat;
            tag = pTag;
        }



        #endregion




        #region Setter and Getter



        public void setJahr(int value)
        {
            jahr = value;
        }
        public int getJahr()
        {
            return jahr;
        }



        public void setMonat(int value)
        {
            monat = value;
        }
        public int getMonat()
        {
            return monat;
        }



        public void setTag(int value)
        {
            tag = value;
        }
        public int getTag()
        {
            return tag;
        }



        #endregion




        // Methods
        #region Methods



        public int berechneAnzahlSchaltjahre(Datum datumAlt)
        {
            int anzahl = 0;
            for (int j = datumAlt.getJahr(); j < jahr; j++)
                if (pruefeObSchaltjahr(j)) anzahl++;
            return anzahl;
        }



        public int berechneTageDifferenz(Datum datumAlt)
        {
            return (jahr - datumAlt.getJahr()) * 365
            + berechneAnzahlSchaltjahre(datumAlt)
            - datumAlt.berechneTageSeitJahresbeginn()
            + berechneTageSeitJahresbeginn();
        }



        public int berechneTageSeitJahresbeginn()
        {
            int tage = tag;
            for (int m = 1; m < monat; m++)
                tage = tage + ermittleMonatstage(m);
            return tage;
        }



        public int ermittleMonatstage(int monat)
        {
            int tage = 0;
            switch (monat)
            {
                case 1:
                    tage = 31;
                    break;
                case 2:
                    if (pruefeObSchaltjahr(jahr)) tage = 29;
                    else tage = 28;
                    break;
                case 3:
                    tage = 31;
                    break;
                case 4:
                    tage = 30;
                    break;
                case 5:
                    tage = 31;
                    break;
                case 6:
                    tage = 30;
                    break;
                case 7:
                    tage = 31;
                    break;
                case 8:
                    tage = 31;
                    break;
                case 9:
                    tage = 30;
                    break;
                case 10:
                    tage = 31;
                    break;
                case 11:
                    tage = 30;
                    break;
                case 12:
                    tage = 31;
                    break;
                default: tage = 0; break;
            }



            return tage;
        }



        public bool pruefeObSchaltjahr(int jahr)
        {
            return ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0);
        }



        public void setDatumAufHeute()
        {
            GregorianCalendar heute = new GregorianCalendar();
            tag = heute.GetDayOfMonth(DateTime.Today);
            monat = heute.GetMonth(DateTime.Today);
            jahr = heute.GetYear(DateTime.Today);
        }



        #endregion



    }
}
