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
	public partial class BookCoverBlo : BaseBlo<BookCover>
  {

    public static BookCoverBlo GetInstance()
    {
      return InstanceFactory.GetInstance<BookCoverBlo>();
    }

    public IBookCoverService Service { get { return _bookcoverService; } }

    private readonly IBookCoverService _bookcoverService;
    private readonly IUnitOfWork _uow;

    public BookCoverBlo(IBookCoverService bookcoverService, IUnitOfWork uow)
      : base(bookcoverService, uow)
    {
      _bookcoverService = bookcoverService;
      _uow = uow;
    }

    public BookCoverDto GetBookCover(long id)
    {
      return BookCoverDtoMapper.From(Get(id));
    }

    public IList<BookCoverDto> GetAllBookCovers()
    {
      return BookCoverDtoMapper.From(GetAll());
    }

    public int AddBookCover(BookCoverDto dto)
    {
      return Add(BookCoverDtoMapper.To(dto));
    }

    public int EditBookCover(BookCoverDto dto)
    {
      return Edit(BookCoverDtoMapper.To(dto));
    }

    public int DeleteBookCover(long id)
	  {
	    return Delete(id);
	  }
  }
}
