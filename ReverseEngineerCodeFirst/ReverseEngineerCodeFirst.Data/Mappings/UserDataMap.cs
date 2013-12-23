using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Data.Mappings
{
  public class UserDataMap : EntityTypeConfiguration<UserData>
  {
    public UserDataMap()
    {
      // Primary Key
      HasKey(t => t.Id);

      // Properties
      Property(t => t.Id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

      // Table & Column Mappings
      ToTable("UserData");
      Property(t => t.Id).HasColumnName("Id");
      Property(t => t.Address1).HasColumnName("Address1");
      Property(t => t.Address2).HasColumnName("Address2");
      Property(t => t.Image).HasColumnName("Image");

      // Relationships

      HasRequired(t => t.User)
        .WithOptional(t => t.UserData);
    }
  }
}
