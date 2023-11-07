using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public int? RoleUniqeCode { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
