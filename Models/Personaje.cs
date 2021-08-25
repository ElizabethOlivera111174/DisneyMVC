using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disney.Models
{
    [Table("Personajes")]
    public class Personaje
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idPersonaje {set; get;}

        [Required(ErrorMessage = "Escriba el nombre del personaje")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 50 caracteres")]
        public string nombre {set; get;}

        [Required(ErrorMessage = "Escriba la edad del personaje")]
        public int edad {set; get;}

        [Required(ErrorMessage = "Escriba el peso del personaje")]
        public int peso {set; get;}

        [Required(ErrorMessage = "Escriba la historia del personaje")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 3 caracteres")]
        public string historia {set; get;}

        
        public string imagen {set; get;}

        public Personaje(){

        }        

        public Personaje(int idPersonaje, string nombre, int edad, int peso, string historia, string imagen){
            this.idPersonaje= idPersonaje;
            this.nombre= nombre;
            this.edad= edad;
            this.peso= peso;
            this.historia= historia;
            this.imagen= imagen;
        }


    }
}
