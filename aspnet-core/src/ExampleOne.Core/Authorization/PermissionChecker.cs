using Abp.Authorization;
using ExampleOne.Authorization.Roles;
using ExampleOne.Authorization.Users;

namespace ExampleOne.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
