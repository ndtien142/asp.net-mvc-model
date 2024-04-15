namespace Thuan2180605993.Models.Entites
{
	public class Brand
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public long? MenuID { get; set; }

		public Menu Menu { get; set; }
	}
}
