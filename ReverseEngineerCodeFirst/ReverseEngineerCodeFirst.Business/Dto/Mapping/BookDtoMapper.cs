using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class BookDtoMapper
  {
    public static BookDto From(Book entity)
    {
      return new BookDto
      {
        Id = entity.Id,
        Title = entity.Title,
        AuthorId = entity.AuthorId,
        Author = entity.Author != null ? AuthorDtoMapper.From(entity.Author) : null,
        BookCovers = entity.BookCovers != null ? entity.BookCovers.Select(BookCoverDtoMapper.From).ToList() : null,
      };
    }

    public static IList<BookDto> From(IList<Book> entities)
    {
      return entities.Select(From).ToList();
    }

    public static Book To(BookDto dto)
    {
      return new Book
      {
        Id = dto.Id,
        Title = dto.Title,
        AuthorId = dto.AuthorId,
        Author = dto.Author != null ? AuthorDtoMapper.To(dto.Author) : null,
        BookCovers = dto.BookCovers != null ? dto.BookCovers.Select(BookCoverDtoMapper.To).ToList() : null,
      };
    }

    public static IList<Book> To(IList<BookDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
