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
    public partial class frmMag : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public frmMag()
        {
            InitializeComponent();
        }

        private void frmMag_Load(object sender, EventArgs e)
                    
        {
            var data = db.Magasin1.Select(m => new
            {
                id_magasin = m.Id_magasin,
                intitule = m.Intitulé,
                ville = m.ville
           
            }).ToList();
            gcMag.DataSource = data;
           
           
        }





        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //ajouter un colone dans le tableau et base de donnees  par 3 fonctions 
            // 1er fonction InsertOnSubmit créé et ajouté à un colone au base de données
            //2 emme SubmitChanges pour enregistrer les modifications  dans une base de donnees
            
            Magasin1 mag = new Magasin1();

            mag.Intitulé = textEdit1.Text;
            mag.ville = textEdit2.Text;
            db.Magasin1.InsertOnSubmit(mag);
            db.SubmitChanges();
            load_data();
            textEdit1.Text = "";
            textEdit2.Text = "";
            
        }

        

       

        

        private void gvMag_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // remplir textEdit1 par Intitulé et ville selectionne 
            textEdit1.Text = gvMag.GetFocusedRowCellValue(Intitulé).ToString();
            textEdit2.Text = gvMag.GetFocusedRowCellValue(Ville).ToString();
        }

        private void load_data()
        {
            // recuperer  les lignes de tableau dans  les lignes de gridView
            var data = db.Magasin1.Select(m => new
            {
                id_magasin = m.Id_magasin,
                intitule = m.Intitulé,
                ville = m.ville,
                responsable = db.Responsable1.Where(r => r.Id_resp == db.Ass_mag_resp.Where(rs => rs.id_mag == m.Id_magasin).FirstOrDefault().id_resp).FirstOrDefault().Prenom_resp
            }).ToList();
            gcMag.DataSource = data;
        
        }

     

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = " ";
            textEdit2.Text = " ";
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            // Supprimer un colonne  
            // donne la valeur de "Id" à 'magid' et "resint" à "Intitulé"
            //récupérer toutes les lignes de la table Ass_mag_resp 
            //où l'ID_mag correspond à l'ID de la ligne sélectionnée 
            //  Affiche une boîte de dialogue demande une confirmation de la suppression de l'intitulé de la ligne sélectionné.
            // Si oui  supprime la ligne sélectionnée
            //supprime toutes les lignes qui selectionne dans rowToDelete
            // supprime dans la base de donnees
            // enregister les modifications

            var magid = gvMag.GetFocusedRowCellValue(ID).ToString();
            
            var resint = gvMag.GetFocusedRowCellValue(Intitulé);
            var rowsToDelete = from r in db.Ass_mag_resp
                               where r.id_mag == Int32.Parse(magid)
                               select r;
            var br = from n in db.Magasin1
                     where n.Id_magasin == Int32.Parse(magid)
                     select n;
           
          
            Magasin1 R = db.Magasin1.FirstOrDefault(x => x.Id_magasin == Int32.Parse(magid));

            
            var d = MessageBox.Show($"voulez vous supprimer {resint}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                gvMag.DeleteRow(gvMag.FocusedRowHandle);
                db.Ass_mag_resp.DeleteAllOnSubmit(rowsToDelete);
                db.Magasin1.DeleteAllOnSubmit(br);


                db.Magasin1.DeleteOnSubmit(R);
                db.SubmitChanges();
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            // Modifier les lignes de tableau :
            //1er etape on focus sur un colone par ID
            //2eme etape si magid n'est null on le transfere à int et le donné sa valeur à mid
            // 3eme etape prend Id_magasin la mid valeur de   les propriétés "Intitulé" et "ville" 
            // sont mises à jour avec les valeurs de textEdit1 et textEdit2 si il n'est pas null
            var magid = gvMag.GetFocusedRowCellValue(ID).ToString();
            int mid;
            if (!Int32.TryParse(magid, out mid))
            {

                MessageBox.Show("Invalid ID value.");
                return;
            }
            Magasin1 R = db.Magasin1.FirstOrDefault(m => m.Id_magasin == mid);
            if (R != null)
            {
                R.Intitulé = textEdit1.Text;
                R.ville = textEdit2.Text;
                db.SubmitChanges();
                load_data();
            }

        }
    }
}
