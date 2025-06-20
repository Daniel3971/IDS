namespace MyWebApi.Models
{
    public class MeetingRoom
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public string? Location { get; set; }
        public string? Features { get; set; }
        public string? Password { get; set; }
        public int? UserID { get; set; }
    }
}
