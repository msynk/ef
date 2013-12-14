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
	public partial class AuthorBlo : BaseBlo<Author>
  {

    public static AuthorBlo GetInstance()
    {
      return InstanceFactory.GetInstance<AuthorBlo>();
    }

    public IAuthorService Service { get { return _authorService; } }

    private readonly IAuthorService _authorService;
    private readonly IUnitOfWork _uow;

    public AuthorBlo(IAuthorService authorService, IUnitOfWork uow)
      : base(authorService, uow)
    {
      _authorService = authorService;
      _uow = uow;
    }

    public AuthorDto GetAuthor(long id)
    {
      return AuthorDtoMapper.From(Get(id));
    }

    public IList<AuthorDto> GetAllAuthors()
    {
      return AuthorDtoMapper.From(GetAll());
    }

    public int AddAuthor(AuthorDto dto)
    {
      return Add(AuthorDtoMapper.To(dto));
    }

    public int EditAuthor(AuthorDto dto)
    {
      return Edit(AuthorDtoMapper.To(dto));
    }

    public int DeleteAuthor(long id)
	  {
	    return Delete(id);
	  }
  }
}
