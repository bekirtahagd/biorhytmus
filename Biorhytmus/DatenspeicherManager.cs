using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace Biorhytmus
{
    [Serializable()]
    class DatenspeicherManager
    {
        // Variables
        #region Variables
            //LokaleDaten
        private LokaleDaten lokaleDaten = new LokaleDaten();
        private string lokaleDatenQuelle = Directory.GetCurrentDirectory() + "\\lokaleDaten.txt";

        //Benutzer
        private List<Benutzer> benutzerliste = new List<Benutzer>();
        private  string benutzerlisteQuelle = Directory.GetCurrentDirectory() + "\\benutzerListe.txt";
        #endregion

        public DatenspeicherManager()
        {
            if (File.Exists(lokaleDatenQuelle) && File.Exists(benutzerlisteQuelle)){
                //aktualisiere lokale Daten und Benutzerliste
                aktualisiereLokaleDaten();
                aktualisiereBenutzerListe();
            }
        }



        #region Setter and Getter

        public void setLokaleDaten(LokaleDaten value)
        {
            lokaleDaten = value;
        }
        public LokaleDaten getLokaleDaten()
        {
            return lokaleDaten;
        }
        
        public List<Benutzer> getBenutzerListe()
        {
            return benutzerliste;
        }

        public string getLokaleDatenQuelle()
        {
            return lokaleDatenQuelle;
        }
        public string getBenutzerlisteQuelle()
        {
            return benutzerlisteQuelle;
        }

        #endregion



        // Methods
        #region Methoden

        //Speichert die Werte
        private void speicherLokal(string dateiquelle, object ob)
        {
            leereLokal(dateiquelle);


            Stream s = File.Open(dateiquelle, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();

            //Zweiter Parameter wird gespeichert in ersten Parameter Stream
            b.Serialize(s, ob);
            s.Close();
        }


        //Leert die Werte
        private void leereLokal(string dateiquelle)
        {
            File.WriteAllText(dateiquelle, "");
        }

        #region lokale Daten
        //Speichert Lokale Daten
        public void speicherLokaleDaten()
        {
            speicherLokal(lokaleDatenQuelle, lokaleDaten);
        }


        //Liest lokale Daten
        public LokaleDaten liesLokaleDaten()
        {
            Stream s = File.OpenRead(lokaleDatenQuelle);
            BinaryFormatter b = new BinaryFormatter();
            LokaleDaten lD = (LokaleDaten)b.Deserialize(s);
            s.Close();


            return lD;
        }

        public void leereLokaleDaten()
        {
            leereLokal(lokaleDatenQuelle);
        }

        //Aktualisiert die lokalen Daten
        //Lokale Daten Variable wird gespeichert
        public LokaleDaten aktualisiereLokaleDaten()
        {
            LokaleDaten lkD = liesLokaleDaten();

            //Aktualisiere Werte
            lokaleDaten.setIstEingeloggt(lkD.getIstEingeloggt());
            lokaleDaten.setBenutzer(lkD.getBenutzer());

            return lokaleDaten;
        }

        #endregion

        #region Benutzer Liste
        //Speichert Benutzer Liste
        public void speicherBenutzerListe()
        {
            speicherLokal(benutzerlisteQuelle, benutzerliste);

            aktualisiereBenutzerListe();
        }


        //Liest lokale Daten
        public List<Benutzer> liesBenutzerListe()
        {
            if (!File.Exists(benutzerlisteQuelle))
            {
                File.Create(benutzerlisteQuelle).Close();
                return new List<Benutzer>();
            }
            else
            {
                Stream s = File.OpenRead(benutzerlisteQuelle);
                BinaryFormatter b = new BinaryFormatter();
                List<Benutzer> bL = (List<Benutzer>)b.Deserialize(s); //System.InvalidCastException: "Das Objekt des Typs "Biorhytmus.LokaleDaten" kann nicht in Typ "System.Collections.Generic.List`1[Biorhytmus.Benutzer]" umgewandelt werden."
                s.Close();
                return bL;
            }
        }

        public void leereBenutzerListe()
        {
            leereLokal(benutzerlisteQuelle);
        }

        //Aktualisiert die lokalen Daten
        public void aktualisiereBenutzerListe()
        {
            List<Benutzer> bl = liesBenutzerListe();

            //Aktualisiere Werte
            benutzerliste.Clear();
            benutzerliste = bl;
            
        }


        #endregion


        #endregion
    }
}