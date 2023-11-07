using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? NationalCode { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
