﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
	public virtual string title
	{
		get;
		set;
	}

	public virtual IEnumerable<Author> Author
	{
		get;
		set;
	}

}

