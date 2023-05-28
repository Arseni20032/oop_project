using System;
using SQLite;
using MauiApp1.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1.Services
{
    public class SQLiteService : IDbService
    {
        SQLiteConnection connection;

        public IEnumerable<Entities.Region> GetAllRegions()
        {
            Init();
            return connection.Table<Entities.Region>().ToList();
        }

        public IEnumerable<City> GetCities(string Name)
        {
            Init();
            return connection.Table<City>().Where(t => t.RegionName == Name).ToList();
        }

        public void Init()
        {
            if (connection is not null)
                return;
            //SQLiteConnection
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);

            var regions_table = connection.CreateTable<Entities.Region>();
            var cities_table = connection.CreateTable<City>();

            var count1 = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Regions");
            var count2 = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Cities");

            if (count1 != 0)
            {
                connection.DeleteAll<Entities.Region>();
            }

            if (count2 != 0)
            {
                connection.DeleteAll<City>();
            }

            var reg1 = new Entities.Region()
            {
                Name = "Брестская"
            };
            connection.Insert(reg1);

            var reg2 = new Entities.Region()
            {
                Name = "Витебская"
            };
            connection.Insert(reg2);

            var reg3 = new Entities.Region()
            {
                Name = "Гомельская"
            };
            connection.Insert(reg3);

            var reg4 = new Entities.Region()
            {
                Name = "Гродненская"
            };
            connection.Insert(reg4);

            var reg5 = new Entities.Region()
            {
                Name = "Могилевская"
            };
            connection.Insert(reg5);

            var reg6 = new Entities.Region()
            {
                Name = "Минская"
            };
            connection.Insert(reg6);

            var city1_1 = new City()
            {
                RegionName = reg1.Name,
                CityName = "Брест"
            };
            connection.Insert(city1_1);

            var city1_2 = new City()
            {
                RegionName = reg1.Name,
                CityName = "Барановичи"
            };
            connection.Insert(city1_2);

            var city1_3 = new City()
            {
                RegionName = reg1.Name,
                CityName = "Пинск"
            };
            connection.Insert(city1_3);

            var song1_4 = new City()
            {
                RegionName = reg1.Name,
                CityName = "Кобрин"
            };
            connection.Insert(song1_4);

            var city1_5 = new City()
            {
                RegionName = reg1.Name,
                CityName = "Берёза"
            };
            connection.Insert(city1_5);

            var city2_1 = new City()
            {
                RegionName = reg2.Name,
                CityName = "Витебск"
            };
            connection.Insert(city2_1);

            var song2_2 = new City()
            {
                RegionName = reg2.Name,
                CityName = "Орша"
            };
            connection.Insert(song2_2);

            var city2_3 = new City()
            {
                RegionName = reg2.Name,
                CityName = "Новополоцк"
            };
            connection.Insert(city2_3);

            var city2_4 = new City()
            {
                RegionName = reg2.Name,
                CityName = "Полоцк"
            };
            connection.Insert(city2_4);

            var city2_5 = new City()
            {
                RegionName = reg2.Name,
                CityName = "Поставы"
            };
            connection.Insert(city2_5);

            var city3_1 = new City()
            {
                RegionName = reg3.Name,
                CityName = "Гомель"
            };
            connection.Insert(city3_1);

            var city3_2 = new City()
            {
                RegionName = reg3.Name,
                CityName = "Мозырь"
            };
            connection.Insert(city3_2);

            var city3_3 = new City()
            {
                RegionName = reg3.Name,
                CityName = "Жлобин"
            };
            connection.Insert(city3_3);

            var city3_4 = new City()
            {
                RegionName = reg3.Name,
                CityName = "Речица"
            };
            connection.Insert(city3_4);

            var city3_5 = new City()
            {
                RegionName = reg3.Name,
                CityName = "Светлогорск"
            };
            connection.Insert(city3_5);

            var city4_1 = new City()
            {
                RegionName = reg4.Name,
                CityName = "Гродно"
            };
            connection.Insert(city4_1);

            var city4_2 = new City()
            {
                RegionName = reg4.Name,
                CityName = "Лида"
            };
            connection.Insert(city4_2);

            var city4_3 = new City()
            {
                RegionName = reg4.Name,
                CityName = "Слоним"
            };
            connection.Insert(city4_3);

            var city4_4 = new City()
            {
                RegionName = reg4.Name,
                CityName = "Волковыск"
            };
            connection.Insert(city4_4);

            var city4_5 = new City()
            {
                RegionName = reg4.Name,
                CityName = "Сморгонь"
            };
            connection.Insert(city4_5);

            var city5_1 = new City()
            {
                RegionName = reg5.Name,
                CityName = "Могилёв"
            };
            connection.Insert(city5_1);

            var city5_2 = new City()
            {
                RegionName = reg5.Name,
                CityName = "Бобруйск"
            };
            connection.Insert(city5_2);

            var city5_3 = new City()
            {
                RegionName = reg5.Name,
                CityName = "Горки"
            };
            connection.Insert(city5_3);

            var city5_4 = new City()
            {
                RegionName = reg5.Name,
                CityName = "Осиповичи"
            };
            connection.Insert(city5_4);

            var city5_5 = new City()
            {
                RegionName = reg5.Name,
                CityName = "Кричев"
            };
            connection.Insert(city5_5);

            var city6_1 = new City()
            {
                RegionName = reg6.Name,
                CityName = "Борисов"
            };
            connection.Insert(city6_1);

            var city6_2 = new City()
            {
                RegionName = reg6.Name,
                CityName = "Солигорск"
            };
            connection.Insert(city6_2);

            var city6_3 = new City()
            {
                RegionName = reg6.Name,
                CityName = "Молодечно"
            };
            connection.Insert(city6_3);

            var city6_4 = new City()
            {
                RegionName = reg6.Name,
                CityName = "Жодино"
            };
            connection.Insert(city6_4);

            var city6_5 = new City()
            {
                RegionName = reg6.Name,
                CityName = "Слуцк"
            };
            connection.Insert(city6_5);
        }
    }
}
