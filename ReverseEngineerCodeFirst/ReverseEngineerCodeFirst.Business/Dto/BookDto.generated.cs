using System.Linq;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Business.Dto
{
	public partial class BookDto
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public virtual AuthorDto Author { get; set; }
    public virtual ICollection<BookCoverDto> BookCovers { get; set; }
  }
}
