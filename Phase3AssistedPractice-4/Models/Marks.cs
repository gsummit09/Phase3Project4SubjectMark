using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase3AssistedPractice_4.Models
{
    [Table("Marks")]
    public class Marks
    {
        [Key]
        public int ID  { get; set; }
        public string? Name { get; set; }
        public int SubID { get; set; }
        public string? SubName { get; set; }
        public int Mark { get; set; }
    }
}
