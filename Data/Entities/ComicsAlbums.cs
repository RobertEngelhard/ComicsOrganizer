
namespace Data.Entities
{
    public class ComicsAlbums
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public bool Owned { get; set; }
        public ComicsSeries Series { get; set; }

    }
}
