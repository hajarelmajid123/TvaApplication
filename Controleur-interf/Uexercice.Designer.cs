using System.Windows.Forms;
namespace TvaDeclarationApp.Controleur_interf
{
    partial class Uexercice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uexercice));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cherche = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.lsoc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 49);
            this.textBox1.TabIndex = 14;
            // 
            // cherche
            // 
            this.cherche.BackColor = System.Drawing.Color.White;
            //this.cherche.BackgroundImage = global::TvaDeclarationApp.Properties.Resources.search;
            this.cherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cherche.Location = new System.Drawing.Point(628, 68);
            this.cherche.Name = "cherche";
            this.cherche.Size = new System.Drawing.Size(49, 49);
            this.cherche.TabIndex = 13;
            this.cherche.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(18, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 81);
            this.add.TabIndex = 12;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // lsoc
            // 
            this.lsoc.AutoSize = true;
            this.lsoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsoc.Location = new System.Drawing.Point(18, 96);
            this.lsoc.Name = "lsoc";
            this.lsoc.Size = new System.Drawing.Size(80, 21);
            this.lsoc.TabIndex = 11;
            this.lsoc.Text = "Exercices";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(674, 434);
            this.dataGridView1.TabIndex = 10;
            // 
            // Uexercice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cherche);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lsoc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Uexercice";
            this.Size = new System.Drawing.Size(687, 559);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button cherche;
        private Button add;
        private Label lsoc;
        private DataGridView dataGridView1;
    }
}
