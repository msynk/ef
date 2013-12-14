using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ReverseEngineerCodeFirst.Model.Models;

namespace ReverseEngineerCodeFirst.Data.Mappings
{
    public class BookCoverMap : EntityTypeConfiguration<BookCover>
    {
        public BookCoverMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Text, t.BookId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Text)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.BookId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BookCovers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.BookId).HasColumnName("BookId");

            // Relationships
            this.HasRequired(t => t.Book)
                .WithMany(t => t.BookCovers)
                .HasForeignKey(d => d.BookId);

        }
    }
}
