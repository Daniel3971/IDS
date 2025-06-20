namespace MyWebApi.Models
{
    public class Mom
    {
        public int Id { get; set; }
        public int MeetingID { get; set; }
        public string Summary { get; set; }
        public string? PDFPath { get; set; }
    }
}
