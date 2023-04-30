namespace for_test.Models
{
    public class Ticket
    {
        public Ticket()
        {

        }
        public Ticket(int id, string name, string price)
        {

            Id = id;
            Name = name;
            Price = price;
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        
    }
}
