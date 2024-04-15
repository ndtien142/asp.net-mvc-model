using System.ComponentModel.DataAnnotations;

namespace Thuan2180605993.Models.Entites
{
	public class Admin
	{
		public string Username { get; set; }
		[DataType(DataType.Password)]
		public string Passwords { get; set; }
		public string Name { get; set; }
		public string Picture { get; set; }
	}
}
