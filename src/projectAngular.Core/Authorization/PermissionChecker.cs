using Abp.Authorization;
using projectAngular.Authorization.Roles;
using projectAngular.Authorization.Users;

namespace projectAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
