namespace Thuan2180605993.Models.Entites
{
	public class Payment
	{
		public long ID { get; set; }
		public decimal? Payprices { get; set; }
		public long? OrderID { get; set; }
		public Order Order { get; set; }
	}
}
