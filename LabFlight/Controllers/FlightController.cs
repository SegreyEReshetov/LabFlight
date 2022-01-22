using Microsoft.AspNetCore.Mvc;
using Business.Interop;
using Business.MyService;
using System.Linq;
namespace LabFlight.Controllers
{
    public class FlightController : Controller
    {
        private readonly IFlightService _flightService;
        private readonly IAirportService _airportService;
        private IFlightStatusService _flightStatusService;
        private ITicketService _ticketService;

        public FlightController(IFlightService flightService, IAirportService airportService, IFlightStatusService flightStatusService, ITicketService ticketService)
        {
            _flightService = flightService;
            _airportService = airportService;
            _flightStatusService = flightStatusService;
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            var flights = _flightService.GetAll();
            return View(flights);
        }
        public IActionResult Home(int id)
        {
            
            var flight = _flightService.GetById(id);
            var tickets = _ticketService.GetAll().Where(e => e.FlightId == id);
            flight.Tickets = tickets;
            return View(flight);
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Airports = _airportService.GetAll()
                .OrderBy(_ => _.ToString());
            ViewBag.Tickets = _ticketService.GetAll()
                .OrderBy(_ => _.ToString());
            ViewBag.FlightStatuses = _flightStatusService.GetAll()
                .OrderBy(_ => _.ToString());
            if (id == null)
                return View();
            var flight = _flightService.GetById(id.Value);
            return View(flight);
        }
        [HttpPost]
        public IActionResult Edit(FlightDto flight)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Edit), new { id = flight.Id });
            var res = _flightService.CreateOrUpdate(flight);
            return RedirectToAction(nameof(Index), new { id = res.Id });
        }
        public IActionResult Delete(int id)
        {
            var flilight = _flightService.GetById(id);
            var tickets = _ticketService.GetAll().Where(e => e.FlightId== id);
            foreach (var t in tickets)
                _ticketService.Delete(t.Id);
            _flightService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
