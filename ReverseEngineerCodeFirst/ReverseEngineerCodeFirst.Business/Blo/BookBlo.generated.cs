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
	public partial class BookBlo : BaseBlo<Book>
  {

    public static BookBlo GetInstance()
    {
      return InstanceFactory.GetInstance<BookBlo>();
    }

    public IBookService Service { get { return _bookService; } }

    private readonly IBookService _bookService;
    private readonly IUnitOfWork _uow;

    public BookBlo(IBookService bookService, IUnitOfWork uow)
      : base(bookService, uow)
    {
      _bookService = bookService;
      _uow = uow;
    }

    public BookDto GetBook(long id)
    {
      return BookDtoMapper.From(Get(id));
    }

    public IList<BookDto> GetAllBooks()
    {
      return BookDtoMapper.From(GetAll());
    }

    public int AddBook(BookDto dto)
    {
      return Add(BookDtoMapper.To(dto));
    }

    public int EditBook(BookDto dto)
    {
      return Edit(BookDtoMapper.To(dto));
    }

    public int DeleteBook(long id)
	  {
	    return Delete(id);
	  }
  }
}
