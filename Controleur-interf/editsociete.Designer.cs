using System.Windows.Forms;
namespace TvaDeclarationApp.Controleur_interf
{
    partial class editsociete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregsiter = new System.Windows.Forms.Button();
            this.Typederegime = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lcapital = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcapitale = new System.Windows.Forms.TextBox();
            this.lactivite = new System.Windows.Forms.Label();
            this.combomodele = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtactivit = new System.Windows.Forms.TextBox();
            this.lModele = new System.Windows.Forms.Label();
            this.txtcnss = new System.Windows.Forms.TextBox();
            this.lcnss = new System.Windows.Forms.Label();
            this.lrc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lice = new System.Windows.Forms.Label();
            this.comboBoregisme = new System.Windows.Forms.ComboBox();
            this.txtice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltaxepro = new System.Windows.Forms.Label();
            this.lIdentidia = new System.Windows.Forms.Label();
            this.combforme = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtidentifiant = new System.Windows.Forms.TextBox();
            this.txttaxepro = new System.Windows.Forms.TextBox();
            this.lforme = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.ltel = new System.Windows.Forms.Label();
            this.lCommune = new System.Windows.Forms.Label();
            this.txtsiege = new System.Windows.Forms.TextBox();
            this.lsiege = new System.Windows.Forms.Label();
            this.txtraison = new System.Windows.Forms.TextBox();
            this.lraison = new System.Windows.Forms.Label();
            this.suppr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 33);
            this.panel1.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Sociéte";
            // 
            // btnEnregsiter
            // 
            this.btnEnregsiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(186)))), ((int)(((byte)(225)))));
            this.btnEnregsiter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnregsiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregsiter.Location = new System.Drawing.Point(341, 500);
            this.btnEnregsiter.Name = "btnEnregsiter";
            this.btnEnregsiter.Size = new System.Drawing.Size(168, 55);
            this.btnEnregsiter.TabIndex = 128;
            this.btnEnregsiter.Text = "Enregsitrer";
            this.btnEnregsiter.UseVisualStyleBackColor = false;
            this.btnEnregsiter.Click += new System.EventHandler(this.btnEnregsiter_Click_1);
            // 
            // Typederegime
            // 
            this.Typederegime.AutoSize = true;
            this.Typederegime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Typederegime.Location = new System.Drawing.Point(3, 457);
            this.Typederegime.Name = "Typederegime";
            this.Typederegime.Size = new System.Drawing.Size(91, 15);
            this.Typederegime.TabIndex = 127;
            this.Typederegime.Text = "Type Régime   :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBox2.Location = new System.Drawing.Point(128, 449);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 23);
            this.comboBox2.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(355, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Mot de passe   :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(476, 447);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 38);
            this.textBox6.TabIndex = 122;
            // 
            // lcapital
            // 
            this.lcapital.AutoSize = true;
            this.lcapital.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lcapital.Location = new System.Drawing.Point(354, 390);
            this.lcapital.Name = "lcapital";
            this.lcapital.Size = new System.Drawing.Size(57, 15);
            this.lcapital.TabIndex = 124;
            this.lcapital.Text = "Capitale :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 120;
            this.label6.Text = "Login   :";
            // 
            // txtcapitale
            // 
            this.txtcapitale.Location = new System.Drawing.Point(475, 387);
            this.txtcapitale.Multiline = true;
            this.txtcapitale.Name = "txtcapitale";
            this.txtcapitale.Size = new System.Drawing.Size(206, 38);
            this.txtcapitale.TabIndex = 123;
            // 
            // lactivite
            // 
            this.lactivite.AutoSize = true;
            this.lactivite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lactivite.Location = new System.Drawing.Point(3, 412);
            this.lactivite.Name = "lactivite";
            this.lactivite.Size = new System.Drawing.Size(62, 15);
            this.lactivite.TabIndex = 121;
            this.lactivite.Text = "Activités :";
            // 
            // combomodele
            // 
            this.combomodele.FormattingEnabled = true;
            this.combomodele.Items.AddRange(new object[] {
            "Ainchock"});
            this.combomodele.Location = new System.Drawing.Point(128, 376);
            this.combomodele.Name = "combomodele";
            this.combomodele.Size = new System.Drawing.Size(206, 23);
            this.combomodele.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "N°Rc :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 343);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 38);
            this.textBox2.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(354, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Ice  :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 480);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 38);
            this.textBox5.TabIndex = 114;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(474, 298);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 38);
            this.textBox3.TabIndex = 115;
            // 
            // txtactivit
            // 
            this.txtactivit.Location = new System.Drawing.Point(128, 405);
            this.txtactivit.Multiline = true;
            this.txtactivit.Name = "txtactivit";
            this.txtactivit.Size = new System.Drawing.Size(206, 38);
            this.txtactivit.TabIndex = 113;
            // 
            // lModele
            // 
            this.lModele.AutoSize = true;
            this.lModele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lModele.Location = new System.Drawing.Point(0, 379);
            this.lModele.Name = "lModele";
            this.lModele.Size = new System.Drawing.Size(121, 15);
            this.lModele.TabIndex = 112;
            this.lModele.Text = "Modéle Comptable  :";
            // 
            // txtcnss
            // 
            this.txtcnss.Location = new System.Drawing.Point(128, 320);
            this.txtcnss.Multiline = true;
            this.txtcnss.Name = "txtcnss";
            this.txtcnss.Size = new System.Drawing.Size(206, 38);
            this.txtcnss.TabIndex = 111;
            // 
            // lcnss
            // 
            this.lcnss.AutoSize = true;
            this.lcnss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lcnss.Location = new System.Drawing.Point(3, 341);
            this.lcnss.Name = "lcnss";
            this.lcnss.Size = new System.Drawing.Size(59, 17);
            this.lcnss.TabIndex = 110;
            this.lcnss.Text = "N°Cnss :";
            // 
            // lrc
            // 
            this.lrc.AutoSize = true;
            this.lrc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lrc.Location = new System.Drawing.Point(354, 262);
            this.lrc.Name = "lrc";
            this.lrc.Size = new System.Drawing.Size(45, 17);
            this.lrc.TabIndex = 109;
            this.lrc.Text = "N°Rc :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 38);
            this.textBox1.TabIndex = 108;
            // 
            // lice
            // 
            this.lice.AutoSize = true;
            this.lice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lice.Location = new System.Drawing.Point(354, 204);
            this.lice.Name = "lice";
            this.lice.Size = new System.Drawing.Size(37, 17);
            this.lice.TabIndex = 107;
            this.lice.Text = "Ice  :";
            // 
            // comboBoregisme
            // 
            this.comboBoregisme.FormattingEnabled = true;
            this.comboBoregisme.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBoregisme.Location = new System.Drawing.Point(474, 169);
            this.comboBoregisme.Name = "comboBoregisme";
            this.comboBoregisme.Size = new System.Drawing.Size(206, 23);
            this.comboBoregisme.TabIndex = 106;
            // 
            // txtice
            // 
            this.txtice.Location = new System.Drawing.Point(474, 202);
            this.txtice.Multiline = true;
            this.txtice.Name = "txtice";
            this.txtice.Size = new System.Drawing.Size(206, 38);
            this.txtice.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Régime  :";
            // 
            // ltaxepro
            // 
            this.ltaxepro.AutoSize = true;
            this.ltaxepro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ltaxepro.Location = new System.Drawing.Point(354, 125);
            this.ltaxepro.Name = "ltaxepro";
            this.ltaxepro.Size = new System.Drawing.Size(88, 17);
            this.ltaxepro.TabIndex = 103;
            this.ltaxepro.Text = "N°Taxe Pro  :";
            // 
            // lIdentidia
            // 
            this.lIdentidia.AutoSize = true;
            this.lIdentidia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lIdentidia.Location = new System.Drawing.Point(355, 74);
            this.lIdentidia.Name = "lIdentidia";
            this.lIdentidia.Size = new System.Drawing.Size(81, 17);
            this.lIdentidia.TabIndex = 102;
            this.lIdentidia.Text = "Identifiant :";
            // 
            // combforme
            // 
            this.combforme.FormattingEnabled = true;
            this.combforme.Items.AddRange(new object[] {
            "Ainchock"});
            this.combforme.Location = new System.Drawing.Point(474, 44);
            this.combforme.Name = "combforme";
            this.combforme.Size = new System.Drawing.Size(206, 23);
            this.combforme.TabIndex = 101;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ainchock"});
            this.comboBox1.Location = new System.Drawing.Point(127, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 23);
            this.comboBox1.TabIndex = 100;
            // 
            // txtidentifiant
            // 
            this.txtidentifiant.Location = new System.Drawing.Point(475, 73);
            this.txtidentifiant.Multiline = true;
            this.txtidentifiant.Name = "txtidentifiant";
            this.txtidentifiant.Size = new System.Drawing.Size(206, 38);
            this.txtidentifiant.TabIndex = 99;
            // 
            // txttaxepro
            // 
            this.txttaxepro.Location = new System.Drawing.Point(474, 119);
            this.txttaxepro.Multiline = true;
            this.txttaxepro.Name = "txttaxepro";
            this.txttaxepro.Size = new System.Drawing.Size(206, 38);
            this.txttaxepro.TabIndex = 98;
            // 
            // lforme
            // 
            this.lforme.AutoSize = true;
            this.lforme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lforme.Location = new System.Drawing.Point(355, 45);
            this.lforme.Name = "lforme";
            this.lforme.Size = new System.Drawing.Size(115, 17);
            this.lforme.TabIndex = 97;
            this.lforme.Text = "Forme juridique :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(128, 274);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(206, 38);
            this.txtemail.TabIndex = 96;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lemail.Location = new System.Drawing.Point(3, 284);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(54, 17);
            this.lemail.TabIndex = 95;
            this.lemail.Text = "Email  :";
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(128, 224);
            this.txtfax.Multiline = true;
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(206, 38);
            this.txtfax.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = " Fax :";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(128, 168);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(206, 38);
            this.txttel.TabIndex = 92;
            // 
            // ltel
            // 
            this.ltel.AutoSize = true;
            this.ltel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ltel.Location = new System.Drawing.Point(3, 169);
            this.ltel.Name = "ltel";
            this.ltel.Size = new System.Drawing.Size(34, 17);
            this.ltel.TabIndex = 91;
            this.ltel.Text = "Tél :";
            // 
            // lCommune
            // 
            this.lCommune.AutoSize = true;
            this.lCommune.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCommune.Location = new System.Drawing.Point(2, 134);
            this.lCommune.Name = "lCommune";
            this.lCommune.Size = new System.Drawing.Size(79, 17);
            this.lCommune.TabIndex = 90;
            this.lCommune.Text = "Commune :";
            // 
            // txtsiege
            // 
            this.txtsiege.AccessibleName = "";
            this.txtsiege.Location = new System.Drawing.Point(128, 88);
            this.txtsiege.Multiline = true;
            this.txtsiege.Name = "txtsiege";
            this.txtsiege.Size = new System.Drawing.Size(206, 38);
            this.txtsiege.TabIndex = 89;
            // 
            // lsiege
            // 
            this.lsiege.AutoSize = true;
            this.lsiege.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsiege.Location = new System.Drawing.Point(3, 89);
            this.lsiege.Name = "lsiege";
            this.lsiege.Size = new System.Drawing.Size(89, 17);
            this.lsiege.TabIndex = 88;
            this.lsiege.Text = "Siége Social :";
            // 
            // txtraison
            // 
            this.txtraison.Location = new System.Drawing.Point(128, 44);
            this.txtraison.Multiline = true;
            this.txtraison.Name = "txtraison";
            this.txtraison.Size = new System.Drawing.Size(206, 38);
            this.txtraison.TabIndex = 87;
            // 
            // lraison
            // 
            this.lraison.AutoSize = true;
            this.lraison.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lraison.Location = new System.Drawing.Point(3, 45);
            this.lraison.Name = "lraison";
            this.lraison.Size = new System.Drawing.Size(104, 17);
            this.lraison.TabIndex = 86;
            this.lraison.Text = "Raison Sociale :";
            // 
            // suppr
            // 
            this.suppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(186)))), ((int)(((byte)(225)))));
            this.suppr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suppr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppr.Location = new System.Drawing.Point(512, 500);
            this.suppr.Name = "suppr";
            this.suppr.Size = new System.Drawing.Size(168, 55);
            this.suppr.TabIndex = 130;
            this.suppr.Text = "Enregsitrer";
            this.suppr.UseVisualStyleBackColor = false;
            this.suppr.Click += new System.EventHandler(this.suppr_Click);
            // 
            // editsociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.suppr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnregsiter);
            this.Controls.Add(this.Typederegime);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lcapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcapitale);
            this.Controls.Add(this.lactivite);
            this.Controls.Add(this.combomodele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtactivit);
            this.Controls.Add(this.lModele);
            this.Controls.Add(this.txtcnss);
            this.Controls.Add(this.lcnss);
            this.Controls.Add(this.lrc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lice);
            this.Controls.Add(this.comboBoregisme);
            this.Controls.Add(this.txtice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltaxepro);
            this.Controls.Add(this.lIdentidia);
            this.Controls.Add(this.combforme);
            this.Controls.Add(this.comboBox1);
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
            this.Name = "editsociete";
            this.Size = new System.Drawing.Size(697, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btnEnregsiter;
        private Label Typederegime;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox6;
        private Label lcapital;
        private Label label6;
        private TextBox txtcapitale;
        private Label lactivite;
        private ComboBox combomodele;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox txtactivit;
        private Label lModele;
        private TextBox txtcnss;
        private Label lcnss;
        private Label lrc;
        private TextBox textBox1;
        private Label lice;
        private ComboBox comboBoregisme;
        private TextBox txtice;
        private Label label1;
        private Label ltaxepro;
        private Label lIdentidia;
        private ComboBox combforme;
        private ComboBox comboBox1;
        private TextBox txtidentifiant;
        private TextBox txttaxepro;
        private Label lforme;
        private TextBox txtemail;
        private Label lemail;
        private TextBox txtfax;
        private Label label4;
        private TextBox txttel;
        private Label ltel;
        private Label lCommune;
        private TextBox txtsiege;
        private Label lsiege;
        private TextBox txtraison;
        private Label lraison;
        private Button suppr;
    }
}
