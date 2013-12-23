using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class UserParamDtoMapper
  {
    public static UserParamDto From(UserParam entity)
    {
      return new UserParamDto
      {
        Id = entity.Id,
        UserId = entity.UserId,
        Name = entity.Name,
        Value = entity.Value,
        User = entity.User != null ? UserDtoMapper.From(entity.User) : null,
      };
    }

    public static IList<UserParamDto> From(IList<UserParam> entities)
    {
      return entities.Select(From).ToList();
    }

    public static UserParam To(UserParamDto dto)
    {
      return new UserParam
      {
        Id = dto.Id,
        UserId = dto.UserId,
        Name = dto.Name,
        Value = dto.Value,
        User = dto.User != null ? UserDtoMapper.To(dto.User) : null,
      };
    }

    public static IList<UserParam> To(IList<UserParamDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
