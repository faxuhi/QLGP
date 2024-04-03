using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UserManager.Models;
using UserManager.Models.EF;

namespace DAL
{

	public class UserDAL
	{
		private readonly UserManagerContext db;
		public UserDAL()
		{
			db = new UserManagerContext();
		}
		public List<UserCustomViewETT> GetUsersDAL()
		{

			var UserList = from u in db.User
						   orderby u.Id descending
						   select new UserCustomViewETT()
						   {
							   UserName = u.UserName,
							   RoleName = u.Role.Name,
							   Name = u.Name,
							   Birthday = u.Birthday.Value,
							   Phone = u.Phone,
							   Email = u.Email,
						   };
			var result = UserList.ToList();//.AsEnumerable();
			return result;

		}
		public List<UserCustomViewETT> GetUsersDAL(int pageNum, int pageRecord)
		{
			var UserList = from u in db.User
						   orderby u.Id descending
						   select new UserCustomViewETT()
						   {
							   UserName = u.UserName,
							   RoleName = u.Role.Name,
							   Name = u.Name,
							   Birthday = u.Birthday.Value,
							   Phone = u.Phone,
							   Email = u.Email,
						   };
			var result = UserList.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();//.AsEnumerable();
			return result;

		}
		public List<UserCustomViewETT> GetUsersDAL(string searchText, object Option)
		{

			IEnumerable<UserCustomViewETT> UserList = from u in db.User
													  orderby u.Id descending
													  select new UserCustomViewETT()
													  {
														  UserName = u.UserName,
														  RoleName = u.Role.Name,
														  Name = u.Name,
														  Birthday = u.Birthday.Value,
														  Phone = u.Phone,
														  Email = u.Email,
													  };
			switch (Option)
			{
				case "All":
					UserList = UserList.Where(
							u => u.UserName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1 ||
						   (u.Name != null && u.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1) ||
						   (u.RoleName != null && u.RoleName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1) ||
							u.Phone.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1 ||
							u.Email.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1
							);
					break;
				case "UserName":

					UserList = UserList.Where(u => u.UserName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1);
					break;
				case "RoleName":
					UserList = UserList.Where(u => (u.RoleName != null && u.RoleName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1));
					break;
				case "Name":
					UserList = UserList.Where(u => (u.Name != null && u.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1));
					break;
				case "Phone":
					UserList = UserList.Where(u => u.Phone.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1);
					break;
				case "Email":
					UserList = UserList.Where(u => u.Email.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1);
					break;
			}
			var result = UserList.ToList();//.AsEnumerable();
			return result;

		}
		public int CountRecordsDAL()
		{
			//var UserList =  db.User;
			var result = db.User.Count();// ToList();//.AsEnumerable();
			return result;
		}
		//DataTime DataTime?
		public List<UserETT> FindNameDAL(string userName)
		{
			return db.User.Where(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)).AsNoTracking().ToList();
		}

		public static void InsertUserDAL(UserDTO UserDTO)
		{
			UserETT User = new UserETT();
			//User.Id = UserDTO.Id;
			User.RoleId = UserDTO.RoleId;
			User.UserName = UserDTO.UserName;
			User.PassWord = UserDTO.PassWord;
			User.Name = UserDTO.Name;
			User.Birthday = UserDTO.Birthday;
			User.Phone = UserDTO.Phone.ToString();
			User.Email = UserDTO.Email;
			User.RegisteredDate = UserDTO.RegisteredDate;
			User.IsOnline = UserDTO.IsOnline;
			User.LastLogin = UserDTO.LastLogin;
			User.Intro = UserDTO.Intro;
			User.InsertUserETT();
		}

		public void UpdateOnlineDAL(string userName, bool isOnline)
		{
			UserETT User = db.User.SingleOrDefault(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));
			User.IsOnline = isOnline;
			db.SaveChanges();
		}

		public void LastLoginDAL(string userName)
		{
			UserETT User = db.User.SingleOrDefault(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));
			User.LastLogin = DateTime.UtcNow;
			db.SaveChanges();
		}
		public void UpdateUserDAL(UserDTO UserDTO)
		{
			UserETT User = db.User.SingleOrDefault(u => u.UserName.Equals(UserDTO.UserName, StringComparison.OrdinalIgnoreCase));
			User.RoleId = UserDTO.RoleId;
			//User.PassWord = passWord;
			User.Name = UserDTO.Name;
			User.Birthday = UserDTO.Birthday;//?? defaultDate;//??  DBNull.Value;
			User.Phone = UserDTO.Phone.ToString();
			User.Email = UserDTO.Email;
			User.Intro = UserDTO.Intro;
			db.SaveChanges();
		}
		public int CheckUserNameDAL(string userName)
		{
			var count = db.User.Count(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));
			return count;
		}
		public int CheckPhoneDAL(string phone)
		{
			var count = db.User.Count(u => u.Phone == phone);
			return count;
		}
		public int CheckChinSoCuoiPhoneDAL(string chinSoCuoiPhone)
		{
			var count = db.User.Count(u => u.Phone.EndsWith(chinSoCuoiPhone));
			return count;
		}
		public int CheckEmailDAL(string email)
		{
			var count = db.User.Count(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
			return count;
		}
		public bool CheckLoginDAL(string userName, string passWord)
		{
			try
			{
				return db.User.Any(u => u.UserName == userName && u.PassWord == passWord);
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool CheckUserOnlineDAL(string userName)
		{
			try
			{
				return db.User.Any(u => u.UserName == userName && u.IsOnline == true);
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool CheckPermissionDAL(string userName, string permission)
		{
			var permissionId = db.Permission.Where(p => p.Name.Equals(permission, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Id;
			var userId = db.User.Where(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Id;
			var roleId = db.User.Where(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().RoleId;

			var checkUserPermission = db.User_Permission.Any(up => up.UserId == userId && up.PermissionId == permissionId);
			var checkRolePermission = db.Role_Permission.Any(rp => rp.RoleId == roleId && rp.PermissionId == permissionId);

			if (checkUserPermission == true || checkRolePermission == true)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

	}

}
