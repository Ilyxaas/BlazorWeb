using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorProject.Shared.DataAnnotations
{
	[Table("User", Schema = "public")]
	public class User
	{
		[Key]
		public int ID { get; set; }
		
		public string Login { get; set; }
        
        public string Email { get; set; }
        
        public string HashPassword { get; set; }
	}
}

