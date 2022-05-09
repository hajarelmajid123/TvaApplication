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


namespace TvaDeclarationApp.Controleur_interf
{
    public partial class Usociete : UserControl
    {
        public Usociete()
        {
            InitializeComponent();
        }

        private void Usociete_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregsiter_Click(object sender, EventArgs e)
        {
           /* TvaAppBDEntities db = new TvaAppBDEntities();

            societe sc = new societe();
            {
                sc.SiegeSoc = txtsiege.Text;

                sc.Tel = txttel.Text;
                sc.Fax = txtfax.Text;
                sc.FormeJuridique = combforme.SelectedItem.ToString();
                sc.IdFiscal = Int32.Parse(txtidentifiant.Text);
                sc.NumTaxPro = Int32.Parse(txttaxepro.Text);
                sc.Regime = comboBoregisme.SelectedItem.ToString();
                sc.Ice = Int32.Parse(txtice.Text);
                sc.RegistreCommerce = Int32.Parse(texrc.Text);
                sc.NumCnss = Int32.Parse(txtcnss.Text);
                sc.ModComptable = combomodele.SelectedItem.ToString();
                sc.LoginDGI = textlog.Text;
                sc.MdpDgi = txtmdp.Text;
                sc.Capital = decimal.Parse(txtcapitale.Text);
                sc.Activite = txtactivit.Text;
                sc.TypeRegime = txtraison.Text;
                sc.commune = combocomm.SelectedItem.ToString();
            };
            db.societes.AddObject(sc);

            db.SaveChanges();*/

            MessageBox.Show("ajout effectué avec sucée.");


        }
    }
}
