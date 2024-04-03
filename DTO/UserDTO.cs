using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class UserDTO
	{
	//	public int Id { get; set; }
		public int? RoleId { get; set; }
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public string Name { get; set; }
		public DateTime? Birthday { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public DateTime? RegisteredDate { get; set; }
		public bool IsOnline { get; set; }
		public DateTime? LastLogin { get; set; }
		public string Intro { get; set; }
		
		
		public UserDTO()
		{ 
		}
		public UserDTO( int roleId, 	string userName, 	string passWord, 	string name, 	DateTime birthday, 	string phone, 	string email, 
			DateTime registeredDate, 	bool isOnline, 	DateTime lastLogin, 	string intro)
		{
			RoleId = roleId;
			UserName = userName; 
			PassWord = passWord; 
			Name = name; 
			Birthday = birthday;
			Phone = phone; 
			Email = email; 
			RegisteredDate = registeredDate; 
			IsOnline = isOnline; 
			LastLogin = lastLogin;
			Intro = intro;
		}
	}
	
}
