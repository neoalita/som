using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("atex")]
    public class Atex
    {
        public int id { get; set; }
        public string atex_marking { get; set; }
        public string description { get; set; }
    }
}