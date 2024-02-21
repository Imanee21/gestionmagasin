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
    public partial class FrmBSSuite : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        private string a;

        public FrmBSSuite()
        {

        }

        public FrmBSSuite(string a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void FrmBSSuite_Load(object sender, EventArgs e)
        {
            if (a != null)
            {
                bon_sortie b = db.bon_sortie.FirstOrDefault(f => f.id_bonsortie == Int32.Parse(a));
                detail_BS s = db.detail_BS.FirstOrDefault(r => r.Id_bonsortie == Int32.Parse(a));
                txtcode.Text = b.code_bonsortie;
                txtdatesortie.Text = b.date_sortie.ToString();
                txtobservation.Text = b.observation;
                txtmagasin.EditValue = b.Id_magasin;

                var fo = from a in db.Article1
                         join m in db.Art_Stock on a.Id_Article equals m.Id_Article
                         where m.Id_Article == m.Id_Article
                         select new { Id_Article = a.Id_Article, Intitule = a.Intitule };



                repositoryItemGridLookUpEdit1.DataSource = fo.ToList();
                repositoryItemGridLookUpEdit1.DisplayMember = "Intitule";
                repositoryItemGridLookUpEdit1.ValueMember = "Id_Article";


                load();


            }
            else
            {
                int idcom = db.bon_sortie.Any() ? db.bon_sortie.Max(x => x.id_bonsortie) + 1 : 1;
                txtcode.Text = "BS000" + idcom.ToString();
            }

            mag();



        }
        private void mag()
        {


            var query = from m in db.Magasin1
                        select new { Id_magasin = m.Id_magasin, Intitulé = m.Intitulé };

            txtmagasin.Properties.DataSource = query.ToList();
            txtmagasin.Properties.DisplayMember = "Intitulé";
            txtmagasin.Properties.ValueMember = "Id_magasin";


        }
        private void load()
        {
            List<detail_BS> re = db.detail_BS
                .Where(m => m.Id_bonsortie == Int32.Parse(a))

                .ToList();

            if (re == null)
            {

            }
            else
            {
                detailBSBindingSource1.DataSource = re;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                bon_sortie b = db.bon_sortie.FirstOrDefault(f => f.id_bonsortie == Int32.Parse(a));

                txtcode.Text = b.code_bonsortie;
                txtdatesortie.Text = b.date_sortie.ToString();
                txtobservation.Text = b.observation;
                txtmagasin.EditValue = b.Id_magasin;
                var fo = from a in db.Article1
                         join m in db.Art_Stock on a.Id_Article equals m.Id_Article
                         where m.Id_Article == a.Id_Article
                         select new { Id_Article = a.Id_Article, Intitule = a.Intitule };



                repositoryItemGridLookUpEdit1.DataSource = fo.ToList();
                repositoryItemGridLookUpEdit1.DisplayMember = "Intitule";
                repositoryItemGridLookUpEdit1.ValueMember = "Id_Article";
                db.SubmitChanges();
                detail_BS be = new detail_BS();
                int dd = Int32.Parse(a);
                String Id_Articlee = gvsortie1.GetRowCellValue(gvsortie1.FocusedRowHandle, "Id_Article").ToString();

                Article1 az = db.Article1.FirstOrDefault(art => art.Id_Article == Int32.Parse(Id_Articlee));
                int qte = Convert.ToInt32(gvsortie1.GetRowCellValue(gvsortie1.FocusedRowHandle, "Qte"));
                int pri = Int32.Parse(az.Prix_achat.ToString());
                gvsortie1.SetRowCellValue(gvsortie1.FocusedRowHandle, "Prix", pri);
                int prix_HT = Convert.ToInt32(gvsortie1.GetRowCellValue(gvsortie1.FocusedRowHandle, "Prix"));
                int montant = prix_HT * qte;

                gvsortie1.SetRowCellValue(gvsortie1.FocusedRowHandle, "Montant", montant);
                be.Montant = montant;
                be.Prix = prix_HT;
                be.Qte = qte;
                be.Id_stock = db.Art_Stock.Where(t => t.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault().Id_ligne;
                be.Id_Article = Id_Articlee;
                /*Int32.Parse(Id_Articlee);*/
                be.id_dbs = dd;
                db.detail_BS.InsertOnSubmit(be);
                db.SubmitChanges();

                bool article = db.Art_Stock.Any(mll => mll.Id_Article == Int32.Parse(Id_Articlee));

                Art_Stock rm = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault();
                var lte = db.Art_Stock.Where(mll => mll.Id_Article == Int32.Parse(Id_Articlee)).FirstOrDefault().Qte;
                rm.Qte = lte - Convert.ToInt32(gvsortie1.GetRowCellValue(gvsortie1.FocusedRowHandle, "Qte"));
                String T = rm.Qte.ToString();
                be.Id_bonsortie = Int32.Parse(a);
                if (qte > rm.Qte)
                {
                    MessageBox.Show("erreur dans quantité");
                    Close();
                }
                else
                {
                    db.SubmitChanges();
                }



            }
            else
            {
                bon_sortie b = new bon_sortie();
                b.code_bonsortie = txtcode.Text;
                b.date_sortie = txtdatesortie.DateTime;
                b.observation = txtobservation.Text;


                if (!String.IsNullOrEmpty(txtmagasin.EditValue?.ToString()))
                {
                    string selectedFam = txtmagasin.EditValue.ToString();
                    var selectedId = from x in db.Magasin1
                                     where x.Id_magasin.Equals(selectedFam)
                                     select x.Id_magasin;
                    b.Id_magasin = Int32.Parse(selectedFam);

                }
                a = b.id_bonsortie.ToString();

                db.bon_sortie.InsertOnSubmit(b);
                db.SubmitChanges();
            }
            Close();
        }

        private void gcsorti1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            String ti = gvsortie1.GetFocusedRowCellValue(colid_dbs).ToString();
            String pm = gvsortie1.GetFocusedRowCellValue(colId_Article).ToString();
            String jr = gvsortie1.GetFocusedRowCellValue(colQte).ToString();
            var dlg = MessageBox.Show($"voulez vous supprimer {pm}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                int ifi = Int32.Parse(a);
                int hy = Int32.Parse(ti);
                var detailArticleToDelete = db.detail_BS.FirstOrDefault(da => da.Id_bonsortie == ifi && da.id_dbs == hy);
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
                    }
                    db.detail_BS.DeleteOnSubmit(detailArticleToDelete);

                    db.SubmitChanges();
                }
               
                        Close();

                    
                    load();

                }
            
        }
    }
}
