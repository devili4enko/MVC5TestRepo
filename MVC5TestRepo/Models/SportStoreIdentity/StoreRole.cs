using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVC5TestRepo.Models.SportStoreIdentity
{
    public class StoreRole :IdentityRole
    {
        public StoreRole() :base()
        {
            
        }

        public StoreRole(string name) :base(name)
        {
            
        }
    }
}