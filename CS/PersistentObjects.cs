namespace MasterDetailGrids {
    using System;
    using DevExpress.Xpo;
    
	public class Customer : XPObject {
		public string Name;
		public string Phone;
		[Association("CustomerOrders", typeof(Order)), Aggregated]
		public XPCollection Orders { 
			get {
				return GetCollection("Orders");
			}
		}
	}
	public class Order : XPObject {
		public DateTime OrderDate;
		public decimal Freight;
		[Association("CustomerOrders")]
		public Customer Customer;
		[Association("OrderDetails", typeof(OrderDetail)), Aggregated]
		public XPCollection Details { 
			get {
				return GetCollection("Details");
			}
		}
	}
	public class OrderDetail : XPObject {
		public string Product;
        public int Quantity;
		[Association("OrderDetails")]
		public Order Order;
	}
}
