using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ComicsSeries
  
    {
  
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ComicsAlbums> Albums { get; set; }
    }
}
