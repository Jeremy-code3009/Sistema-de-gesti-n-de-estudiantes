namespace Sistema_Gestión_de_Estudiantes
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuRegistrar = new System.Windows.Forms.Button();
            this.btnMenuListar = new System.Windows.Forms.Button();
            this.btnMenuBuscar = new System.Windows.Forms.Button();
            this.btnMenuActualizar = new System.Windows.Forms.Button();
            this.btnMenuEliminar = new System.Windows.Forms.Button();
            this.btnMenuSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuRegistrar
            // 
            this.btnMenuRegistrar.Location = new System.Drawing.Point(219, 12);
            this.btnMenuRegistrar.Name = "btnMenuRegistrar";
            this.btnMenuRegistrar.Size = new System.Drawing.Size(331, 49);
            this.btnMenuRegistrar.TabIndex = 0;
            this.btnMenuRegistrar.Text = "1. Registrar Nuevo Estudiante";
            this.btnMenuRegistrar.UseVisualStyleBackColor = true;
            this.btnMenuRegistrar.Click += new System.EventHandler(this.btnMenuRegistrar_Click);
            // 
            // btnMenuListar
            // 
            this.btnMenuListar.Location = new System.Drawing.Point(310, 89);
            this.btnMenuListar.Name = "btnMenuListar";
            this.btnMenuListar.Size = new System.Drawing.Size(138, 46);
            this.btnMenuListar.TabIndex = 1;
            this.btnMenuListar.Text = "2. Listado";
            this.btnMenuListar.UseVisualStyleBackColor = true;
            this.btnMenuListar.Click += new System.EventHandler(this.btnMenuListar_Click);
            // 
            // btnMenuBuscar
            // 
            this.btnMenuBuscar.Location = new System.Drawing.Point(262, 164);
            this.btnMenuBuscar.Name = "btnMenuBuscar";
            this.btnMenuBuscar.Size = new System.Drawing.Size(231, 46);
            this.btnMenuBuscar.TabIndex = 2;
            this.btnMenuBuscar.Text = "3. Buscar Estudiante";
            this.btnMenuBuscar.UseVisualStyleBackColor = true;
            this.btnMenuBuscar.Click += new System.EventHandler(this.btnMenuBuscar_Click);
            // 
            // btnMenuActualizar
            // 
            this.btnMenuActualizar.Location = new System.Drawing.Point(249, 242);
            this.btnMenuActualizar.Name = "btnMenuActualizar";
            this.btnMenuActualizar.Size = new System.Drawing.Size(253, 46);
            this.btnMenuActualizar.TabIndex = 3;
            this.btnMenuActualizar.Text = "4. Actualizar Estudiante";
            this.btnMenuActualizar.UseVisualStyleBackColor = true;
            this.btnMenuActualizar.Click += new System.EventHandler(this.btnMenuActualizar_Click);
            // 
            // btnMenuEliminar
            // 
            this.btnMenuEliminar.Location = new System.Drawing.Point(262, 320);
            this.btnMenuEliminar.Name = "btnMenuEliminar";
            this.btnMenuEliminar.Size = new System.Drawing.Size(231, 46);
            this.btnMenuEliminar.TabIndex = 4;
            this.btnMenuEliminar.Text = "5. Eliminar Estudiante";
            this.btnMenuEliminar.UseVisualStyleBackColor = true;
            this.btnMenuEliminar.Click += new System.EventHandler(this.btnMenuEliminar_Click);
            // 
            // btnMenuSalir
            // 
            this.btnMenuSalir.Location = new System.Drawing.Point(262, 392);
            this.btnMenuSalir.Name = "btnMenuSalir";
            this.btnMenuSalir.Size = new System.Drawing.Size(231, 46);
            this.btnMenuSalir.TabIndex = 5;
            this.btnMenuSalir.Text = "6. Salir del Sistema";
            this.btnMenuSalir.UseVisualStyleBackColor = true;
            this.btnMenuSalir.Click += new System.EventHandler(this.btnMenuSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuSalir);
            this.Controls.Add(this.btnMenuEliminar);
            this.Controls.Add(this.btnMenuActualizar);
            this.Controls.Add(this.btnMenuBuscar);
            this.Controls.Add(this.btnMenuListar);
            this.Controls.Add(this.btnMenuRegistrar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuRegistrar;
        private System.Windows.Forms.Button btnMenuListar;
        private System.Windows.Forms.Button btnMenuBuscar;
        private System.Windows.Forms.Button btnMenuActualizar;
        private System.Windows.Forms.Button btnMenuEliminar;
        private System.Windows.Forms.Button btnMenuSalir;
    }
}