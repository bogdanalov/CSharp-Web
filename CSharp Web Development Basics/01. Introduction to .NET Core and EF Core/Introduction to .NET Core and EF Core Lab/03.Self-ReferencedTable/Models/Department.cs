﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _03.Self_ReferencedTable
{
    public class Department
    {
	    public int Id { get; set; }

		[Required]
		[MaxLength(50)]
	    public string Name { get; set; }

	    public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
