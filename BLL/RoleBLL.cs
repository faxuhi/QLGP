using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models;

namespace BLL
{
	public class RoleBLL
	{
		private readonly RoleDAL roleDAL;
		public RoleBLL()
		{
			roleDAL = new RoleDAL();
		}

		public List<RoleETT> GetRoleBLL()
		{
			return roleDAL.GetRoleDAL();
		}

		public static void InsertRoleBLL(RoleDTO a)
		{
			RoleDAL.InsertRoleDAL(a);
		}

		public static void Delete(string name)
		{
			RoleETT.DeleteRoleETT(name);
		}

		public void UpdateRoleBLL( int id,string name, string description, bool active)
		{
			roleDAL.UpdateRoleDAL(id, name, description, active);
		}
	}
}
