using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConeBD
{
    public class Global
    {
        public static List<Proyectos> ListarProyectos()
        {
            using (var dbContext = new ConexionBD())
            {
                return dbContext.Proyecto.ToList();
            }
        }



        public static bool GuardarProyecto(string nombre, DateTime fechaInicio, DateTime fechaFinal, string estado)
        {
            try
            {
                using (var dbContext = new ConexionBD())
                {
                    var proyecto = new Proyectos
                    {
                        Nombre = nombre,
                        FechaInicio = fechaInicio,
                        FechaFinal = fechaFinal,
                        Estado = estado
                    };

                    dbContext.Proyecto.Add(proyecto);
                    dbContext.SaveChanges();
                    return true; // Operación de guardado exitosa
                }
            }
            catch (Exception ex)
            {
                // Registra el mensaje de error
                Console.WriteLine("Error al guardar el proyecto: " + ex.Message);
                return false; // Operación de guardado fallida
            }

        }
    }
}
