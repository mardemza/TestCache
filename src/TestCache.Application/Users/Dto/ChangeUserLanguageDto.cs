using System.ComponentModel.DataAnnotations;

namespace TestCache.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}