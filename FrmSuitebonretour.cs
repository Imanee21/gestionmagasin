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
    public partial class FrmSuitebonretour : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        private string a;
        public FrmSuitebonretour(string a)
        {
            InitializeComponent();
            this.a = a;
        }




        private void FrmSuitebonretour_Load(object sender, EventArgs e)
        {
            if (a != null)
            {
                bon_retour b = db.bon_retour.FirstOrDefault(f => f.Id_bonretour == Int32.Parse(a));

                txtcoder.Text = b.n_bonretour;
                txtdatere.Text = b.date_retour.ToString();
                txtobse.Text = b.observation;
                txtbonl.EditValue = b.Id_livraison;

                if (int.TryParse(txtbonl.EditValue.ToString(), out int selectedCommandeId))
                {
                    var fo = from a in db.Article1
                             join m in db.BLSuite on a.Id_Article equals m.Intitulee
                             where m.id_livraison == selectedCommandeId
                             select new { Id_Article = a.Id_Article, Intitule = a.Intitule };



                    repositoryItemGridLookUpEdit1.DataSource = fo.ToList();
                    txtbonl.Properties.DisplayMember = "Intitule" ;
                    txtbonl.Properties.ValueMember = "Id_Article";
                }
                load();

            }
            else
            {
                int idcom = db.bon_retour.Any() ? db.bon_retour.Max(x => x.Id_bonretour) + 1 : 1;
                txtcoder.Text = "BR000" + idcom.ToString();
            }
            commandee();
           
        }
        private void commandee()
        {


            var query = from m in db.bon_livraison
                        select new { id_livraison = m.id_livraison, Intitulé = m.code_livraison };

            txtbonl.Properties.DataSource = query.ToList();
            txtbonl.Properties.DisplayMember = "Intitulé";
            txtbonl.Properties.ValueMember = "id_livraison";


        }
        private void load()
        {
            List<BCsuite> re = db.BCsuite
                .Where(m => m.id_bonretour == Int32.Parse(a))
                .ToList();

            if (re.Count == 0)
            {
                
            }
            else
            {
                bCsuiteBindingSource.DataSource = re;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (a != null)
            {

                bon_retour b = db.bon_retour.FirstOrDefault(f => f.Id_bonretour == Int32.Parse(a));
                b.n_bonretour = txtcoder.Text;
                b.date_retour = txtdatere.DateTime;
                b.observation = txtobse.Text;
                b.Nom_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == b.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Nom_four;
                b.CIN = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == b.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Cin;
                b.Ref_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == b.Id_livraison).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().N_Fournisseur;

                if (!String.IsNullOrEmpty(txtobse.EditValue?.ToString()))
                {
                    string selectedFam = txtbonl.EditValue.ToString();
                    var selectedId = from x in db.bon_livraison
                                     where x.code_livraison.Equals(selectedFam)
                                     select x.id_livraison;
                    b.Id_livraison = Int32.Parse(selectedFam);

                }

                db.SubmitChanges();
                BCsuite be = new BCsuite();
                BLSuite rre = new BLSuite();
                int dd = Int32.Parse(a);
                String Id_Articlee = gvbr.GetRowCellValue(gvbr.FocusedRowHandle, "Intitule").ToString();
                BLSuite h = db.BLSuite.Where(s => s.id_livraison == db.bon_retour.Where(p => p.Id_bonretour == Int32.Parse(a)).FirstOrDefault().Id_livraison).FirstOrDefault();

                bool articleExiste = db.BCsuite.Any(dc => dc.Intitule == Int32.Parse(Id_Articlee) && dc.id_bonretour == dd);
                String bo = h.Qte_livrée.ToString();
                int tt = Int32.Parse(bo);
                
                if (!articleExiste)
                {
                    Article1 az = db.Article1.FirstOrDefault(art => art.Id_Article ==Int32.Parse(Id_Articlee));
                    int qte = Convert.ToInt32(gvbr.GetRowCellValue(gvbr.FocusedRowHandle, "qte"));
                    
                    int pri = Int32.Parse(az.Prix_achat.ToString());
                    gvbr.SetRowCellValue(gvbr.FocusedRowHandle, "prix", pri);
                    int prix_HT = Convert.ToInt32(gvbr.GetRowCellValue(gvbr.FocusedRowHandle, "prix"));
                    int montant = prix_HT * qte;

                    gvbr.SetRowCellValue(gvbr.FocusedRowHandle, "Montant", montant);
                    be.Montant = montant;
                    be.prix = prix_HT;
                    be.qte = qte;
                    be.Intitule = Int32.Parse(Id_Articlee);
                    be.id_dbr = dd;
                    if(qte > tt)
                    {
                        var fs = MessageBox.Show("quantite d'article livrer est superieur à quantité livré ");
                        if (fs == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        db.BCsuite.InsertOnSubmit(be);
                        db.SubmitChanges();
                        bool article = db.Art_Stock.Any(mll => mll.Id_Article == Int32.Parse(Id_Articlee));

                        Art_Stock rm = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault();
                        var lte = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault().Qte;
                        rm.Qte = lte - Convert.ToInt32(gvbr.GetRowCellValue(gvbr.FocusedRowHandle, "qte"));
                        String T = rm.Qte.ToString();
                        be.id_bonretour = Int32.Parse(a);

                        db.SubmitChanges();
                    }
                    
                }


                }
            else
            {
                bon_retour b = new bon_retour();
                b.n_bonretour = txtcoder.Text;
                b.date_retour = txtdatere.DateTime;
                b.observation = txtobse.Text;
               

                if (!String.IsNullOrEmpty(txtobse.EditValue?.ToString()))
                {
                    string selectedFam = txtbonl.EditValue.ToString();
                    var selectedId = from x in db.bon_livraison
                                     where x.code_livraison.Equals(selectedFam)
                                     select x.id_livraison;
                    b.Id_livraison = Int32.Parse(selectedFam);
                    b.Nom_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == Int32.Parse(selectedFam)).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Nom_four;
                    b.CIN = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == Int32.Parse(selectedFam)).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().Cin;
                    b.Ref_fournisseur = db.Fournisseur.Where(t => t.Id_four == db.bon_commande.Where(r => r.id_commande == db.bon_livraison.Where(y => y.id_livraison == Int32.Parse(selectedFam)).FirstOrDefault().id_commande).FirstOrDefault().Id_four).FirstOrDefault().N_Fournisseur;

                }
                a = b.Id_bonretour.ToString();
                
                db.bon_retour.InsertOnSubmit(b);
                db.SubmitChanges();
                Close();
            }
           
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            String ti = gvbr.GetFocusedRowCellValue(colid_dbr).ToString();
            String pm = gvbr.GetFocusedRowCellValue(colIntitule).ToString();
            String jr = gvbr.GetFocusedRowCellValue(colqte).ToString();
            var dlg = MessageBox.Show($"voulez vous supprimer {ti}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                int ifi = Int32.Parse(a);
                int hy = Int32.Parse(ti);
                var detailArticleToDelete = db.BCsuite.FirstOrDefault(da => da.id_bonretour == ifi && da.id_dbr == hy);
                if (detailArticleToDelete != null)
                {
                    Art_Stock dd = db.Art_Stock.FirstOrDefault(f => f.Id_Article == Int32.Parse(pm));
                    if (dd != null)
                    {
                        if (dd.Qte == Int32.Parse(jr))
                        {
                            db.Art_Stock.DeleteAllOnSubmit<Art_Stock>(new List<Art_Stock> { dd });
                        }
                        else
                        {
                            dd.Qte = dd.Qte + Int32.Parse(jr);
                        }
                        db.BCsuite.DeleteOnSubmit(detailArticleToDelete);

                        db.SubmitChanges();
                        Close();

                    }
                    load();


                }
                else
                {

                }

            }
        }
    }
}

