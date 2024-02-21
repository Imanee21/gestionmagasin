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
    public partial class FrmBoncommande : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public FrmBoncommande()
        {
            InitializeComponent();
        }
       

        private void FrmBoncommande_Load(object sender, EventArgs e)
        {
            bon_livraison nn = new bon_livraison();
            bon_commande nb = new bon_commande();
           
            var data = db.bon_commande.Select(m => new
            {
                id = m.id_commande,
                num_commande = m.numero_commande,
                date_bc = m.date_bc,
                date_echeance = m.date_echeance,
                date_livraison = m.date_livraison,
                mode_reglement = m.mode_reglement,
                observation = m.observation,
                reference = m.reference,

                fournisseur = db.Fournisseur.Where(b => b.Id_four == m.Id_four).FirstOrDefault().Nom_four,

                dbl = db.BLSuite.Where(a => a.id_livraison == db.bon_livraison.Where(r => r.id_commande == m.id_commande).FirstOrDefault().id_livraison).FirstOrDefault().Qte_livrée,

                dbc = db.detail_BC2.Where(c => c.Id_commande == m.id_commande).FirstOrDefault().Qte,
                etat_livraison = CalculerEtatLivraison(db.BLSuite.Where(a => a.id_livraison == db.bon_livraison.Where(r => r.id_commande == m.id_commande).FirstOrDefault().id_livraison).Sum(bf => bf.Qte_livrée), db.detail_BC2.Where(te => te.Id_commande == m.id_commande).Sum(te => te.Qte))



            }).ToList();
       

            gcBC.DataSource = data;
          

           

        }

        private string CalculerEtatLivraison(int? qte_livrée, int? qte)
        {
            bon_commande nb = new bon_commande();
            String b = null;
           
                if (qte_livrée == qte && qte_livrée != null)
                {
                    b = "livrer";
                }
                else if (qte_livrée == null)
                {
                    b = "non livre";
                }
                else
                {
                    b = "partiellement livrer";
                }
            nb.etat_livraison = b;
            return b;
            
            
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
                string A = null; // un argument pour instancier un objet de la classe "frmresp"
                FrmBcsuite F1 = new FrmBcsuite(A);
                F1.Show();
           
           



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            var ete = gvBC.GetFocusedRowCellValue(etat_livraison);
            string ret = ete.ToString();
            if (ret == "livrer")
            {
                MessageBox.Show("Cette commande a ete livrée");
            }


            else {
                var a = gvBC.GetFocusedRowCellValue(id).ToString();
                FrmBcsuite F1 = new FrmBcsuite(a);
                F1.Show();

               
            }
            var d = gvBC.GetFocusedRowCellValue(id).ToString();
            string h = d.ToString();
            bon_commande b = db.bon_commande.FirstOrDefault(pi => pi.id_commande == Int32.Parse(h));
            b.etat_livraison = ret.ToString();
            db.SubmitChanges();

        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var persid = gvBC.GetFocusedRowCellValue(id).ToString();
            var nom = gvBC.GetFocusedRowCellValue(reference);
            var ete = gvBC.GetFocusedRowCellValue(etat_livraison);
            string ret = ete.ToString();
            if (ret == "livrer" || ret == "partiellement livrer")
            {
                
                MessageBox.Show("Cette commande a ete livrée");
            }
           
            else
            {

                var rowsToDelete = from r in db.detail_BC2
                                   where r.Id_commande == Int32.Parse(persid)
                                   select r;
                var rowsToDelete1 = from r in db.bon_livraison
                                    where r.id_commande == Int32.Parse(persid)
                                    select r;
                var row = from t in db.bon_retour
                          where t.Id_livraison == db.bon_livraison.Where(r => r.id_commande == Int32.Parse(persid)).FirstOrDefault().id_livraison
                          select t;
                var HY = from r in db.totalprix
                         where r.Id_commande == Int32.Parse(persid)
                         select r;
                bon_commande R = db.bon_commande.FirstOrDefault(m => m.id_commande == Int32.Parse(persid));
                Table_1 j = db.Table_1.FirstOrDefault(n=>n.Id_commande == Int32.Parse(persid));
                detail_BC2 bl = db.detail_BC2.FirstOrDefault(t => t.Id_commande == Int32.Parse(persid));

                var d = MessageBox.Show($"voulez vous supprimer {nom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                 
                        gvBC.DeleteRow(gvBC.FocusedRowHandle);
                        db.bon_retour.DeleteAllOnSubmit(row);
                        db.detail_BC2.DeleteAllOnSubmit(rowsToDelete);
                        db.bon_livraison.DeleteAllOnSubmit(rowsToDelete1);
                        db.totalprix.DeleteAllOnSubmit(HY);
                        db.bon_commande.DeleteOnSubmit(R);
                        db.Table_1.DeleteOnSubmit(j);
                        db.SubmitChanges();
                    
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var data = db.bon_commande.Select(m => new
            {
                id = m.id_commande,
                num_commande = m.numero_commande,
                date_bc = m.date_bc,
                date_echeance = m.date_echeance,
                date_livraison = m.date_livraison,
                mode_reglement = m.mode_reglement,
                observation = m.observation,
                reference = m.reference,

                fournisseur = db.Fournisseur.Where(b => b.Id_four == m.Id_four).FirstOrDefault().Nom_four,

                dbl = db.BLSuite.Where(ja => ja.id_livraison == db.bon_livraison.Where(r => r.id_commande == m.id_commande).FirstOrDefault().id_livraison).FirstOrDefault().Qte_livrée,

                dbc = db.detail_BC2.Where(c => c.Id_commande == m.id_commande).FirstOrDefault().Qte,
                etat_livraison = CalculerEtatLivraison(db.BLSuite.Where(ra => ra.id_livraison == db.bon_livraison.Where(r => r.id_commande == m.id_commande).FirstOrDefault().id_livraison).Sum(bf => bf.Qte_livrée), db.detail_BC2.Where(te => te.Id_commande == m.id_commande).Sum(te => te.Qte)),


            }).ToList();
            gcBC.DataSource = data;


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            bon_commande m = new bon_commande();
            string ee = null;

            ee = db.BLSuite.Where(a => a.id_livraison == db.bon_livraison.Where(r => r.id_commande ==9).FirstOrDefault().id_livraison).Sum(bf => bf.Qte_livrée).ToString();
            MessageBox.Show("ee = " + ee + ", confirmation");

        }
    }
}
