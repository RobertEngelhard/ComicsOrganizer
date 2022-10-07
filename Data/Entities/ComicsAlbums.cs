using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ComicsAlbums
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public ComicsSeries Series { get; set; }
    }
}
