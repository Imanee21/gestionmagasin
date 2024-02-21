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
    public partial class FrmArti : Form
    {
        dbContextDataContext db = new dbContextDataContext();
       

        public FrmArti()
        {
            InitializeComponent();
        }

        private void FrmArti_Load(object sender, EventArgs e)
        {
          
            load();
            Famillef();
        }
      
        
        private void load()
        {
            int nm = 0;
            //var nm=0;
            var data = db.Article1.Select(
              m => new
              {

                  id = m.Id_Article,
                  descri = m.Intitule,
                  qte_stock = m.Qte,
                  m_stock = m.Mode_Stock,
                  p_achat = m.Prix_achat,
                  unite_stock = m.Unite_achat,
                  unite_ventee = m.Unite_vente,
                 // c_article = m.code_article,
                  c_article = db.Famille1.Where(f => f.Id_famille == m.Id_famille).FirstOrDefault().Code_Famille.ToString() + "" + m.Id_Article.ToString(),
                  s_famille = db.Famille1.Where(b => b.Id_famille == m.Id_famille).FirstOrDefault().Intitule
              }).ToList();
            gcArti.DataSource = data;
            
        }

        private void Famillef()
        {


            var query = from m in db.Famille1
                        select new { Id_famille = m.Id_famille, Intitulé = m.Intitule };

            txtFamille.Properties.DataSource = query.ToList();
            txtFamille.Properties.DisplayMember = "Intitulé";
            txtFamille.Properties.ValueMember = "Id_famille";


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtFamille.Text = "";
            textcode.Text = "";
            textDescription.Text = "";
            textPrix.Text = "";
            txtVente.Text = "";
          
            txtAchat.Text = "";
            textStockk.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Article1 a = new Article1();
            
            a.Prix_achat = Int32.Parse(textPrix.Text);
            a.Intitule = textDescription.Text;

            if (!String.IsNullOrEmpty(txtFamille.EditValue?.ToString()))
            {
                string selectedFam = txtFamille.EditValue.ToString();
                var selectedId = from x in db.Famille1
                                 where x.Intitule.Equals(selectedFam)
                                 select x.Id_famille;
                a.Id_famille = Int32.Parse(selectedFam);



            }
            a.Id_famille = Int32.Parse(txtFamille.EditValue.ToString());


            a.Mode_Stock = textStockk.EditValue.ToString();
            a.Unite_achat = txtAchat.EditValue.ToString();
            a.Unite_vente = txtVente.EditValue.ToString();
            db.Article1.InsertOnSubmit(a);
            db.SubmitChanges();
            load();
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var Artid = gvArti.GetFocusedRowCellValue(id).ToString();
            
            int mid;
            if (!Int32.TryParse(Artid, out mid))
            {

                MessageBox.Show("Invalid ID value.");
                return;
            }
            Article1 a= db.Article1.FirstOrDefault(m => m.Id_Article== mid);
            if (a != null)
            {
                
                a.Prix_achat = Int32.Parse(textPrix.Text);
                a.Intitule = textDescription.Text;
                if (!String.IsNullOrEmpty(txtFamille.EditValue?.ToString()))
                {
                    string selectedFam = txtFamille.EditValue.ToString();
                    var selectedId = from x in db.Famille1
                                     where x.Intitule.Equals(selectedFam)
                                     select x.Id_famille;
                    a.Id_famille = Int32.Parse(selectedFam);



                }
                a.Id_famille = Int32.Parse(txtFamille.EditValue.ToString());



                a.Mode_Stock = textStockk.EditValue.ToString();
                a.Unite_achat = txtAchat.EditValue.ToString();
                a.Unite_vente = txtVente.EditValue.ToString();

            }
            db.SubmitChanges();
                load();


            
         }

            private void simpleButton4_Click(object sender, EventArgs e)
        {
            var Artid = gvArti.GetFocusedRowCellValue(id).ToString();
            var resint = gvArti.GetFocusedRowCellValue(descri);
           

            Article1 R = db.Article1.FirstOrDefault(m => m.Id_Article == Int32.Parse(Artid));

            var d = MessageBox.Show($"voulez vous supprimer {resint}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var rowsToDelete = from r in db.detail_BC2
                               where r.Id_Article == Int32.Parse(Artid)
                               select r;
            if (d == DialogResult.Yes)
            {

                gvArti.DeleteRow(gvArti.FocusedRowHandle);
                db.detail_BC2.DeleteAllOnSubmit(rowsToDelete);


                db.Article1.DeleteOnSubmit(R);


                db.SubmitChanges();
                load();

            }
        }

        private void gvArti_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

     


            if (gvArti.GetFocusedRowCellValue(descri) != null)
            {
                textDescription.Text = gvArti.GetFocusedRowCellValue(descri).ToString();
            }
            else
            {
                textDescription.Text = "";
            }

                //textDescription.Text = gvArti.GetFocusedRowCellValue(descri).ToString();

            if (gvArti.GetFocusedRowCellValue(p_achat) != null)
            {
                textPrix.Text = gvArti.GetFocusedRowCellValue(p_achat).ToString();
            }
            else
            {
                textPrix.Text = "";
            }



            //textPrix.Text = gvArti.GetFocusedRowCellValue(p_achat).ToString();

            if (gvArti.GetFocusedRowCellValue(m_stock) != null)
            {
                textStockk.Text = gvArti.GetFocusedRowCellValue(m_stock).ToString();
            }
            else
            {
                textStockk.Text = "";
            }


            //textStockk.Text = gvArti.GetFocusedRowCellValue(m_stock).ToString();

            if (gvArti.GetFocusedRowCellValue(unite_stock) != null)
            {
                txtAchat.Text = gvArti.GetFocusedRowCellValue(unite_stock).ToString();
            }
            else
            {
                txtAchat.Text = "";
            }

            //txtAchat.Text = gvArti.GetFocusedRowCellValue(unite_stock).ToString();


            if (gvArti.GetFocusedRowCellValue(unite_ventee) != null)
            {
                txtVente.Text = gvArti.GetFocusedRowCellValue(unite_ventee).ToString();
            }
            else
            {
                txtVente.Text = "";
            }
            //txtVente.Text = gvArti.GetFocusedRowCellValue(unite_ventee).ToString();


            if (gvArti.GetFocusedRowCellValue(c_article) != null)
            {
                textcode.Text = gvArti.GetFocusedRowCellValue(c_article).ToString();
            }
            else
            {
                textcode.Text = "";
            }

            //if (gvArti.GetFocusedRowCellValue(s_famille) != null)
            //{
            //    txtFamille.Text = gvArti.GetFocusedRowCellValue(s_famille).ToString();
            //}
            //else
            //{
            //    txtFamille.Text = "";
            //}

        }

        private void txtFamille_EditValueChanged(object sender, EventArgs e)
        {
            
            
            if (txtFamille != null)
            {
                string id = txtFamille.EditValue.ToString();
                Famille1 f = db.Famille1.Where(y => y.Id_famille == Convert.ToInt32(id)).FirstOrDefault();
                int idarticle = db.Article1.Any() ? db.Article1.Max(x => x.Id_Article) + 1 : 1;
                string codearticle = f.Code_Famille + idarticle.ToString();
                textcode.Text = codearticle;


            }
            else
            {

            }
        }
    }
}
