Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Namespace MasterDetailGrids
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomers As DevExpress.Xpo.XPCollection
		Private splitter1 As System.Windows.Forms.Splitter
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			FillDefault()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.colCustomers = New DevExpress.Xpo.XPCollection()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.colCustomers
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(536, 173)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' colCustomers
			' 
			Me.colCustomers.ObjectType = GetType(MasterDetailGrids.Customer)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colPhone})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableMasterViewMode = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colPhone
			' 
			Me.colPhone.Caption = "Phone"
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 1
			' 
			' gridControl2
			' 
			Me.gridControl2.DataMember = "Orders"
			Me.gridControl2.DataSource = Me.colCustomers
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.Location = New System.Drawing.Point(0, 176)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(536, 198)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.UseEmbeddedNavigator = True
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderDate, Me.colFreight})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsView.ShowGroupPanel = False
			' 
			' colOrderDate
			' 
			Me.colOrderDate.Caption = "OrderDate"
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 0
			' 
			' colFreight
			' 
			Me.colFreight.Caption = "Freight"
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 1
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter1.Location = New System.Drawing.Point(0, 173)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(536, 3)
			Me.splitter1.TabIndex = 2
			Me.splitter1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(536, 374)
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "How to use two XtraGrid controls to display collections of persistent objects wit" & "h a one-to-many association"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub

		Private Sub FillDefault()
			If Session.DefaultSession.FindObject(GetType(Customer), Nothing) IsNot Nothing Then
				Return ' items exist
			End If

			Dim rnd As New Random()

			For i As Integer = 1 To 3
				Dim cust As New Customer()
				cust.Name = "Customer " & i.ToString()
				cust.Phone = String.Format("{0}{0}{0}-{0}0-{0}0", i)
				For j As Integer = 1 To 5
					Dim order As New Order()
					order.OrderDate = DateTime.Today.AddDays(-rnd.Next(20))
					order.Freight = Convert.ToDecimal(Math.Round(rnd.NextDouble() * 1000, 2))
					For k As Integer = 0 To 3
						Dim detail As New OrderDetail()
						detail.Product = String.Format("Product {0}", k)
						detail.Quantity = rnd.Next(10) + 1
						order.Details.Add(detail)
					Next k
					cust.Orders.Add(order)
				Next j
				cust.Save()
			Next i
		End Sub

	End Class
End Namespace