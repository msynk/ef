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

    public DbSet<Permission> Permissions { get; set; }
    public DbSet<UserData> UserDatas { get; set; }
    public DbSet<UserParam> UserParams { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new PermissionMap());
      modelBuilder.Configurations.Add(new UserDataMap());
      modelBuilder.Configurations.Add(new UserParamMap());
      modelBuilder.Configurations.Add(new UserMap());
    }
  }
}
