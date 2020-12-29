using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PC04.Models
{

    [Table("Usuario")]
    public class Usuario
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("contraseña")]
        public string contraseña { get; set; }

    }
    
        
    
}