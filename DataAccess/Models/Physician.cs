using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
	public class Physician
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
	}
}
