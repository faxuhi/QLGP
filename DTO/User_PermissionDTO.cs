using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class User_PermissionDTO
	{
		public int UserId { get; set; }
		public int PermissionId { get; set; }
		public User_PermissionDTO()
		{
		}
		public User_PermissionDTO(int userId, int permissionId)
		{
			UserId = userId;
			PermissionId = permissionId;

		}
	}
}
