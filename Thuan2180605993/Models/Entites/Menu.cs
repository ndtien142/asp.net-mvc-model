namespace Thuan2180605993.Models.Entites
{
	public class Menu
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }

		public ICollection<Brand> Brands { get; set; }
		public ICollection<ItemType> ItemTypes { get; set; }
	}
}
