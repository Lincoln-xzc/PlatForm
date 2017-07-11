using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
  [Table("t_User")]
  public class User :BaseEntity
  {
    public new Guid ID { get; set; }

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

    public DateTime UpdatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid UpdatedBy { get; set; }
  }
}
