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
    public partial class Form6 : Form
    {
        private GestorEstudiantes gestorCompartido;
        private Estudiante estudianteEncontrado = null;

        public Form6(GestorEstudiantes gestor)
        {
            InitializeComponent();
            gestorCompartido = gestor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatriculaBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese la matrícula a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
 
                estudianteEncontrado = gestorCompartido.ObtenerEstudiantes()
                    .Find(x => x.IdMatricula.Equals(txtMatriculaBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (estudianteEncontrado != null)
                {
               
                    txtNombre.Text = estudianteEncontrado.NombreCompleto;
                    txtEdad.Text = estudianteEncontrado.Edad.ToString();
                    txtCarrera.Text = estudianteEncontrado.Carrera;
                    MessageBox.Show("¡Estudiante encontrado! Modifique los datos y presione Actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estudiante con esa matrícula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (estudianteEncontrado == null)
            {
                MessageBox.Show("Primero debe buscar y cargar un estudiante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(txtEdad.Text, out int nuevaEdad))
                {
                    MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

           
                estudianteEncontrado.NombreCompleto = txtNombre.Text.Trim();
                estudianteEncontrado.Edad = nuevaEdad;
                estudianteEncontrado.Carrera = txtCarrera.Text.Trim();

                MessageBox.Show("¡Estudiante actualizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
