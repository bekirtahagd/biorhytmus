using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Biorhytmus
{
    [Serializable()]
    public class Benutzer
    {



        // Variables
        #region Variables

        private int index;
        private string name;
        private string passwort;
        private Datum gebDatum;
        private Kondition kondition;



        #endregion

        //Constructor
        #region Constructor

        public Benutzer(int pIndex, string pName, string pPasswort, Datum pGebDatum, Kondition pKondition)
        {
            index = pIndex;
            name = pName;
            passwort = pPasswort;
            gebDatum = pGebDatum;
            kondition = pKondition;
        }



        #endregion


        #region Setter and Getter

        public void setIndex(int value)
        {
            index = value;
        }
        public int getIndex()
        {
            return index;
        }

        public void setName(string value)
        {
            name = value;
        }
        public string getName()
        {
            return name;
        }

        public void setPasswort(string value)
        {
            passwort = value;
        }
        public string getPasswort()
        {
            return passwort;
        }

        public void setGebDatum(Datum value)
        {
            gebDatum = value;
        }
        public Datum getGebDatum()
        {
            return gebDatum;
        }



        public void setKondition(Kondition value)
        {
            kondition = value;
        }
        public Kondition getKondition()
        {
            return kondition;
        }



        #endregion
    }
}