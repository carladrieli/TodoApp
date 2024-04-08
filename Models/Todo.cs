using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Title { get; set; }
        [DisplayName("Concluído")]
        public bool Done { get; set; }
        [DisplayName("Usuário")]
        public string User { get; set; }
    }
}