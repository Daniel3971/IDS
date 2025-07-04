namespace MyWebApi.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public int MeetingID { get; set; }
        public int UserID { get; set; }
        public string AttendanceStatus { get; set; } = string.Empty; //yaane ma feha tkoun 0

    }
}
