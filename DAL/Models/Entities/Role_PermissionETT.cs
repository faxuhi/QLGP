using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
	[Table("Role_Permission")]

	public class Role_PermissionETT
	{
		[Key]
		[Column(Order = 1)]
		public int RoleId { get; set; }

		[ForeignKey("RoleId")]
		public virtual RoleETT Role { get; set; }

		[Key]
		[Column(Order = 2)]
		public int PermissionId { get; set; }

		[ForeignKey("PermissionId")]
		public virtual PermissionETT Permission { get; set; }
	}
}
