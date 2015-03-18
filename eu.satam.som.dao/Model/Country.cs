using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("country")]
    public class Country
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
}