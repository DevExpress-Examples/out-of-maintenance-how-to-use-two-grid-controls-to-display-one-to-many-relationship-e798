using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;

namespace MasterDetailGrids
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Xpo.XPCollection colCustomers;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            FillDefault();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.colCustomers = new DevExpress.Xpo.XPCollection();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.colCustomers;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(536, 173);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // colCustomers
            // 
            this.colCustomers.ObjectType = typeof(MasterDetailGrids.Customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPhone});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Orders";
            this.gridControl2.DataSource = this.colCustomers;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 176);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(536, 198);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderDate,
            this.colFreight});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "OrderDate";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 0;
            // 
            // colFreight
            // 
            this.colFreight.Caption = "Freight";
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 173);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(536, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(536, 374);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "How to use two XtraGrid controls to display collections of persistent objects wit" +
                "h a one-to-many association";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        void FillDefault()
        {
            if (Session.DefaultSession.FindObject(typeof(Customer), null) != null)
                return;  // items exist

            Random rnd = new Random();

            for (int i = 1; i <= 3; i++)
            {
                Customer cust = new Customer();
                cust.Name = "Customer " + i.ToString();
                cust.Phone = string.Format("{0}{0}{0}-{0}0-{0}0", i);
                for (int j = 1; j <= 5; j++)
                {
                    Order order = new Order();
                    order.OrderDate = DateTime.Today.AddDays(-rnd.Next(20));
                    order.Freight = Convert.ToDecimal(Math.Round(rnd.NextDouble() * 1000, 2));
                    for (int k = 0; k < 4; k++)
                    {
                        OrderDetail detail = new OrderDetail();
                        detail.Product = string.Format("Product {0}", k);
                        detail.Quantity = rnd.Next(10) + 1;
                        order.Details.Add(detail);
                    }
                    cust.Orders.Add(order);
                }
                cust.Save();
            }
        }

    }
}