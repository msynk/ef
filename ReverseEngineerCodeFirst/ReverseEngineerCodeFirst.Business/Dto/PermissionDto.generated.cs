using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class PermissionDto
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public virtual ICollection<UserDto> Users { get; set; }
  }
}
