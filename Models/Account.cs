using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    public class Account
    {
        public int ID { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Balance { get; set; }
        public int UserID { get; set; }
        public int SecUserID { get; set; }        

        public User User { get; set; } = null!;
    }
}
