using Npgsql;

namespace ComicsOrganizer.Web
{
    public interface INpgsqlConnectionFactory
    {
        NpgsqlConnection GetConnection();
    }
}
