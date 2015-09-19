using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using MVC5TestRepo.Models;

namespace MVC5TestRepo.Controllers
{
    public class GuestApiController : ApiController
    {
        public IEnumerable<GuestResponse> GetAttendees()
        {
            return PartyRepository.GuestResponses.Where(x => x.Attend == true).ToList();
        }

        public GuestResponse GetAttendee(string name)
        {
            return PartyRepository.GuestResponses.FirstOrDefault(x => x.Attend == true && x.Name==name);
        }

        public void PostResponse(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                PartyRepository.Add(response);
            }
        }

        public void DeleteAll()
        {
            PartyRepository.RemoveAll();
        }
    }
}
