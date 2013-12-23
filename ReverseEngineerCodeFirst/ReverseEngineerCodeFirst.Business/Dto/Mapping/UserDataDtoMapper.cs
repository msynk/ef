using System.Linq;
using System.Collections.Generic;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Dto.Mapping
{
  public static class UserDataDtoMapper
  {
    public static UserDataDto From(UserData entity)
    {
      return new UserDataDto
      {
        Id = entity.Id,
        Address1 = entity.Address1,
        Address2 = entity.Address2,
        Image = entity.Image,
        User = entity.User != null ? UserDtoMapper.From(entity.User) : null,
      };
    }

    public static IList<UserDataDto> From(IList<UserData> entities)
    {
      return entities.Select(From).ToList();
    }

    public static UserData To(UserDataDto dto)
    {
      return new UserData
      {
        Id = dto.Id,
        Address1 = dto.Address1,
        Address2 = dto.Address2,
        Image = dto.Image,
        User = dto.User != null ? UserDtoMapper.To(dto.User) : null,
      };
    }

    public static IList<UserData> To(IList<UserDataDto> dtos)
    {
      return dtos.Select(To).ToList();
    }
  }
}
