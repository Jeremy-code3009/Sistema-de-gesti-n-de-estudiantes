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
    public partial class Form1 : Form
    {
        private GestorEstudiantes gestor;

       
        public Form1()
        {
            InitializeComponent();
            gestor = new GestorEstudiantes();
        }

        
        public Form1(GestorEstudiantes gestorMaestro)
        {
            InitializeComponent();
            gestor = gestorMaestro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoAcademico));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtCarrera.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtEdad.Text, out int edad))
                {
                    MessageBox.Show("El campo edad debe contener un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Estudiante nuevo = new Estudiante(
                    txtMatricula.Text.Trim(),
                    txtNombre.Text.Trim(),
                    edad,
                    (Sexo)cmbSexo.SelectedItem,
                    txtCarrera.Text.Trim(),
                    (EstadoAcademico)cmbEstado.SelectedItem,
                    dtpInscripcion.Value
                );

                gestor.RegistrarEstudiante(nuevo);

                MessageBox.Show("¡Estudiante registrado exitosamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult respuesta = MessageBox.Show("¿Desea registrar otro estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    txtMatricula.Clear();
                    txtNombre.Clear();
                    txtEdad.Clear();
                    txtCarrera.Clear();
                    txtMatricula.Focus();
                }
                else
                {
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}