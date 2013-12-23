using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class UserParamDto
  {
    public long Id { get; set; }
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public virtual UserDto User { get; set; }
  }
}
