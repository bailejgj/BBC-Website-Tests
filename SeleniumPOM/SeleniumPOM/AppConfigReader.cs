using System.Configuration;

namespace SeleniumPOM
{
    // Global reader for the App.config attirbutes
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["login_url"];
    }
}

