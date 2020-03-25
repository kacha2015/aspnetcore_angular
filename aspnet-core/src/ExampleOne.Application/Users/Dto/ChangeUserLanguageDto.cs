using System.ComponentModel.DataAnnotations;

namespace ExampleOne.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}