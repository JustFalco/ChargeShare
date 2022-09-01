using System;
using System.Collections.Generic;
using System.Text;

namespace ChargeShare.Models
{
	public class ChargeStation
	{
		public int Id { get; set; }
		public int PricePerHour { get; set; }
		public string Description { get; set; }
	}
}
