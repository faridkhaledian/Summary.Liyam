namespace Summary.Liyam
{
    using Core.Security.Permissions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class Permissions : IPermissionProvider
    {
        internal static Permission ManageLiyamSettings =
            new Permission(nameof(ManageLiyamSettings), "Manage Liyam Settings");

        public Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            return Task.FromResult(new[] { ManageLiyamSettings }.AsEnumerable());
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[]
            {
                new PermissionStereotype
                {
                    Name = "Administrator",
                    Permissions = new []{ ManageLiyamSettings }
                }
            };
        }
    }
}