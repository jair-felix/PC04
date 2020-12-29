using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace PC04.Models
{
    public class Imagenes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("titulo")]
        public string titulo { get; set; }

        [Column("imagen")]
        public string imagen { get; set; }

        public ICollection<Comentario> Comentario { get; set; }

        
    }
}