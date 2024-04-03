using DAL.Models.Validate;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Entities
{
	public class UserValidateETT : UserEntityValidator
	{
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
		public string UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[MinLength(6, ErrorMessage = "Mật khẩu phải ít nhất 6 ký tự")]
		[MaxLength(100, ErrorMessage = "Mật khẩu giới hạn dưới 100 ký tự")]
		public string Password { get; set; }

		[Display(Name = "Họ và Tên")]
		[StringLength(50, ErrorMessage = "Name không được quá 50 ký tự")]
		[RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Name không được dùng ký tự đặc biệt")]
		public string Name { get; set; }

		[DataType(DataType.DateTime, ErrorMessage = "Định dạng Ngày Tháng Năm")]
		public DateTime? Birthday { get; set; }

		[Required]
		[RegularExpression(@"((^(\+84|84|0|0084){1})(3|5|7|8|9))+([0-9]{8})$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
		public string Phone { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Phải đúng định dạng Email")]
		public string Email { get; set; }

		[StringLength(250)]
		public string Intro { get; set; }
	}
	public class UserEditValidateETT : UserEntityValidator
	{
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
		public string UserName { get; set; }

		//[Required]
		//[DataType(DataType.Password)]
		//[MinLength(6, ErrorMessage = "Mật khẩu phải ít nhất 6 ký tự")]
		//[MaxLength(100, ErrorMessage = "Mật khẩu giới hạn dưới 100 ký tự")]
		//public string Password { get; set; }
		public int RoleId { get; set; }

		[Display(Name = "Họ và Tên")]
		[StringLength(50, ErrorMessage = "Name không được quá 50 ký tự")]
		[RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Name không được dùng ký tự đặc biệt")]
		public string Name { get; set; }

		[DataType(DataType.DateTime, ErrorMessage = "Định dạng Ngày Tháng Năm")]
		public DateTime? Birthday { get; set; }

		[Required]
		[RegularExpression(@"((^(\+84|84|0|0084){1})(3|5|7|8|9))+([0-9]{8})$", ErrorMessage = "UserName không được dùng ký tự đặc biệt")]
		public string Phone { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Phải đúng định dạng Email")]
		public string Email { get; set; }

		[StringLength(250)]
		public string Intro { get; set; }
	}
}
