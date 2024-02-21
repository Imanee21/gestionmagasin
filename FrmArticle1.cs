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
    public partial class FrmArticle1 : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public FrmArticle1()
        {
            InitializeComponent();
        }

        private void FrmArticle1_Load(object sender, EventArgs e)
        {
            var data = db.Article1.Select(
              m => new
              {
                  id = m.Id_Article,
                  article = m.Intitule,
                  famille = db.Famille1.Where(a => a.Id_famille == m.Id_famille).FirstOrDefault().Intitule
              }).ToList();
            gcArticle.DataSource = data;
            mag_resp();

        }
        private void mag_resp()
        {


            var query = from m in db.Famille1
                        select new { Id_famille = m.Id_famille, Intitulé = m.Intitule };

            comboBoxEdit1.Properties.DataSource = query.ToList();
            comboBoxEdit1.Properties.DisplayMember = "Intitulé";
            comboBoxEdit1.Properties.ValueMember = "Id_famille";


        }
        private void load()
        {
            var data = db.Article1.Select(
             m => new
             {
                 id = m.Id_Article,
                 article = m.Intitule,
                 famille = db.Famille1.Where(a => a.Id_famille == m.Id_famille).FirstOrDefault().Intitule
             }).ToList();
            gcArticle.DataSource = data;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Article1 a = new Article1();
            a.Intitule = txtIntitule.Text;

            if (!string.IsNullOrEmpty(comboBoxEdit1.EditValue?.ToString()))
            {

                string selectedmag = comboBoxEdit1.EditValue.ToString();



                var selectedmagid = from x in db.Famille1
                                    where x.Intitule.Equals(selectedmag)
                                    select x.Id_famille;

                a.Id_famille = Int32.Parse(selectedmag);







            }
            db.Article1.InsertOnSubmit(a);
            db.SubmitChanges();
            load();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            var Artid = gvArticle.GetFocusedRowCellValue(id).ToString();
            int mid;
            if (!Int32.TryParse(Artid, out mid))
            {

                MessageBox.Show("Invalid ID value.");
                return;
            }
            Article1 a = db.Article1.FirstOrDefault(m => m.Id_Article == mid);
            if (a != null)
            {

                a.Intitule = txtIntitule.Text;

                if (!string.IsNullOrEmpty(comboBoxEdit1.EditValue?.ToString()))
                {

                    string selectedmag = comboBoxEdit1.EditValue.ToString();



                    var selectedmagid = from x in db.Famille1
                                        where x.Intitule.Equals(selectedmag)
                                        select x.Id_famille;

                    a.Id_famille = Int32.Parse(selectedmag);


                }
                db.SubmitChanges();
                load();

            }
        }

        private void gvArticle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtIntitule.Text = gvArticle.GetFocusedRowCellValue(article).ToString();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            txtIntitule.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           


            var Artid = gvArticle.GetFocusedRowCellValue(id).ToString();
            var resint = gvArticle.GetFocusedRowCellValue(article);
            Article1 R = db.Article1.FirstOrDefault(m => m.Id_Article == Int32.Parse(Artid));
            var rt = from n in db.detail_BC2
                      where n.Id_Article == Int32.Parse(Artid)
                      select n;

            var d = MessageBox.Show($"voulez vous supprimer {resint}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                
                gvArticle.DeleteRow(gvArticle.FocusedRowHandle);
                db.detail_BC2.DeleteAllOnSubmit(rt);

                db.Article1.DeleteOnSubmit(R);
                db.SubmitChanges();


            }

        }
    }
}

