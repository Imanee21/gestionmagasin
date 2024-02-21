namespace GestionMagasins
{
    partial class FrmArticle1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticle1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnNouveau = new DevExpress.XtraEditors.SimpleButton();
            this.gcArticle = new DevExpress.XtraGrid.GridControl();
            this.gvArticle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.article = new DevExpress.XtraGrid.Columns.GridColumn();
            this.famille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.txtIntitule = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Intitule = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Famillee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntitule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intitule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Famillee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSupprimer);
            this.layoutControl1.Controls.Add(this.btnNouveau);
            this.layoutControl1.Controls.Add(this.gcArticle);
            this.layoutControl1.Controls.Add(this.btnModifier);
            this.layoutControl1.Controls.Add(this.btnAjouter);
            this.layoutControl1.Controls.Add(this.txtIntitule);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.ImageOptions.Image")));
            this.btnSupprimer.Location = new System.Drawing.Point(477, 62);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 38);
            this.btnSupprimer.StyleController = this.layoutControl1;
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.ImageOptions.Image")));
            this.btnNouveau.Location = new System.Drawing.Point(477, 18);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(132, 38);
            this.btnNouveau.StyleController = this.layoutControl1;
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // gcArticle
            // 
            this.gcArticle.Location = new System.Drawing.Point(18, 106);
            this.gcArticle.MainView = this.gvArticle;
            this.gcArticle.Name = "gcArticle";
            this.gcArticle.Size = new System.Drawing.Size(764, 316);
            this.gcArticle.TabIndex = 8;
            this.gcArticle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticle});
            // 
            // gvArticle
            // 
            this.gvArticle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.article,
            this.famille,
            this.id});
            this.gvArticle.GridControl = this.gcArticle;
            this.gvArticle.Name = "gvArticle";
            this.gvArticle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvArticle_FocusedRowChanged);
            // 
            // article
            // 
            this.article.Caption = "Article";
            this.article.FieldName = "article";
            this.article.Name = "article";
            this.article.Visible = true;
            this.article.VisibleIndex = 1;
            // 
            // famille
            // 
            this.famille.Caption = "Famille";
            this.famille.FieldName = "famille";
            this.famille.Name = "famille";
            this.famille.Visible = true;
            this.famille.VisibleIndex = 2;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.ImageOptions.Image")));
            this.btnModifier.Location = new System.Drawing.Point(615, 62);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(167, 38);
            this.btnModifier.StyleController = this.layoutControl1;
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.ImageOptions.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(615, 18);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(167, 38);
            this.btnAjouter.StyleController = this.layoutControl1;
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouer";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(81, 18);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(390, 26);
            this.txtIntitule.StyleController = this.layoutControl1;
            this.txtIntitule.TabIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(81, 62);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.NullText = "";
            this.comboBoxEdit1.Properties.PopupSizeable = false;
            this.comboBoxEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.comboBoxEdit1.Size = new System.Drawing.Size(390, 26);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 5;
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
            this.Intitule,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.Famillee,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Intitule
            // 
            this.Intitule.Control = this.txtIntitule;
            this.Intitule.Location = new System.Drawing.Point(0, 0);
            this.Intitule.Name = "Intitule";
            this.Intitule.Size = new System.Drawing.Size(459, 44);
            this.Intitule.TextSize = new System.Drawing.Size(58, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 410);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(770, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnModifier;
            this.layoutControlItem4.Location = new System.Drawing.Point(597, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(173, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAjouter;
            this.layoutControlItem3.Location = new System.Drawing.Point(597, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(173, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Famillee
            // 
            this.Famillee.Control = this.comboBoxEdit1;
            this.Famillee.Location = new System.Drawing.Point(0, 44);
            this.Famillee.Name = "Famillee";
            this.Famillee.Size = new System.Drawing.Size(459, 44);
            this.Famillee.TextSize = new System.Drawing.Size(58, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcArticle;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(770, 322);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnNouveau;
            this.layoutControlItem1.Location = new System.Drawing.Point(459, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(138, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSupprimer;
            this.layoutControlItem6.Location = new System.Drawing.Point(459, 44);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(138, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FrmArticle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmArticle1";
            this.Text = "FrmArticle1";
            this.Load += new System.EventHandler(this.FrmArticle1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntitule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intitule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Famillee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcArticle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticle;
        private DevExpress.XtraGrid.Columns.GridColumn article;
        private DevExpress.XtraGrid.Columns.GridColumn famille;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnAjouter;
        private DevExpress.XtraEditors.TextEdit txtIntitule;
        private DevExpress.XtraLayout.LayoutControlItem Intitule;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem Famillee;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GridLookUpEdit comboBoxEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.SimpleButton btnSupprimer;
        private DevExpress.XtraEditors.SimpleButton btnNouveau;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}