namespace Thuan2180605993.Models.Entites
{
	public class OrderDetail
	{
		public long ID { get; set; }
		public int Quantity { get; set; }
		public long? ItemId { get; set; }
		public long? OrderID { get; set; }
		public decimal? Totalprice { get; set; }

		public Item Item { get; set; }
		public Order Order { get; set; }
	}
}
