using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models.EF;

namespace UserManager.Models
{
	[Table("Permission")]

	public class PermissionETT
	{
		[Key]
        public int Id { get; set; }
		[MaxLength(50)]
		public string Name { get; set; }

		public static void DeletePermissionETT(string name)
		{
			UserManagerContext userManagerContext = new UserManagerContext();
			PermissionETT ac = userManagerContext.Permission.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
			try
			{
				userManagerContext.Permission.Remove(ac);
				userManagerContext.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void InsertPermissionETT()
		{
			UserManagerContext context = new UserManagerContext();
			context.Permission.AddOrUpdate(this);
			context.SaveChanges();
		}
	}
}
