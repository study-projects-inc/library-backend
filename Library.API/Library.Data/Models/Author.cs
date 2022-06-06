using System;
using System.Collections.Generic;

namespace Library.Data.Models
{
    public partial class Author
    {
        public long AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
