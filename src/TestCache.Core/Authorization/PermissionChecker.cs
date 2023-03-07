using Abp.Authorization;
using TestCache.Authorization.Roles;
using TestCache.Authorization.Users;

namespace TestCache.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
