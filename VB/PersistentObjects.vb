Imports Microsoft.VisualBasic
	Imports System
	Imports DevExpress.Xpo
Namespace MasterDetailGrids

	Public Class Customer
		Inherits XPObject
		Public Name As String
		Public Phone As String
		<Association("CustomerOrders", GetType(Order)), Aggregated> _
		Public ReadOnly Property Orders() As XPCollection
			Get
				Return GetCollection("Orders")
			End Get
		End Property
	End Class
	Public Class Order
		Inherits XPObject
		Public OrderDate As DateTime
		Public Freight As Decimal
		<Association("CustomerOrders")> _
		Public Customer As Customer
		<Association("OrderDetails", GetType(OrderDetail)), Aggregated> _
		Public ReadOnly Property Details() As XPCollection
			Get
				Return GetCollection("Details")
			End Get
		End Property
	End Class
	Public Class OrderDetail
		Inherits XPObject
		Public Product As String
		Public Quantity As Integer
		<Association("OrderDetails")> _
		Public Order As Order
	End Class
End Namespace
