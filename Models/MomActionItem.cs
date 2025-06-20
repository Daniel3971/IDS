namespace MyWebApi.Models
{
    public class MomActionItem
    {
        public int Id { get; set; }
        public int MomID { get; set; }
        public string Description { get; set; }
        public int AssignedTo { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
    }
}
