using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;

namespace GestionMagasins
{
    public partial class Reportbon_retour : DevExpress.XtraReports.UI.XtraReport
    {
        dbContextDataContext db = new dbContextDataContext();
        public Reportbon_retour()
        {
            InitializeComponent();
        }
        private void load()
        {
            List<BCsuite> re = db.BCsuite
                
                .ToList();

            
        }

        internal void ini(int Id_bonretour,string n_Fournisseur, DateTime? date_retour, string nom_four, string cin, List<BCsuite> data)
        {
            Id_bonretourr.Value = Id_bonretour;
            Ref_fournisseur.Value = n_Fournisseur;
            Date_retour.Value = date_retour;
            Nom_fournisseur.Value = nom_four;
            CIN.Value = cin;


            objectDataSource2.DataSource = data;
        }

        
    }
}
