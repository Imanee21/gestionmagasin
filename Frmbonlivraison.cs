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
    public partial class Frmbonlivraison : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public Frmbonlivraison()
        {
            InitializeComponent();
        }

        private void Frmbonlivraison_Load(object sender, EventArgs e)
        {
            var data = db.bon_livraison.Select(
          m => new
          {
              id = m.id_livraison,
              code_liv = m.code_livraison,
              date_livraison = m.date_livraison,
              observation = m.observation,
              id_commande = m.id_commande


          });
         





            gcbl.DataSource = data;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string A = null; // un argument pour instancier un objet de la classe "frmresp"
            FrmBLsuite F1 = new FrmBLsuite(A);
            F1.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var a = gvBl.GetFocusedRowCellValue(id).ToString();
            FrmBLsuite F1 = new FrmBLsuite(a);
            F1.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var data = db.bon_livraison.Select(
        m => new
        {
            id = m.id_livraison,
            code_liv = m.code_livraison,
            date_livraison = m.date_livraison,
            observation = m.observation,
            id_commande = m.id_commande


        });






            gcbl.DataSource = data;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var persid = gvBl.GetFocusedRowCellValue(id).ToString();
            var nom = gvBl.GetFocusedRowCellValue(code_liv);
            var rowsToDelete = from r in db.BLSuite
                               where r.id_livraison == Int32.Parse(persid)
                               select r;
            var row= from r in db.bon_retour
                     where r.Id_livraison == Int32.Parse(persid)
                     select r;
            bon_livraison R = db.bon_livraison.FirstOrDefault(m => m.id_livraison == Int32.Parse(persid));
            BLSuite s = db.BLSuite.FirstOrDefault(l => l.id_livraison == Int32.Parse(persid));
            //string hh = s.idbl.ToString();
            var d = MessageBox.Show($"voulez vous supprimer {nom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (s != null && s.idbl != 0)
                {
                    MessageBox.Show("supprimer premierement les articles");
                }
                else
                {
                    

                    gvBl.DeleteRow(gvBl.FocusedRowHandle);
                    db.BLSuite.DeleteAllOnSubmit(rowsToDelete);
                    db.bon_retour.DeleteAllOnSubmit(row);
                    db.bon_livraison.DeleteOnSubmit(R);
                    db.SubmitChanges();
                }
            }
        }
    }
}
