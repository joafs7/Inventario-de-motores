namespace Inventario_de_motores
{
    partial class Menu_Principal
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
            this.btn_MotoresLinea = new System.Windows.Forms.Button();
            this.btn_MotoresClientes = new System.Windows.Forms.Button();
            this.btn_MotoresDomiciliarios = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MotoresLinea
            // 
            this.btn_MotoresLinea.BackColor = System.Drawing.Color.Lime;
            this.btn_MotoresLinea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresLinea.Location = new System.Drawing.Point(65, 35);
            this.btn_MotoresLinea.Name = "btn_MotoresLinea";
            this.btn_MotoresLinea.Size = new System.Drawing.Size(140, 74);
            this.btn_MotoresLinea.TabIndex = 0;
            this.btn_MotoresLinea.Text = "Motores de linea";
            this.btn_MotoresLinea.UseVisualStyleBackColor = false;
            // 
            // btn_MotoresClientes
            // 
            this.btn_MotoresClientes.BackColor = System.Drawing.Color.Lime;
            this.btn_MotoresClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresClientes.Location = new System.Drawing.Point(68, 130);
            this.btn_MotoresClientes.Name = "btn_MotoresClientes";
            this.btn_MotoresClientes.Size = new System.Drawing.Size(140, 74);
            this.btn_MotoresClientes.TabIndex = 1;
            this.btn_MotoresClientes.Text = "Motores de clientes";
            this.btn_MotoresClientes.UseVisualStyleBackColor = false;
            // 
            // btn_MotoresDomiciliarios
            // 
            this.btn_MotoresDomiciliarios.BackColor = System.Drawing.Color.Lime;
            this.btn_MotoresDomiciliarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresDomiciliarios.Location = new System.Drawing.Point(68, 236);
            this.btn_MotoresDomiciliarios.Name = "btn_MotoresDomiciliarios";
            this.btn_MotoresDomiciliarios.Size = new System.Drawing.Size(140, 74);
            this.btn_MotoresDomiciliarios.TabIndex = 2;
            this.btn_MotoresDomiciliarios.Text = "Motores Domiciliarios";
            this.btn_MotoresDomiciliarios.UseVisualStyleBackColor = false;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btn_CerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(68, 342);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(140, 74);
            this.btn_CerrarSesion.TabIndex = 3;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(276, 428);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_MotoresDomiciliarios);
            this.Controls.Add(this.btn_MotoresClientes);
            this.Controls.Add(this.btn_MotoresLinea);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MotoresLinea;
        private System.Windows.Forms.Button btn_MotoresClientes;
        private System.Windows.Forms.Button btn_MotoresDomiciliarios;
        private System.Windows.Forms.Button btn_CerrarSesion;
    }
}