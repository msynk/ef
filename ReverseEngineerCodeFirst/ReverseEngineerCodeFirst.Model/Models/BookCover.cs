using System;
using System.Collections.Generic;

namespace ReverseEngineerCodeFirst.Model.Models
{
    public partial class BookCover
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
