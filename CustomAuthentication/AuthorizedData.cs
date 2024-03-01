using System.ComponentModel.DataAnnotations;

namespace CustomAuthentication
{
    public class AuthorizedData
    {
        [Required(ErrorMessage = "Логин не может быть пустым")]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        public string? Password { get; set; }
    }
}
