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
    public partial class FrmDelailivraison : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public FrmDelailivraison()
        {
            InitializeComponent();
        }

        private void FrmDelailivraison_Load(object sender, EventArgs e)
        {
            var data = db.Table_1.Select(m => new
            {
               Bon_commande = db.bon_commande.Where(s=> s.id_commande == m.Id_commande).FirstOrDefault().numero_commande,
               Date_livraison1= db.bon_commande.Where(s => s.id_commande == m.Id_commande).FirstOrDefault().date_livraison,
               Date_livraison2 = db.bon_livraison.Where(p=>p.id_commande == m.Id_commande).FirstOrDefault().date_livraison,
               Observation = CalculerEtatLivraison(db.bon_commande.Where(s => s.id_commande == m.Id_commande).FirstOrDefault().date_livraison.ToString(), db.bon_livraison.Where(p => p.id_commande == m.Id_commande).FirstOrDefault().date_livraison.ToString()),
            }).ToList();
            gcdelai.DataSource = data;
            
        }
        private string CalculerEtatLivraison(String Date_livraison1, String Date_livraison2)
        {

            String b = null;

            if (Date_livraison1 == Date_livraison2 && Date_livraison2 != null)
            {
                b = "bien recu";
            }
            else if ( Date_livraison2 == null )
            {
                b = "en cours de livrer";
            }
            else
            {
            
                b = "on retard";
            }
            return b;


        }

      
     
    }
}
