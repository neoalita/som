using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("lang")]
    public class Lang
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string shortname { get; set; }
        public string template_deal_file { get; set; }
    }
}