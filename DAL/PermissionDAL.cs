using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models.EF;
using UserManager.Models;

namespace DAL
{
	public class PermissionDAL
	{
		private readonly UserManagerContext userManagerContext;
		public PermissionDAL()
		{
			userManagerContext = new UserManagerContext();
		}

		public List<PermissionETT> GetPermissionDAL()
		{
			return userManagerContext.Permission.ToList();
		}

		public static void InsertPermissionDAL(PermissionDTO PermissionDTO)
		{
			PermissionETT Permission = new PermissionETT();
			Permission.Name = PermissionDTO.Name;
			Permission.InsertPermissionETT();
		}


		public void UpdatePermissionDAL(string name)
		{
			PermissionETT Permission = userManagerContext.Permission.SingleOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
			Permission.Name = name;
			userManagerContext.SaveChanges();
		}
	}
}
