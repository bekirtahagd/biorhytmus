using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhytmus
{
    public class BenutzerManager
    {
        #region Methods

        public bool istNameVerfügbar(string benutzername)
        {
            //Lade zuerst all die Benutzer
            DatenspeicherManager dM = new DatenspeicherManager();
            List<Benutzer> benutzerListe = dM.getBenutzerListe();

            //Loop durch alle Benutzer
            foreach (Benutzer b in benutzerListe)
            {
                //Falls benutzernamen und passwort übereinstimmen, kann man sich anmelden
                if (benutzername.Equals(b.getName()))
                    return false;
            }

            return true;
        }

        public void registriereAccount(Benutzer benutzer)
        {
            //Bekomm eine Referenz zum Speicher
            DatenspeicherManager speicher = new DatenspeicherManager();

            //Füg den Benutzer zum speicher hinzu
            speicher.getBenutzerListe().Add(benutzer);

            //Füge Benutzer zur Liste hinzu
            speicher.speicherBenutzerListe();
            
        }

        public Benutzer probiereAnmeldung(string benutzername, string passwort)
        {
            //Lade zuerst all die Benutzer
            DatenspeicherManager dM = new DatenspeicherManager();
            List<Benutzer> benutzerListe = dM.getBenutzerListe();

            //Loop durch alle Benutzer
            foreach (Benutzer b in benutzerListe)
            {
                //Falls benutzernamen und passwort übereinstimmen, kann man sich anmelden
                if (benutzername.Equals(b.getName()) && passwort.Equals(b.getPasswort()))
                {
                    return b;
                }
            }

            return null;
        }
        public void anmelden(Benutzer benutzer, bool speichern)
        {
            //Aktualisiere Lokale Daten
            DatenspeicherManager speicher = new DatenspeicherManager();

            speicher.getLokaleDaten().setIstEingeloggt(speichern);
            speicher.getLokaleDaten().setBenutzer(benutzer);

            speicher.speicherLokaleDaten();
        }

        public void abmelden()
        {
            //Aktualisiere Lokale Daten
            DatenspeicherManager speicher = new DatenspeicherManager();

            speicher.getLokaleDaten().setIstEingeloggt(false);
            speicher.getLokaleDaten().setBenutzer(null);

            speicher.speicherLokaleDaten();
        }

        #endregion
    }
}
