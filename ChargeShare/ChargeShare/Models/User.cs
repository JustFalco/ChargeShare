﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargeShare.Models
{
	public class User
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
