namespace CustomAuthentication
{
    public class AuthorizedUser
    {
        public Guid Id { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public RoleType Role { get; set; }
    }
}
