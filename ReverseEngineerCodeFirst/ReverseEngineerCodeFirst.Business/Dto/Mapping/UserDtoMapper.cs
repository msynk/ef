using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class UserDtoMapper
  {
    public static UserDto From(User entity)
    {
      return new UserDto
      {
        Id = entity.Id,
        Username = entity.Username,
        Password = entity.Password,
        Name = entity.Name,
      };
    }

    public static IList<UserDto> From(IList<User> entities)
    {
      return entities.Select(From).ToList();
    }

    public static User To(UserDto dto)
    {
      return new User
      {
        Id = dto.Id,
        Username = dto.Username,
        Password = dto.Password,
        Name = dto.Name,
      };
    }

    public static IList<User> To(IList<UserDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
