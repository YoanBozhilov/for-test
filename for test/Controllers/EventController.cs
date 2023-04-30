using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using for_test.Models;
using for_test.Services;

namespace for_test.Controllers
{
    public class EventController : Controller
    {
        private EventService eventService;

        public EventController(EventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = eventService.GetAll();

            return View(events);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Event game = eventService.GetById(id);

            return View(game);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Event game)
        {
            eventService.Create(game);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Event game = eventService.GetById(id);

            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Event game)
        {
            eventService.Edit(game);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Event game = eventService.GetById(id);

            return View(game);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            eventService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}