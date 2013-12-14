using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class BookCoverDto
  {
    public int Id { get; set; }
    public string Text { get; set; }
    public int BookId { get; set; }
    public virtual BookDto Book { get; set; }
  }
}
