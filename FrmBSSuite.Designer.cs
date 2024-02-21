namespace GestionMagasins
{
    partial class FrmBSSuite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBSSuite));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcsorti1 = new DevExpress.XtraGrid.GridControl();
            this.detailBSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvsortie1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_dbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Intitule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_bonsortie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Supprimer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colId_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtdatesortie = new DevExpress.XtraEditors.DateEdit();
            this.txtobservation = new DevExpress.XtraEditors.TextEdit();
            this.txtcode = new DevExpress.XtraEditors.TextEdit();
            this.txtmagasin = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Code_sortie = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Observation = new DevExpress.XtraLayout.LayoutControlItem();
            this.Date_sortie = new DevExpress.XtraLayout.LayoutControlItem();
            this.Magasin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.detailBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bon_sortie = new DevExpress.XtraLayout.LayoutControlGroup();
            this.list_Article = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcsorti1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsortie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatesortie.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatesortie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtobservation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmagasin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code_sortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Observation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_sortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magasin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bon_sortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_Article)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.gcsorti1);
            this.dataLayoutControl1.Controls.Add(this.txtdatesortie);
            this.dataLayoutControl1.Controls.Add(this.txtobservation);
            this.dataLayoutControl1.Controls.Add(this.txtcode);
            this.dataLayoutControl1.Controls.Add(this.txtmagasin);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 450);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 384);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(764, 38);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Enregistrer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcsorti1
            // 
            this.gcsorti1.DataSource = this.detailBSBindingSource1;
            this.gcsorti1.Location = new System.Drawing.Point(37, 195);
            this.gcsorti1.MainView = this.gvsortie1;
            this.gcsorti1.Name = "gcsorti1";
            this.gcsorti1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.gcsorti1.Size = new System.Drawing.Size(726, 164);
            this.gcsorti1.TabIndex = 8;
            this.gcsorti1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvsortie1});
            this.gcsorti1.Click += new System.EventHandler(this.gcsorti1_Click);
            // 
            // detailBSBindingSource1
            // 
            this.detailBSBindingSource1.DataSource = typeof(GestionMagasins.detail_BS);
            // 
            // gvsortie1
            // 
            this.gvsortie1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_dbs,
            this.colId_Article,
            this.colId_bonsortie,
            this.colQte,
            this.colMontant,
            this.colPrix,
            this.Supprimer,
            this.colId_stock});
            this.gvsortie1.GridControl = this.gcsorti1;
            this.gvsortie1.Name = "gvsortie1";
            this.gvsortie1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colid_dbs
            // 
            this.colid_dbs.FieldName = "id_dbs";
            this.colid_dbs.Name = "colid_dbs";
            // 
            // colId_Article
            // 
            this.colId_Article.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colId_Article.FieldName = "Id_Article";
            this.colId_Article.Name = "colId_Article";
            this.colId_Article.Visible = true;
            this.colId_Article.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Id_Article";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Id_ligne";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Intitule,
            this.Id_Article});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Intitule
            // 
            this.Intitule.Caption = "Intitule";
            this.Intitule.FieldName = "Intitule";
            this.Intitule.Name = "Intitule";
            this.Intitule.Visible = true;
            this.Intitule.VisibleIndex = 1;
            // 
            // Id_Article
            // 
            this.Id_Article.Caption = "Id_Article";
            this.Id_Article.FieldName = "Id_Article";
            this.Id_Article.Name = "Id_Article";
            this.Id_Article.Visible = true;
            this.Id_Article.VisibleIndex = 0;
            // 
            // colId_bonsortie
            // 
            this.colId_bonsortie.FieldName = "Id_bonsortie";
            this.colId_bonsortie.Name = "colId_bonsortie";
            // 
            // colQte
            // 
            this.colQte.FieldName = "Qte";
            this.colQte.Name = "colQte";
            this.colQte.Visible = true;
            this.colQte.VisibleIndex = 1;
            // 
            // colMontant
            // 
            this.colMontant.FieldName = "Montant";
            this.colMontant.Name = "colMontant";
            this.colMontant.Visible = true;
            this.colMontant.VisibleIndex = 2;
            // 
            // colPrix
            // 
            this.colPrix.FieldName = "Prix";
            this.colPrix.Name = "colPrix";
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 3;
            // 
            // Supprimer
            // 
            this.Supprimer.Caption = "Supprimer";
            this.Supprimer.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Supprimer.FieldName = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Visible = true;
            this.Supprimer.VisibleIndex = 4;
            this.Supprimer.Width = 105;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // colId_stock
            // 
            this.colId_stock.FieldName = "Id_stock";
            this.colId_stock.Name = "colId_stock";
            // 
            // txtdatesortie
            // 
            this.txtdatesortie.EditValue = null;
            this.txtdatesortie.Location = new System.Drawing.Point(493, 65);
            this.txtdatesortie.Name = "txtdatesortie";
            this.txtdatesortie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdatesortie.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdatesortie.Size = new System.Drawing.Size(270, 26);
            this.txtdatesortie.StyleController = this.dataLayoutControl1;
            this.txtdatesortie.TabIndex = 6;
            // 
            // txtobservation
            // 
            this.txtobservation.Location = new System.Drawing.Point(493, 97);
            this.txtobservation.Name = "txtobservation";
            this.txtobservation.Size = new System.Drawing.Size(270, 26);
            this.txtobservation.StyleController = this.dataLayoutControl1;
            this.txtobservation.TabIndex = 5;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(127, 65);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(270, 26);
            this.txtcode.StyleController = this.dataLayoutControl1;
            this.txtcode.TabIndex = 4;
            // 
            // txtmagasin
            // 
            this.txtmagasin.Location = new System.Drawing.Point(127, 97);
            this.txtmagasin.Name = "txtmagasin";
            this.txtmagasin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmagasin.Properties.NullText = "";
            this.txtmagasin.Properties.PopupSizeable = false;
            this.txtmagasin.Properties.PopupView = this.gridLookUpEdit1View;
            this.txtmagasin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtmagasin.Size = new System.Drawing.Size(270, 26);
            this.txtmagasin.StyleController = this.dataLayoutControl1;
            this.txtmagasin.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.Bon_sortie,
            this.list_Article});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Code_sortie
            // 
            this.Code_sortie.Control = this.txtcode;
            this.Code_sortie.Location = new System.Drawing.Point(0, 0);
            this.Code_sortie.Name = "Code_sortie";
            this.Code_sortie.Size = new System.Drawing.Size(366, 32);
            this.Code_sortie.TextSize = new System.Drawing.Size(85, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 410);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(770, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Observation
            // 
            this.Observation.Control = this.txtobservation;
            this.Observation.Location = new System.Drawing.Point(366, 32);
            this.Observation.Name = "Observation";
            this.Observation.Size = new System.Drawing.Size(366, 32);
            this.Observation.TextSize = new System.Drawing.Size(85, 19);
            // 
            // Date_sortie
            // 
            this.Date_sortie.Control = this.txtdatesortie;
            this.Date_sortie.Location = new System.Drawing.Point(366, 0);
            this.Date_sortie.Name = "Date_sortie";
            this.Date_sortie.Size = new System.Drawing.Size(366, 32);
            this.Date_sortie.TextSize = new System.Drawing.Size(85, 19);
            // 
            // Magasin
            // 
            this.Magasin.Control = this.txtmagasin;
            this.Magasin.Location = new System.Drawing.Point(0, 32);
            this.Magasin.Name = "Magasin";
            this.Magasin.Size = new System.Drawing.Size(366, 32);
            this.Magasin.TextSize = new System.Drawing.Size(85, 19);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcsorti1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(732, 170);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 366);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(770, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // detailBSBindingSource
            // 
            this.detailBSBindingSource.DataSource = typeof(GestionMagasins.detail_BS);
            // 
            // Bon_sortie
            // 
            this.Bon_sortie.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Code_sortie,
            this.Date_sortie,
            this.Observation,
            this.Magasin});
            this.Bon_sortie.Location = new System.Drawing.Point(0, 0);
            this.Bon_sortie.Name = "Bon_sortie";
            this.Bon_sortie.OptionsItemText.TextToControlDistance = 5;
            this.Bon_sortie.Size = new System.Drawing.Size(770, 130);
            // 
            // list_Article
            // 
            this.list_Article.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.list_Article.Location = new System.Drawing.Point(0, 130);
            this.list_Article.Name = "list_Article";
            this.list_Article.OptionsItemText.TextToControlDistance = 5;
            this.list_Article.Size = new System.Drawing.Size(770, 236);
            // 
            // FrmBSSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "FrmBSSuite";
            this.Text = "detail_BS";
            this.Load += new System.EventHandler(this.FrmBSSuite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcsorti1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsortie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatesortie.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatesortie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtobservation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmagasin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code_sortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Observation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_sortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Magasin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bon_sortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_Article)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcsorti1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvsortie1;
        private DevExpress.XtraEditors.DateEdit txtdatesortie;
        private DevExpress.XtraEditors.TextEdit txtobservation;
        private DevExpress.XtraEditors.TextEdit txtcode;
        private DevExpress.XtraLayout.LayoutControlItem Code_sortie;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem Observation;
        private DevExpress.XtraLayout.LayoutControlItem Date_sortie;
        private DevExpress.XtraLayout.LayoutControlItem Magasin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GridLookUpEdit txtmagasin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource detailBSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_dbs;
        private DevExpress.XtraGrid.Columns.GridColumn colId_bonsortie;
        private DevExpress.XtraGrid.Columns.GridColumn colQte;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Intitule;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Article;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn Supprimer;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.BindingSource detailBSBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Article;
        private DevExpress.XtraGrid.Columns.GridColumn colId_stock;
        private DevExpress.XtraLayout.LayoutControlGroup Bon_sortie;
        private DevExpress.XtraLayout.LayoutControlGroup list_Article;
    }
}