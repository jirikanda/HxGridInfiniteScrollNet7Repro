﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore;
using Havit.Data.EntityFrameworkCore.Patterns.DataSources;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;

namespace Havit.GoranG3.DataLayer.DataSources.Attrida
{
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public partial class AttridaTagDbDataSource : DbDataSource<Havit.GoranG3.Model.Attrida.AttridaTag>, IAttridaTagDataSource
	{
		public AttridaTagDbDataSource(IDbContext dbContext, ISoftDeleteManager softDeleteManager)
			: base(dbContext, softDeleteManager)
		{
		}
	}
}