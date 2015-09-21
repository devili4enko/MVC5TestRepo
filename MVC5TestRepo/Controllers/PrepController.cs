using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Models.SportStoreModels;
using MVC5TestRepo.Models.SportStoreIdentity;
using MVC5TestRepo.Repositories.Implementation;
using MVC5TestRepo.Repositories.Interfaces;

namespace MVC5TestRepo.Controllers
{
    public class PrepController : Controller
    {
        private readonly ISportStoreRepository _repository;

        public PrepController()
        {
            _repository= new SportStoreRepository();
        }

        //
        // GET: /Prep/
        public ActionResult Index()
        {
            return View(_repository.Products);
        }

        [Authorize(Roles = "Administrators")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            await _repository.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrators")]
        public async Task<ActionResult> SaveProduct(Product product)
        {
            await _repository.SaveProductAsync(product);
            return RedirectToAction("Index");
        }

        public ActionResult Orders()
        {
            return View(_repository.Orders);
        }

        public async Task<ActionResult> DeleteOrder(int id)
        {
            await _repository.DeleteOrderAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> SaveOrder(Order order)
        {
            await _repository.SaveOrderAsync(order);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> SignIn()
        {
            IAuthenticationManager authMgr = HttpContext.GetOwinContext().Authentication;
            StoreUserManager userMrg = HttpContext.GetOwinContext().GetUserManager<StoreUserManager>();
            StoreUser user = await userMrg.FindAsync("Admin", "secret");
            authMgr.SignIn(await userMrg.CreateIdentityAsync(user,
            DefaultAuthenticationTypes.ApplicationCookie));
            return RedirectToAction("Index");
        }
        public ActionResult SignOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("Index");
        }
	}
}