namespace Thuan2180605993.Models.Entites
{
	public class ItemType
	{
		public long ID { get; set; }
		public string TypeName { get; set; }
		public long? MenuID { get; set; }
		public Menu Menu { get; set; }
	}
}
