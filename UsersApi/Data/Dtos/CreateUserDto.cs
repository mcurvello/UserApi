using System;
using System.ComponentModel.DataAnnotations;

namespace UsersApi.Data.Dtos
{
	public class CreateUserDto
	{
		[Required]
		public string Username { get; set; }

		[Required]
		public DateTime Birthdate { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[Compare("Password")]
		public string RePassword { get; set; }
	}
}

