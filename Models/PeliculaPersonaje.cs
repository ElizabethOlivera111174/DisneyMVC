using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Disney.Models;

namespace Disney.Models
{
    [Table("PeliculasPerosnajes")]
    public class PeliculaPersonaje
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idPeliculaPersonaje {set; get;}
        public int idPeliculaSerie {set; get;}
        [ForeignKey("idPeliculaSerie")]

         public PeliculaSerie peliculasSeries{get; set;}

        public int idPersonaje {set; get;}
        [ForeignKey("idPersonaje")]
        public Personaje personajes{get; set;}


         public PeliculaPersonaje(){

         }
    }
}
