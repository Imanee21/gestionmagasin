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
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private Form formm=null;

        public Main()
        {
            InitializeComponent();
        }
        

        private void Magasin_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            OForm(new frmMag());

        }

       
        private void Article_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            OForm(new FrmArticle1());
        }
        private void OForm(Form form)
        {
            if (formm != null)
            {
                formm.Close();
            }



           formm = form;
            formm.TopLevel = false;
            formm.Dock = DockStyle.Fill;
            formm.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(formm);
            formm.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmArticle1());
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmStock());
        }

     

        private void Fournisseur_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new Fournisseurrr());
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            OForm(new frmMag());
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmFamille());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void Article_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmArti());
        }

        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmBoncommande());
        }

        private void navBarItem4_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmStock());
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new Frmbonlivraison());
        }

        private void Fournisseurr_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new Fournisseurrr());
        }

        private void Delai_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new FrmDelailivraison());
        }

        private void bon_retour_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OForm(new Frmbon_retour());
        }
    }
    
}