namespace for_test.DTOs
{
    public class UserDTO
    {
        public UserDTO()
        {

        }
        public UserDTO(int id, string username, string password)
        {

            Id = id;
            Username = username;
            Password = password;

        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
