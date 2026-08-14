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
    public partial class Form7 : Form
    {
        private GestorEstudiantes gestorCompartido;

        public Form7(GestorEstudiantes gestor)
        {
            InitializeComponent();
            gestorCompartido = gestor;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, ingrese la matrícula del estudiante a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string matriculaBuscada = txtMatricula.Text.Trim();

           
                var estudianteAEliminar = gestorCompartido.ObtenerEstudiantes()
                    .Find(x => x.IdMatricula.Equals(matriculaBuscada, StringComparison.OrdinalIgnoreCase));

                if (estudianteAEliminar != null)
                {
                
                    DialogResult resultado = MessageBox.Show(
                        $"¿Está seguro de que desea eliminar al estudiante {estudianteAEliminar.NombreCompleto}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                      
                        gestorCompartido.ObtenerEstudiantes().Remove(estudianteAEliminar);

                        MessageBox.Show("¡Estudiante eliminado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estudiante registrado con esa matrícula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}