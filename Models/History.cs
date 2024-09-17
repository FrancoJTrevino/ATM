namespace ATM.Models
{
    public class History
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public int UserID { get; set; }
        public string Transaction { get; set; } = null!;
        public DateTime DateAdd { get; set; }
    }
}
