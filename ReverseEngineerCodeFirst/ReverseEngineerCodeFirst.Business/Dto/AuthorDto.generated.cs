using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class AuthorDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BookDto> Books { get; set; }
  }
}
