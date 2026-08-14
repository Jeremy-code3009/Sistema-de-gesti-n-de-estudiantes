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
    public partial class Form3 : Form
    {
        
        private GestorEstudiantes gestorMaestro = new GestorEstudiantes();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnMenuRegistrar_Click(object sender, EventArgs e)
        {
          
            Form1 formRegistro = new Form1(gestorMaestro);
            formRegistro.ShowDialog();
        }

        private void btnMenuListar_Click(object sender, EventArgs e)
        {
           
            Form4 formListar = new Form4(gestorMaestro);
            formListar.ShowDialog();
        }

        private void btnMenuBuscar_Click(object sender, EventArgs e)
        {
           
            Form5 formBuscar = new Form5(gestorMaestro);
            formBuscar.ShowDialog();
        }

        private void btnMenuActualizar_Click(object sender, EventArgs e)
        {

            Form6 formActualizar = new Form6(gestorMaestro);
            formActualizar.ShowDialog();
        }

        private void btnMenuEliminar_Click(object sender, EventArgs e)
        {
   
            Form7 formEliminar = new Form7(gestorMaestro);
            formEliminar.ShowDialog();
        }

        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}