using System.Globalization;
using System.Runtime.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disney.Models
{
    [Table("Generos")]
    public class Genero
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Key]
         public int idGenero {set; get;}
         public string nombre {set; get;}
         public string imagen {set; get;}
        

        public Genero (){

        }
        public Genero(int idGenero, string nombre, string imagen,int idPeliculaSerie){
            this.idGenero = idGenero;
            this.nombre= nombre;
            this.imagen = imagen;
        }

    }
}
