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
    public partial class Frmbonsortie : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        private string a;

        public Frmbonsortie()
        {
            InitializeComponent();
        }

        public Frmbonsortie(string a)
        {
            this.a = a;
        }

        private void Frmbonsortie_Load(object sender, EventArgs e)
        {
            var data = db.bon_sortie.Select(
               m => new
               {
                   id = m.id_bonsortie,
                   code_sortie = m.code_bonsortie,
                   date_sortie = m.date_sortie,
                   observation = m.observation,
                   magasin = db.Magasin1.Where(t=>t.Id_magasin == m.Id_magasin).FirstOrDefault().Intitulé,




               });






            gcsortie.DataSource = data;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string A = null; // un argument pour instancier un objet de la classe "frmresp"
            FrmBSSuite F1 = new FrmBSSuite(A);
            F1.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var a = gvsortie.GetFocusedRowCellValue(id).ToString();
            FrmBSSuite F1 = new FrmBSSuite(a);
            F1.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var data = db.bon_sortie.Select(
              m => new
              {
                  id = m.id_bonsortie,
                  code_sortie = m.code_bonsortie,
                  date_sortie = m.date_sortie,
                  observation = m.observation,
                  magasin = db.Magasin1.Where(t => t.Id_magasin == m.Id_magasin).FirstOrDefault().Intitulé,




              });






            gcsortie.DataSource = data;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var a = gvsortie.GetFocusedRowCellValue(id).ToString();
            bon_sortie obj = db.bon_sortie.FirstOrDefault(g => g.id_bonsortie == Int32.Parse(a));
            detail_BS h = db.detail_BS.FirstOrDefault(i => i.Id_bonsortie == Int32.Parse(a));



            List<detail_BS> list = db.detail_BS.Where(o => o.Id_bonsortie == Int32.Parse(a)).ToList();


            if (obj.id_bonsortie == list.FirstOrDefault()?.Id_bonsortie)
            {
                using (FRMBONSORTIEPRINT frm = new FRMBONSORTIEPRINT())
                {
                    frm.printInvosortie(obj, list);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("erreur");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var persid = gvsortie.GetFocusedRowCellValue(id).ToString();
            var nom = gvsortie.GetFocusedRowCellValue(code_sortie);
            bon_sortie R = db.bon_sortie.FirstOrDefault(m => m.id_bonsortie == Int32.Parse(persid));
            var d = MessageBox.Show($"voulez vous supprimer {nom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            detail_BS s = db.detail_BS.FirstOrDefault(l => l.Id_bonsortie == Int32.Parse(persid));
            var HY = from r in db.detail_BS
                     where r.Id_bonsortie == Int32.Parse(persid)
                     select r;
            if (d == DialogResult.Yes)
            {
                if (s != null && s.id_dbs != 0)
                {
                    MessageBox.Show("supprimer premierement les articles");
                }
                else
                {
                    gvsortie.DeleteRow(gvsortie.FocusedRowHandle);
                    db.detail_BS.DeleteAllOnSubmit(HY);

                    db.bon_sortie.DeleteOnSubmit(R);
                    db.SubmitChanges();
                }
            }
        }
    }
}
