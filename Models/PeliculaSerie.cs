using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disney.Models
{
    [Table("PeliculasSeries")]
    public class PeliculaSerie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idPeliculaSerie{set; get;}

        [Required(ErrorMessage = "Escriba el nombre de la pelicula")]
        [MinLength(5,ErrorMessage = "Debe escribir mas de 5 caracteres")]
        [MaxLength(50,ErrorMessage = "Debe escribir maximo 50 caracteres")]
        public string titulo {set; get;}

        [Required(ErrorMessage = "Escriba la fecha de cracion de la pelicula")]
        public DateTime fechaCreacion {set; get;}

        [Required(ErrorMessage = "Escriba la fecha de cracion de la pelicula")]
        public int calificacion {set; get;}
        public string imagen {set; get;}
        
         public int idGenero{set; get;}
         [ForeignKey("idGenero")]
         public Genero generos{get; set;}

        public PeliculaSerie(){

        }
        public PeliculaSerie(int idPeliculaSerie, string titulo, DateTime fechaCreacion, int calificacion, string imagen){
            this.idPeliculaSerie= idPeliculaSerie;
            this.titulo= titulo;
            this.fechaCreacion= fechaCreacion;
            this.calificacion= calificacion;
            this.imagen= imagen;
        }
    }
}
