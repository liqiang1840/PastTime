using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhao.Domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public List<int> Authority { get; set; }
    }
}
