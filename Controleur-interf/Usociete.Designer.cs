using System.Windows.Forms;
namespace TvaDeclarationApp.Controleur_interf
{
    partial class Usociete
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
            this.btnEnregsiter = new System.Windows.Forms.Button();
            this.Typederegime = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textlog = new System.Windows.Forms.TextBox();
            this.lcapital = new System.Windows.Forms.Label();
            this.txtcapitale = new System.Windows.Forms.TextBox();
            this.lactivite = new System.Windows.Forms.Label();
            this.combomodele = new System.Windows.Forms.ComboBox();
            this.lcnss = new System.Windows.Forms.Label();
            this.txtcnss = new System.Windows.Forms.TextBox();
            this.lModele = new System.Windows.Forms.Label();
            this.txtactivit = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lrc = new System.Windows.Forms.Label();
            this.texrc = new System.Windows.Forms.TextBox();
            this.lice = new System.Windows.Forms.Label();
            this.comboBoregisme = new System.Windows.Forms.ComboBox();
            this.txtice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltaxepro = new System.Windows.Forms.Label();
            this.lIdentidia = new System.Windows.Forms.Label();
            this.combforme = new System.Windows.Forms.ComboBox();
            this.combocomm = new System.Windows.Forms.ComboBox();
            this.txtidentifiant = new System.Windows.Forms.TextBox();
            this.lforme = new System.Windows.Forms.Label();
            this.txttaxepro = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.ltel = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lCommune = new System.Windows.Forms.Label();
            this.lsiege = new System.Windows.Forms.Label();
            this.txtsiege = new System.Windows.Forms.TextBox();
            this.txtraison = new System.Windows.Forms.TextBox();
            this.lraison = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregsiter
            // 
            this.btnEnregsiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(186)))), ((int)(((byte)(225)))));
            this.btnEnregsiter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnregsiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregsiter.Location = new System.Drawing.Point(304, 432);
            this.btnEnregsiter.Name = "btnEnregsiter";
            this.btnEnregsiter.Size = new System.Drawing.Size(160, 48);
            this.btnEnregsiter.TabIndex = 39;
            this.btnEnregsiter.Text = "Enregsitrer";
            this.btnEnregsiter.UseVisualStyleBackColor = false;
            this.btnEnregsiter.Click += new System.EventHandler(this.btnEnregsiter_Click);
            // 
            // Typederegime
            // 
            this.Typederegime.AutoSize = true;
            this.Typederegime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Typederegime.Location = new System.Drawing.Point(3, 394);
            this.Typederegime.Name = "Typederegime";
            this.Typederegime.Size = new System.Drawing.Size(91, 15);
            this.Typederegime.TabIndex = 38;
            this.Typederegime.Text = "Type Régime   :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBox2.Location = new System.Drawing.Point(110, 387);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(304, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mot de passe   :";
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(408, 386);
            this.txtmdp.Multiline = true;
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(177, 33);
            this.txtmdp.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(8, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Login   :";
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(111, 414);
            this.textlog.Multiline = true;
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(177, 33);
            this.textlog.TabIndex = 28;
            // 
            // lcapital
            // 
            this.lcapital.AutoSize = true;
            this.lcapital.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lcapital.Location = new System.Drawing.Point(303, 336);
            this.lcapital.Name = "lcapital";
            this.lcapital.Size = new System.Drawing.Size(57, 15);
            this.lcapital.TabIndex = 36;
            this.lcapital.Text = "Capitale :";
            // 
            // txtcapitale
            // 
            this.txtcapitale.Location = new System.Drawing.Point(407, 334);
            this.txtcapitale.Multiline = true;
            this.txtcapitale.Name = "txtcapitale";
            this.txtcapitale.Size = new System.Drawing.Size(177, 33);
            this.txtcapitale.TabIndex = 35;
            // 
            // lactivite
            // 
            this.lactivite.AutoSize = true;
            this.lactivite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lactivite.Location = new System.Drawing.Point(3, 355);
            this.lactivite.Name = "lactivite";
            this.lactivite.Size = new System.Drawing.Size(62, 15);
            this.lactivite.TabIndex = 34;
            this.lactivite.Text = "Activités :";
            // 
            // combomodele
            // 
            this.combomodele.FormattingEnabled = true;
            this.combomodele.Items.AddRange(new object[] {
            "Ainchock"});
            this.combomodele.Location = new System.Drawing.Point(110, 324);
            this.combomodele.Name = "combomodele";
            this.combomodele.Size = new System.Drawing.Size(177, 21);
            this.combomodele.TabIndex = 33;
            // 
            // lcnss
            // 
            this.lcnss.AutoSize = true;
            this.lcnss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lcnss.Location = new System.Drawing.Point(3, 294);
            this.lcnss.Name = "lcnss";
            this.lcnss.Size = new System.Drawing.Size(59, 17);
            this.lcnss.TabIndex = 25;
            this.lcnss.Text = "N°Cnss :";
            // 
            // txtcnss
            // 
            this.txtcnss.Location = new System.Drawing.Point(110, 276);
            this.txtcnss.Multiline = true;
            this.txtcnss.Name = "txtcnss";
            this.txtcnss.Size = new System.Drawing.Size(177, 33);
            this.txtcnss.TabIndex = 26;
            // 
            // lModele
            // 
            this.lModele.AutoSize = true;
            this.lModele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lModele.Location = new System.Drawing.Point(0, 327);
            this.lModele.Name = "lModele";
            this.lModele.Size = new System.Drawing.Size(121, 15);
            this.lModele.TabIndex = 27;
            this.lModele.Text = "Modéle Comptable  :";
            // 
            // txtactivit
            // 
            this.txtactivit.Location = new System.Drawing.Point(110, 349);
            this.txtactivit.Multiline = true;
            this.txtactivit.Name = "txtactivit";
            this.txtactivit.Size = new System.Drawing.Size(177, 33);
            this.txtactivit.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(406, 257);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 33);
            this.textBox3.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(303, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ice  :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 296);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 33);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(303, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "N°Rc :";
            // 
            // lrc
            // 
            this.lrc.AutoSize = true;
            this.lrc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lrc.Location = new System.Drawing.Point(303, 225);
            this.lrc.Name = "lrc";
            this.lrc.Size = new System.Drawing.Size(45, 17);
            this.lrc.TabIndex = 24;
            this.lrc.Text = "N°Rc :";
            // 
            // texrc
            // 
            this.texrc.Location = new System.Drawing.Point(406, 212);
            this.texrc.Multiline = true;
            this.texrc.Name = "texrc";
            this.texrc.Size = new System.Drawing.Size(177, 33);
            this.texrc.TabIndex = 23;
            // 
            // lice
            // 
            this.lice.AutoSize = true;
            this.lice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lice.Location = new System.Drawing.Point(303, 175);
            this.lice.Name = "lice";
            this.lice.Size = new System.Drawing.Size(37, 17);
            this.lice.TabIndex = 22;
            this.lice.Text = "Ice  :";
            // 
            // comboBoregisme
            // 
            this.comboBoregisme.FormattingEnabled = true;
            this.comboBoregisme.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBoregisme.Location = new System.Drawing.Point(406, 145);
            this.comboBoregisme.Name = "comboBoregisme";
            this.comboBoregisme.Size = new System.Drawing.Size(177, 21);
            this.comboBoregisme.TabIndex = 21;
            // 
            // txtice
            // 
            this.txtice.Location = new System.Drawing.Point(406, 173);
            this.txtice.Multiline = true;
            this.txtice.Name = "txtice";
            this.txtice.Size = new System.Drawing.Size(177, 33);
            this.txtice.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(303, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Régime  :";
            // 
            // ltaxepro
            // 
            this.ltaxepro.AutoSize = true;
            this.ltaxepro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ltaxepro.Location = new System.Drawing.Point(303, 107);
            this.ltaxepro.Name = "ltaxepro";
            this.ltaxepro.Size = new System.Drawing.Size(88, 17);
            this.ltaxepro.TabIndex = 18;
            this.ltaxepro.Text = "N°Taxe Pro  :";
            // 
            // lIdentidia
            // 
            this.lIdentidia.AutoSize = true;
            this.lIdentidia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lIdentidia.Location = new System.Drawing.Point(304, 62);
            this.lIdentidia.Name = "lIdentidia";
            this.lIdentidia.Size = new System.Drawing.Size(81, 17);
            this.lIdentidia.TabIndex = 17;
            this.lIdentidia.Text = "Identifiant :";
            // 
            // combforme
            // 
            this.combforme.FormattingEnabled = true;
            this.combforme.Items.AddRange(new object[] {
            "Ainchock"});
            this.combforme.Location = new System.Drawing.Point(406, 36);
            this.combforme.Name = "combforme";
            this.combforme.Size = new System.Drawing.Size(177, 21);
            this.combforme.TabIndex = 16;
            // 
            // combocomm
            // 
            this.combocomm.FormattingEnabled = true;
            this.combocomm.Items.AddRange(new object[] {
            "Ainchock"});
            this.combocomm.Location = new System.Drawing.Point(109, 114);
            this.combocomm.Name = "combocomm";
            this.combocomm.Size = new System.Drawing.Size(177, 21);
            this.combocomm.TabIndex = 15;
            // 
            // txtidentifiant
            // 
            this.txtidentifiant.Location = new System.Drawing.Point(407, 62);
            this.txtidentifiant.MaxLength = 15;
            this.txtidentifiant.Multiline = true;
            this.txtidentifiant.Name = "txtidentifiant";
            this.txtidentifiant.Size = new System.Drawing.Size(177, 33);
            this.txtidentifiant.TabIndex = 14;
            this.txtidentifiant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentifiant_KeyPress);
            // 
            // lforme
            // 
            this.lforme.AutoSize = true;
            this.lforme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lforme.Location = new System.Drawing.Point(304, 37);
            this.lforme.Name = "lforme";
            this.lforme.Size = new System.Drawing.Size(115, 17);
            this.lforme.TabIndex = 12;
            this.lforme.Text = "Forme juridique :";
            // 
            // txttaxepro
            // 
            this.txttaxepro.Location = new System.Drawing.Point(406, 101);
            this.txttaxepro.Multiline = true;
            this.txttaxepro.Name = "txttaxepro";
            this.txttaxepro.Size = new System.Drawing.Size(177, 33);
            this.txttaxepro.TabIndex = 13;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lemail.Location = new System.Drawing.Point(3, 244);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(54, 17);
            this.lemail.TabIndex = 10;
            this.lemail.Text = "Email  :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 236);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(177, 33);
            this.txtemail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " Fax :";
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(110, 192);
            this.txtfax.MaxLength = 10;
            this.txtfax.Multiline = true;
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(177, 33);
            this.txtfax.TabIndex = 9;
            // 
            // ltel
            // 
            this.ltel.AutoSize = true;
            this.ltel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ltel.Location = new System.Drawing.Point(3, 145);
            this.ltel.Name = "ltel";
            this.ltel.Size = new System.Drawing.Size(34, 17);
            this.ltel.TabIndex = 6;
            this.ltel.Text = "Tél :";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(110, 144);
            this.txttel.MaxLength = 10;
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(177, 33);
            this.txttel.TabIndex = 7;
            // 
            // lCommune
            // 
            this.lCommune.AutoSize = true;
            this.lCommune.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lCommune.Location = new System.Drawing.Point(2, 114);
            this.lCommune.Name = "lCommune";
            this.lCommune.Size = new System.Drawing.Size(79, 17);
            this.lCommune.TabIndex = 4;
            this.lCommune.Text = "Commune :";
            // 
            // lsiege
            // 
            this.lsiege.AutoSize = true;
            this.lsiege.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lsiege.Location = new System.Drawing.Point(3, 75);
            this.lsiege.Name = "lsiege";
            this.lsiege.Size = new System.Drawing.Size(89, 17);
            this.lsiege.TabIndex = 2;
            this.lsiege.Text = "Siége Social :";
            // 
            // txtsiege
            // 
            this.txtsiege.AccessibleName = "";
            this.txtsiege.Location = new System.Drawing.Point(110, 75);
            this.txtsiege.Multiline = true;
            this.txtsiege.Name = "txtsiege";
            this.txtsiege.Size = new System.Drawing.Size(177, 33);
            this.txtsiege.TabIndex = 3;
            // 
            // txtraison
            // 
            this.txtraison.Location = new System.Drawing.Point(110, 36);
            this.txtraison.Multiline = true;
            this.txtraison.Name = "txtraison";
            this.txtraison.Size = new System.Drawing.Size(177, 33);
            this.txtraison.TabIndex = 1;
            // 
            // lraison
            // 
            this.lraison.AutoSize = true;
            this.lraison.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lraison.Location = new System.Drawing.Point(3, 37);
            this.lraison.Name = "lraison";
            this.lraison.Size = new System.Drawing.Size(104, 17);
            this.lraison.TabIndex = 0;
            this.lraison.Text = "Raison Sociale :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 29);
            this.panel1.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Sociéte";
            // 
            // Usociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnregsiter);
            this.Controls.Add(this.Typederegime);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.lcapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcapitale);
            this.Controls.Add(this.lactivite);
            this.Controls.Add(this.combomodele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtactivit);
            this.Controls.Add(this.lModele);
            this.Controls.Add(this.txtcnss);
            this.Controls.Add(this.lcnss);
            this.Controls.Add(this.lrc);
            this.Controls.Add(this.texrc);
            this.Controls.Add(this.lice);
            this.Controls.Add(this.comboBoregisme);
            this.Controls.Add(this.txtice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltaxepro);
            this.Controls.Add(this.lIdentidia);
            this.Controls.Add(this.combforme);
            this.Controls.Add(this.combocomm);
            this.Controls.Add(this.txtidentifiant);
            this.Controls.Add(this.txttaxepro);
            this.Controls.Add(this.lforme);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.txtfax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.ltel);
            this.Controls.Add(this.lCommune);
            this.Controls.Add(this.txtsiege);
            this.Controls.Add(this.lsiege);
            this.Controls.Add(this.txtraison);
            this.Controls.Add(this.lraison);
            this.Name = "Usociete";
            this.Size = new System.Drawing.Size(597, 484);
            this.Load += new System.EventHandler(this.Usociete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnregsiter;
        private Label Typederegime;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox txtmdp;
        private Label label6;
        private TextBox textlog;
        private Label lcapital;
        private TextBox txtcapitale;
        private Label lactivite;
        private ComboBox combomodele;
        private Label lcnss;
        private TextBox txtcnss;
        private Label lModele;
        private TextBox txtactivit;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label lrc;
        private Label lice;
        private ComboBox comboBoregisme;
        private TextBox txtice;
        private Label label1;
        private Label ltaxepro;
        private Label lIdentidia;
        private ComboBox combforme;
        private ComboBox combocomm;
        private TextBox txtidentifiant;
        private Label lforme;
        private TextBox txttaxepro;
        private Label lemail;
        private TextBox txtemail;
        private Label label4;
        private TextBox txtfax;
        private Label ltel;
        private TextBox txttel;
        private Label lCommune;
        private Label lsiege;
        private TextBox txtsiege;
        private TextBox txtraison;
        private Label lraison;
        private Panel panel1;
        private Label label5;
        public TextBox texrc;
    }
}
