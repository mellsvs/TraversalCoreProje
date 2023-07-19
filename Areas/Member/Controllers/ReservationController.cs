using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal);
        public IActionResult MyCurrentReservation() { 
            return View(); 

        }
       
        [HttpGet]
        public IActionResult NewReservation()
        {
            List < SelectListItem> values =(from x in destinationManager.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = x.City,
                                                Value = x.DestinationID.ToString()
                                            }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(ReservationController p)
        {
            return View();
        }
    }
}

