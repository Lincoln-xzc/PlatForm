using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace platform.Models
{
  public class UserViewModel
  {
    public Guid ID { get; set; }

    public Guid BusinessID { get; set; }

    public string Account { get; set; }

    public string Name { get; set; }

    public string Avatar { get; set; }

    public string Password { get; set; }

    public int Sex { get; set; }

    public string Mobile { get; set; }

    public string Email { get; set; }

    public string DeptCode { get; set; }

    public string PositionCode { get; set; }

    public string Roles { get; set; }

    public string Purviews { get; set; }

    public int Status { get; set; }

    public DateTime LastLoginAt { get; set; }

    public string LastLoginIp { get; set; }

    public bool IsSuper { get; set; }

    public bool IsDel { get; set; }

    public string OpenID { get; set; }
  }
}