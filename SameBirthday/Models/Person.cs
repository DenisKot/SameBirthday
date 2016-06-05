using System.ComponentModel.DataAnnotations.Schema;

namespace SameBirthday.Models
{
    [Table("persons")]
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public byte[] Image { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}