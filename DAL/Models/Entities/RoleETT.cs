using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models.EF;
using System.Data.Entity.Migrations;

namespace UserManager.Models
{
	[Table("Role")]

	public class RoleETT
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(50)]
		public string Name { get; set; }
		[MaxLength(100)]
		public string Description { get; set; }

		public bool Active { get; set; }

		public static void DeleteRoleETT(string name)
		{
			UserManagerContext userManagerContext = new UserManagerContext();
			RoleETT ac = userManagerContext.Role.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
			try
			{
				userManagerContext.Role.Remove(ac);
				userManagerContext.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void InsertRoleETT()
		{
			UserManagerContext context = new UserManagerContext();
			context.Role.AddOrUpdate(this);
			context.SaveChanges();
		}
	}

}
