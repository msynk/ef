using System.Linq;
using System.Data.Entity;
using ReverseEngineerCodeFirst.Data.Services.Implementations.EF.Base;
using ReverseEngineerCodeFirst.Data.Services.Interfaces;
using ReverseEngineerCodeFirst.Data.Services.Interfaces.Base;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Data.Services.Implementations.EF
{
	public partial class BookCoverService : DbServiceBase<BookCover>, IBookCoverService
  {
    public BookCoverService(IUnitOfWork uow) : base(uow)
    {
    }

    public BookCover Get(long id)
    {
      return Repository.AsNoTracking().Single(p => p.Id == id);
    }

    public BookCover GetForEdit(long id)
    {
      return Repository.Single(p => p.Id == id);
    }

    public void Delete(long id)
    {
      var entity = GetForEdit(id);
      Delete(entity);
    }
  }
}
