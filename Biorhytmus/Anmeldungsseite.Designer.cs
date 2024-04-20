namespace Biorhytmus
{
    partial class AnmeldungsSeite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btAnmelden = new System.Windows.Forms.Button();
            this.tbNutzername = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.cbAngemeldetBleiben = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRegistrieren = new System.Windows.Forms.Button();
            this.pnlDMHuelle = new System.Windows.Forms.Panel();
            this.pnlDMBox = new System.Windows.Forms.Panel();
            this.pnlDMHuelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmelden";
            // 
            // btAnmelden
            // 
            this.btAnmelden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnmelden.Location = new System.Drawing.Point(180, 176);
            this.btAnmelden.Name = "btAnmelden";
            this.btAnmelden.Size = new System.Drawing.Size(80, 24);
            this.btAnmelden.TabIndex = 1;
            this.btAnmelden.Text = "Anmelden";
            this.btAnmelden.UseVisualStyleBackColor = true;
            this.btAnmelden.Click += new System.EventHandler(this.btAnmelden_Click);
            // 
            // tbNutzername
            // 
            this.tbNutzername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNutzername.Location = new System.Drawing.Point(125, 93);
            this.tbNutzername.Name = "tbNutzername";
            this.tbNutzername.Size = new System.Drawing.Size(135, 20);
            this.tbNutzername.TabIndex = 2;
            // 
            // tbPasswort
            // 
            this.tbPasswort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPasswort.Location = new System.Drawing.Point(125, 133);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(135, 20);
            this.tbPasswort.TabIndex = 3;
            // 
            // cbAngemeldetBleiben
            // 
            this.cbAngemeldetBleiben.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAngemeldetBleiben.AutoSize = true;
            this.cbAngemeldetBleiben.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAngemeldetBleiben.Location = new System.Drawing.Point(63, 184);
            this.cbAngemeldetBleiben.Name = "cbAngemeldetBleiben";
            this.cbAngemeldetBleiben.Size = new System.Drawing.Size(111, 14);
            this.cbAngemeldetBleiben.TabIndex = 4;
            this.cbAngemeldetBleiben.Text = "Angemeldet bleiben?";
            this.cbAngemeldetBleiben.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAngemeldetBleiben.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nutzername:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passwort:";
            // 
            // btRegistrieren
            // 
            this.btRegistrieren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRegistrieren.BackColor = System.Drawing.Color.Transparent;
            this.btRegistrieren.FlatAppearance.BorderSize = 0;
            this.btRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrieren.ForeColor = System.Drawing.Color.Magenta;
            this.btRegistrieren.Location = new System.Drawing.Point(125, 204);
            this.btRegistrieren.Name = "btRegistrieren";
            this.btRegistrieren.Size = new System.Drawing.Size(96, 61);
            this.btRegistrieren.TabIndex = 7;
            this.btRegistrieren.Text = "oder Registriere dich jetzt";
            this.btRegistrieren.UseVisualStyleBackColor = false;
            this.btRegistrieren.Click += new System.EventHandler(this.btRegistrieren_Click);
            // 
            // pnlDMHuelle
            // 
            this.pnlDMHuelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDMHuelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlDMHuelle.Controls.Add(this.pnlDMBox);
            this.pnlDMHuelle.Location = new System.Drawing.Point(262, 11);
            this.pnlDMHuelle.Name = "pnlDMHuelle";
            this.pnlDMHuelle.Size = new System.Drawing.Size(40, 18);
            this.pnlDMHuelle.TabIndex = 23;
            this.pnlDMHuelle.Click += new System.EventHandler(this.pnlDM_Click);
            // 
            // pnlDMBox
            // 
            this.pnlDMBox.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlDMBox.Location = new System.Drawing.Point(4, 3);
            this.pnlDMBox.Name = "pnlDMBox";
            this.pnlDMBox.Size = new System.Drawing.Size(13, 12);
            this.pnlDMBox.TabIndex = 5;
            this.pnlDMBox.Click += new System.EventHandler(this.pnlDM_Click);
            // 
            // AnmeldungsSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.pnlDMHuelle);
            this.Controls.Add(this.btRegistrieren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAngemeldetBleiben);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbNutzername);
            this.Controls.Add(this.btAnmelden);
            this.Controls.Add(this.label1);
            this.Name = "AnmeldungsSeite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmeldung";
            this.Load += new System.EventHandler(this.AnmeldungsSeite_Load);
            this.pnlDMHuelle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnmelden;
        private System.Windows.Forms.TextBox tbNutzername;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.CheckBox cbAngemeldetBleiben;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRegistrieren;
        private System.Windows.Forms.Panel pnlDMHuelle;
        private System.Windows.Forms.Panel pnlDMBox;
    }
}