using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model.Models
{
  public partial class User
  {
    public User()
    {
      UserParams = new List<UserParam>();
      Permissions = new List<Permission>();
    }

    public long Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }

    //Navigation Properties
    public virtual UserData UserData { get; set; }
    public virtual ICollection<UserParam> UserParams { get; set; }
    public virtual ICollection<Permission> Permissions { get; set; }
  }
}
