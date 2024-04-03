using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.Entities
{
	[Table("User_Permission")]
	public class User_PermissionETT
	{
		[Key]
		[Column(Order = 0)]
		public int UserId { get; set; }

		[ForeignKey("UserId")]
		public virtual UserETT User { get; set; }

		[Key]
		[Column(Order = 1)]
		public int PermissionId { get; set; }

		[ForeignKey("PermissionId")]
		public virtual PermissionETT Permission { get; set; }
	}
}
