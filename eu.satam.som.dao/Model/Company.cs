using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("company")]
    public class Company
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string site { get; set; }
        public string adress { get; set; }
        public Int64 country_id { get; set; }
        public Decimal global_discount { get; set; }
        public string convention { get; set; }
    }
}