using for_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace for_test.Services
{
    public class EventService
    {

        private SQLDbContext dbContext;

        public EventService(SQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Event> GetAll()
        {
            return dbContext.Events.ToList();
        }

        public Event GetById(int id)
        {
            return dbContext.Events.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Event game)
        {
            dbContext.Events.Add(game);
            dbContext.SaveChanges();
        }

        public void Edit(Event game)
        {
            Event dbProduct = GetById(game.Id);

            dbProduct.Name = game.Name;
            dbProduct.Description = game.Description;
            dbProduct.PremiereDate = game.PremiereDate;
            dbProduct.Picture = game.Picture;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Event dbProduct = GetById(id);

            dbContext.Events.Remove(dbProduct);
            dbContext.SaveChanges();
        }

    }
}