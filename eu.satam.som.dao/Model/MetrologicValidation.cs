using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("metrologic_validation")]
    public class MetrologicValidation
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string fr_description { get; set; }
        public string en_description { get; set; }
    }
}