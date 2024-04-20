using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhytmus
{
    public partial class AnmeldungsSeite : Form
    {
        public AnmeldungsSeite(bool pDunklerModus)
        {
            InitializeComponent();

            dunklerModus = pDunklerModus;
        }

        private bool dunklerModus = false;
        private static SchemaSammlung schemaSammlung = new SchemaSammlung();

        private void btRegistrieren_Click(object sender, EventArgs e)
        {
            //Wechsel zu Registrierungsseite

            //Verstecke dieses Fenster
            this.Hide();

            //Öffne neues Fenster
            Registrierungsseite registrierung = new Registrierungsseite(dunklerModus);
            registrierung.ShowDialog();

            //Schließ dieses Fenster
            this.Close();
        }

        private void btAnmelden_Click(object sender, EventArgs e)
        {
            //Anmelden
            BenutzerManager bM = new BenutzerManager();

            Benutzer benutzer = bM.probiereAnmeldung(tbNutzername.Text, tbPasswort.Text);

            //Kann sich anmelden
            if (benutzer != null)
            {
                bM.anmelden(benutzer, cbAngemeldetBleiben.Checked);
                öffneHauptseite();
            }
            else
            {
                MessageBox.Show("Ein Fehler ist aufgetreten! Vergewisseren Sie sich, dass der Benutzername und das Passwort korrekt sind", "Fehlerhafter Benutzername oder Passwort", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void AnmeldungsSeite_Load(object sender, EventArgs e)
        {
            //Ändere Farbschema zuerst
            aendereFarbschema(dunklerModus);
            aendereFarbschemaPanel(dunklerModus, true);


            DatenspeicherManager dM = new DatenspeicherManager();
            string path = dM.getLokaleDatenQuelle();

            //Prüfe ob es vorherige Anmeldung gab
            if (!File.Exists(path))
            {
                //Erstelle Datenspeicher
                File.Create(path).Close();
                dM.getLokaleDaten().setIstEingeloggt(false);
                dM.speicherLokaleDaten();

                //Erstelle Benutzer Liste
                File.Create(dM.getBenutzerlisteQuelle()).Close();
                dM.getBenutzerListe().Add(new Benutzer(0, "123123sasddsffasdasdgdsq23wertwqer", "12398712ewr39ewrwerqwwer87qdjasd", new Datum(0, 0, 0), new Kondition()));
                dM.speicherBenutzerListe();

                Console.WriteLine("Files created;");
            }
            else
            {
                //Aktualisiere Datenspeicher und Benutzer Liste
                LokaleDaten lk = dM.aktualisiereLokaleDaten();
                dM.aktualisiereBenutzerListe();
                

                //Angemeldet?
                if (lk.getIstEingeloggt())
                {
                    öffneHauptseite();
                }
            }
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
            btRegistrieren.ForeColor = schemaSammlung.getSpecialButtonSchema(dunkel).getForeColor();
        }

        #endregion


    }
}
