using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("product")]
    public class Product
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Int64 lang_id { get; set; }
        public Decimal price { get; set; }
        public Int64 atex_id { get; set; }
        public string todo_reglementation { get; set; }
        public Int64 metrologicvalidation_id { get; set; }
        public string todo_group_product { get; set; }
    }
}