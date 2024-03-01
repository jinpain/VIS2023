using Microsoft.AspNetCore.Components.Authorization;
using System.DirectoryServices.AccountManagement;

namespace LDAPAuth
{
    public static class UserAuthorizationExtension
    {
        /// <summary>
        /// получить полное имя авторизированого пользователя [Фамилия {инициалы} Имя]
        /// </summary>
        /// <returns></returns>
        public static string GetCurentUserFullName(AuthenticationState state)
        {
            try
            {
                using PrincipalContext pc = new PrincipalContext(ContextType.Domain);
                UserPrincipal up = UserPrincipal.FindByIdentity(pc, state.User.Identity.Name);
                return up.Name;
            }
            catch (Exception ex)
            {
                return ex.StackTrace.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        public static bool ContainsAnyRole(AuthenticationState state, List<string> roles)
        {
            var user = state?.User;

            if (user != null)
            {
                foreach (var item in roles)
                {
                    if (user.IsInRole(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ContainsAnyRole(AuthenticationState state, string role)
        {
            var user = state?.User;

            if (user != null)
            {
                if (user.IsInRole(role))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// получить имя аккаунта авторизированого пользователя [u99999]
        /// </summary>
        /// <returns></returns>
        public static string GetCurentUserAccauntName(AuthenticationState state)
        {
            try
            {
                using PrincipalContext pc = new PrincipalContext(ContextType.Domain);
                UserPrincipal up = UserPrincipal.FindByIdentity(pc, state.User.Identity.Name);
                return up.SamAccountName;
            }
            catch (Exception ex)
            {
                return ex.StackTrace.ToString();
            }
        }

        /// <summary>
        /// проверить существует ли аккаунт указаного пользователя в AD
        /// </summary>
        /// <returns></returns>
        public static bool HaveUserAccaunt(string accauntName)
        {
            try
            {
                using PrincipalContext pc = new PrincipalContext(ContextType.Domain);
                UserPrincipal up = UserPrincipal.FindByIdentity(pc, $"okb3\\{accauntName}");
                return up != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
