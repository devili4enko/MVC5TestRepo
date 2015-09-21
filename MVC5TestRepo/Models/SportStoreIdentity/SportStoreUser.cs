using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVC5TestRepo.Models.SportStoreIdentity
{
    public class StoreUser : IdentityUser
    {

        public string Email { get; set; }
    }
}