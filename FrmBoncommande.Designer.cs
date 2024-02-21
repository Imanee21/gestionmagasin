namespace GestionMagasins
{
    partial class FrmBoncommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoncommande));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcBC = new DevExpress.XtraGrid.GridControl();
            this.gvBC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.num_commande = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_livraison = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_echeance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_bc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mode_reglement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.observation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.etat_livraison = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.gcBC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1080, 621);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(543, 62);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(519, 38);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Actualiser";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(18, 62);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(519, 38);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Supprimer";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(543, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(519, 38);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Ouvrir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(519, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcBC
            // 
            this.gcBC.Location = new System.Drawing.Point(18, 106);
            this.gcBC.MainView = this.gvBC;
            this.gcBC.Name = "gcBC";
            this.gcBC.Size = new System.Drawing.Size(1044, 497);
            this.gcBC.TabIndex = 4;
            this.gcBC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBC});
            // 
            // gvBC
            // 
            this.gvBC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.num_commande,
            this.fournisseur,
            this.date_livraison,
            this.date_echeance,
            this.date_bc,
            this.mode_reglement,
            this.observation,
            this.reference,
            this.etat_livraison});
            this.gvBC.GridControl = this.gcBC;
            this.gvBC.Name = "gvBC";
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // num_commande
            // 
            this.num_commande.Caption = "N° Commande";
            this.num_commande.FieldName = "num_commande";
            this.num_commande.Name = "num_commande";
            this.num_commande.Visible = true;
            this.num_commande.VisibleIndex = 0;
            // 
            // fournisseur
            // 
            this.fournisseur.Caption = "Fournisseur";
            this.fournisseur.FieldName = "fournisseur";
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.Visible = true;
            this.fournisseur.VisibleIndex = 1;
            // 
            // date_livraison
            // 
            this.date_livraison.Caption = "Date Livraison";
            this.date_livraison.FieldName = "date_livraison";
            this.date_livraison.Name = "date_livraison";
            this.date_livraison.Visible = true;
            this.date_livraison.VisibleIndex = 4;
            // 
            // date_echeance
            // 
            this.date_echeance.Caption = "Date Echeance";
            this.date_echeance.FieldName = "date_echeance";
            this.date_echeance.Name = "date_echeance";
            this.date_echeance.Visible = true;
            this.date_echeance.VisibleIndex = 3;
            // 
            // date_bc
            // 
            this.date_bc.Caption = "Date_BC";
            this.date_bc.FieldName = "date_bc";
            this.date_bc.Name = "date_bc";
            this.date_bc.Visible = true;
            this.date_bc.VisibleIndex = 2;
            // 
            // mode_reglement
            // 
            this.mode_reglement.Caption = "Mode_Reglement";
            this.mode_reglement.FieldName = "mode_reglement";
            this.mode_reglement.Name = "mode_reglement";
            this.mode_reglement.Visible = true;
            this.mode_reglement.VisibleIndex = 5;
            // 
            // observation
            // 
            this.observation.Caption = "Observation";
            this.observation.FieldName = "observation";
            this.observation.Name = "observation";
            this.observation.Visible = true;
            this.observation.VisibleIndex = 6;
            // 
            // reference
            // 
            this.reference.Caption = "Reference";
            this.reference.FieldName = "reference";
            this.reference.Name = "reference";
            this.reference.Visible = true;
            this.reference.VisibleIndex = 7;
            // 
            // etat_livraison
            // 
            this.etat_livraison.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.etat_livraison.AppearanceCell.Options.UseBackColor = true;
            this.etat_livraison.Caption = "Etat livraison";
            this.etat_livraison.FieldName = "etat_livraison";
            this.etat_livraison.Name = "etat_livraison";
            this.etat_livraison.Visible = true;
            this.etat_livraison.VisibleIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1080, 621);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcBC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1050, 503);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(525, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(525, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(525, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton3;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(525, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton4;
            this.layoutControlItem5.Location = new System.Drawing.Point(525, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(525, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmBoncommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmBoncommande";
            this.Text = "Bon commande";
            this.Load += new System.EventHandler(this.FrmBoncommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcBC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBC;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn num_commande;
        private DevExpress.XtraGrid.Columns.GridColumn fournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn date_livraison;
        private DevExpress.XtraGrid.Columns.GridColumn date_echeance;
        private DevExpress.XtraGrid.Columns.GridColumn date_bc;
        private DevExpress.XtraGrid.Columns.GridColumn mode_reglement;
        private DevExpress.XtraGrid.Columns.GridColumn observation;
        private DevExpress.XtraGrid.Columns.GridColumn reference;
        private DevExpress.XtraGrid.Columns.GridColumn etat_livraison;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}