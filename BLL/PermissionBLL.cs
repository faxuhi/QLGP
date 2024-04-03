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
	public class PermissionBLL
	{
		private readonly PermissionDAL permissionDAL;
		public PermissionBLL()
		{
			permissionDAL = new PermissionDAL();
		}

		public List<PermissionETT> GetPermissionBLL()
		{
			return permissionDAL.GetPermissionDAL();
		}

		public static void InsertPermissionBLL(PermissionDTO a)
		{
			PermissionDAL.InsertPermissionDAL(a);
		}

		public static void Delete(string name)
		{
			PermissionETT.DeletePermissionETT(name);
		}

		public void UpdatePermissionBLL( string name)
		{
			permissionDAL.UpdatePermissionDAL(name);
		}
	}
}
