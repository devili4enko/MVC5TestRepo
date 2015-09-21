using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;

namespace MVC5TestRepo.Models.SportStoreIdentity
{
    public class StoreIdentityDbContext : IdentityDbContext<StoreUser>
    {
        public StoreIdentityDbContext() :base("SportStoreIdentityDb")
        {
            Database.SetInitializer<StoreIdentityDbContext>(new StoreIdentityDbInitializer());
        }

        internal static StoreIdentityDbContext Create()
        {
           return new StoreIdentityDbContext();
        }
    }
}