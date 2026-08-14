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
    public partial class Form5 : Form
    {
        private GestorEstudiantes gestorCompartido;

        public Form5()
        {
            InitializeComponent();
            gestorCompartido = new GestorEstudiantes();
        }

        public Form5(GestorEstudiantes gestor)
        {
            InitializeComponent();
            gestorCompartido = gestor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCriterio.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Estudiante> resultados = gestorCompartido.BuscarEstudiantes(txtCriterio.Text.Trim());

                dgvResultados.DataSource = null;
                dgvResultados.DataSource = resultados;

               
                if (dgvResultados.Columns["IdMatricula"] != null)
                    dgvResultados.Columns["IdMatricula"].HeaderText = "Matrícula";
                if (dgvResultados.Columns["NombreCompleto"] != null)
                    dgvResultados.Columns["NombreCompleto"].HeaderText = "Nombre";
                if (dgvResultados.Columns["Edad"] != null)
                    dgvResultados.Columns["Edad"].HeaderText = "Edad";
                if (dgvResultados.Columns["Sexo"] != null)
                    dgvResultados.Columns["Sexo"].HeaderText = "Sexo";
                if (dgvResultados.Columns["Carrera"] != null)
                    dgvResultados.Columns["Carrera"].HeaderText = "Carrera";
                if (dgvResultados.Columns["EstadoAcademico"] != null)
                    dgvResultados.Columns["EstadoAcademico"].HeaderText = "Estado";
                if (dgvResultados.Columns["FechaInscripcion"] != null)
                    dgvResultados.Columns["FechaInscripcion"].HeaderText = "Fecha";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResultados.DataSource = null;
            }
        }
    }
}