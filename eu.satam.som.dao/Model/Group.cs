using System.ComponentModel.DataAnnotations.Schema;

namespace eu.satam.som.dao.Model
{
    [Table("group")]
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string Template { get; set; }
    }
}
