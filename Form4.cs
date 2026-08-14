using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEstudiantes;


namespace Sistema_Gestión_de_Estudiantes
{
    public partial class Form4 : Form
    {
        private GestorEstudiantes gestorCompartido;

        public Form4()
        {
            InitializeComponent();
            gestorCompartido = new GestorEstudiantes();
            CargarEstudiantes();
        }

      
        public Form4(GestorEstudiantes gestor)
        {
            InitializeComponent();
            gestorCompartido = gestor;
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = gestorCompartido.ObtenerEstudiantes();

       
            if (dgvEstudiantes.Columns["IdMatricula"] != null)
                dgvEstudiantes.Columns["IdMatricula"].HeaderText = "Matrícula";

            if (dgvEstudiantes.Columns["NombreCompleto"] != null)
                dgvEstudiantes.Columns["NombreCompleto"].HeaderText = "Nombre";

            if (dgvEstudiantes.Columns["Edad"] != null)
                dgvEstudiantes.Columns["Edad"].HeaderText = "Edad";

            if (dgvEstudiantes.Columns["Sexo"] != null)
                dgvEstudiantes.Columns["Sexo"].HeaderText = "Sexo";

            if (dgvEstudiantes.Columns["Carrera"] != null)
                dgvEstudiantes.Columns["Carrera"].HeaderText = "Carrera";

            if (dgvEstudiantes.Columns["EstadoAcademico"] != null)
                dgvEstudiantes.Columns["EstadoAcademico"].HeaderText = "Estado";

            if (dgvEstudiantes.Columns["FechaInscripcion"] != null)
                dgvEstudiantes.Columns["FechaInscripcion"].HeaderText = "Fecha";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}