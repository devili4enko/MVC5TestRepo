using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace MVC5TestRepo.Models.SportStoreIdentity
{
    internal class StoreRoleManager : RoleManager<StoreRole>
    {
        public StoreRoleManager(RoleStore<StoreRole> roleStore) : base(roleStore) { }

        public static StoreRoleManager Create(IdentityFactoryOptions<StoreRoleManager> options, IOwinContext context)
        {
            return new StoreRoleManager(new
                RoleStore<StoreRole>(context.Get<StoreIdentityDbContext>()));
        }
    }
}