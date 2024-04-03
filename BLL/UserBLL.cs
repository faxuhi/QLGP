using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using UserManager.Models;

namespace BLL
{
	public class UserBLL
	{
		private readonly UserDAL userDAL;
		public UserBLL()
		{
			userDAL = new UserDAL();
		}

		public List<UserCustomViewETT> GetUsersBLL(string searchText, object Option)
		{
			return userDAL.GetUsersDAL(searchText, Option);
		}
		public List<UserCustomViewETT> GetUsersBLL(int pageNum, int pageRecord)
		{
			return userDAL.GetUsersDAL(pageNum, pageRecord);
		}
		public List<UserCustomViewETT> GetUsersBLL()
		{
			return userDAL.GetUsersDAL();
		}
		public static void InsertUserBLL(UserDTO a)
		{
			UserDAL.InsertUserDAL(a);
		}

		public List<UserETT> FindNameBLL(string userName)
		{
			return userDAL.FindNameDAL(userName);
		}

		public static void DeleteUserBLL(string userName)
		{
			UserETT.DeleteUserETT(userName);
		}

		public void UpdateUserBLL(UserDTO a)
		{
			userDAL.UpdateUserDAL(a);
		}
		public void UpdateOnlineBLL(string userName, bool isOnline)
		{
			userDAL.UpdateOnlineDAL(userName, isOnline);
		}
		public void LastLoginBLL(string userName)
		{
			userDAL.LastLoginDAL(userName);
		}
		public bool CheckLoginBLL(string userName, string passWord)
		{
			return userDAL.CheckLoginDAL(userName, passWord);
		}
		public bool CheckUserOnlineBLL(string userName)
		{
			return userDAL.CheckUserOnlineDAL(userName);
		}
		public int CheckUserNameBLL(string userName)
		{
			return userDAL.CheckUserNameDAL(userName);
		}
		public int CheckEmailBLL(string email)
		{
			return userDAL.CheckEmailDAL(email);
		}
		public int CheckChinSoCuoiPhoneBLL(string phone)
		{
			var chinSoCuoiPhone = phone.Substring(phone.Length - 9);
			return userDAL.CheckChinSoCuoiPhoneDAL(chinSoCuoiPhone);
		}
		public string CheckInfoSignUp(string phone, string userName, string email, string password, string confirmPassword)
		{
			var chinSoCuoiPhone = phone.Substring(phone.Length - 9);
			if (userDAL.CheckChinSoCuoiPhoneDAL(chinSoCuoiPhone) != 0)//CheckPhoneDAL(phone) == 1) // 
			{
				return "phoneNumber_da_dangky";
			}
			if (userDAL.CheckUserNameDAL(userName) == 1)
			{
				return "userName_da_dangky";
			}
			if (userDAL.CheckEmailDAL(email) == 1)
			{
				return "email_da_dangky";
			}
			if (password != confirmPassword)
			{
				return "confirmPassword";
			}
			return "OK";
		}
		public string CheckInfoEdit(string phone, string userName, string email)
		{
			var chinSoCuoiPhone = phone.Substring(phone.Length - 9);
			if (userDAL.CheckChinSoCuoiPhoneDAL(chinSoCuoiPhone) != 0 && userDAL.FindNameDAL(userName).FirstOrDefault().Phone != phone)//CheckPhoneDAL(phone) == 1) // 
			{
				return "phoneNumber_da_dangky";
			}
			//if (userDAL.CheckUserNameDAL(userName) == 1)
			//{
			//	return "userName_da_dangky";
			//}
			if (userDAL.CheckEmailDAL(email) == 1 && userDAL.FindNameDAL(userName).FirstOrDefault().Email != email)
			{
				return "email_da_dangky";
			}
			return "OK";
		}

		public bool CheckPermissionBLL(string userName, string permission)
		{
			return userDAL.CheckPermissionDAL(userName, permission);
		}
		public int CountRecordsBLL()
		{
			return userDAL.CountRecordsDAL();
		}
	}
}
