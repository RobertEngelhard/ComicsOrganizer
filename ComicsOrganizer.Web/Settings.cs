namespace ComicsOrganizer.Web
{
    public class Settings
    {
        public static string Get(string key)
        {
            var setting = Environment.GetEnvironmentVariable(key);
            if (string.IsNullOrEmpty(setting))
                throw new Exception("Missing enviroment variable: " + key);
            return setting;
        }
    }
}
