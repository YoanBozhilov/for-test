namespace for_test.Models
{
    public class Tickets
    {
        public Tickets()
        {

        }
        public Tickets(int id, string firstname, string lastname, string email)
        {

            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;

        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
