﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPoC.DAL.Entities
{
	public class Class
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Teacher Teacher { get; set; }
	}
}
