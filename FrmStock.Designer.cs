namespace GestionMagasins
{
    partial class FrmStock
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gcStock = new DevExpress.XtraGrid.GridControl();
            this.artStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.articlee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qtee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mode_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prix_achat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Stock = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.gcStock);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(965, 638);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 20);
            this.panel1.TabIndex = 18;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(160, 50);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(787, 26);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 13;
            // 
            // gcStock
            // 
            this.gcStock.DataSource = this.artStockBindingSource;
            this.gcStock.Location = new System.Drawing.Point(37, 91);
            this.gcStock.MainView = this.gvStock;
            this.gcStock.Name = "gcStock";
            this.gcStock.Size = new System.Drawing.Size(891, 500);
            this.gcStock.TabIndex = 11;
            this.gcStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStock});
            // 
            // artStockBindingSource
            // 
            this.artStockBindingSource.DataSource = typeof(GestionMagasins.Art_Stock);
            // 
            // gvStock
            // 
            this.gvStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.articlee,
            this.qtee,
            this.mode_stock,
            this.prix_achat});
            this.gvStock.GridControl = this.gcStock;
            this.gvStock.Name = "gvStock";
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.FieldName = "Id_ligne";
            this.id.Name = "id";
            // 
            // articlee
            // 
            this.articlee.Caption = "Article";
            this.articlee.FieldName = "Id_Article";
            this.articlee.Name = "articlee";
            this.articlee.Visible = true;
            this.articlee.VisibleIndex = 0;
            // 
            // qtee
            // 
            this.qtee.Caption = "Qte";
            this.qtee.FieldName = "Qte";
            this.qtee.Name = "qtee";
            this.qtee.Visible = true;
            this.qtee.VisibleIndex = 2;
            // 
            // mode_stock
            // 
            this.mode_stock.Caption = "Mode Stock";
            this.mode_stock.FieldName = "Mode_Stock";
            this.mode_stock.Name = "mode_stock";
            this.mode_stock.Visible = true;
            this.mode_stock.VisibleIndex = 1;
            // 
            // prix_achat
            // 
            this.prix_achat.Caption = "Prix d\'achat";
            this.prix_achat.FieldName = "Prix_achat";
            this.prix_achat.Name = "prix_achat";
            this.prix_achat.Visible = true;
            this.prix_achat.VisibleIndex = 3;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(935, 32);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.Stock});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(965, 638);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 598);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(935, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.panel1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(935, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // Stock
            // 
            this.Stock.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.Stock.Location = new System.Drawing.Point(0, 26);
            this.Stock.Name = "Stock";
            this.Stock.OptionsItemText.TextToControlDistance = 5;
            this.Stock.Size = new System.Drawing.Size(935, 572);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcStock;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(897, 506);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 638);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gcStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStock;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn articlee;
        private DevExpress.XtraGrid.Columns.GridColumn qtee;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn mode_stock;
        private DevExpress.XtraGrid.Columns.GridColumn prix_achat;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.LayoutControlGroup Stock;
        private System.Windows.Forms.BindingSource artStockBindingSource;
    }
}