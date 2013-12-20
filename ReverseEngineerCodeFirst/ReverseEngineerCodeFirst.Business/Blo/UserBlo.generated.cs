using System.Collections.Generic;
using ReverseEngineerCodeFirst.Business.StructureMap;
using ReverseEngineerCodeFirst.Business.Blo.Base;
using ReverseEngineerCodeFirst.Business.Dto;
using ReverseEngineerCodeFirst.Business.Dto.Mapping;
using ReverseEngineerCodeFirst.Data.Services.Interfaces;
using ReverseEngineerCodeFirst.Data.Services.Interfaces.Base;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Business.Blo
{
	public partial class UserBlo : BaseBlo<User>
  {

    public static UserBlo GetInstance()
    {
      return InstanceFactory.GetInstance<UserBlo>();
    }

    public IUserService Service { get { return _userService; } }

    private readonly IUserService _userService;
    private readonly IUnitOfWork _uow;

    public UserBlo(IUserService userService, IUnitOfWork uow)
      : base(userService, uow)
    {
      _userService = userService;
      _uow = uow;
    }

    public UserDto GetUser(long id)
    {
      return UserDtoMapper.From(Get(id));
    }

    public IList<UserDto> GetAllUsers()
    {
      return UserDtoMapper.From(GetAll());
    }

    public int AddUser(UserDto dto)
    {
      return Add(UserDtoMapper.To(dto));
    }

    public int EditUser(UserDto dto)
    {
      return Edit(UserDtoMapper.To(dto));
    }

    public int DeleteUser(long id)
	  {
	    return Delete(id);
	  }
  }
}
