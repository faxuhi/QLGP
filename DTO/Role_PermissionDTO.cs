using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Role_PermissionDTO
	{
		public int RoleId { get; set; }
		public int PermissionId { get; set; }
		public Role_PermissionDTO()
		{
		}
		public Role_PermissionDTO(int roleId, int permissionId)
		{
			RoleId = roleId;
			PermissionId = permissionId;

		}
	}
}
