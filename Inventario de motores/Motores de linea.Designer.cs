namespace Inventario_de_motores
{
    partial class Motores_de_linea
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
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.lbl_RPM = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.cbx_RPM = new System.Windows.Forms.ComboBox();
            this.cbx_HP = new System.Windows.Forms.ComboBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Location = new System.Drawing.Point(29, 23);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(132, 39);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modificar.Location = new System.Drawing.Point(194, 23);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(132, 39);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(369, 23);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(132, 39);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Location = new System.Drawing.Point(539, 23);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(132, 39);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.Location = new System.Drawing.Point(712, 23);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 39);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(26, 91);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 5;
            this.lbl_Marca.Text = "Marca";
            this.lbl_Marca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_HP
            // 
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.Location = new System.Drawing.Point(173, 91);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(22, 13);
            this.lbl_HP.TabIndex = 6;
            this.lbl_HP.Text = "HP";
            // 
            // lbl_RPM
            // 
            this.lbl_RPM.AutoSize = true;
            this.lbl_RPM.Location = new System.Drawing.Point(323, 91);
            this.lbl_RPM.Name = "lbl_RPM";
            this.lbl_RPM.Size = new System.Drawing.Size(31, 13);
            this.lbl_RPM.TabIndex = 7;
            this.lbl_RPM.Text = "RPM";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(488, 91);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 8;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "WEG",
            "SIEMENS",
            "MEC",
            "TEM",
            "DAFA",
            "ADAS",
            "ALFA",
            "CZERWENY"});
            this.cbx_Marca.Location = new System.Drawing.Point(29, 112);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(131, 21);
            this.cbx_Marca.TabIndex = 9;
            // 
            // cbx_RPM
            // 
            this.cbx_RPM.FormattingEnabled = true;
            this.cbx_RPM.Items.AddRange(new object[] {
            "750",
            "900",
            "1500",
            "3000"});
            this.cbx_RPM.Location = new System.Drawing.Point(326, 112);
            this.cbx_RPM.Name = "cbx_RPM";
            this.cbx_RPM.Size = new System.Drawing.Size(131, 21);
            this.cbx_RPM.TabIndex = 10;
            // 
            // cbx_HP
            // 
            this.cbx_HP.FormattingEnabled = true;
            this.cbx_HP.Items.AddRange(new object[] {
            "0.25",
            "0.33",
            "0.5",
            "0.75",
            "1",
            "2",
            "3",
            "4",
            "5.5",
            "7.5",
            "10",
            "12.5",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "100",
            "125"});
            this.cbx_HP.Location = new System.Drawing.Point(176, 112);
            this.cbx_HP.Name = "cbx_HP";
            this.cbx_HP.Size = new System.Drawing.Size(131, 21);
            this.cbx_HP.TabIndex = 11;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(491, 112);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 344);
            this.dataGridView1.TabIndex = 13;
            // 
            // Motores_de_linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cbx_HP);
            this.Controls.Add(this.cbx_RPM);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_RPM);
            this.Controls.Add(this.lbl_HP);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "Motores_de_linea";
            this.Text = "Motores_de_linea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.Label lbl_RPM;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.ComboBox cbx_RPM;
        private System.Windows.Forms.ComboBox cbx_HP;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}