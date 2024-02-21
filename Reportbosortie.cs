using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace GestionMagasins
{
    public partial class Reportbosortie : DevExpress.XtraReports.UI.XtraReport
    {
        dbContextDataContext db = new dbContextDataContext();
        public Reportbosortie()
        {
            InitializeComponent();
        }
     

      

        internal void inip(string r, DateTime? date_sortie, string S, List<detail_BS> data)
        {
            Date_sortie.Value = date_sortie;
            Magasin.Value = r;
            Ville.Value = S;


            bindingSource1.DataSource = data;
        }
    }
}
