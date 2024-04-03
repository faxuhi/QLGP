using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models.Entities;

namespace UserManager.Models.EF
{
	public  class UserManagerContext:DbContext
	{
		public UserManagerContext() : base(@"Server=HIEUPHAM\SQLEXPRESS;Database=UserManager;Integrated Security=True;") 
		{
		}
		public DbSet<UserETT> User { get; set; }
		public DbSet<RoleETT> Role { get; set; }
		public DbSet<PermissionETT> Permission { get; set; }
		public DbSet<Role_PermissionETT> Role_Permission { get; set; }
		public DbSet<User_PermissionETT> User_Permission { get; set; }
		


	}
}
