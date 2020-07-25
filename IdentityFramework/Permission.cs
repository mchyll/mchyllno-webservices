using System;
using System.Collections.Generic;

namespace Mchyll.IdentityFramework
{
    public class Permission
    {
        public string Id { get; set; }

        public Permission(string id)
        {
            Id = id;
        }

        public static implicit operator Permission(string id)
        {
            return new Permission(id);
        }

        public override bool Equals(object obj)
        {
            return obj is Permission permission && string.Equals(Id, permission.Id, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id.ToLower());
        }

        public override string ToString()
        {
            return $"Permission({Id})";
        }
    }
}
