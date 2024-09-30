using SQLite;
using System;

namespace Prueba.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Text { get; set; }
        public string Description { get; set; }
    }
}