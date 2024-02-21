namespace GestionMagasins
{
    partial class frmMag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMag));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gcMag = new DevExpress.XtraGrid.GridControl();
            this.gvMag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_magasin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.intitule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.villee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Intitulé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ville = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.btnModifier);
            this.layoutControl1.Controls.Add(this.btnSupprimer);
            this.layoutControl1.Controls.Add(this.gcMag);
            this.layoutControl1.Controls.Add(this.btnAjouter);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(895, 695);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(360, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(250, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Nouveau";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.ImageOptions.Image")));
            this.btnModifier.Location = new System.Drawing.Point(360, 62);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(250, 38);
            this.btnModifier.StyleController = this.layoutControl1;
            this.btnModifier.TabIndex = 18;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.ImageOptions.Image")));
            this.btnSupprimer.Location = new System.Drawing.Point(616, 62);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(261, 38);
            this.btnSupprimer.StyleController = this.layoutControl1;
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // gcMag
            // 
            this.gcMag.Location = new System.Drawing.Point(37, 153);
            this.gcMag.MainView = this.gvMag;
            this.gcMag.Name = "gcMag";
            this.gcMag.Size = new System.Drawing.Size(821, 495);
            this.gcMag.TabIndex = 10;
            this.gcMag.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMag});
            // 
            // gvMag
            // 
            this.gvMag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_magasin,
            this.intitule,
            this.villee});
            this.gvMag.GridControl = this.gcMag;
            this.gvMag.Name = "gvMag";
            this.gvMag.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMag_FocusedRowChanged);
            // 
            // id_magasin
            // 
            this.id_magasin.Caption = "gridColumn1";
            this.id_magasin.FieldName = "id_magasin";
            this.id_magasin.Name = "id_magasin";
            // 
            // intitule
            // 
            this.intitule.Caption = "Magasin";
            this.intitule.FieldName = "intitule";
            this.intitule.Name = "intitule";
            this.intitule.Visible = true;
            this.intitule.VisibleIndex = 0;
            // 
            // villee
            // 
            this.villee.Caption = "Ville";
            this.villee.FieldName = "ville";
            this.villee.Name = "villee";
            this.villee.Visible = true;
            this.villee.VisibleIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.ImageOptions.Image")));
            this.btnAjouter.Location = new System.Drawing.Point(616, 18);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(261, 38);
            this.btnAjouter.StyleController = this.layoutControl1;
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(73, 62);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(281, 26);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(73, 18);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(281, 26);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(895, 695);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 44);
            this.layoutControlItem1.Text = "Intitulé";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 655);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(865, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(342, 44);
            this.layoutControlItem2.Text = "Ville";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAjouter;
            this.layoutControlItem3.Location = new System.Drawing.Point(598, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(267, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 88);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(865, 567);
            this.layoutControlGroup2.Text = "Liste des magasins";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcMag;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(827, 501);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(342, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(256, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSupprimer;
            this.layoutControlItem4.Location = new System.Drawing.Point(598, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(267, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnModifier;
            this.layoutControlItem5.Location = new System.Drawing.Point(342, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(256, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ID
            // 
            this.ID.Caption = "Id";
            this.ID.FieldName = "id_magasin";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Intitulé
            // 
            this.Intitulé.Caption = "Intitulé";
            this.Intitulé.FieldName = "intitule";
            this.Intitulé.Name = "Intitulé";
            this.Intitulé.Visible = true;
            this.Intitulé.VisibleIndex = 1;
            // 
            // Ville
            // 
            this.Ville.Caption = "Ville";
            this.Ville.FieldName = "ville";
            this.Ville.Name = "Ville";
            this.Ville.Visible = true;
            this.Ville.VisibleIndex = 2;
            // 
            // colResp
            // 
            this.colResp.Caption = "Responsable";
            this.colResp.FieldName = "responsable";
            this.colResp.Name = "colResp";
            this.colResp.Visible = true;
            this.colResp.VisibleIndex = 3;
            // 
            // frmMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 695);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmMag";
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.frmMag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnAjouter;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSupprimer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gcMag;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMag;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Intitulé;
        private DevExpress.XtraGrid.Columns.GridColumn Ville;
        private DevExpress.XtraGrid.Columns.GridColumn colResp;
        private DevExpress.XtraGrid.Columns.GridColumn id_magasin;
        private DevExpress.XtraGrid.Columns.GridColumn intitule;
        private DevExpress.XtraGrid.Columns.GridColumn villee;
    }
}