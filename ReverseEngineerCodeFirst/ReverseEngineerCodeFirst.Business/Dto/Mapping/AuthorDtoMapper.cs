using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class AuthorDtoMapper
  {
    public static AuthorDto From(Author entity)
    {
      return new AuthorDto
      {
        Id = entity.Id,
        Name = entity.Name,
        Books = entity.Books != null ? entity.Books.Select(BookDtoMapper.From).ToList() : null,
      };
    }

    public static IList<AuthorDto> From(IList<Author> entities)
    {
      return entities.Select(From).ToList();
    }

    public static Author To(AuthorDto dto)
    {
      return new Author
      {
        Id = dto.Id,
        Name = dto.Name,
        Books = dto.Books != null ? dto.Books.Select(BookDtoMapper.To).ToList() : null,
      };
    }

    public static IList<Author> To(IList<AuthorDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
