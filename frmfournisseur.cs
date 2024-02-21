using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasins
{
    public partial class Fournisseurrr : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public Fournisseurrr()
        {
            InitializeComponent();
        }

        private void frmfournisseur_Load(object sender, EventArgs e)
        {
            gcFournisseur.DataSource = from m in db.Fournisseur
                                       select new
                                       {
                                           id = m.Id_four,
                                           nom_fournisseur = m.Nom_four,
                                           prenom_fournisseur = m.Prenom_four,
                                           cin = m.Cin,
                                           tel = m.Tel,
                                           email = m.Email,
                                           delai_livraison = m.Delai_livraison,
                                           n_forenisseur = m.N_Fournisseur,
                                           adresse = m.Adresse,

                                           pays = m.Pays,
                                           ville = m.Ville,





                                       };
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string A = null; // an argument to instantiate an object of the "frmresp" class
                frmFournisseur1 F1 = new frmFournisseur1(A);
                F1.Show();
            }
            catch (Exception)
            {
                string errorMessage = "Verifier la connection" ;

                // Display the error message or handle it as per your application's requirements
                Console.WriteLine(errorMessage);
                // or
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // or any other desired way to handle the error
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var a = gvFournisseur.GetFocusedRowCellValue(id).ToString();// un argument pour instancier un objet de la classe "frmresp"
            frmFournisseur1 F1 = new frmFournisseur1(a);
            F1.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var fourid = gvFournisseur.GetFocusedRowCellValue(id).ToString();
            var nom = gvFournisseur.GetFocusedRowCellValue(nom_fournisseur);

            Fournisseur R = db.Fournisseur.FirstOrDefault(m => m.Id_four == Int32.Parse(fourid));

            var det = from n in db.detail_BC2
                      where n.Id_four == Int32.Parse(fourid)

                      select n;
            var cpm = from n in db.bon_commande
                      where n.Id_four == Int32.Parse(fourid)

                      select n;
            var d = MessageBox.Show($"voulez vous supprimer {nom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (d == DialogResult.Yes)
            //{

            //        gvFournisseur.DeleteRow(gvFournisseur.FocusedRowHandle);

            //        db.detail_BC2.DeleteAllOnSubmit(det);

            //        db.Fournisseur.DeleteOnSubmit(R);
            //        db.SubmitChanges();




            //}
            bon_commande t = new bon_commande();
            if (d == DialogResult.Yes)
            {

                gvFournisseur.DeleteRow(gvFournisseur.FocusedRowHandle);

                db.detail_BC2.DeleteAllOnSubmit(det);
                if(R.Id_four == t.Id_four)
                {
                    MessageBox.Show("Impossible de supprimer");
                }
                else
                {
                    db.Fournisseur.DeleteOnSubmit(R);
                    db.SubmitChanges();
                }
               




            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            gcFournisseur.DataSource = from m in db.Fournisseur
                                       select new
                                       {
                                           id = m.Id_four,
                                           nom_fournisseur = m.Nom_four,
                                           prenom_fournisseur = m.Prenom_four,
                                           cin = m.Cin,
                                           tel = m.Tel,
                                           email = m.Email,
                                           delai_livraison = m.Delai_livraison,
                                           n_forenisseur = m.N_Fournisseur,
                                           adresse = m.Adresse,

                                           pays = m.Pays,
                                           ville = m.Ville,




                                       };
        }

        private void gcFournisseur_Click(object sender, EventArgs e)
        {

        }
    }
}
