using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class UserDto
  {
    public long Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public virtual UserDataDto UserData { get; set; }
    public virtual ICollection<UserParamDto> UserParams { get; set; }
    public virtual ICollection<PermissionDto> Permissions { get; set; }
  }
}
