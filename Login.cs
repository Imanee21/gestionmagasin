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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        dbContextDataContext db = new dbContextDataContext();
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400, MaterialSkin.Primary.BlueGrey400, MaterialSkin.Primary.BlueGrey300, MaterialSkin.Accent.Orange200, MaterialSkin.TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            tblAdmin n = new tblAdmin();
           
            if ( materialSingleLineTextField1.Text== "Admin"  &&    materialSingleLineTextField2.Text=="1234")
            {

                frmtest frm = new frmtest();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Mot de passe ou Nom d'utilisateur est incorrecte");
            }
        }
    }
}
