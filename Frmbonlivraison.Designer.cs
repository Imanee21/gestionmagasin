namespace GestionMagasins
{
    partial class Frmbonlivraison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbonlivraison));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcbl = new DevExpress.XtraGrid.GridControl();
            this.gvBl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.code_liv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_livraison = new DevExpress.XtraGrid.Columns.GridColumn();
            this.observation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_commande = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.simpleButton4);
            this.dataLayoutControl1.Controls.Add(this.simpleButton3);
            this.dataLayoutControl1.Controls.Add(this.simpleButton2);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.gcbl);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1126, 621);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(566, 18);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(542, 38);
            this.simpleButton4.StyleController = this.dataLayoutControl1;
            this.simpleButton4.TabIndex = 9;
            this.simpleButton4.Text = "Ouvrir";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(566, 62);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(542, 38);
            this.simpleButton3.StyleController = this.dataLayoutControl1;
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Actualiser";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(18, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(542, 38);
            this.simpleButton2.StyleController = this.dataLayoutControl1;
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Supprimer";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(542, 38);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcbl
            // 
            this.gcbl.Location = new System.Drawing.Point(18, 106);
            this.gcbl.MainView = this.gvBl;
            this.gcbl.Name = "gcbl";
            this.gcbl.Size = new System.Drawing.Size(1090, 497);
            this.gcbl.TabIndex = 4;
            this.gcbl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBl});
            // 
            // gvBl
            // 
            this.gvBl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.code_liv,
            this.date_livraison,
            this.observation,
            this.id,
            this.id_commande});
            this.gvBl.GridControl = this.gcbl;
            this.gvBl.Name = "gvBl";
            // 
            // code_liv
            // 
            this.code_liv.Caption = "Code_livraison";
            this.code_liv.FieldName = "code_liv";
            this.code_liv.Name = "code_liv";
            this.code_liv.Visible = true;
            this.code_liv.VisibleIndex = 0;
            // 
            // date_livraison
            // 
            this.date_livraison.Caption = "Date_livraison";
            this.date_livraison.FieldName = "date_livraison";
            this.date_livraison.Name = "date_livraison";
            this.date_livraison.Visible = true;
            this.date_livraison.VisibleIndex = 1;
            // 
            // observation
            // 
            this.observation.Caption = "Observation";
            this.observation.FieldName = "observation";
            this.observation.Name = "observation";
            this.observation.Visible = true;
            this.observation.VisibleIndex = 2;
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // id_commande
            // 
            this.id_commande.Caption = "Id_commande";
            this.id_commande.FieldName = "id_commande";
            this.id_commande.Name = "id_commande";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1126, 621);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcbl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1096, 503);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(548, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(548, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton3;
            this.layoutControlItem5.Location = new System.Drawing.Point(548, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(548, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton4;
            this.layoutControlItem3.Location = new System.Drawing.Point(548, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(548, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Frmbonlivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 621);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Frmbonlivraison";
            this.Text = "bon livraison";
            this.Load += new System.EventHandler(this.Frmbonlivraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcbl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn code_liv;
        private DevExpress.XtraGrid.Columns.GridColumn date_livraison;
        private DevExpress.XtraGrid.Columns.GridColumn observation;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn id_commande;
    }
}