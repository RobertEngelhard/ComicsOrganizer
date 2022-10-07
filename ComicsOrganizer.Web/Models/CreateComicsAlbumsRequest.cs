namespace ComicsOrganizer.Web.Models
{
    public class CreateComicsAlbumsRequest
    {
        public string Name { get; set; }
        public string AlbumNumber { get; set; }
        public bool Owned { get; set; }
        public int SeriesId { get; set; }
    }
}