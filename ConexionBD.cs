using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace ConeBD
{
    public class ConexionBD : DbContext
    {
        public ConexionBD() : base("name=MiConexionBD")
        {

        }

        public DbSet<Proyectos> Proyecto { get; set; }


    }

    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Estado { get; set; }
    }


}
