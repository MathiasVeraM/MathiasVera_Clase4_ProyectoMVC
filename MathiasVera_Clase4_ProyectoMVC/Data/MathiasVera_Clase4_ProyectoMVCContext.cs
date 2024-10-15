using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MathiasVera_Clase4_ProyectoMVC.Models;

namespace MathiasVera_Clase4_ProyectoMVC.Data
{
    public class MathiasVera_Clase4_ProyectoMVCContext : DbContext
    {
        public MathiasVera_Clase4_ProyectoMVCContext (DbContextOptions<MathiasVera_Clase4_ProyectoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MathiasVera_Clase4_ProyectoMVC.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<MathiasVera_Clase4_ProyectoMVC.Models.Carrera> Carrera { get; set; } = default!;
    }
}
