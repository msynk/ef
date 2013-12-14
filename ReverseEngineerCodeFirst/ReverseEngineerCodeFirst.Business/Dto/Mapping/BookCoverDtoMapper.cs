using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class BookCoverDtoMapper
  {
    public static BookCoverDto From(BookCover entity)
    {
      return new BookCoverDto
      {
        Id = entity.Id,
        Text = entity.Text,
        BookId = entity.BookId,
        Book = entity.Book != null ? BookDtoMapper.From(entity.Book) : null,
      };
    }

    public static IList<BookCoverDto> From(IList<BookCover> entities)
    {
      return entities.Select(From).ToList();
    }

    public static BookCover To(BookCoverDto dto)
    {
      return new BookCover
      {
        Id = dto.Id,
        Text = dto.Text,
        BookId = dto.BookId,
        Book = dto.Book != null ? BookDtoMapper.To(dto.Book) : null,
      };
    }

    public static IList<BookCover> To(IList<BookCoverDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
