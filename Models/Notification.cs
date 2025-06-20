namespace MyWebApi.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public bool Seen { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
