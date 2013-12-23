using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ReverseEngineerCodeFirst.Model;

namespace ReverseEngineerCodeFirst.Data.Mappings
{
  public class PermissionMap : EntityTypeConfiguration<Permission>
  {
    public PermissionMap()
    {
      // Primary Key
      HasKey(t => t.Id);

      // Properties
      Property(t => t.Id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

      Property(t => t.Name)
        .IsRequired()
        .HasMaxLength(50);

      Property(t => t.Value)
        .HasMaxLength(50);

      // Table & Column Mappings
      ToTable("Permissions");
      Property(t => t.Id).HasColumnName("Id");
      Property(t => t.Name).HasColumnName("Name");
      Property(t => t.Value).HasColumnName("Value");

      // Relationships
      HasMany(t => t.Users)
        .WithMany(t => t.Permissions)
        .Map(m =>
        {
          m.ToTable("UserPermissions");
          m.MapLeftKey("PermissionId");
          m.MapRightKey("UserId");
        });
    }
  }
}
