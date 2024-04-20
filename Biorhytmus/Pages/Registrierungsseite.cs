using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhytmus
{
    public partial class Registrierungsseite : Form
    {
        public Registrierungsseite(bool pDunklerModus)
        {
            InitializeComponent();

            dunklerModus = pDunklerModus;
        }

        private bool dunklerModus = false;
        private static SchemaSammlung schemaSammlung = new SchemaSammlung();

        private void BtAnmelden_Click(object sender, EventArgs e)
        {
            //Öffne Anmeldeseite
            öffneAnmeldeseite();
            
        }

        private void BtRegistrieren_Click(object sender, EventArgs e)
        {
            //Registriere dich

            BenutzerManager bm = new BenutzerManager();

            //Prüfe ob benutzername mehr als 4 zeichen und weniger als 64 hat
            string nutzername = tbNutzername.Text;
            if (nutzername.Length >= 4 && nutzername.Length <= 20)
            { //Nutzername korrekt
                //Hat Nutzername irgendwelche Sonderzeichen
                if (!nutzername.Any(ch => !char.IsLetterOrDigit(ch)))
                { //Nein
                    string passwort = tbPasswort.Text;

                    //Passwort muss minimum 8 Zeichen haben
                    if (passwort.Length >= 8)
                    {
                        string bestaetigtesPasswort = tbPasswortBestaetigen.Text;

                        //Prüfe ob Passwörter übereinstimmen
                        if (passwort.Equals(bestaetigtesPasswort))
                        { //Ja
                            //ist Benutzername noch verfügbar
                            if (bm.istNameVerfügbar(nutzername))
                            { //Erstelle Account
                                registriere(nutzername, passwort, cbAngemeldetBleiben.Checked);
                            }
                            else
                            { //Nein
                                MessageBox.Show("Benutzername ist schon vergeben!", "Freier Benutzername", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        { //Nein
                            MessageBox.Show("Passwörter müssen übereinstimmen!", "Fehlerhafte Passwörter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        //Nein
                        MessageBox.Show("Dein Passwort braucht mindestens 8 Zeichen!", "Fehlerhaftes Passwort", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Dein Benutzername darf keine Sonderzeichen beinhalten!", "Fehlerhafter Nutzername", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            { //Nutzername fehlerhaft
                MessageBox.Show("Dein Benutzername darf nicht weniger als 4 und mehr als 20 Zeichen beinhalten!", "Fehlerhafter Nutzername", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void registriere(string name, string passwort, bool speichern)
        {
            //Bekomme Index
            //Index = List Count
            DatenspeicherManager dM = new DatenspeicherManager();
            int index = dM.getBenutzerListe().Count;
            

            //Kriege Info für Anzumeldenende Account
            Datum phDatum = new Datum(0, 0, 0); //platzhalter
            phDatum.setDatumAufHeute();
            Benutzer benutzer = new Benutzer(index, name, passwort, phDatum, new Kondition());

            //Account wird registriert
            BenutzerManager bM = new BenutzerManager();
            bM.registriereAccount(benutzer);

            Console.WriteLine("Registriert");

            //Anmelden
            bM.anmelden(benutzer, speichern);
            öffneHauptseite();

        }

        private void öffneHauptseite()
        {
            //Verstecke diese Seite
            this.Hide();

            //Öffne Anmeldeseite
            Hauptseite hauptseite = new Hauptseite(dunklerModus);
            hauptseite.ShowDialog();

            //Schließe diese Seite
            this.Close();
        }

        private void öffneAnmeldeseite()
        {
            //Verstecke diese Seite
            this.Hide();

            //Öffne Anmeldeseite
            AnmeldungsSeite anmeldung = new AnmeldungsSeite(dunklerModus);
            anmeldung.ShowDialog();

            //Schließe diese Seite
            this.Close();
        }

        #region Farbschema
        private void pnlDM_Click(object sender, EventArgs e)
        {
            dunklerModus = !dunklerModus;
            aendereFarbschemaPanel(dunklerModus, false);
            aendereFarbschema(dunklerModus);
        }

        //Die Variable übergang beschreibt ob dies beim Laden der Seite ausgeführt wird
        //Falls ja, darf die pnlDMBox nicht weiter nach links verschoben werden
        private void aendereFarbschemaPanel(bool dunkel, bool übergang)
        {
            if (!übergang)
            {
                //Visuell
                if (dunkel)
                {
                    pnlDMBox.Left += 20;
                }
                else
                {
                    pnlDMBox.Left -= 20;
                }
            }
            else
            {
                //Wenn es der white mode ist, soll nichts passieren
                //Wenn es dark mode ist, soll es nach rechts verschoben werden
                if (dunkel)
                {
                    pnlDMBox.Left += 20;
                }
            }
        }

        private void aendereFarbschema(bool dunkel)
        {
            //Form
            this.BackColor = schemaSammlung.getFormSchema(dunkel).getBackColor();

            foreach (Control komponent in this.Controls)
            {
                if (komponent is Label)
                {
                    komponent.BackColor = schemaSammlung.getLabelSchema(dunkel).getBackColor();
                    komponent.ForeColor = schemaSammlung.getLabelSchema(dunkel).getForeColor();
                }

                if (komponent is CheckBox)
                {
                    komponent.ForeColor = schemaSammlung.getLabelSchema(dunkel).getForeColor();
                }

                if (komponent is Panel)
                {
                    foreach (Control kind in komponent.Controls)
                    {
                        if (kind is Label)
                        {
                            kind.BackColor = schemaSammlung.getLabelSchema(dunkel).getBackColor();
                            kind.ForeColor = schemaSammlung.getLabelSchema(dunkel).getForeColor();
                        }
                    }
                }
            }

            //Panel Switch Button
            pnlDMHuelle.BackColor = schemaSammlung.getDmPanelSchema(dunkel).getBackColor();
            pnlDMBox.BackColor = schemaSammlung.getDmPanelSchema(!dunkel).getBackColor();

            //Oder Registrieren Knopf
            btAnmelden.ForeColor = schemaSammlung.getSpecialButtonSchema(dunkel).getForeColor();
        }

        #endregion

        private void Registrierungsseite_Load(object sender, EventArgs e)
        {
            //Ändere Farbschema zuerst
            aendereFarbschema(dunklerModus);
            aendereFarbschemaPanel(dunklerModus, true);
        }
    }
}
