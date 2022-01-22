using Business.Interop;
using Business.MyService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LabFlight.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        private readonly ITicketService _ticketService;

        public PersonController(IPersonService personService, ITicketService ticketService)
        {
            _personService = personService;
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            var people = _personService.GetAll();
            return View(people);
        }
        public IActionResult Home(int id)
        {
            var person = _personService.GetById(id);
            var tickets = _ticketService.GetAll().Where(e => e.PersonId == id);
            person.Tickets = tickets;
            return View(person);
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Tickets = _ticketService.GetAll()
                .OrderBy(_ => _.ToString());
            if (id == null)
                return View();
            var person = _personService.GetById(id.Value);
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(PersonDto person)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Edit), new { id = person.Id });
            var res = _personService.CreateOrUpdate(person);
            return RedirectToAction(nameof(Index), new { id = res.Id });
        }
        public IActionResult Delete(int id)
        {
            var person = _personService.GetById(id);
            var tickets = _ticketService.GetAll().Where(e => e.PersonId== id);
            foreach (var t in tickets)
                _ticketService.Delete(t.Id);
            _personService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
