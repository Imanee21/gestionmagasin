namespace GestionMagasins
{
    partial class Fournisseurrr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fournisseurrr));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcFournisseur = new DevExpress.XtraGrid.GridControl();
            this.gvFournisseur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom_fournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prenom_fournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ville = new DevExpress.XtraGrid.Columns.GridColumn();
            this.n_fournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delai_livraison = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcFournisseur);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1027, 707);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcFournisseur
            // 
            this.gcFournisseur.Location = new System.Drawing.Point(18, 106);
            this.gcFournisseur.MainView = this.gvFournisseur;
            this.gcFournisseur.Name = "gcFournisseur";
            this.gcFournisseur.Size = new System.Drawing.Size(991, 573);
            this.gcFournisseur.TabIndex = 8;
            this.gcFournisseur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFournisseur});
            this.gcFournisseur.Click += new System.EventHandler(this.gcFournisseur_Click);
            // 
            // gvFournisseur
            // 
            this.gvFournisseur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.nom_fournisseur,
            this.prenom_fournisseur,
            this.tel,
            this.cin,
            this.pays,
            this.ville,
            this.n_fournisseur,
            this.adresse,
            this.email,
            this.delai_livraison});
            this.gvFournisseur.GridControl = this.gcFournisseur;
            this.gvFournisseur.Name = "gvFournisseur";
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Width = 88;
            // 
            // nom_fournisseur
            // 
            this.nom_fournisseur.Caption = "Fournisseur";
            this.nom_fournisseur.FieldName = "nom_fournisseur";
            this.nom_fournisseur.Name = "nom_fournisseur";
            this.nom_fournisseur.Visible = true;
            this.nom_fournisseur.VisibleIndex = 1;
            this.nom_fournisseur.Width = 88;
            // 
            // prenom_fournisseur
            // 
            this.prenom_fournisseur.Caption = "Prenom_fournisseur";
            this.prenom_fournisseur.FieldName = "prenom_fournisseur";
            this.prenom_fournisseur.Name = "prenom_fournisseur";
            this.prenom_fournisseur.Width = 88;
            // 
            // tel
            // 
            this.tel.Caption = "Tel";
            this.tel.FieldName = "tel";
            this.tel.Name = "tel";
            this.tel.Visible = true;
            this.tel.VisibleIndex = 3;
            this.tel.Width = 85;
            // 
            // cin
            // 
            this.cin.Caption = "Cin";
            this.cin.FieldName = "cin";
            this.cin.Name = "cin";
            this.cin.Width = 85;
            // 
            // pays
            // 
            this.pays.Caption = "Pays";
            this.pays.FieldName = "pays";
            this.pays.Name = "pays";
            this.pays.Visible = true;
            this.pays.VisibleIndex = 4;
            this.pays.Width = 85;
            // 
            // ville
            // 
            this.ville.Caption = "Ville";
            this.ville.FieldName = "ville";
            this.ville.Name = "ville";
            this.ville.Visible = true;
            this.ville.VisibleIndex = 5;
            this.ville.Width = 86;
            // 
            // n_fournisseur
            // 
            this.n_fournisseur.Caption = "Ref°fournisseur";
            this.n_fournisseur.FieldName = "n_forenisseur";
            this.n_fournisseur.Name = "n_fournisseur";
            this.n_fournisseur.Visible = true;
            this.n_fournisseur.VisibleIndex = 0;
            this.n_fournisseur.Width = 85;
            // 
            // adresse
            // 
            this.adresse.Caption = "Adresse";
            this.adresse.FieldName = "adresse";
            this.adresse.Name = "adresse";
            this.adresse.Visible = true;
            this.adresse.VisibleIndex = 6;
            this.adresse.Width = 85;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "email";
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 2;
            this.email.Width = 85;
            // 
            // delai_livraison
            // 
            this.delai_livraison.Caption = "Delai_livraison";
            this.delai_livraison.FieldName = "delai_livraison";
            this.delai_livraison.Name = "delai_livraison";
            this.delai_livraison.Visible = true;
            this.delai_livraison.VisibleIndex = 7;
            this.delai_livraison.Width = 108;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(501, 62);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(508, 38);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Actualiser";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(18, 62);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(477, 38);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Supprimer";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(501, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(508, 38);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Ouvrir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(477, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1027, 707);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 667);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(997, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(483, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(514, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(483, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(483, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton4;
            this.layoutControlItem4.Location = new System.Drawing.Point(483, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(514, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcFournisseur;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(997, 579);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Fournisseurrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 707);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Fournisseurrr";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.frmfournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcFournisseur;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFournisseur;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn nom_fournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn prenom_fournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn tel;
        private DevExpress.XtraGrid.Columns.GridColumn cin;
        private DevExpress.XtraGrid.Columns.GridColumn pays;
        private DevExpress.XtraGrid.Columns.GridColumn ville;
        private DevExpress.XtraGrid.Columns.GridColumn n_fournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn adresse;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn delai_livraison;
    }
}