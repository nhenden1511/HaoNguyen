using SQLite.Net.Interop;
using System.IO;

namespace AppManager.Context
{
    public static class DbInitialization
    {
        static ISQLitePlatform _platform;

        static string _databaseFilePath;
        static object _lockDb;
        static object _lockBackup;
        static string pathSQLite = System.IO.Directory.GetCurrentDirectory();

        public static readonly string DBNAME = "SQLManager.db";
        public static readonly string DBBACKUP = "backup.db";

        public static object Lockbackup = new object();

        public static object Lockdb = new object();

        public static void InitSQLitePlatform(ISQLitePlatform platform, string path)
        {
            if (platform != null)
            {
                _platform = platform;
                _platform.SQLiteApi.Shutdown();
                _platform.SQLiteApi.Config(ConfigOption.Serialized);
                _platform.SQLiteApi.Initialize();
            }

            _databaseFilePath = path;
        }

        public static ISQLitePlatform Platform
        {
            get
            {
                return _platform;
            }
        }

        public static string DbPath
        {
            get
            {
                return Path.Combine(pathSQLite, DBNAME);
            }
        }

        public static string BackupPath
        {
            get
            {
                return Path.Combine(_databaseFilePath, DBBACKUP);
            }
        }
    }
}
