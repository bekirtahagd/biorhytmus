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
    public partial class Hauptseite : Form
    {
        public Hauptseite(bool pDunklerModus)
        {
            InitializeComponent();

            dunklerModus = pDunklerModus;
        }

        private bool dunklerModus;
        private static SchemaSammlung schemaSammlung = new SchemaSammlung();

        private void Hauptseite_Load(object sender, EventArgs e)
        {
            //Ändere Farbschema zuerst
            aendereFarbschema(dunklerModus);
            aendereFarbschemaPanel(dunklerModus, true);

            //Aktualisiere die Werte
            DatenspeicherManager dM = new DatenspeicherManager();
            Benutzer benutzer = dM.getLokaleDaten().getBenutzer();
            Datum geb = benutzer.getGebDatum();

            dtpGeburtsdatum.Value = new DateTime(year: geb.getJahr(), month: geb.getMonat(), day: geb.getTag());
            verarbeite();
        }

        #region Button
        private void pnlDM_Click(object sender, EventArgs e)
        {
            dunklerModus = !dunklerModus;
            aendereFarbschemaPanel(dunklerModus, false);
            aendereFarbschema(dunklerModus);
        }
        private void btnAbmelden_Click(object sender, EventArgs e)
        {
            //Abmelden
            BenutzerManager bM = new BenutzerManager();
            bM.abmelden();
            öffneAnmeldeseite();
        }
        private void BtVerarbeitung_Click(object sender, EventArgs e)
        {
            verarbeite();
        }

        private void btnErweitert_Click(object sender, EventArgs e)
        {
            //Verstecke diese Seite
            this.Hide();

            //Öffne Anmeldeseite
            ErweiterteAnsicht erweiterteAnsicht = new ErweiterteAnsicht(getGeburtstag(), getKondition(), dunklerModus);
            erweiterteAnsicht.ShowDialog();

            //Schließe diese Seite
            this.Close();

        }


        #endregion


        #region Funktionen

        private void verarbeite()
        {
            Datum gebDatum = getGeburtstag();


            Datum heuteDatum = new Datum(0, 0, 0);
            heuteDatum.setDatumAufHeute();


            Kondition kondition = getKondition();


            lbTagesdatum.Text = "Tagesdatum: " + (heuteDatum.getTag() + "." +
            heuteDatum.getMonat() + "." +
            heuteDatum.getJahr());


            string glueckwunschText = "Alles Gute zum Geburtstag!!";
            //Falls früher geboren
            if (kondition.getTageSeitGeburt() > 0)
            {
                //Falls genau gestern
                if (kondition.getTageSeitGeburt() == 1)
                    lbGesamttage.Text = "Du hast gestern das Licht der Welt erblickt";
                //Falls vor mehr als 1 Tagen
                else
                    lbGesamttage.Text = "Du hast vor " + Convert.ToString(kondition.getTageSeitGeburt()) + " Tagen das Licht der Welt erblickt";
            }
            //Falls später geboren wird
            else if (kondition.getTageSeitGeburt() < 0)
            {
                //Falls genau morgen
                if (kondition.getTageSeitGeburt() == -1)
                    lbGesamttage.Text = "Du wirst in einem Tag das Licht der Welt erblicken";
                //Falls mehr als 1 Tag
                else
                    lbGesamttage.Text = "Du wirst in " + Convert.ToString(kondition.getTageSeitGeburt() * -1) + " Tagen das Licht der Welt erblicken";
            }
            //Falls genau heute geboren
            else if (kondition.getTageSeitGeburt() == 0)
            {
                lbGesamttage.Text = glueckwunschText;
            }

            //Falls Benutzer nioht heute geboren wurde und Geburtstag hat
            if (kondition.getTageSeitGeburt() != 0 && kondition.hatGeburtstag(gebDatum, heuteDatum))
            {
                lbGlueckwunsch.Text = glueckwunschText;
            }

            lbProzentKoerperlich.Text = Math.Round(kondition.berechneKonditionKoerperlich(0), 2) + "%";
            lbProzentGeistig.Text = Math.Round(kondition.berechneKonditionGeistig(0), 2) + "%";
            lbProzentPsychisch.Text = Math.Round(kondition.berechneKonditionPsychisch(0), 2) + "%";
            kondition.erzeugeKonditionPrognose(dgvTextPrognose, 14, 0, true);
            kondition.zeichneKonditionPrognose_60Tage(pnlPrognoseGraph.CreateGraphics());
            updateBenutzer();
        }

        #region Daten

        private void updateBenutzer()
        {
            DatenspeicherManager dM = new DatenspeicherManager();

            Benutzer benutzer = dM.getLokaleDaten().getBenutzer();
            Console.WriteLine(benutzer.getName());

            dM.getBenutzerListe()[benutzer.getIndex()].setGebDatum(getGeburtstag());
            dM.speicherBenutzerListe();
        }

        private Datum getGeburtstag()
        {
            int day = dtpGeburtsdatum.Value.Day;
            int month = dtpGeburtsdatum.Value.Month;
            int year = dtpGeburtsdatum.Value.Year;
            return new Datum(year, month, day);
        }
        private Kondition getKondition()
        {
            Datum heuteDatum = new Datum(0, 0, 0);
            heuteDatum.setDatumAufHeute();

            Kondition kondition = new Kondition();
            kondition.setTageSeitGeburt(heuteDatum.berechneTageDifferenz(getGeburtstag()));

            return kondition;
        }
        #endregion

        #region Farbschema
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

            //Ausnahmen rücksetzen
            lbKörperlich.ForeColor = SystemColors.HotTrack;
            lbGeistig.ForeColor = Color.Red;
            lbPhysisch.ForeColor = Color.Green;
        }
        #endregion

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

        #region Drucker

        //ToolTip
        private void pbDruck_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbDruck, "Drucken");
        }

        //Drucken
        Drucker drucker = new Drucker();
        protected override void OnPaint(PaintEventArgs e)
        {
            if (drucker.getBmp() != null)
            {
                e.Graphics.DrawImage(drucker.getBmp(), 0, 0);
                base.OnPaint(e);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            drucker.EV_DruckSeite(e);
        }

        private void pbDruck_Click(object sender, EventArgs e)
        {
            Control druckObjekt = this;
            drucker.Druck(druckObjekt, printPreviewDialog1);
        }


        #endregion


        #endregion
    }
}

