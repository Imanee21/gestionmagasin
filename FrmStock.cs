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
    public partial class FrmStock : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            var data = db.Art_Stock.Where(m=> m.Qte> 0)
                .Select(
             m => new
             {
                 Id_ligne = m.Id_ligne,
                 Qte = m.Qte,
                 Mode_Stock = m.Mode_Stock,
                 Prix_achat = m.Prix_achat,

                 
                Id_Article = db.Article1.Where(b => b.Id_Article == m.Id_Article).FirstOrDefault().Intitule
             }).ToList();
            gcStock.DataSource = data;


        }
     




}
 }

