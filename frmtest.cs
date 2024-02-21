using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace GestionMagasins
{
    public partial class frmtest : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private Form formm = null;
        public frmtest()
        {
            InitializeComponent();
        }
        //private void OForm(Form form)
        //{
        //    if (formm != null)
        //    {
        //        formm.Close();
        //    }



        //    formm = form;
        //    formm.TopLevel = false;
        //    formm.Dock = DockStyle.Fill;
        //    formm.FormBorderStyle = FormBorderStyle.None;
        //    panel1.Controls.Add(formm);
        //    formm.Show();
        //}

        private void Article_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new FrmArti());
            FrmArti frm = new FrmArti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Famille_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new FrmFamille());
            FrmFamille frm = new FrmFamille();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new FrmDelailivraison());
            FrmDelailivraison frm = new FrmDelailivraison();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new FrmBoncommande());
            FrmBoncommande  frm = new FrmBoncommande();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new FrmStock());
            FrmStock frm = new FrmStock();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new Frmbonlivraison());
            Frmbonlivraison frm = new Frmbonlivraison();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Bon_retour_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new Frmbon_retour());
            Frmbon_retour frm = new Frmbon_retour();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Fournisseur_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OForm(new frmfournisseur());
            Fournisseurrr frm = new Fournisseurrr();
            frm.MdiParent = this;
            frm.Show(); ;
        }

        private void frmtest_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frmbonsortie frm = new Frmbonsortie();
            frm.MdiParent = this;
            frm.Show(); ;
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMag frm = new frmMag();
            frm.MdiParent = this;
            frm.Show(); ;
        }
    }
}