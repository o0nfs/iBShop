using IBshopDemo.Enums;
using IBshopDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace IBshopDemo.Initializer
{
	public static class IBshopInitializer
	{
		public static void Initialize(TestHadadianContext db)
		{
			_createRoles(db);
		}

		private static List<int> _createRoles(TestHadadianContext db)
		{

			List<Role> roles = new List<Role>();
			foreach (var i in Enum.GetValues(typeof(Roles)))
			{
				if (!db.Roles.Any(a => a.RoleUniqeCode == (int)i))
				{
					var role = new Role();
					role.RoleUniqeCode = (int)i;
					role.RoleName = i.ToString().Replace("_"," ");
					roles.Add(role);
				}
			}


			db.AddRange(roles);
			db.SaveChanges();

			return roles.Select(x => x.RoleId).ToList();
		}
		//private static int  _userCreator(TestHadadianContext db)
		//{

		//}

	}
}
