using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Collections.Generic;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        //Fields

        //Contstructors
  
        //Methods
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListResponses()
        {
            List<GuestResponse> responses = Repository.GetResponses();
            return View(responses);
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View(); //go look for Rsvp.cshtml
            return answer;
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);  //go look for Thanks.cshtml
            }
            else
            {
                return View(guestResponse);
            }
           
        }
    }
}
