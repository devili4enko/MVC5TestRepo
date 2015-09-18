using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css;

//Freeman A. Expert WebApi 
namespace MVC5TestRepo.Models
{
    public class PartyRepository
    {
        private static Dictionary<string, GuestResponse> _guestResponses;

        static PartyRepository()
        {
            _guestResponses=new Dictionary<string, GuestResponse>();
            _guestResponses.Add("Alex", new GuestResponse { Name = "Alex", Attend = true, Email = "alex@gmail.com" });
            _guestResponses.Add("Dan", new GuestResponse { Name = "Dan", Attend = false, Email = "Dan@gmail.com" });
            _guestResponses.Add("Eva", new GuestResponse { Name = "Eva", Attend = true, Email = "Eva@gmail.com" });
            _guestResponses.Add("Ann", new GuestResponse { Name = "Ann", Attend = true, Email = "Ann@gmail.com" });
            _guestResponses.Add("Ted", new GuestResponse { Name = "Ted", Attend = true, Email = "Ted@gmail.com" });
        }

        public static void Add(GuestResponse response)
        {
            if (_guestResponses.ContainsKey(response.Name))
            {
                _guestResponses[response.Name] = response;
            }
            else
            {
                _guestResponses.Add(response.Name, response);
            }
        }

        public static IEnumerable<GuestResponse> GuestResponses { get { return _guestResponses.Values; }}
    }
}