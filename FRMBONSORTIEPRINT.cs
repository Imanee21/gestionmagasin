using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GestionMagasins
{
    public partial class FRMBONSORTIEPRINT : DevExpress.XtraEditors.XtraForm
    {
        dbContextDataContext db = new dbContextDataContext();
        public FRMBONSORTIEPRINT()
        {
            InitializeComponent();
        }

        public void printInvosortie(bon_sortie order, List<detail_BS> data)
        {
            Reportbosortie report = new Reportbosortie();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            String r = db.Magasin1.Where(t => t.Id_magasin == order.Id_magasin).FirstOrDefault().Intitulé;
            String S = db.Magasin1.Where(t => t.Id_magasin == order.Id_magasin).FirstOrDefault().ville;
            report.inip( r, order.date_sortie,S, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();

        }
    }
}