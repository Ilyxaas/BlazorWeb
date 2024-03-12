using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Client
{
	public class AuthorizationForms
	{
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string? login { get; set; }


        [StringLength(20, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }

        public AuthorizationForms()
		{

		}
	}
}

