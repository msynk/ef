using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model.Models
{
    public partial class Book
    {
        public Book()
        {
            this.BookCovers = new List<BookCover>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<BookCover> BookCovers { get; set; }
    }
}
