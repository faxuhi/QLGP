using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models.EF;

namespace UserManager.Models
{
	[Table("User")]
	public  class UserETT
	{
        [Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public int? RoleId { get; set; }
		[ForeignKey("RoleId")]
		public virtual RoleETT Role { get; set; }

		[Required]
		[MaxLength(50)]
		public string UserName { get; set; }

		[Required]
		[MaxLength(250),MinLength(6, ErrorMessage="Mật khẩu phải ít nhất 6 ký tự")]
		public string PassWord { get; set; }

		[MaxLength(50)]
		public string Name { get; set; }

		public DateTime? Birthday { get; set; }

	//	[Index(IsUnique = true)]
		[Required]
		[MaxLength(50)]
		public string Phone { get; set; }

	//	[Index(IsUnique = true)]
		[Required]
		[MaxLength(50)]
		public string Email { get; set; }

	//	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime? RegisteredDate { get; set; }

		public bool IsOnline { get; set; }

        public DateTime? LastLogin { get; set; }

		[MaxLength(100)]
		public string Intro { get; set; }

		public static void DeleteUserETT(string userName)
		{
			UserManagerContext userManagerContext = new UserManagerContext();
			UserETT ac = userManagerContext.User.Where(p => p.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
			try
			{
				userManagerContext.User.Remove(ac);
				userManagerContext.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void InsertUserETT()
		{
			UserManagerContext context = new UserManagerContext();
			context.User.AddOrUpdate(this);
			context.SaveChanges();
		}

	}
	public class UserCustomViewETT
	{
		public UserCustomViewETT() { }
			[Required]
		public string UserName { get; set; }
		public string RoleName { get; set; }
		public string Name { get; set; }
		public DateTime? Birthday { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}
	//public class UserSignUpETT
	//{
	//	[Required]
	//	[RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
	//	public string UserName { get; set; }

	//	[Required]
	//	[MinLength(6, ErrorMessage = "Mật khẩu phải ít nhất 6 ký tự")]
	//	[MaxLength(100, ErrorMessage = "Mật khẩu giới hạn dưới 100 ký tự")]
	//	//[RegularExpression(@"^.{6,}$", ErrorMessage = "Mật khẩu ít nhất có 6 ký tự")]
	//	public string Password { get; set; }

	//	[StringLength(50, ErrorMessage = "Name không được quá 50 ký tự")]
	//	[RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Name không được dùng ký tự đặc biệt")]
	//	public string Name { get; set; }

	//	public DateTime? Birthday { get; set; }

	//	[Required]
	//	[RegularExpression(@"((^(\+84|84|0|0084){1})(3|5|7|8|9))+([0-9]{8})$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
	//	public string Phone { get; set; }

	//	[Required]
	//	[EmailAddress(ErrorMessage = "Phải đúng định dạng Email")]
	//	public string Email { get; set; }

	//	[StringLength(250)]
	//	public string Intro { get; set; }
	//}
}
