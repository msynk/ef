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
	public partial class UserDataBlo : BaseBlo<UserData>
  {

    public static UserDataBlo GetInstance()
    {
      return InstanceFactory.GetInstance<UserDataBlo>();
    }

    public IUserDataService Service { get { return _userdataService; } }

    private readonly IUserDataService _userdataService;
    private readonly IUnitOfWork _uow;

    public UserDataBlo(IUserDataService userdataService, IUnitOfWork uow)
      : base(userdataService, uow)
    {
      _userdataService = userdataService;
      _uow = uow;
    }

    public UserDataDto GetUserData(long id)
    {
      return UserDataDtoMapper.From(Get(id));
    }

    public IList<UserDataDto> GetAllUserDatas()
    {
      return UserDataDtoMapper.From(GetAll());
    }

    public int AddUserData(UserDataDto dto)
    {
      return Add(UserDataDtoMapper.To(dto));
    }

    public int EditUserData(UserDataDto dto)
    {
      return Edit(UserDataDtoMapper.To(dto));
    }

    public int DeleteUserData(long id)
	  {
	    return Delete(id);
	  }
  }
}
