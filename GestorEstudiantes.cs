using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionEstudiantes
{
   
    public class EstudianteNoEncontradoException : Exception
    {
        public EstudianteNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class GestorEstudiantes
    {
        private List<Estudiante> listaEstudiantes;

        public GestorEstudiantes()
        {
            listaEstudiantes = new List<Estudiante>();
        }

 
        public List<Estudiante> ObtenerEstudiantes()
        {
            return listaEstudiantes;
        }

       
        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            bool existe = listaEstudiantes.Any(e => e.IdMatricula.Equals(nuevoEstudiante.IdMatricula, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                throw new InvalidOperationException("El ID o matrícula ingresado ya se encuentra registrado en el sistema.");
            }

            if (nuevoEstudiante.Edad <= 0 || nuevoEstudiante.Edad > 120)
            {
                throw new ArgumentException("La edad ingresada no es válida.");
            }

            listaEstudiantes.Add(nuevoEstudiante);
        }

     
        public List<Estudiante> BuscarEstudiantes(string criterio)
        {
            var resultados = listaEstudiantes.Where(e =>
                e.IdMatricula.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0 ||
                e.NombreCompleto.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            if (resultados.Count == 0)
            {
                throw new EstudianteNoEncontradoException("No se encontró ningún estudiante con el criterio de búsqueda especificado.");
            }

            return resultados;
        }

      
        public void ActualizarEstudiante(string idMatricula, string nuevoNombre, int nuevaEdad, Sexo nuevoSexo, string nuevaCarrera, EstadoAcademico nuevoEstado)
        {
            Estudiante est = listaEstudiantes.FirstOrDefault(e => e.IdMatricula.Equals(idMatricula, StringComparison.OrdinalIgnoreCase));

            if (est == null)
            {
                throw new EstudianteNoEncontradoException("El estudiante a actualizar no fue encontrado en el sistema.");
            }

            est.NombreCompleto = nuevoNombre;
            est.Edad = nuevaEdad;
            est.SexoEstudiante = nuevoSexo;
            est.Carrera = nuevaCarrera;
            est.Estado = nuevoEstado;
        }

      
        public void EliminarEstudiante(string idMatricula)
        {
            Estudiante est = listaEstudiantes.FirstOrDefault(e => e.IdMatricula.Equals(idMatricula, StringComparison.OrdinalIgnoreCase));

            if (est == null)
            {
                throw new EstudianteNoEncontradoException("El estudiante que intenta eliminar no existe.");
            }

            listaEstudiantes.Remove(est);
        }
    }
}