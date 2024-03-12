using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Client
{
	public enum Gender
	{
		Man = 1,
        Woman = 2
    }


    public class RegistrationForms
	{
        public RegistrationForms()
        {

        }
        
        public string? ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string? Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string? LastName { get; set; }

        [Required]        
        public string? email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string? login { get; set; }

        [StringLength(20, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }

        [StringLength(20, MinimumLength = 8)]
        [Required]
        public string? PasswordRepetition { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public DateTime Time { get; set; }

    }
}

