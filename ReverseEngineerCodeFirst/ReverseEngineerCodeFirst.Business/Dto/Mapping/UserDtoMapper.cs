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
        UserData = entity.UserData != null ? UserDataDtoMapper.From(entity.UserData) : null,
        UserParams = entity.UserParams != null ? entity.UserParams.Select(UserParamDtoMapper.From).ToList() : null,
        Permissions = entity.Permissions != null ? entity.Permissions.Select(PermissionDtoMapper.From).ToList() : null,
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
        UserData = dto.UserData != null ? UserDataDtoMapper.To(dto.UserData) : null,
        UserParams = dto.UserParams != null ? dto.UserParams.Select(UserParamDtoMapper.To).ToList() : null,
        Permissions = dto.Permissions != null ? dto.Permissions.Select(PermissionDtoMapper.To).ToList() : null,
      };
    }

    public static IList<User> To(IList<UserDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
