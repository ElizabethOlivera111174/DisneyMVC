using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disney.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id {get; set;}

        [Required(ErrorMessage = "Escriba su email")]
        [EmailAddress(ErrorMessage = "Escriba un correo valido")]
        public string email {get; set;}

        [Required(ErrorMessage = "Escriba su Password")]
        public string password {get;set;}

        public string Sal { get; set; }

        [Required(ErrorMessage = "Escriba su Nombre")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 50 caracteres")]
        public string Nombre{get; set;}

        [Required(ErrorMessage = "Escriba su Apellido")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 50 caracteres")]
        public string Apellido{get; set;}

        [Required(ErrorMessage = "Escriba su Nombre")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 50 caracteres")]
        public string nobreUsu{get; set;}
             
        public Usuario(){}
        public Usuario(int id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }

    }
}
