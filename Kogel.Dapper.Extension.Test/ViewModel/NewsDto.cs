﻿using Kogel.Dapper.Extension.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kogel.Dapper.Extension.Test.ViewModel
{
	public class NewsDto
	{
		[Identity]
		public long Id { get; set; }
	}
}
