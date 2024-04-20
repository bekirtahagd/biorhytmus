namespace Biorhytmus
{
    partial class Hauptseite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptseite));
            this.btVerarbeitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTagesdatum = new System.Windows.Forms.Label();
            this.lbGesamttage = new System.Windows.Forms.Label();
            this.lbProzentGeistig = new System.Windows.Forms.Label();
            this.lbProzentPsychisch = new System.Windows.Forms.Label();
            this.lbPrognose14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.lbProzentKoerperlich = new System.Windows.Forms.Label();
            this.lbPrognose60 = new System.Windows.Forms.Label();
            this.pnlPrognoseGraph = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPhysisch = new System.Windows.Forms.Label();
            this.lbGeistig = new System.Windows.Forms.Label();
            this.lbKörperlich = new System.Windows.Forms.Label();
            this.dgvTextPrognose = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.körperlich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geistig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psychisch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGlueckwunsch = new System.Windows.Forms.Label();
            this.pnlDMHuelle = new System.Windows.Forms.Panel();
            this.pnlDMBox = new System.Windows.Forms.Panel();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pbDruck = new System.Windows.Forms.PictureBox();
            this.btnErweitert = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextPrognose)).BeginInit();
            this.pnlDMHuelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDruck)).BeginInit();
            this.SuspendLayout();
            // 
            // btVerarbeitung
            // 
            this.btVerarbeitung.Location = new System.Drawing.Point(59, 258);
            this.btVerarbeitung.Name = "btVerarbeitung";
            this.btVerarbeitung.Size = new System.Drawing.Size(116, 23);
            this.btVerarbeitung.TabIndex = 0;
            this.btVerarbeitung.Text = "Verarbeitung";
            this.btVerarbeitung.UseVisualStyleBackColor = true;
            this.btVerarbeitung.Click += new System.EventHandler(this.BtVerarbeitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teste deine Kondition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Geburtsdatum";
            // 
            // lbTagesdatum
            // 
            this.lbTagesdatum.AutoSize = true;
            this.lbTagesdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTagesdatum.Location = new System.Drawing.Point(56, 233);
            this.lbTagesdatum.Name = "lbTagesdatum";
            this.lbTagesdatum.Size = new System.Drawing.Size(127, 16);
            this.lbTagesdatum.TabIndex = 5;
            this.lbTagesdatum.Text = "Tagesdatum: ___";
            // 
            // lbGesamttage
            // 
            this.lbGesamttage.AutoSize = true;
            this.lbGesamttage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGesamttage.Location = new System.Drawing.Point(53, 325);
            this.lbGesamttage.Name = "lbGesamttage";
            this.lbGesamttage.Size = new System.Drawing.Size(354, 16);
            this.lbGesamttage.TabIndex = 6;
            this.lbGesamttage.Text = "Du hast vor ____ Tagen das Licht der Welt erblickt";
            // 
            // lbProzentGeistig
            // 
            this.lbProzentGeistig.AutoSize = true;
            this.lbProzentGeistig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProzentGeistig.Location = new System.Drawing.Point(156, 490);
            this.lbProzentGeistig.Name = "lbProzentGeistig";
            this.lbProzentGeistig.Size = new System.Drawing.Size(32, 16);
            this.lbProzentGeistig.TabIndex = 7;
            this.lbProzentGeistig.Text = "___";
            // 
            // lbProzentPsychisch
            // 
            this.lbProzentPsychisch.AutoSize = true;
            this.lbProzentPsychisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProzentPsychisch.Location = new System.Drawing.Point(156, 465);
            this.lbProzentPsychisch.Name = "lbProzentPsychisch";
            this.lbProzentPsychisch.Size = new System.Drawing.Size(32, 16);
            this.lbProzentPsychisch.TabIndex = 8;
            this.lbProzentPsychisch.Text = "___";
            // 
            // lbPrognose14
            // 
            this.lbPrognose14.AutoSize = true;
            this.lbPrognose14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrognose14.Location = new System.Drawing.Point(477, 132);
            this.lbPrognose14.Name = "lbPrognose14";
            this.lbPrognose14.Size = new System.Drawing.Size(155, 20);
            this.lbPrognose14.TabIndex = 9;
            this.lbPrognose14.Text = "Prognose 14 Tage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(67, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "körperlich";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tageskondition";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "geistig";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "psychisch";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(61, 182);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeburtsdatum.TabIndex = 15;
            // 
            // lbProzentKoerperlich
            // 
            this.lbProzentKoerperlich.AutoSize = true;
            this.lbProzentKoerperlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProzentKoerperlich.Location = new System.Drawing.Point(156, 437);
            this.lbProzentKoerperlich.Name = "lbProzentKoerperlich";
            this.lbProzentKoerperlich.Size = new System.Drawing.Size(32, 16);
            this.lbProzentKoerperlich.TabIndex = 16;
            this.lbProzentKoerperlich.Text = "___";
            // 
            // lbPrognose60
            // 
            this.lbPrognose60.AutoSize = true;
            this.lbPrognose60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrognose60.Location = new System.Drawing.Point(477, 347);
            this.lbPrognose60.Name = "lbPrognose60";
            this.lbPrognose60.Size = new System.Drawing.Size(155, 20);
            this.lbPrognose60.TabIndex = 17;
            this.lbPrognose60.Text = "Prognose 60 Tage";
            // 
            // pnlPrognoseGraph
            // 
            this.pnlPrognoseGraph.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlPrognoseGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrognoseGraph.Location = new System.Drawing.Point(481, 410);
            this.pnlPrognoseGraph.Name = "pnlPrognoseGraph";
            this.pnlPrognoseGraph.Size = new System.Drawing.Size(300, 145);
            this.pnlPrognoseGraph.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbPhysisch);
            this.panel2.Controls.Add(this.lbGeistig);
            this.panel2.Controls.Add(this.lbKörperlich);
            this.panel2.Location = new System.Drawing.Point(481, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 30);
            this.panel2.TabIndex = 19;
            // 
            // lbPhysisch
            // 
            this.lbPhysisch.AutoSize = true;
            this.lbPhysisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhysisch.ForeColor = System.Drawing.Color.Green;
            this.lbPhysisch.Location = new System.Drawing.Point(200, 6);
            this.lbPhysisch.Name = "lbPhysisch";
            this.lbPhysisch.Size = new System.Drawing.Size(56, 13);
            this.lbPhysisch.TabIndex = 2;
            this.lbPhysisch.Text = "physisch";
            // 
            // lbGeistig
            // 
            this.lbGeistig.AutoSize = true;
            this.lbGeistig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeistig.ForeColor = System.Drawing.Color.Red;
            this.lbGeistig.Location = new System.Drawing.Point(132, 6);
            this.lbGeistig.Name = "lbGeistig";
            this.lbGeistig.Size = new System.Drawing.Size(44, 13);
            this.lbGeistig.TabIndex = 1;
            this.lbGeistig.Text = "geistig";
            // 
            // lbKörperlich
            // 
            this.lbKörperlich.AutoSize = true;
            this.lbKörperlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKörperlich.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbKörperlich.Location = new System.Drawing.Point(44, 6);
            this.lbKörperlich.Name = "lbKörperlich";
            this.lbKörperlich.Size = new System.Drawing.Size(63, 13);
            this.lbKörperlich.TabIndex = 0;
            this.lbKörperlich.Text = "körperlich";
            // 
            // dgvTextPrognose
            // 
            this.dgvTextPrognose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTextPrognose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.körperlich,
            this.geistig,
            this.psychisch});
            this.dgvTextPrognose.Location = new System.Drawing.Point(480, 171);
            this.dgvTextPrognose.Name = "dgvTextPrognose";
            this.dgvTextPrognose.ReadOnly = true;
            this.dgvTextPrognose.RowHeadersVisible = false;
            this.dgvTextPrognose.Size = new System.Drawing.Size(300, 145);
            this.dgvTextPrognose.TabIndex = 14;
            // 
            // Tag
            // 
            this.Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tag.FillWeight = 50F;
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // körperlich
            // 
            this.körperlich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.körperlich.HeaderText = "körperlich";
            this.körperlich.Name = "körperlich";
            this.körperlich.ReadOnly = true;
            // 
            // geistig
            // 
            this.geistig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.geistig.HeaderText = "geistig";
            this.geistig.Name = "geistig";
            this.geistig.ReadOnly = true;
            // 
            // psychisch
            // 
            this.psychisch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.psychisch.HeaderText = "psychisch";
            this.psychisch.Name = "psychisch";
            this.psychisch.ReadOnly = true;
            // 
            // lbGlueckwunsch
            // 
            this.lbGlueckwunsch.AutoSize = true;
            this.lbGlueckwunsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGlueckwunsch.Location = new System.Drawing.Point(119, 358);
            this.lbGlueckwunsch.Name = "lbGlueckwunsch";
            this.lbGlueckwunsch.Size = new System.Drawing.Size(16, 16);
            this.lbGlueckwunsch.TabIndex = 20;
            this.lbGlueckwunsch.Text = "_";
            // 
            // pnlDMHuelle
            // 
            this.pnlDMHuelle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlDMHuelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlDMHuelle.Controls.Add(this.pnlDMBox);
            this.pnlDMHuelle.Location = new System.Drawing.Point(830, 21);
            this.pnlDMHuelle.Name = "pnlDMHuelle";
            this.pnlDMHuelle.Size = new System.Drawing.Size(49, 21);
            this.pnlDMHuelle.TabIndex = 22;
            this.pnlDMHuelle.Click += new System.EventHandler(this.pnlDM_Click);
            // 
            // pnlDMBox
            // 
            this.pnlDMBox.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlDMBox.Location = new System.Drawing.Point(3, 2);
            this.pnlDMBox.Name = "pnlDMBox";
            this.pnlDMBox.Size = new System.Drawing.Size(18, 17);
            this.pnlDMBox.TabIndex = 5;
            this.pnlDMBox.Click += new System.EventHandler(this.pnlDM_Click);
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.ForeColor = System.Drawing.Color.Red;
            this.btnAnmelden.Location = new System.Drawing.Point(12, 9);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 23;
            this.btnAnmelden.Text = "Abmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAbmelden_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Bioryhtmus";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pbDruck
            // 
            this.pbDruck.BackColor = System.Drawing.Color.Transparent;
            this.pbDruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbDruck.Image = global::Biorhytmus.Properties.Resources.Bild_2023_05_23_212218666_removebg_preview;
            this.pbDruck.Location = new System.Drawing.Point(743, 7);
            this.pbDruck.Name = "pbDruck";
            this.pbDruck.Size = new System.Drawing.Size(100, 52);
            this.pbDruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDruck.TabIndex = 24;
            this.pbDruck.TabStop = false;
            this.pbDruck.Click += new System.EventHandler(this.pbDruck_Click);
            this.pbDruck.MouseHover += new System.EventHandler(this.pbDruck_MouseHover);
            // 
            // btnErweitert
            // 
            this.btnErweitert.Location = new System.Drawing.Point(685, 132);
            this.btnErweitert.Name = "btnErweitert";
            this.btnErweitert.Size = new System.Drawing.Size(96, 23);
            this.btnErweitert.TabIndex = 25;
            this.btnErweitert.Text = "Erweitert";
            this.btnErweitert.UseVisualStyleBackColor = true;
            this.btnErweitert.Click += new System.EventHandler(this.btnErweitert_Click);
            // 
            // Hauptseite
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 637);
            this.Controls.Add(this.btnErweitert);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.pnlDMHuelle);
            this.Controls.Add(this.lbGlueckwunsch);
            this.Controls.Add(this.pnlPrognoseGraph);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbPrognose60);
            this.Controls.Add(this.lbProzentKoerperlich);
            this.Controls.Add(this.dtpGeburtsdatum);
            this.Controls.Add(this.dgvTextPrognose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPrognose14);
            this.Controls.Add(this.lbProzentPsychisch);
            this.Controls.Add(this.lbProzentGeistig);
            this.Controls.Add(this.lbGesamttage);
            this.Controls.Add(this.lbTagesdatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVerarbeitung);
            this.Controls.Add(this.pbDruck);
            this.Name = "Hauptseite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bioryhtmus";
            this.Load += new System.EventHandler(this.Hauptseite_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextPrognose)).EndInit();
            this.pnlDMHuelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerarbeitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTagesdatum;
        private System.Windows.Forms.Label lbGesamttage;
        private System.Windows.Forms.Label lbProzentGeistig;
        private System.Windows.Forms.Label lbProzentPsychisch;
        private System.Windows.Forms.Label lbPrognose14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.Label lbProzentKoerperlich;
        private System.Windows.Forms.Label lbPrognose60;
        private System.Windows.Forms.Panel pnlPrognoseGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPhysisch;
        private System.Windows.Forms.Label lbGeistig;
        private System.Windows.Forms.Label lbKörperlich;
        private System.Windows.Forms.DataGridView dgvTextPrognose;
        new private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn körperlich;
        private System.Windows.Forms.DataGridViewTextBoxColumn geistig;
        private System.Windows.Forms.DataGridViewTextBoxColumn psychisch;
        private System.Windows.Forms.Label lbGlueckwunsch;
        private System.Windows.Forms.Panel pnlDMHuelle;
        private System.Windows.Forms.Panel pnlDMBox;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbDruck;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnErweitert;
    }
}

