namespace GestionMagasins
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.Gestion_Stock = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.Article = new DevExpress.XtraNavBar.NavBarItem();
            this.Magasin = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.Fournisseurr = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.Delai = new DevExpress.XtraNavBar.NavBarItem();
            this.bon_retour = new DevExpress.XtraNavBar.NavBarItem();
            this.pnlContainer = new DevExpress.XtraEditors.PanelControl();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.6742F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.navBarControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(177, 629);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.Gestion_Stock;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.Gestion_Stock,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.Magasin,
            this.navBarItem1,
            this.Article,
            this.navBarItem2,
            this.navBarItem4,
            this.navBarItem5,
            this.Fournisseurr,
            this.Delai,
            this.bon_retour});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 171;
            this.navBarControl1.Size = new System.Drawing.Size(171, 615);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Visual Studio 2013 Light");
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // Gestion_Stock
            // 
            this.Gestion_Stock.Caption = "Gestion_stock";
            this.Gestion_Stock.Expanded = true;
            this.Gestion_Stock.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Article),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Magasin)});
            this.Gestion_Stock.Name = "Gestion_Stock";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Famille";
            this.navBarItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked_1);
            // 
            // Article
            // 
            this.Article.Caption = "Article";
            this.Article.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Article.ImageOptions.LargeImage")));
            this.Article.Name = "Article";
            this.Article.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Article_LinkClicked_1);
            // 
            // Magasin
            // 
            this.Magasin.Caption = "Magasin";
            this.Magasin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Magasin.ImageOptions.LargeImage")));
            this.Magasin.Name = "Magasin";
            this.Magasin.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Gestion_d\'achat";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Fournisseurr),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Delai),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bon_retour)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // Fournisseurr
            // 
            this.Fournisseurr.Caption = "Fournisseur";
            this.Fournisseurr.Name = "Fournisseurr";
            this.Fournisseurr.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Fournisseurr_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Bon commande";
            this.navBarItem2.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked_1);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Bon_livraison";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Stock";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked_1);
            // 
            // Delai
            // 
            this.Delai.Caption = "Delai";
            this.Delai.Name = "Delai";
            this.Delai.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Delai_LinkClicked);
            // 
            // bon_retour
            // 
            this.bon_retour.Caption = "bon_retour";
            this.bon_retour.Name = "bon_retour";
            this.bon_retour.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bon_retour_LinkClicked);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(186, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(873, 629);
            this.pnlContainer.TabIndex = 1;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Fournisseur";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.PanelControl pnlContainer;
        private DevExpress.XtraNavBar.NavBarGroup Gestion_Stock;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem Magasin;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem Article;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem Fournisseurr;
        private DevExpress.XtraNavBar.NavBarItem Delai;
        private DevExpress.XtraNavBar.NavBarItem bon_retour;
    }
}