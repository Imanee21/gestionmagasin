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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        public void printInvo(bon_retour order,List<BCsuite> data)
        {
            Reportbon_retour report = new Reportbon_retour();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.ini(order.Id_bonretour,order.Ref_fournisseur, order.date_retour, order.Nom_fournisseur, order.CIN, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }
    }
}