using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Entities
{
    [SQLite.Table("Cities")]
    public class City
    {
        [PrimaryKey, AutoIncrement, Indexed]
        [SQLite.Column("Id")]
        public int CityId { get; set; }
        public string CityName { get; set; }
        [Indexed]
        public string RegionName { get; set; }
    }
}
