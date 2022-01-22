using Business.Interop;
using Business.MyService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LabFlight.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly ISeatService _seatService;
        private readonly IPersonService _personService;
        private readonly IFlightService _flightService;

        public TicketController(ITicketService ticketService, ISeatService seatService, IPersonService personService, IFlightService flightService)
        {
            _ticketService = ticketService;
            _seatService = seatService;
            _personService = personService;
            _flightService = flightService;
        }
        public IActionResult Index()
        {
            var tickets = _ticketService.GetAll();
            return View(tickets);
        }
        public IActionResult Home(int id)
        {
            var ticket = _ticketService.GetById(id);
            return View(ticket);
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.People = _personService.GetAll()
                  .OrderBy(_ => _.ToString());
            ViewBag.Flights = _flightService.GetAll()
                  .OrderBy(_ => _.ToString());
            ViewBag.Seats = _seatService.GetAll()
                .OrderBy(_ => _.ToString());
            if (id == null)
                return View();
            var ticket = _ticketService.GetById(id.Value);
            return View(ticket);
        }
        [HttpPost]
        public IActionResult Edit(TicketDto ticket)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Edit), new { id = ticket.Id });
            var res = _ticketService.CreateOrUpdate(ticket);
            return RedirectToAction(nameof(Index), new { id = res.Id });
        }
        public IActionResult Delete(int id)
        {
            _ticketService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

