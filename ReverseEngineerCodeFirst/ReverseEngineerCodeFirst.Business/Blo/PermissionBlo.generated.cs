using System.Collections.Generic;
using ReverseEngineerCodeFirst.Business.StructureMap;
using ReverseEngineerCodeFirst.Business.Blo.Base;
using ReverseEngineerCodeFirst.Business.Dto;
using ReverseEngineerCodeFirst.Business.Dto.Mapping;
using ReverseEngineerCodeFirst.Data.Services.Interfaces;
using ReverseEngineerCodeFirst.Data.Services.Interfaces.Base;
using ReverseEngineerCodeFirst.Model;

namespace ReverseEngineerCodeFirst.Business.Blo
{
	public partial class PermissionBlo : BaseBlo<Permission>
  {

    public static PermissionBlo GetInstance()
    {
      return InstanceFactory.GetInstance<PermissionBlo>();
    }

    public IPermissionService Service { get { return _permissionService; } }

    private readonly IPermissionService _permissionService;
    private readonly IUnitOfWork _uow;

    public PermissionBlo(IPermissionService permissionService, IUnitOfWork uow)
      : base(permissionService, uow)
    {
      _permissionService = permissionService;
      _uow = uow;
    }

    public PermissionDto GetPermission(long id)
    {
      return PermissionDtoMapper.From(Get(id));
    }

    public IList<PermissionDto> GetAllPermissions()
    {
      return PermissionDtoMapper.From(GetAll());
    }

    public int AddPermission(PermissionDto dto)
    {
      return Add(PermissionDtoMapper.To(dto));
    }

    public int EditPermission(PermissionDto dto)
    {
      return Edit(PermissionDtoMapper.To(dto));
    }

    public int DeletePermission(long id)
	  {
	    return Delete(id);
	  }
  }
}
