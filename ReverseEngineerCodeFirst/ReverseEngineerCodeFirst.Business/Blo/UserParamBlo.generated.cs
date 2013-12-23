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
	public partial class UserParamBlo : BaseBlo<UserParam>
  {

    public static UserParamBlo GetInstance()
    {
      return InstanceFactory.GetInstance<UserParamBlo>();
    }

    public IUserParamService Service { get { return _userparamService; } }

    private readonly IUserParamService _userparamService;
    private readonly IUnitOfWork _uow;

    public UserParamBlo(IUserParamService userparamService, IUnitOfWork uow)
      : base(userparamService, uow)
    {
      _userparamService = userparamService;
      _uow = uow;
    }

    public UserParamDto GetUserParam(long id)
    {
      return UserParamDtoMapper.From(Get(id));
    }

    public IList<UserParamDto> GetAllUserParams()
    {
      return UserParamDtoMapper.From(GetAll());
    }

    public int AddUserParam(UserParamDto dto)
    {
      return Add(UserParamDtoMapper.To(dto));
    }

    public int EditUserParam(UserParamDto dto)
    {
      return Edit(UserParamDtoMapper.To(dto));
    }

    public int DeleteUserParam(long id)
	  {
	    return Delete(id);
	  }
  }
}
