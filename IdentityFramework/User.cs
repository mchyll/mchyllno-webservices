using System.Collections.Generic;
using System.Linq;

namespace Mchyll.IdentityFramework
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public ISet<Role> Roles { get; set; }

        public User()
        {
            Roles = new HashSet<Role>();
        }

        public ISet<Permission> GetAllPermissions()
        {
            return new HashSet<Permission>(Roles.SelectMany(p => p.GetAllPermissions()));
        }

        public bool HasPermission(Permission permission)
        {
            return Roles.Any(p => p.HasPermission(permission));
        }
    }
}
