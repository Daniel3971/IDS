namespace MyWebApi.DTOs
{
    public class UserCreateDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public int DepartmentID { get; set; }
    }
}
