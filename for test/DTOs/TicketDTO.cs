namespace for_test.DTOs
{
    public class TicketDTO
    {
        public TicketDTO()
        {

        }
        public TicketDTO(int id, string name, string price)
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

