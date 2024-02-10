using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Cards
    {
        [Key]
        public int CardId { get; set; }

       
        public string NameCard { get; set; }

        public int? Cost { get; set; }
        public int? AttackDamage { get; set; }
        public int? Hp { get; set; }

        // Add any additional properties or methods here as needed
    }
}
