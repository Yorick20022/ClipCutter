using System;
using System.Linq;
using SQLite;

namespace ClipCutter.models
{
    [Table("Config")]
    public class Config
    {

        [PrimaryKey, AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }

        [Column("OutputPath")]
        public string OutputPath { get; set; } = "";
    }
}
