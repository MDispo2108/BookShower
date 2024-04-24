using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShower.BLL.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public string? Category { get; set; }
    }
}
