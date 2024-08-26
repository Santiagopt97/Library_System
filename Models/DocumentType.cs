using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System.Models
{
    [Table("document_types")] //Table("Nombre de la tabla en la abse de datos)
    public class DocumentType
    {
        [Key] //Para identificar cual es la llave primaria 
        [Column("id")]
        public int Id { get; set; }

        [Column("name")] //Column("Nombre de la tabla en la base de datos")
        public required string Name { get; set; } //required es para que el campo sea requerido

        [Column("abbreviation")]
        public required string Abbreviation { get; set; }

        [Column("description")]
        public string Description { get; set; }

    }
}