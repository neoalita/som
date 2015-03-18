using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("contact")]
    public class Contact
    {
        public Int64 id { get; set; }
        public Int64 company_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string mail { get; set; }
    }
}