using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model.Models
{
  public partial class UserParam
  {
    public long Id { get; set; }
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }

    //Navigation Properties
    public virtual User User { get; set; }
  }
}
