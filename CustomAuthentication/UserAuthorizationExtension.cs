using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CustomAuthentication
{
    public static class UserAuthorizationExtension
    {
        public static string GetCurentUserFullName(AuthenticationState state)
        {
            if (state != null)
            {
                ClaimsPrincipal? user = state.User;
                if(user != null)
                {
                    return user.Identity.Name;
                }
            }
            return string.Empty;
        }

        public static RoleType GetCurrentUserRole(AuthenticationState state)
        {
            if(state != null)
            {
                ClaimsPrincipal user = state.User;
                if (user != null)
                {
                    string userRole = user.FindFirst("role").Value;
                    if (userRole != null)
                    {
                        return (RoleType)Enum.Parse(typeof(RoleType), userRole);
                    }
                }
            }
            return RoleType.Viewer;
        }

        public static Guid GetUserId()
        {
            return Guid.Empty;
        }

        public static async Task<bool> AuthenticateUserAsync(AuthorizedData authorizeData, AuthenticationStateProvider authStateProvider)
        {
            UserAPI _userAPI = new();
            AuthorizedUser? _authorizedUser = await _userAPI.GetAuthUser(authorizeData.Login, authorizeData.Password, Guid.Parse("26d94da3-1ffb-4a8b-a1cf-c19e83991e59"));

            if (_authorizedUser != null)
            {
                CustomAuthenticationStateProvider customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
                await customAuthStateProvider.UpdateAuthenticationState(new AuthorizedUser
                {
                    Lastname = _authorizedUser.Lastname,
                    Firstname = _authorizedUser.Firstname,
                    Surname = _authorizedUser.Surname,
                    Role = _authorizedUser.Role
                });
                return true;
            }
            return false;
        }
    }
}
