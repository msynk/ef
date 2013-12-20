using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ReverseEngineerCodeFirst.Data.Mappings;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Data.Contexts
{
  public partial class TestContext : DbContext
  {
    static TestContext()
    {
      Database.SetInitializer<TestContext>(null);
    }

    public TestContext()
      : base("Name=TestContext")
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new UserMap());
    }
  }
}
