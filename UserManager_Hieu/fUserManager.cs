using BLL;
using System;
using System.Windows.Forms;


namespace UserManager_Hieu
{
	public partial class fUserManager : Form
	{
		UserBLL userBLL = new UserBLL();
		//userName1 = fLogin.Sender
		//public static string userName = lblHello.Text;
		public delegate void SendUserName(String userName);
		public fUserManager()
		{
			InitializeComponent();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			//'check is-admin
			fUsers fUsers = new fUsers();
			this.Hide();
			fUsers.ShowDialog();
			this.Show();
		}

		private void fUserManager_Load(object sender, EventArgs e)
		{
			var currentUser = Properties.Settings.Default.CurrentUser;//nếu set bằng null thì tắt form sẽ reset login
			SetValue(currentUser);
		}

		private void btnLogInOut_Click(object sender, EventArgs e)
		{
			fLogin fLogin = new fLogin(SetValue);
			//fLogin.Sender = GetUserName;
			//this.Hide();
			fLogin.ShowDialog();
			//this.Show();
		}
		public void SetValue(String value)// test delegate - trong trường hợp này dùng Properties.Settings.Default.CurrentUser; cho khỏe
		{
			lblHello.Text = value;
			foreach (Control ctrl in grbAdmin.Controls)
			{
				ctrl.Enabled = false;
			}
			foreach (Control ctrl in grbManagement.Controls)
			{
				ctrl.Enabled = false;
			}
			foreach (Control ctrl in pnlSetting.Controls)
			{
				if (ctrl == btnLogInOut)
				{
					ctrl.Enabled = true;
				}
				else
				{
					ctrl.Enabled = false;
				}
			}
			if (userBLL.CheckUserNameBLL(value) == 0)// tránh trường hợp sửa file lưu Properties trên máy
			{
				lblHello.Text = "";
				Properties.Settings.Default.CurrentUser = "";
				Properties.Settings.Default.Save();
			}
			if (!String.IsNullOrEmpty(value) && userBLL.CheckUserNameBLL(value) != 0)
			{
				if (userBLL.CheckPermissionBLL(value, "View Users") == true) btnUsers.Enabled = true;
				if (userBLL.CheckPermissionBLL(value, "View Roles") == true) btnRoles.Enabled = true;
				if (userBLL.CheckPermissionBLL(value, "View Permissions") == true) btnPermissions.Enabled = true;
				if (userBLL.CheckPermissionBLL(value, "View Settings") == true) ;
				btnPersonalInfo.Enabled = true;
				btnSettings.Enabled = true;
			}

		}
		private void btnRoles_Click(object sender, EventArgs e)
		{
			fRole fRole = new fRole();
			this.Hide();
			fRole.ShowDialog();
			this.Show();
		}

		private void btnPermissons_Click(object sender, EventArgs e)
		{
			fPermission fPermission = new fPermission();
			this.Hide();
			fPermission.ShowDialog();
			this.Show();
		}

		private void btnPersonalInfo_Click(object sender, EventArgs e)
		{
			fUser fUser = new fUser();
			this.Hide();
			fUser.ShowDialog();
			this.Show();
		}

		private void btnMembers_Click(object sender, EventArgs e)
		{
			////test test = new test();
			////this.Hide();
			////test.ShowDialog();
			////this.Show();
		}

		private void grbAdmin_EnabledChanged(object sender, EventArgs e)
		{
		}

		private void fUserManager_Shown(object sender, EventArgs e)
		{


		}

	}
}
