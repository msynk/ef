using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model
{
  public partial class UserData
  {
    public long Id { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public byte[] Image { get; set; }

    //Navigation Properties
    public virtual User User { get; set; }
  }
}
