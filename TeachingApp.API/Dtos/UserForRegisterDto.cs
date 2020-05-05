using System.ComponentModel.DataAnnotations; 
namespace TeachingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required] 
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set;}
}
}