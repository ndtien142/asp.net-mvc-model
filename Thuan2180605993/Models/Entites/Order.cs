namespace Thuan2180605993.Models.Entites
{
	public class Order
	{
		public long ID { get; set; }
		public DateTime? Orderdate { get; set; }
		public bool? Deliverystatus { get; set; }
		public DateTime? Deliverydate { get; set; }
		public bool? Status { get; set; }
		public decimal? Totalprice { get; set; }
		public long? CustomerID { get; set; }
		public Customer Customer { get; set; }
	}
}
