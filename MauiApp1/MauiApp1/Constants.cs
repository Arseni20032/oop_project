//using Org.XmlPull.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class Constants
    {
        public static string OpenWeatherMapEndpoint = "https://api.openweathermap.org/data/2.5/weather";
        public static string OpenWeatherMapAPI = "4fedbb6b5552ccabd12e2456f9084311";
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags flags = SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        //public static string DatabasePath
        //{
        //    get
        //    {
        //        var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //        return Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
        //    }
        //}
    }

}
