using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PermissionDTO
	{
		public string Name { get; set; }

		public PermissionDTO()
		{
		}
		public PermissionDTO(string name)
		{
			//Id = id;
			Name = name;
		}
	}
}
