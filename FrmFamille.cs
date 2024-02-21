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
    public partial class FrmFamille : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public FrmFamille()
        {
            InitializeComponent();
        }

        private void FrmFamille_Load(object sender, EventArgs e)
        {
            gcFamille.DataSource = from m in db.Famille1
                               select new
                               {
                                   famillee= m.Intitule,
                                   code_famillee = m.Code_Famille,
                                   id =m.Id_famille



                               };
        }
        private void load()
        {
            gcFamille.DataSource = from m in db.Famille1
                                   select new
                                   {
                                       famillee = m.Intitule,
                                       code_famillee = m.Code_Famille,
                                       id = m.Id_famille




                                   };
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textcode.Text = "";
            txtFamille.Text = "";


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Famille1 f = new Famille1();

            f.Intitule = txtFamille.Text;
            f.Code_Famille = textcode.Text;
            String a = txtFamille.Text;
            if( f.Intitule == a)
            {
                db.Famille1.InsertOnSubmit(f);
                db.SubmitChanges();
                load();
               
            }
            else
            {
                MessageBox.Show("Cette famille est existe");
            }
          

            textcode.Text = "";
            txtFamille.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var intt = gvFamille.GetFocusedRowCellValue(id).ToString();
            int cd;
            if (!Int32.TryParse(intt, out cd))
            {

                MessageBox.Show("Invalid ID value.");
                return;
            }
            Famille1 f = db.Famille1.FirstOrDefault(m => m.Id_famille == cd);
            if (f != null)
            {
                f.Intitule = txtFamille.Text;
                f.Code_Famille = textcode.Text;

                db.SubmitChanges();
                load();
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
         
            var intt = gvFamille.GetFocusedRowCellValue(id).ToString();
            var resint = gvFamille.GetFocusedRowCellValue(famillee);
          
            var rt = from n in db.Article1
                      where n.Id_famille == Int32.Parse(intt)
                      select n;

            


            Famille1 R = db.Famille1.FirstOrDefault(x => x.Id_famille == Int32.Parse(intt));


            var d = MessageBox.Show($"voulez vous supprimer {resint}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                gvFamille.DeleteRow(gvFamille.FocusedRowHandle);

                db.Article1.DeleteAllOnSubmit(rt);
                
                db.Famille1.DeleteOnSubmit(R);
                db.SubmitChanges();
            }
        }

        private void gvFamille_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            // remplir textEdit1 par Intitulé et ville selectionne 
            

            if (gvFamille.GetFocusedRowCellValue(code_famillee) != null)
            {
                textcode.Text = gvFamille.GetFocusedRowCellValue(code_famillee).ToString();
            }
            else
            {
                textcode.Text = "";
            }
            if (gvFamille.GetFocusedRowCellValue(famillee) != null)
            {
                txtFamille.Text = gvFamille.GetFocusedRowCellValue(famillee).ToString();
            }
            else
            {
                txtFamille.Text = "";
            }
        }
    }
 }

