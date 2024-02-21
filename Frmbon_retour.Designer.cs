namespace GestionMagasins
{
    partial class Frmbon_retour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbon_retour));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gcretour = new DevExpress.XtraGrid.GridControl();
            this.gvretour = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nom_four = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ref_fournisseur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code_retour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date_retour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcretour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvretour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.panel2);
            this.dataLayoutControl1.Controls.Add(this.panel1);
            this.dataLayoutControl1.Controls.Add(this.simpleButton5);
            this.dataLayoutControl1.Controls.Add(this.gcretour);
            this.dataLayoutControl1.Controls.Add(this.simpleButton4);
            this.dataLayoutControl1.Controls.Add(this.simpleButton3);
            this.dataLayoutControl1.Controls.Add(this.simpleButton2);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(998, 522);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(18, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 38);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(160, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 30);
            this.panel1.TabIndex = 10;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(788, 455);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(192, 38);
            this.simpleButton5.StyleController = this.dataLayoutControl1;
            this.simpleButton5.TabIndex = 9;
            this.simpleButton5.Text = "Imprimer";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // gcretour
            // 
            this.gcretour.Location = new System.Drawing.Point(18, 106);
            this.gcretour.MainView = this.gvretour;
            this.gcretour.Name = "gcretour";
            this.gcretour.Size = new System.Drawing.Size(962, 343);
            this.gcretour.TabIndex = 8;
            this.gcretour.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvretour});
            // 
            // gvretour
            // 
            this.gvretour.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nom_four,
            this.Ref_fournisseur,
            this.CIN,
            this.Code_retour,
            this.Date_retour,
            this.Observation,
            this.id});
            this.gvretour.GridControl = this.gcretour;
            this.gvretour.Name = "gvretour";
            // 
            // Nom_four
            // 
            this.Nom_four.Caption = "Nom_four";
            this.Nom_four.FieldName = "Nom_four";
            this.Nom_four.Name = "Nom_four";
            // 
            // Ref_fournisseur
            // 
            this.Ref_fournisseur.Caption = "Ref_fournisseur";
            this.Ref_fournisseur.FieldName = "Ref_fournisseur";
            this.Ref_fournisseur.Name = "Ref_fournisseur";
            // 
            // CIN
            // 
            this.CIN.Caption = "CIN";
            this.CIN.FieldName = "CIN";
            this.CIN.Name = "CIN";
            // 
            // Code_retour
            // 
            this.Code_retour.Caption = "code_retour";
            this.Code_retour.FieldName = "code_retour";
            this.Code_retour.Name = "Code_retour";
            this.Code_retour.Visible = true;
            this.Code_retour.VisibleIndex = 0;
            // 
            // Date_retour
            // 
            this.Date_retour.Caption = "date_retour";
            this.Date_retour.FieldName = "date_retour";
            this.Date_retour.Name = "Date_retour";
            this.Date_retour.Visible = true;
            this.Date_retour.VisibleIndex = 1;
            // 
            // Observation
            // 
            this.Observation.Caption = "observation";
            this.Observation.FieldName = "observation";
            this.Observation.Name = "Observation";
            this.Observation.Visible = true;
            this.Observation.VisibleIndex = 2;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(502, 62);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(478, 38);
            this.simpleButton4.StyleController = this.dataLayoutControl1;
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Actualiser";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(18, 62);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(478, 38);
            this.simpleButton3.StyleController = this.dataLayoutControl1;
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "supprimer";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(502, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(478, 38);
            this.simpleButton2.StyleController = this.dataLayoutControl1;
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Ouvrir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(18, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(478, 38);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.panel1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 469);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(760, 38);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(50, 20);
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(998, 522);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(484, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 481);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(968, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(484, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(484, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(484, 44);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton4;
            this.layoutControlItem4.Location = new System.Drawing.Point(484, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(484, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcretour;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(968, 349);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton5;
            this.layoutControlItem6.Location = new System.Drawing.Point(770, 437);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(198, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.panel2;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 437);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(770, 44);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // Frmbon_retour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 522);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Frmbon_retour";
            this.Text = "bon_retour";
            this.Load += new System.EventHandler(this.Frmbon_retour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcretour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvretour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcretour;
        private DevExpress.XtraGrid.Views.Grid.GridView gvretour;
        private DevExpress.XtraGrid.Columns.GridColumn Code_retour;
        private DevExpress.XtraGrid.Columns.GridColumn Date_retour;
        private DevExpress.XtraGrid.Columns.GridColumn Observation;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn Nom_four;
        private DevExpress.XtraGrid.Columns.GridColumn Ref_fournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn CIN;
    }
}