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
            this.btn_MotoresLinea.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MotoresLinea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresLinea.Location = new System.Drawing.Point(514, 53);
            this.btn_MotoresLinea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MotoresLinea.Name = "btn_MotoresLinea";
            this.btn_MotoresLinea.Size = new System.Drawing.Size(413, 114);
            this.btn_MotoresLinea.TabIndex = 0;
            this.btn_MotoresLinea.Text = "Motores de linea";
            this.btn_MotoresLinea.UseVisualStyleBackColor = false;
            this.btn_MotoresLinea.Click += new System.EventHandler(this.btn_MotoresLinea_Click);
            // 
            // btn_MotoresClientes
            // 
            this.btn_MotoresClientes.BackColor = System.Drawing.Color.Lime;
            this.btn_MotoresClientes.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MotoresClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresClientes.Location = new System.Drawing.Point(518, 199);
            this.btn_MotoresClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MotoresClientes.Name = "btn_MotoresClientes";
            this.btn_MotoresClientes.Size = new System.Drawing.Size(413, 114);
            this.btn_MotoresClientes.TabIndex = 1;
            this.btn_MotoresClientes.Text = "Motores de clientes";
            this.btn_MotoresClientes.UseVisualStyleBackColor = false;
            this.btn_MotoresClientes.Click += new System.EventHandler(this.btn_MotoresClientes_Click);
            // 
            // btn_MotoresDomiciliarios
            // 
            this.btn_MotoresDomiciliarios.BackColor = System.Drawing.Color.Lime;
            this.btn_MotoresDomiciliarios.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MotoresDomiciliarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_MotoresDomiciliarios.Location = new System.Drawing.Point(518, 362);
            this.btn_MotoresDomiciliarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MotoresDomiciliarios.Name = "btn_MotoresDomiciliarios";
            this.btn_MotoresDomiciliarios.Size = new System.Drawing.Size(413, 114);
            this.btn_MotoresDomiciliarios.TabIndex = 2;
            this.btn_MotoresDomiciliarios.Text = "Motores Domiciliarios";
            this.btn_MotoresDomiciliarios.UseVisualStyleBackColor = false;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(518, 525);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(413, 114);
            this.btn_CerrarSesion.TabIndex = 3;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1357, 796);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_MotoresDomiciliarios);
            this.Controls.Add(this.btn_MotoresClientes);
            this.Controls.Add(this.btn_MotoresLinea);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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