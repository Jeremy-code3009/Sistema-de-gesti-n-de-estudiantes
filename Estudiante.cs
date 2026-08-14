using System;

namespace SistemaGestionEstudiantes
{
    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public enum EstadoAcademico
    {
        Activo,
        Inactivo,
        Graduado,
        Suspendido,
        Transferido
    }

    public class Estudiante
    {
        public string IdMatricula { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public Sexo SexoEstudiante { get; set; }
        public string Carrera { get; set; }
        public EstadoAcademico Estado { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public Estudiante() { }

        public Estudiante(string idMatricula, string nombreCompleto, int edad, Sexo sexoEstudiante, string carrera, EstadoAcademico estado, DateTime fechaInscripcion)
        {
            IdMatricula = idMatricula;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            SexoEstudiante = sexoEstudiante;
            Carrera = carrera;
            Estado = estado;
            FechaInscripcion = fechaInscripcion;
        }
    }
}