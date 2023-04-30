using for_test.DTOs;
using for_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace for_test.Services
{
    public class TicketService
    {
        private SQLDbContext dbContext;

        public TicketService(SQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<TicketDTO> GetAll()
        {
            return dbContext.Tickets.Select(u => ToDTO(u)).ToList();
        }

        public Ticket GetById(int id)
        {
            return dbContext.Tickets.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Ticket ticket)
        {
            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();
        }

        public void Edit(Ticket ticket)
        {
            Ticket dbTicket = GetById(ticket.Id);

            dbTicket.Name = ticket.Name;
            dbTicket.Price = ticket.Price;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Ticket dbTicket = GetById(id);

            dbContext.Tickets.Remove(dbTicket);
            dbContext.SaveChanges();
        }
        private static TicketDTO ToDTO(Ticket ticket)
        {
            return new TicketDTO(ticket.Id, ticket.Name, ticket.Price);
        }
    }
}
