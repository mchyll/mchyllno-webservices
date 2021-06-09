using System.Collections.Generic;
using System.Linq;

namespace Mchyll.Identity.Framework
{
    public class Role
    {
        public string Name { get; set; }
        public ISet<Role> ParentRoles { get; set; }
        public ISet<Permission> Permissions { get; set; }

        public Role(string name)
        {
            Name = name;
            ParentRoles = new HashSet<Role>();
            Permissions = new HashSet<Permission>();
        }

        public ISet<Permission> GetAllPermissions()
        {
            return new HashSet<Permission>(ParentRoles.SelectMany(p => p.GetAllPermissions()).Union(Permissions));
        }

        public bool HasPermission(Permission permission)
        {
            return Permissions.Contains(permission) || ParentRoles.Any(p => p.HasPermission(permission));
        }
    }
}
