using DevExpress.XtraEditors;
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
    public partial class Frmbon_retour : XtraForm
    {
        dbContextDataContext db = new dbContextDataContext();
        public Frmbon_retour()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string A = null; // un argument pour instancier un objet de la classe "frmresp"
            FrmSuitebonretour F1 = new FrmSuitebonretour(A);
            F1.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var a = gvretour.GetFocusedRowCellValue(id).ToString();
            FrmSuitebonretour F1 = new FrmSuitebonretour(a);
            F1.Show();
        }

        private void Frmbon_retour_Load(object sender, EventArgs e)
        {
            var data = db.bon_retour.Select(
                m => new
                {
                    id = m.Id_bonretour,
                    code_retour = m.n_bonretour,
                    date_retour = m.date_retour,
                    observation = m.observation,
                    Nom_four = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Nom_four,
                    CIN = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Cin,
                    Ref_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().N_Fournisseur,




                });






            gcretour.DataSource = data;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var data = db.bon_retour.Select(
               m => new
               {
                   id = m.Id_bonretour,
                   code_retour = m.n_bonretour,
                   date_retour = m.date_retour,
                   observation = m.observation,
                   Nom_four = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Nom_four,
                   CIN = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Cin,
                   Ref_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == m.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().N_Fournisseur,



               });
            gcretour.DataSource = data;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var persid = gvretour.GetFocusedRowCellValue(id).ToString();
            var nom = gvretour.GetFocusedRowCellValue(Code_retour);
            bon_retour R = db.bon_retour.FirstOrDefault(m => m.Id_bonretour == Int32.Parse(persid));
            var d = MessageBox.Show($"voulez vous supprimer {nom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            BCsuite s = db.BCsuite.FirstOrDefault(l => l.id_bonretour == Int32.Parse(persid));
            var HY = from r in db.BCsuite
                     where r.id_bonretour == Int32.Parse(persid)
                     select r;
            if (d == DialogResult.Yes)
            {
                if (s != null && s.id_bonretour != 0)
                {
                    MessageBox.Show("supprimer premierement les articles");
                }
                else
                {
                    gvretour.DeleteRow(gvretour.FocusedRowHandle);
                    db.BCsuite.DeleteAllOnSubmit(HY);

                    db.bon_retour.DeleteOnSubmit(R);
                    db.SubmitChanges();
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var a = gvretour.GetFocusedRowCellValue(id).ToString();
            bon_retour obj = db.bon_retour.FirstOrDefault(g => g.Id_bonretour == Int32.Parse(a));
            BCsuite h = db.BCsuite.FirstOrDefault(i => i.id_bonretour == Int32.Parse(a));



            List<BCsuite> list = db.BCsuite.Where(o => o.id_bonretour == Int32.Parse(a)).ToList();


            if (   obj.Id_bonretour== list.FirstOrDefault()?.id_bonretour)
            {
                using (XtraForm1 frm = new XtraForm1())
                {
                    frm.printInvo(obj, list);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("erreur");
            }
        }

    
    }
}
