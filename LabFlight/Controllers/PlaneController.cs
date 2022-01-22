using Business.Interop;
using Business.MyService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LabFlight.Controllers
{
    public class PlaneController : Controller
    {
        private readonly IPlaneService _planeService;
        private readonly ISeatService _seatService;


        public PlaneController(IPlaneService planeService, ISeatService seatService)
        {
            _planeService = planeService;
            _seatService = seatService;
        }

        public IActionResult Index()
        {
            var planes = _planeService.GetAll();
            return View(planes);
        }
        public IActionResult Home(int id)
        {
            var plane = _planeService.GetById(id);
            var seats = _seatService.GetAll().Where(e => e.PlaneId == id);
            plane.Seats = seats;
            return View(plane);
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Seats = _seatService.GetAll()
                .OrderBy(_ => _.ToString());
            if (id == null)
                return View();
            var plane = _planeService.GetById(id.Value);
            return View(plane);
        }
        [HttpPost]
        public IActionResult Edit(PlaneDto plane)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Edit), new { id = plane.Id });
            var res = _planeService.CreateOrUpdate(plane);
            return RedirectToAction(nameof(Index), new { id = res.Id });
        }
        public IActionResult Delete(int id)
        {
            _planeService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
