using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvaDeclarationApp.Controleur_interf;

namespace TvaDeclarationApp
{
    public partial class FormFinal : Form
    {
        public FormFinal()
        {
            InitializeComponent();
        }
         static FormFinal _obj;
        public static FormFinal Instance { get {
                
                if(_obj == null){
                    _obj = new FormFinal();
                }
                return _obj;
            
            } }


        public Panel PnlContainer
        {
            get { return panelcontainer; }
            set { panelcontainer = value; }
        }

        
        
        
        /*public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }*/




        public void AdduserControls(UserControl us)
        {
            us.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(us);
            us.BringToFront();



        }
















        private void btnsociete_Click(object sender, EventArgs e)
        {
            //TvaAppBDEntities2 db = new TvaAppBDEntities2();
            Usociete uc = new Usociete();
            AdduserControls(uc);
            //uc.dataGridView1.DataSource = db.societes.ToList();
        }

        private void btneriode_Click(object sender, EventArgs e)
        {
            Uperiode up = new Uperiode();
            AdduserControls(up);
        }

        private void btnexercice_Click(object sender, EventArgs e)
        {
            Uexercice uee = new Uexercice();
            AdduserControls(uee);
        }
        
        //fournisseurs


        private void button3_Click(object sender, EventArgs e)
        {
            Ufournisseur ude = new Ufournisseur();
            AdduserControls(ude);
        }

        private void btnDéduction_Click(object sender, EventArgs e)
        {
            Udeduction ude = new Udeduction();
            AdduserControls(ude);
        }
        //parametrage
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
