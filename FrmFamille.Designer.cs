namespace GestionMagasins
{
    partial class FrmFamille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamille));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcFamille = new DevExpress.XtraGrid.GridControl();
            this.gvFamille = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.famillee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.code_famillee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textcode = new DevExpress.XtraEditors.TextEdit();
            this.txtFamille = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Famille = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.code_famille = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Detail_Famille = new DevExpress.XtraLayout.LayoutControlGroup();
            this.list_Famille = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamille.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Famille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_famille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Famille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_Famille)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.gcFamille);
            this.layoutControl1.Controls.Add(this.textcode);
            this.layoutControl1.Controls.Add(this.txtFamille);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(836, 571);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(421, 160);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(397, 38);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Text = "Supprimer";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(18, 160);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(397, 38);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Modifier";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(421, 116);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(397, 38);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Ajouter";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 116);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(397, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Nouveau";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcFamille
            // 
            this.gcFamille.Location = new System.Drawing.Point(37, 251);
            this.gcFamille.MainView = this.gvFamille;
            this.gcFamille.Name = "gcFamille";
            this.gcFamille.Size = new System.Drawing.Size(762, 273);
            this.gcFamille.TabIndex = 6;
            this.gcFamille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFamille});
            // 
            // gvFamille
            // 
            this.gvFamille.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.famillee,
            this.code_famillee,
            this.id});
            this.gvFamille.GridControl = this.gcFamille;
            this.gvFamille.Name = "gvFamille";
            this.gvFamille.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvFamille_FocusedColumnChanged);
            // 
            // famillee
            // 
            this.famillee.Caption = "Famille";
            this.famillee.FieldName = "famillee";
            this.famillee.Name = "famillee";
            this.famillee.Visible = true;
            this.famillee.VisibleIndex = 0;
            // 
            // code_famillee
            // 
            this.code_famillee.Caption = "Code_Famille";
            this.code_famillee.FieldName = "code_famillee";
            this.code_famillee.Name = "code_famillee";
            this.code_famillee.Visible = true;
            this.code_famillee.VisibleIndex = 1;
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(515, 65);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(284, 26);
            this.textcode.StyleController = this.layoutControl1;
            this.textcode.TabIndex = 5;
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(131, 65);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(284, 26);
            this.txtFamille.StyleController = this.layoutControl1;
            this.txtFamille.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.Detail_Famille,
            this.list_Famille});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(836, 571);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Famille
            // 
            this.Famille.Control = this.txtFamille;
            this.Famille.Location = new System.Drawing.Point(0, 0);
            this.Famille.Name = "Famille";
            this.Famille.Size = new System.Drawing.Size(384, 32);
            this.Famille.TextSize = new System.Drawing.Size(89, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 531);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(806, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // code_famille
            // 
            this.code_famille.Control = this.textcode;
            this.code_famille.Location = new System.Drawing.Point(384, 0);
            this.code_famille.Name = "code_famille";
            this.code_famille.Size = new System.Drawing.Size(384, 32);
            this.code_famille.TextSize = new System.Drawing.Size(89, 19);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcFamille;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(768, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(403, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(403, 98);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(403, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton3;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(403, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton4;
            this.layoutControlItem5.Location = new System.Drawing.Point(403, 142);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(403, 44);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Detail_Famille
            // 
            this.Detail_Famille.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Famille,
            this.code_famille});
            this.Detail_Famille.Location = new System.Drawing.Point(0, 0);
            this.Detail_Famille.Name = "Detail_Famille";
            this.Detail_Famille.OptionsItemText.TextToControlDistance = 5;
            this.Detail_Famille.Size = new System.Drawing.Size(806, 98);
            // 
            // list_Famille
            // 
            this.list_Famille.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.list_Famille.Location = new System.Drawing.Point(0, 186);
            this.list_Famille.Name = "list_Famille";
            this.list_Famille.OptionsItemText.TextToControlDistance = 5;
            this.list_Famille.Size = new System.Drawing.Size(806, 345);
            // 
            // FrmFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 571);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmFamille";
            this.Text = "Famille";
            this.Load += new System.EventHandler(this.FrmFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamille.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Famille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_famille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Famille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_Famille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcFamille;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFamille;
        private DevExpress.XtraGrid.Columns.GridColumn famillee;
        private DevExpress.XtraGrid.Columns.GridColumn code_famillee;
        private DevExpress.XtraEditors.TextEdit textcode;
        private DevExpress.XtraEditors.TextEdit txtFamille;
        private DevExpress.XtraLayout.LayoutControlItem Famille;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem code_famille;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraLayout.LayoutControlGroup Detail_Famille;
        private DevExpress.XtraLayout.LayoutControlGroup list_Famille;
    }
}