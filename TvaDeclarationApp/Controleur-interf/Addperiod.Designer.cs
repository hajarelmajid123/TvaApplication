﻿namespace TvaDeclarationApp.Controleur_interf
{
    partial class Addperiod
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.facture = new System.Windows.Forms.Label();
            this.txtnompreiode = new System.Windows.Forms.TextBox();
            this.lsiege = new System.Windows.Forms.Label();
            this.MontantPériode = new System.Windows.Forms.Label();
            this.txtmontantperiode = new System.Windows.Forms.TextBox();
            this.btnEnregsiter = new System.Windows.Forms.Button();
            this.datedeclaration = new System.Windows.Forms.MonthCalendar();
            this.comboBoexercice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facture
            // 
            this.facture.AutoSize = true;
            this.facture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facture.Location = new System.Drawing.Point(3, 99);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(97, 17);
            this.facture.TabIndex = 141;
            this.facture.Text = "Nom Période :";
            // 
            // txtnompreiode
            // 
            this.txtnompreiode.Location = new System.Drawing.Point(137, 98);
            this.txtnompreiode.Multiline = true;
            this.txtnompreiode.Name = "txtnompreiode";
            this.txtnompreiode.Size = new System.Drawing.Size(206, 38);
            this.txtnompreiode.TabIndex = 142;
            // 
            // lsiege
            // 
            this.lsiege.AutoSize = true;
            this.lsiege.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsiege.Location = new System.Drawing.Point(1, 232);
            this.lsiege.Name = "lsiege";
            this.lsiege.Size = new System.Drawing.Size(124, 17);
            this.lsiege.TabIndex = 143;
            this.lsiege.Text = "Date Déclaration  :";
            // 
            // MontantPériode
            // 
            this.MontantPériode.AutoSize = true;
            this.MontantPériode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MontantPériode.Location = new System.Drawing.Point(362, 99);
            this.MontantPériode.Name = "MontantPériode";
            this.MontantPériode.Size = new System.Drawing.Size(120, 17);
            this.MontantPériode.TabIndex = 148;
            this.MontantPériode.Text = "MontantPériode  :";
            // 
            // txtmontantperiode
            // 
            this.txtmontantperiode.Location = new System.Drawing.Point(488, 98);
            this.txtmontantperiode.Multiline = true;
            this.txtmontantperiode.Name = "txtmontantperiode";
            this.txtmontantperiode.Size = new System.Drawing.Size(206, 38);
            this.txtmontantperiode.TabIndex = 149;
            // 
            // btnEnregsiter
            // 
            this.btnEnregsiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btnEnregsiter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnregsiter.ForeColor = System.Drawing.Color.White;
            this.btnEnregsiter.Location = new System.Drawing.Point(327, 495);
            this.btnEnregsiter.Name = "btnEnregsiter";
            this.btnEnregsiter.Size = new System.Drawing.Size(187, 55);
            this.btnEnregsiter.TabIndex = 157;
            this.btnEnregsiter.Text = "Enregsiter";
            this.btnEnregsiter.UseVisualStyleBackColor = false;
            this.btnEnregsiter.Click += new System.EventHandler(this.btnEnregsiter_Click);
            // 
            // datedeclaration
            // 
            this.datedeclaration.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.datedeclaration.Location = new System.Drawing.Point(137, 197);
            this.datedeclaration.Name = "datedeclaration";
            this.datedeclaration.TabIndex = 167;
            // 
            // comboBoexercice
            // 
            this.comboBoexercice.FormattingEnabled = true;
            this.comboBoexercice.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBoexercice.Location = new System.Drawing.Point(484, 8);
            this.comboBoexercice.Name = "comboBoexercice";
            this.comboBoexercice.Size = new System.Drawing.Size(206, 23);
            this.comboBoexercice.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Périodes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoexercice);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 53);
            this.panel1.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(377, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 138;
            this.label6.Text = "Exercice   :";
            // 
            // Addperiod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datedeclaration);
            this.Controls.Add(this.btnEnregsiter);
            this.Controls.Add(this.txtmontantperiode);
            this.Controls.Add(this.MontantPériode);
            this.Controls.Add(this.lsiege);
            this.Controls.Add(this.txtnompreiode);
            this.Controls.Add(this.facture);
            this.Name = "Addperiod";
            this.Size = new System.Drawing.Size(697, 631);
            this.Load += new System.EventHandler(this.Addperiod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label facture;
        private TextBox txtnompreiode;
        private Label lsiege;
        private Label MontantPériode;
        private TextBox txtmontantperiode;
        private Button btnEnregsiter;
        private MonthCalendar datedeclaration;
        private ComboBox comboBoexercice;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}
