namespace Thuan2180605993.Models.Entites
{
	public class Item
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public decimal? PurcharsePrice { get; set; }
		public decimal SellPrice { get; set; }
		public DateTime? DateImport { get; set; }
		public int? Quantity { get; set; }
		public long? TypeID { get; set; }
		public long? BrandID { get; set; }
		public string Picture { get; set; }
		public bool? Active { get; set; }
		public string ShortTitle { get; set; }
		public string Describe { get; set; }

		public Brand Brand { get; set; }
		public ItemType ItemType { get; set; }
	}
}
