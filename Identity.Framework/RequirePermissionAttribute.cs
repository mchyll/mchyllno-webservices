using System;
using System.Collections.Generic;

namespace Mchyll.Identity.Framework
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public sealed class RequirePermissionAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236

        // This is a positional argument
        public RequirePermissionAttribute(params string[] requiredPermissions)
        {
            RequiredPermissions = new List<Permission>(requiredPermissions);
        }

        public List<Permission> RequiredPermissions { get; private set; }
    }
}
