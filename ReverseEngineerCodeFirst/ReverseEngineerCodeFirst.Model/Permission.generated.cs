using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model
{
  public partial class Permission
  {
    public Permission()
    {
      Users = new List<User>();
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }

    //Navigation Properties
    public virtual ICollection<User> Users { get; set; }
  }
}
