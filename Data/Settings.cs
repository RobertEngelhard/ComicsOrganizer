namespace Data

{
    public static class Settings
    {
        public static string DbConnectionString => Get("COMICS_ORGANIZER_DB_CONNECTION");

        public static string Get(string key)
        {
            var setting = Environment.GetEnvironmentVariable(key);
            if (string.IsNullOrEmpty(setting))
                throw new Exception("Missing enviroment variable: " + key);
            return setting;
        }
    }
}
