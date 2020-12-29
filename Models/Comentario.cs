using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PC04.Models
{
    public class Comentario
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("descripcion")]
        public string descripcion { get; set; }

        
    }
}