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
        [MaxLength(50, ErrorMessage = "el campo no debe tener mas de 50 caracteres")] //da el tamaño maximo de caracteres y el mesaje de error
        public required string Name { get; set; } //required es para que el campo sea requerido

        [Column("abbreviation")]
        [MinLength(2, ErrorMessage = "El campo debe tener minimo 2 caracteres")] // este da el minimo de caracteres
        [MaxLength(10, ErrorMessage = "el campo no debe tener mas de 10 caracteres")]
        public required string Abbreviation { get; set; }

        [Column("description")]
        [MaxLength(500, ErrorMessage = "el campo no debe tener mas de 500 caracteres")]
        public string Description { get; set; }

    }
}