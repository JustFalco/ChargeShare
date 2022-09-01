using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargeShare.Models
{
	public class User
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		
		[NotNull]
		public string Email { get; set; }

		public long PhoneNumber { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string street { get; set; }
		public string city { get; set; }
		public string Postal { get; set; }
		public string HouseNumber { get; set; }
		public string HouseAddition { get; set; }

		[NotNull]
		public string Password { get; set; }

	}
}
