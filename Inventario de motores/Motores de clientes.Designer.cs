namespace Inventario_de_motores
{
    partial class Motores_de_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motores_de_clientes));
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.cbx_HP = new System.Windows.Forms.ComboBox();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.cbx_RPM = new System.Windows.Forms.ComboBox();
            this.lbl_RPM = new System.Windows.Forms.Label();
            this.cbx_Volts = new System.Windows.Forms.ComboBox();
            this.lbl_Volts = new System.Windows.Forms.Label();
            this.cbx_Hz = new System.Windows.Forms.ComboBox();
            this.lbl_Hz = new System.Windows.Forms.Label();
            this.cbx_Cuerpo = new System.Windows.Forms.ComboBox();
            this.lbl_Cuerpo = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.gbx_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_FiltroCliente = new System.Windows.Forms.TextBox();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_ExportarPDF = new System.Windows.Forms.Button();
            this.gbx_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Red;
            this.btn_Volver.Location = new System.Drawing.Point(71, 54);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(242, 60);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Location = new System.Drawing.Point(367, 54);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(242, 60);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modificar.Location = new System.Drawing.Point(665, 54);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(242, 60);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(963, 54);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(242, 60);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Location = new System.Drawing.Point(1265, 54);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(242, 60);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(67, 168);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(58, 20);
            this.lbl_Cliente.TabIndex = 5;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(71, 203);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(151, 26);
            this.txt_Cliente.TabIndex = 6;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(316, 168);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.lbl_Marca.TabIndex = 7;
            this.lbl_Marca.Text = "Marca";
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "WEG",
            "SIEMENS",
            "MEC",
            "TEM",
            "DAFA",
            "ADAS",
            "ALFA",
            "CZERWENY",
            "STM"});
            this.cbx_Marca.Location = new System.Drawing.Point(317, 203);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(154, 28);
            this.cbx_Marca.TabIndex = 8;
            // 
            // cbx_HP
            // 
            this.cbx_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_HP.Location = new System.Drawing.Point(543, 203);
            this.cbx_HP.Name = "cbx_HP";
            this.cbx_HP.Size = new System.Drawing.Size(162, 28);
            this.cbx_HP.TabIndex = 10;
            // 
            // lbl_HP
            // 
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HP.Location = new System.Drawing.Point(540, 168);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(31, 20);
            this.lbl_HP.TabIndex = 9;
            this.lbl_HP.Text = "HP";
            // 
            // cbx_RPM
            // 
            this.cbx_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_RPM.FormattingEnabled = true;
            this.cbx_RPM.Items.AddRange(new object[] {
            "750",
            "900",
            "1500",
            "3000"});
            this.cbx_RPM.Location = new System.Drawing.Point(778, 203);
            this.cbx_RPM.Name = "cbx_RPM";
            this.cbx_RPM.Size = new System.Drawing.Size(164, 28);
            this.cbx_RPM.TabIndex = 12;
            // 
            // lbl_RPM
            // 
            this.lbl_RPM.AutoSize = true;
            this.lbl_RPM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RPM.Location = new System.Drawing.Point(779, 168);
            this.lbl_RPM.Name = "lbl_RPM";
            this.lbl_RPM.Size = new System.Drawing.Size(44, 20);
            this.lbl_RPM.TabIndex = 11;
            this.lbl_RPM.Text = "RPM";
            // 
            // cbx_Volts
            // 
            this.cbx_Volts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Volts.FormattingEnabled = true;
            this.cbx_Volts.Items.AddRange(new object[] {
            "220",
            "380"});
            this.cbx_Volts.Location = new System.Drawing.Point(310, 311);
            this.cbx_Volts.Name = "cbx_Volts";
            this.cbx_Volts.Size = new System.Drawing.Size(154, 28);
            this.cbx_Volts.TabIndex = 14;
            // 
            // lbl_Volts
            // 
            this.lbl_Volts.AutoSize = true;
            this.lbl_Volts.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Volts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Volts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volts.Location = new System.Drawing.Point(311, 276);
            this.lbl_Volts.Name = "lbl_Volts";
            this.lbl_Volts.Size = new System.Drawing.Size(45, 20);
            this.lbl_Volts.TabIndex = 13;
            this.lbl_Volts.Text = "Volts";
            // 
            // cbx_Hz
            // 
            this.cbx_Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Hz.FormattingEnabled = true;
            this.cbx_Hz.Items.AddRange(new object[] {
            "50 Hz",
            "60 Hz"});
            this.cbx_Hz.Location = new System.Drawing.Point(545, 311);
            this.cbx_Hz.Name = "cbx_Hz";
            this.cbx_Hz.Size = new System.Drawing.Size(160, 28);
            this.cbx_Hz.TabIndex = 16;
            // 
            // lbl_Hz
            // 
            this.lbl_Hz.AutoSize = true;
            this.lbl_Hz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hz.Location = new System.Drawing.Point(546, 276);
            this.lbl_Hz.Name = "lbl_Hz";
            this.lbl_Hz.Size = new System.Drawing.Size(29, 20);
            this.lbl_Hz.TabIndex = 15;
            this.lbl_Hz.Text = "Hz";
            // 
            // cbx_Cuerpo
            // 
            this.cbx_Cuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Cuerpo.FormattingEnabled = true;
            this.cbx_Cuerpo.Items.AddRange(new object[] {
            "71",
            "80",
            "90",
            "100",
            "112",
            "132",
            "160",
            "180",
            "200",
            "225"});
            this.cbx_Cuerpo.Location = new System.Drawing.Point(68, 312);
            this.cbx_Cuerpo.Name = "cbx_Cuerpo";
            this.cbx_Cuerpo.Size = new System.Drawing.Size(154, 28);
            this.cbx_Cuerpo.TabIndex = 18;
            // 
            // lbl_Cuerpo
            // 
            this.lbl_Cuerpo.AutoSize = true;
            this.lbl_Cuerpo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cuerpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cuerpo.Location = new System.Drawing.Point(67, 277);
            this.lbl_Cuerpo.Name = "lbl_Cuerpo";
            this.lbl_Cuerpo.Size = new System.Drawing.Size(61, 20);
            this.lbl_Cuerpo.TabIndex = 17;
            this.lbl_Cuerpo.Text = "Cuerpo";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(778, 315);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(164, 26);
            this.txt_Cantidad.TabIndex = 20;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(774, 280);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(73, 20);
            this.lbl_Cantidad.TabIndex = 19;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // gbx_Cliente
            // 
            this.gbx_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Cliente.Controls.Add(this.txt_FiltroCliente);
            this.gbx_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Cliente.Location = new System.Drawing.Point(1006, 188);
            this.gbx_Cliente.Name = "gbx_Cliente";
            this.gbx_Cliente.Size = new System.Drawing.Size(501, 156);
            this.gbx_Cliente.TabIndex = 21;
            this.gbx_Cliente.TabStop = false;
            this.gbx_Cliente.Text = "Filtro de cliente";
            // 
            // txt_FiltroCliente
            // 
            this.txt_FiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FiltroCliente.Location = new System.Drawing.Point(81, 61);
            this.txt_FiltroCliente.Name = "txt_FiltroCliente";
            this.txt_FiltroCliente.Size = new System.Drawing.Size(354, 30);
            this.txt_FiltroCliente.TabIndex = 22;
            this.txt_FiltroCliente.TextChanged += new System.EventHandler(this.txt_FiltroCliente_TextChanged);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(72, 370);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.RowHeadersWidth = 62;
            this.dgv_Cliente.RowTemplate.Height = 28;
            this.dgv_Cliente.Size = new System.Drawing.Size(1434, 668);
            this.dgv_Cliente.TabIndex = 22;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.White;
            this.btn_Imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.BackgroundImage")));
            this.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Location = new System.Drawing.Point(1535, 469);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(177, 113);
            this.btn_Imprimir.TabIndex = 23;
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_ExportarPDF
            // 
            this.btn_ExportarPDF.BackColor = System.Drawing.Color.White;
            this.btn_ExportarPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExportarPDF.BackgroundImage")));
            this.btn_ExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarPDF.Location = new System.Drawing.Point(1535, 668);
            this.btn_ExportarPDF.Name = "btn_ExportarPDF";
            this.btn_ExportarPDF.Size = new System.Drawing.Size(177, 113);
            this.btn_ExportarPDF.TabIndex = 24;
            this.btn_ExportarPDF.UseVisualStyleBackColor = false;
            this.btn_ExportarPDF.Click += new System.EventHandler(this.btn_ExportarPDF_Click);
            // 
            // Motores_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1724, 1050);
            this.Controls.Add(this.btn_ExportarPDF);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.gbx_Cliente);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.cbx_Cuerpo);
            this.Controls.Add(this.lbl_Cuerpo);
            this.Controls.Add(this.cbx_Hz);
            this.Controls.Add(this.lbl_Hz);
            this.Controls.Add(this.cbx_Volts);
            this.Controls.Add(this.lbl_Volts);
            this.Controls.Add(this.cbx_RPM);
            this.Controls.Add(this.lbl_RPM);
            this.Controls.Add(this.cbx_HP);
            this.Controls.Add(this.lbl_HP);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Volver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Motores_de_clientes";
            this.Text = "Motores_de_clientes";
            this.Load += new System.EventHandler(this.Motores_de_clientes_Load);
            this.gbx_Cliente.ResumeLayout(false);
            this.gbx_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.ComboBox cbx_HP;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.ComboBox cbx_RPM;
        private System.Windows.Forms.Label lbl_RPM;
        private System.Windows.Forms.ComboBox cbx_Volts;
        private System.Windows.Forms.Label lbl_Volts;
        private System.Windows.Forms.ComboBox cbx_Hz;
        private System.Windows.Forms.Label lbl_Hz;
        private System.Windows.Forms.ComboBox cbx_Cuerpo;
        private System.Windows.Forms.Label lbl_Cuerpo;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.GroupBox gbx_Cliente;
        private System.Windows.Forms.TextBox txt_FiltroCliente;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_ExportarPDF;
    }
}