using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Contact
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Нужно ввести имя")]
        public string _name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Нужно ввести фамилию")]
        public string _surname { get; set; }

        [Display(Name = "Электронная почта")]
        [Required(ErrorMessage = "Нужно ввести адрес эл. почты")]
        public string _email { get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "Нужно ввести сообщение")]
        [StringLength(30, ErrorMessage = "Сообщение должно содержать не более 30 символов")]
        public string _message { get; set; }
    }
}
