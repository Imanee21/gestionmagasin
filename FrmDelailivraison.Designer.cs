namespace GestionMagasins
{
    partial class FrmDelailivraison
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gcdelai = new DevExpress.XtraGrid.GridControl();
            this.gvdelai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Bon_commande = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date_livraison1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date_livraison2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.delai_commande = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdelai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdelai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delai_commande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gcdelai);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1010, 613);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gcdelai
            // 
            this.gcdelai.Location = new System.Drawing.Point(37, 65);
            this.gcdelai.MainView = this.gvdelai;
            this.gcdelai.Name = "gcdelai";
            this.gcdelai.Size = new System.Drawing.Size(936, 511);
            this.gcdelai.TabIndex = 4;
            this.gcdelai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdelai});
            // 
            // gvdelai
            // 
            this.gvdelai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Bon_commande,
            this.Date_livraison1,
            this.Date_livraison2,
            this.Observation});
            this.gvdelai.GridControl = this.gcdelai;
            this.gvdelai.Name = "gvdelai";
            // 
            // Bon_commande
            // 
            this.Bon_commande.Caption = "Bon_commande";
            this.Bon_commande.FieldName = "Bon_commande";
            this.Bon_commande.Name = "Bon_commande";
            this.Bon_commande.Visible = true;
            this.Bon_commande.VisibleIndex = 0;
            // 
            // Date_livraison1
            // 
            this.Date_livraison1.Caption = "Date_livraison_prévue";
            this.Date_livraison1.FieldName = "Date_livraison1";
            this.Date_livraison1.Name = "Date_livraison1";
            this.Date_livraison1.Visible = true;
            this.Date_livraison1.VisibleIndex = 1;
            // 
            // Date_livraison2
            // 
            this.Date_livraison2.Caption = "Date_livraison";
            this.Date_livraison2.FieldName = "Date_livraison2";
            this.Date_livraison2.Name = "Date_livraison2";
            this.Date_livraison2.Visible = true;
            this.Date_livraison2.VisibleIndex = 2;
            // 
            // Observation
            // 
            this.Observation.Caption = "Observation";
            this.Observation.FieldName = "Observation";
            this.Observation.Name = "Observation";
            this.Observation.Visible = true;
            this.Observation.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.delai_commande});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1010, 613);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // delai_commande
            // 
            this.delai_commande.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.delai_commande.Location = new System.Drawing.Point(0, 0);
            this.delai_commande.Name = "delai_commande";
            this.delai_commande.OptionsItemText.TextToControlDistance = 5;
            this.delai_commande.Size = new System.Drawing.Size(980, 583);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcdelai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(942, 517);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmDelailivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 613);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "FrmDelailivraison";
            this.Text = "Delai livraison";
            this.Load += new System.EventHandler(this.FrmDelailivraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcdelai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdelai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delai_commande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcdelai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdelai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Bon_commande;
        private DevExpress.XtraGrid.Columns.GridColumn Date_livraison1;
        private DevExpress.XtraGrid.Columns.GridColumn Date_livraison2;
        private DevExpress.XtraGrid.Columns.GridColumn Observation;
        private DevExpress.XtraLayout.LayoutControlGroup delai_commande;
    }
}