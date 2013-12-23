using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class PermissionDtoMapper
  {
    public static PermissionDto From(Permission entity)
    {
      return new PermissionDto
      {
        Id = entity.Id,
        Name = entity.Name,
        Value = entity.Value,
        Users = entity.Users != null ? entity.Users.Select(UserDtoMapper.From).ToList() : null,
      };
    }

    public static IList<PermissionDto> From(IList<Permission> entities)
    {
      return entities.Select(From).ToList();
    }

    public static Permission To(PermissionDto dto)
    {
      return new Permission
      {
        Id = dto.Id,
        Name = dto.Name,
        Value = dto.Value,
        Users = dto.Users != null ? dto.Users.Select(UserDtoMapper.To).ToList() : null,
      };
    }

    public static IList<Permission> To(IList<PermissionDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
