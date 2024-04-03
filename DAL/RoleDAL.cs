using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UserManager.Models;
using UserManager.Models.EF;

namespace DAL
{
	public class RoleDAL
	{
		private readonly UserManagerContext userManagerContext;
		public RoleDAL()
		{
			userManagerContext = new UserManagerContext();
		}

		public List<RoleETT> GetRoleDAL()
		{
			return userManagerContext.Role.Where(u => u.Active == true).ToList();


		}

		public static void InsertRoleDAL(RoleDTO RoleDTO)
		{
			RoleETT Role = new RoleETT();
			//Role.Id = RoleDTO.Id;
			Role.Name = RoleDTO.Name;
			Role.Description = RoleDTO.Description;
			Role.Active = RoleDTO.Active;
			Role.InsertRoleETT();
		}


		public void UpdateRoleDAL(int id, string name, string description, bool active)
		{
			RoleETT Role = userManagerContext.Role.SingleOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
			Role.Id = id;
			Role.Name = name;
			Role.Description = description;
			Role.Active = active;
			userManagerContext.SaveChanges();
		}


	}
}
