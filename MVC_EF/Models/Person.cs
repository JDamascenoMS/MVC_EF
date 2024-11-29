using System.ComponentModel.DataAnnotations;

namespace MVC_EF.Models
{
    public class Person
    {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
