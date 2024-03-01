namespace CustomAuthentication.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool IsBlocked { get; set; } = false;
    }
}
