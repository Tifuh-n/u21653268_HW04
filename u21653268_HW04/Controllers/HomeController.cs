using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21653268_HW04.Models;

namespace u21653268_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is HeadHealth?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Questions, queries and bookings";

            return View();
        }

        public ActionResult Counselling()
        {
            List<Session> sessions = GetSessions();
            return View(sessions);
        }

        private List<Session> GetSessions()
        {
            List<Session> sessionObjs = new List<Session>();
            VirtualConsult vc1 = new VirtualConsult("Online Consultation", "Book a virtual consultation with a counsellor. Let them know what you need help with.", 60, 100.00, false, "https://images.unsplash.com/photo-1616587894289-86480e533129?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Zoom");
            VirtualConsult vc2 = new VirtualConsult("Online Consultation + Mental wellbeing tips book", "Book a virtual consultation with a counsellor. Let them know what you need help with. Receive a physical copy of Mental wellbeing tips which will be your all-in-one resource on mental health", 60, 130.00, false, "https://images.unsplash.com/photo-1616587894289-86480e533129?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Zoom");

            SingleConsult sc1 = new SingleConsult("Single Consultation", "Book a in-person consultation with a counsellor. Let them know what you need help with.", 60, 130.00, true, "https://images.unsplash.com/photo-1507537362848-9c7e70b7b5c1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "18 Venus street hellow");
            SingleConsult sc2 = new SingleConsult("Single Consultation + Mental wellbeing tips book", "Book a in-person consultation with a counsellor. Let them know what you need help with. Receive a physical copy of Mental wellbeing tips which will be your all-in-one resource on mental health", 60, 160.00, false, "https://images.unsplash.com/photo-1507537362848-9c7e70b7b5c1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "18 Venus street hellow");

            EmergencyVirtualConsult evc1 = new EmergencyVirtualConsult("Emergency Virtual Consultation", "Book an emergency virtual consultation with a counsellor. Let them know what you need help with and get help immediately.", 30, 75.00, true, "https://images.unsplash.com/photo-1484807352052-23338990c6c6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Skype", "High");

            sessionObjs.Add(vc1);
            sessionObjs.Add(vc2);
            sessionObjs.Add(sc1);
            sessionObjs.Add(sc2);
            sessionObjs.Add(evc1);

            return sessionObjs;
        }

        public ActionResult Home()
        {

            return View();
        }

    }
}