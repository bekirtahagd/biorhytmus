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
    public partial class ErweiterteAnsicht : Form
    {
        public ErweiterteAnsicht(Datum pGeb, Kondition pKond, bool pDunklerModus)
        {
            InitializeComponent();

            geburtstag = pGeb;
            kondition = pKond;
            dunklerModus = pDunklerModus;
        }

        bool dunklerModus;
        private static SchemaSammlung schemaSammlung = new SchemaSammlung();

        Datum geburtstag;
        Kondition kondition;

        private void ErweiterteAnsicht_Load(object sender, EventArgs e)
        {
            //Ändere Farbschema zuerst
            aendereFarbschema(dunklerModus);
            aendereFarbschemaPanel(dunklerModus, true);

            verarbeite();
        }

        private void verarbeite()
        {
            kondition.erzeugeKonditionPrognose(dgvTextPrognoseL70, 30, 60, false);
            kondition.erzeugeKonditionPrognose(dgvTextPrognoseL35, 30, 30, false);
            kondition.erzeugeKonditionPrognose(dgvTextPrognoseN35, 31, -1, true);
            kondition.erzeugeKonditionPrognose(dgvTextPrognoseN70, 31, 29, true);
        }
        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();

            Hauptseite hauptseite = new Hauptseite(dunklerModus);
            hauptseite.ShowDialog();

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
                    pnlDMBox.Left += 42;
                }
                else
                {
                    pnlDMBox.Left -= 42;
                }
            }
            else
            {
                //Wenn es der white mode ist, soll nichts passieren
                //Wenn es dark mode ist, soll es nach rechts verschoben werden
                if (dunkel)
                {
                    pnlDMBox.Left += 42;
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

        }

        #endregion


        #region Drucker


        Drucker drucker = new Drucker();
        protected override void OnPaint(PaintEventArgs e)
        {
            if (drucker.getBmp() != null)
            {
                e.Graphics.DrawImage(drucker.getBmp(), 0, 0);
                base.OnPaint(e);
            }
        }

        #region Letzten 70 Tage

        //ToolTip
        private void pbDruckL70T_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pbDruckL70T, "70 letzten Tage drucken");
        }


        private void pdL70T_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            drucker.EV_DruckSeite(e);
        }

        private void pbDruckL70T_Click(object sender, EventArgs e)
        {
            Control druckObjekt = pnlL70T;
            drucker.Druck(druckObjekt, ppdL70T);
        }

        #endregion

        #region Nächsten 70 Tage

        //ToolTip
        private void pbDruckN70T_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pbDruckN70T, "Nächste 70 Tage drucken");
        }


        private void pdN70T_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            drucker.EV_DruckSeite(e);
        }

        private void pbDruckN70T_Click(object sender, EventArgs e)
        {
            Control druckObjekt = pnlN70T;
            drucker.Druck(druckObjekt, ppdN70T);
        }


        #endregion

        #endregion


    }
}
