using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class UserDataDto
  {
    public long Id { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public byte[] Image { get; set; }
    public virtual UserDto User { get; set; }
  }
}
