using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ReverseEngineerCodeFirst.Data.Mappings;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Data.Contexts
{
  public partial class TestEntitiesContext : DbContext
  {
    static TestEntitiesContext()
    {
      Database.SetInitializer<TestEntitiesContext>(null);
    }

    public TestEntitiesContext()
      : base("Name=TestEntitiesContext")
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<BookCover> BookCovers { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new AuthorMap());
      modelBuilder.Configurations.Add(new BookCoverMap());
      modelBuilder.Configurations.Add(new BookMap());
    }
  }
}
