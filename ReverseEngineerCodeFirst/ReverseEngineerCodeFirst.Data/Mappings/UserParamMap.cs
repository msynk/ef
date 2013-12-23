using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ReverseEngineerCodeFirst.Model;

namespace ReverseEngineerCodeFirst.Data.Mappings
{
  public class UserParamMap : EntityTypeConfiguration<UserParam>
  {
    public UserParamMap()
    {
      // Primary Key
      HasKey(t => t.Id);

      // Properties
      Property(t => t.Id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

      Property(t => t.Name)
        .HasMaxLength(100);

      Property(t => t.Value)
        .HasMaxLength(200);

      // Table & Column Mappings
      ToTable("UserParams");
      Property(t => t.Id).HasColumnName("Id");
      Property(t => t.UserId).HasColumnName("UserId");
      Property(t => t.Name).HasColumnName("Name");
      Property(t => t.Value).HasColumnName("Value");

      // Relationships

      HasRequired(t => t.User)
        .WithMany(t => t.UserParams)
        .HasForeignKey(d => d.UserId);
    }
  }
}
