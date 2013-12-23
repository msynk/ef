using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ReverseEngineerCodeFirst.Model;

namespace ReverseEngineerCodeFirst.Data.Mappings
{
  public class UserMap : EntityTypeConfiguration<User>
  {
    public UserMap()
    {
      // Primary Key
      HasKey(t => t.Id);

      // Properties
      Property(t => t.Username)
        .IsRequired()
        .HasMaxLength(100);

      Property(t => t.Password)
        .IsRequired()
        .HasMaxLength(100);

      Property(t => t.Name)
        .HasMaxLength(100);

      // Table & Column Mappings
      ToTable("Users");
      Property(t => t.Id).HasColumnName("Id");
      Property(t => t.Username).HasColumnName("Username");
      Property(t => t.Password).HasColumnName("Password");
      Property(t => t.Name).HasColumnName("Name");
    }
  }
}
