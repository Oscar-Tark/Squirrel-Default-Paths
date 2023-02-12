using System.Text;

namespace SquirrelDefaultPaths
{
    public static class GeneralEncoding
    {
        public static Encoding default_encoding = Encoding.UTF8;
    }

    public static class SquirrelPaths
    {
        public static string main_user_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel";
        public static string main_user_projects_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/Projects";
        public static string main_user_manuals_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/Manuals";

        public static string main_user_aes_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/AES";
        public static string main_user_aes_path_file = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/AES/aes.ky";

        public static string main_user_rsa_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/RSA";

        public static string main_users_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/Users";
        public static string main_users_config_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/Users/scpwd.conf";
        public static string main_users_perm_config_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/Users/{0}.scpwd";

        public static string main_tmp_path = "/tmp/squirrelees";

        public static string main_log_path = $"{main_user_path}/Logs";
    }

    public static class ScorpionHTTPPaths
    {
        public static string http_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/HTTP/";
        public static string http_config_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Squirrel/HTTP/http.cfg";
    }

    public static class LinuxSystemPaths
    {
        public static string bin_path = "/usr/bin";
        public static string usr_bin_path = "/usr/bin";
        public static readonly string home_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    }
}