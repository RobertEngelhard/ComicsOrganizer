using Data;
using Npgsql;



namespace ComicsOrganizer.Web
{
    public class NpgsqlConnectionFactory : INpgsqlConnectionFactory
    {
        private readonly IConfiguration configuration;



        public NpgsqlConnectionFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        public NpgsqlConnection GetConnection() => new NpgsqlConnection(Settings.Get("COMICS_ORGANIZER_DB_CONNECTION"));
    }
}