using System.ComponentModel.DataAnnotations;

namespace projectAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}