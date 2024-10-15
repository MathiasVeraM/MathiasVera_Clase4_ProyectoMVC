using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MathiasVera_Clase4_ProyectoMVC.Models
{
    public class Estudiante
    {
        [Key] // Esta anotación sirve para ver que el Id es la primary key de Estudiante
        public int Id { get; set; }
        [MaxLength(200)]
        [Required] // Maximo una longitud de 200 caracteres y que sea requerido
        public string Nombre { get; set; }
        [EmailAddress]
        public string? Correo { get; set; } // El ? es para que el correo pueda ser null
        public DateTime FechaNacimiento { get; set; }
        public Boolean TieneBeca {  get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")] // Señala que IdCarrera es el foreign key de Carrera
        public int IdCarrera { get; set; }

    }
}
