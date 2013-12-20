using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class UserDto
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
  }
}
