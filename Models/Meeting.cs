namespace MyWebApi.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public int BookingID { get; set; }
        public string Title { get; set; }
        public string? Agenda { get; set; }
        public int OrganizerID { get; set; }
    }
}
