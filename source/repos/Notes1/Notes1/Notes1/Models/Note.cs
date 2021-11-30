using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Createdby {get; set; }

        public string Ingredient { get; set; }
        public string Steps { get; set; }
        public DateTime Date { get; set; }
    }
}