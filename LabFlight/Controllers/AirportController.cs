using Business.Interop;
using Business.MyService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LabFlight.Controllers
{
    public class AirportController : Controller
    {
        private readonly IAirportService _airportService;
        private readonly ICityService _cityService;
        private readonly IFlightService _flightService;


        public AirportController(IAirportService airportService, ICityService cityService, IFlightService flightService)
        {
            _airportService = airportService;
            _cityService = cityService;
            _flightService = flightService;
        }

        public IActionResult Index()
        {
            var airports = _airportService.GetAll();
            return View(airports);
        }
        public IActionResult Home(int id)
        {
            var airport = _airportService.GetById(id);
            var flights = _flightService.GetAll().Where(e => e.DepartureAirportId == id);
            airport.Flights = flights;
            return View(airport);
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Cities = _cityService.GetAll()
                .OrderBy(_ => _.ToString());
            if (id == null)
                return View();
            var airport = _airportService.GetById(id.Value);
            return View(airport);
        }
        [HttpPost]
        public IActionResult Edit(AirportDto airport)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Edit), new { id = airport.Id });
            var res = _airportService.CreateOrUpdate(airport);
            return RedirectToAction(nameof(Index), new { id = res.Id });
        }
        public IActionResult Delete(int id)
        {
            var airport = _airportService.GetById(id);
            var flights = _flightService.GetAll().Where(e => e.DepartureAirportId == id);
            foreach (var f in flights)
                _flightService.Delete(f.Id);
            _airportService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}