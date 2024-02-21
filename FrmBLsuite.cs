using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestionMagasins
{
    public partial class FrmBLsuite : Form
    {

        dbContextDataContext db = new dbContextDataContext();
        private string a;



        public FrmBLsuite(string a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void FrmBLsuite_Load(object sender, EventArgs e)
        {
            BLSuite rr = new BLSuite();
            if (a != null)
            {


                bon_livraison b = db.bon_livraison.FirstOrDefault(f => f.id_livraison == Int32.Parse(a));
                txtcommande.EditValue = b.id_commande.ToString();
                txtdate.Text = b.date_livraison.ToString();

                txtnuml.Text = b.code_livraison;
                txtobservation.Text = b.observation;
                
                
                if (int.TryParse(txtcommande.EditValue.ToString(), out int selectedCommandeId))
                {
                    var fo = from a in db.Article1
                             join m in db.detail_BC2 on a.Id_Article equals m.Id_Article
                             where m.Id_commande == selectedCommandeId
                             //select new { Id_Article = a.Id_Article, Intitulé = a.Intitule };
                             select new { Id_Article = a.Id_Article, Intitule = a.Intitule };




                    repositoryItemGridLookUpEdit1.DataSource = fo.ToList();


                    txtcommande.Properties.DisplayMember = "Intitule";
                    txtcommande.Properties.ValueMember = "Id_Article";
                }
                load();



            }
            else
            {
                int idcom = db.bon_livraison.Any() ? db.bon_livraison.Max(x => x.id_livraison) + 1 : 1;
                txtnuml.Text = "BL000" + idcom.ToString();
            }
            commandee();
           




            repositoryItemmag.DataSource = db.Magasin1;

        }
        private void commandee()
        {


            var query = from m in db.bon_commande
                        where m.etat_livraison != "livrer"
                        select new { Id_commande = m.id_commande, Intitulé = m.numero_commande };

            txtcommande.Properties.DataSource = query.ToList();
            txtcommande.Properties.DisplayMember = "Intitulé";
            txtcommande.Properties.ValueMember = "Id_commande";


        }



     
        private void load()
        {
            List<BLSuite> re = db.BLSuite
                .Where(m => m.id_livraison == Int32.Parse(a))
                .ToList();

            if (re == null)
            {
                
            }
            else
            {
                bLSuiteBindingSource.DataSource = re;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                bon_livraison b = db.bon_livraison.FirstOrDefault(m => m.id_livraison == Int32.Parse(a));
                b.code_livraison = txtnuml.Text;


                b.observation = txtobservation.Text;
                b.date_livraison = txtdate.DateTime;
                if (!String.IsNullOrEmpty(txtcommande.EditValue?.ToString()))
                {
                    string selectedFam = txtcommande.EditValue.ToString();
                    var selectedId = from x in db.bon_commande
                                     where x.numero_commande.Equals(selectedFam)
                                     select x.id_commande;
                    b.id_commande = Int32.Parse(selectedFam);

                }


                db.SubmitChanges();
                BLSuite rr = new BLSuite();
                detail_BC2 tt = new detail_BC2();
               
                int bd = Int32.Parse(a);
                String Id_Articlee = gvBlsuite.GetRowCellValue(gvBlsuite.FocusedRowHandle, "Intitulee").ToString();

                Article1 az = db.Article1.FirstOrDefault(art => art.Id_Article == Int32.Parse(Id_Articlee));
                detail_BC2 h = db.detail_BC2.Where(s => s.Id_commande == db.bon_livraison.Where(p => p.id_livraison == Int32.Parse(a) ).FirstOrDefault().id_commande).FirstOrDefault();
                    int pri = Int32.Parse(az.Prix_achat.ToString());
                    gvBlsuite.SetRowCellValue(gvBlsuite.FocusedRowHandle, "Prix", pri);
                   
                    var bo = h.Qte;
                    string lp = bo.ToString();
                
                    int qte = Convert.ToInt32(gvBlsuite.GetRowCellValue(gvBlsuite.FocusedRowHandle, "Qte_livrée"));
                if(tt.Qte < qte)
                {
                    MessageBox.Show("erreur");
                }
                    int prix_HT = Convert.ToInt32(gvBlsuite.GetRowCellValue(gvBlsuite.FocusedRowHandle, "Prix"));
                    int montant = prix_HT * qte;

                    gvBlsuite.SetRowCellValue(gvBlsuite.FocusedRowHandle, "Montant", montant);
                    rr.Prix = prix_HT.ToString();
                    rr.Montant = montant.ToString();
                    rr.Qte_livrée = qte;
                    rr.Intitulee = Int32.Parse(Id_Articlee);
                    rr.id_livraison = bd;
                    if (qte > Int32.Parse(lp))
                    {
                       var fs =  MessageBox.Show("quantite d'article livrer est superieur à quantité commandé ");
                        if(fs == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else { 
                    db.BLSuite.InsertOnSubmit(rr);
                    db.SubmitChanges();

                    bool article = db.Art_Stock.Any(mll => mll.Id_Article == Int32.Parse(Id_Articlee));
                    if (!article)
                    {
                        Art_Stock rl = new Art_Stock();
                        rl.Id_Article = Int32.Parse(Id_Articlee);
                        rl.Qte = qte;
                        String ts = db.Article1.Where(mll => mll.Id_Article == rl.Id_Article).FirstOrDefault().Mode_Stock;
                        var pr = db.Article1.Where(mll => mll.Id_Article == rl.Id_Article).FirstOrDefault().Prix_achat;
                        rl.Mode_Stock = ts;
                        rl.Prix_achat = pr;
                        db.Art_Stock.InsertOnSubmit(rl);
                        db.SubmitChanges();
                        

                    }
                    else
                    {

                        Art_Stock rm = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault();
                            var lte = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault().Qte;
                            rm.Qte = Convert.ToInt32(gvBlsuite.GetRowCellValue(gvBlsuite.FocusedRowHandle, "Qte_livrée"));
                          rm.Qte = Convert.ToInt32(gvBlsuite.GetRowCellValue(gvBlsuite.FocusedRowHandle, "Qte_livrée"))+ lte;
                           String T = rm.Qte.ToString();

                            db.SubmitChanges();
                  

                    }
                    }



                //}
                //else
                //{
                    
                //}
            }
            else
            {
                bon_livraison br = new bon_livraison();

                br.code_livraison = txtnuml.Text;
                br.date_livraison = txtdate.DateTime;

                String mrl = txtobservation.Text;
                br.observation = txtobservation.Text;
                if (!String.IsNullOrEmpty(txtcommande.EditValue?.ToString()))
                {
                    string selectedFam = txtcommande.EditValue.ToString();
                    var selectedId = from x in db.bon_commande
                                     where x.numero_commande.Equals(selectedFam)
                                     select x.id_commande;
                    br.id_commande = Int32.Parse(selectedFam);
                }
                a = br.id_livraison.ToString();
                db.bon_livraison.InsertOnSubmit(br);
                db.SubmitChanges();




                Close();
            }

        }


        private void repositoryItemButtonEdit1_Click_1(object sender, EventArgs e)
        {
            String ti = gvBlsuite.GetFocusedRowCellValue(colidbl).ToString();
            String pm = gvBlsuite.GetFocusedRowCellValue(colIntitulee).ToString();
            String jr = gvBlsuite.GetFocusedRowCellValue(colQte_livrée).ToString();


            var dlg = MessageBox.Show($"voulez vous supprimer {ti}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                int ifi = Int32.Parse(a);
                int hy = Int32.Parse(ti);

                var detailArticleToDelete = db.BLSuite.FirstOrDefault(da => da.id_livraison == ifi && da.idbl == hy);
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
                            dd.Qte = dd.Qte - Int32.Parse(jr);
                        }
                        //var rowsToDelete = from r in db.Art_Stock
                        //                   where r.Id_Article == Int32.Parse(pm)
                        //                   select r;
                        //db.Art_Stock.DeleteAllOnSubmit(rowsToDelete);
                        db.BLSuite.DeleteOnSubmit(detailArticleToDelete);

                        db.SubmitChanges();



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
