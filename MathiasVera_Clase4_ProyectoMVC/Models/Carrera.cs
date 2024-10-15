using System.ComponentModel.DataAnnotations;

namespace MathiasVera_Clase4_ProyectoMVC.Models
{
    public class Carrera
    {
        [Key] // Primary Key de Carrera
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
