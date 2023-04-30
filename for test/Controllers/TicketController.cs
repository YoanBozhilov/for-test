using for_test.DTOs;
using for_test.Models;
using Microsoft.AspNetCore.Mvc;
using for_test.Services;

namespace for_test.Controllers
{
    public class TicketController : Controller
    {
        private TicketService ticketService;

        public TicketController(TicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<TicketDTO> tickets = ticketService.GetAll();

            return View(tickets);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Ticket ticket = ticketService.GetById(id);

            return View(ticket);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            ticketService.Create(ticket);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Ticket ticket = ticketService.GetById(id);

            return View(ticket);
        }

        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            ticketService.Edit(ticket);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Ticket ticket = ticketService.GetById(id);

            return View(ticket);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            ticketService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

