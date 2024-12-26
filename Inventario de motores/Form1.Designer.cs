namespace Inventario_de_motores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_Contraseña;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            lbl_Contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
            lbl_Contraseña.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Contraseña.Location = new System.Drawing.Point(619, 347);
            lbl_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new System.Drawing.Size(214, 48);
            lbl_Contraseña.TabIndex = 2;
            lbl_Contraseña.Text = "Contraseña";
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.Lime;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.Location = new System.Drawing.Point(597, 524);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(311, 60);
            this.btn_IniciarSesion.TabIndex = 0;
            this.btn_IniciarSesion.Text = "Iniciar Sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(646, 196);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(167, 48);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Usuario.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(481, 270);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(518, 55);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_Contrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Contrasena.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasena.Location = new System.Drawing.Point(481, 420);
            this.txt_Contrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(518, 55);
            this.txt_Contrasena.TabIndex = 4;
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.Lime;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.Location = new System.Drawing.Point(597, 640);
            this.btn_crearUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(311, 60);
            this.btn_crearUsuario.TabIndex = 5;
            this.btn_crearUsuario.Text = "Crear Usuario";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1357, 796);
            this.Controls.Add(this.btn_crearUsuario);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_IniciarSesion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Inventario de motores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Button btn_crearUsuario;
    }
}

