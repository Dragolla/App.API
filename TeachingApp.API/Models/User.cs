namespace TeachingApp.API.Models
{
    public class User
    {
        public int ID { get; set; }
        public  string username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}