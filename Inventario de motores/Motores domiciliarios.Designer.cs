namespace Inventario_de_motores
{
    partial class Motores_domiciliarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motores_domiciliarios));
            this.gbx_Filtro = new System.Windows.Forms.GroupBox();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.cbx_Hz = new System.Windows.Forms.ComboBox();
            this.lbl_Hz = new System.Windows.Forms.Label();
            this.cbx_Volts = new System.Windows.Forms.ComboBox();
            this.lbl_Volts = new System.Windows.Forms.Label();
            this.dgv_Domiciliario = new System.Windows.Forms.DataGridView();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.cbx_HP = new System.Windows.Forms.ComboBox();
            this.cbx_RPM = new System.Windows.Forms.ComboBox();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_RPM = new System.Windows.Forms.Label();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_ExportarPDF = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.gbx_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Domiciliario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Filtro
            // 
            this.gbx_Filtro.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbx_Filtro.Controls.Add(this.txt_Filtro);
            this.gbx_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Filtro.Location = new System.Drawing.Point(885, 153);
            this.gbx_Filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Filtro.Name = "gbx_Filtro";
            this.gbx_Filtro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Filtro.Size = new System.Drawing.Size(554, 177);
            this.gbx_Filtro.TabIndex = 41;
            this.gbx_Filtro.TabStop = false;
            this.gbx_Filtro.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(57, 74);
            this.txt_Filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(445, 26);
            this.txt_Filtro.TabIndex = 0;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            // 
            // cbx_Hz
            // 
            this.cbx_Hz.Enabled = false;
            this.cbx_Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Hz.FormattingEnabled = true;
            this.cbx_Hz.Items.AddRange(new object[] {
            "50 Hz",
            "60 Hz"});
            this.cbx_Hz.Location = new System.Drawing.Point(385, 289);
            this.cbx_Hz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Hz.Name = "cbx_Hz";
            this.cbx_Hz.Size = new System.Drawing.Size(194, 28);
            this.cbx_Hz.TabIndex = 40;
            // 
            // lbl_Hz
            // 
            this.lbl_Hz.AutoSize = true;
            this.lbl_Hz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hz.Location = new System.Drawing.Point(380, 256);
            this.lbl_Hz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hz.Name = "lbl_Hz";
            this.lbl_Hz.Size = new System.Drawing.Size(29, 20);
            this.lbl_Hz.TabIndex = 39;
            this.lbl_Hz.Text = "Hz";
            // 
            // cbx_Volts
            // 
            this.cbx_Volts.Enabled = false;
            this.cbx_Volts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Volts.FormattingEnabled = true;
            this.cbx_Volts.Items.AddRange(new object[] {
            "220",
            "380"});
            this.cbx_Volts.Location = new System.Drawing.Point(160, 289);
            this.cbx_Volts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Volts.Name = "cbx_Volts";
            this.cbx_Volts.Size = new System.Drawing.Size(194, 28);
            this.cbx_Volts.TabIndex = 38;
            // 
            // lbl_Volts
            // 
            this.lbl_Volts.AutoSize = true;
            this.lbl_Volts.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Volts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Volts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Volts.Location = new System.Drawing.Point(156, 256);
            this.lbl_Volts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Volts.Name = "lbl_Volts";
            this.lbl_Volts.Size = new System.Drawing.Size(45, 20);
            this.lbl_Volts.TabIndex = 37;
            this.lbl_Volts.Text = "Volts";
            // 
            // dgv_Domiciliario
            // 
            this.dgv_Domiciliario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Domiciliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Domiciliario.Location = new System.Drawing.Point(23, 370);
            this.dgv_Domiciliario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Domiciliario.Name = "dgv_Domiciliario";
            this.dgv_Domiciliario.RowHeadersWidth = 62;
            this.dgv_Domiciliario.Size = new System.Drawing.Size(1486, 666);
            this.dgv_Domiciliario.TabIndex = 34;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Enabled = false;
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(606, 288);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(194, 26);
            this.txt_Cantidad.TabIndex = 33;
            // 
            // cbx_HP
            // 
            this.cbx_HP.Enabled = false;
            this.cbx_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_HP.FormattingEnabled = true;
            this.cbx_HP.Items.AddRange(new object[] {
            "0.02",
            "0.04",
            "0.07",
            "0.10",
            "0.15",
            "0.17",
            "0.33",
            "0.47",
            "0.67"});
            this.cbx_HP.Location = new System.Drawing.Point(381, 185);
            this.cbx_HP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_HP.Name = "cbx_HP";
            this.cbx_HP.Size = new System.Drawing.Size(194, 28);
            this.cbx_HP.TabIndex = 32;
            // 
            // cbx_RPM
            // 
            this.cbx_RPM.Enabled = false;
            this.cbx_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_RPM.FormattingEnabled = true;
            this.cbx_RPM.Items.AddRange(new object[] {
            "1040",
            "1260",
            "1280",
            "1380",
            "1385",
            "1400",
            "1450",
            "2600",
            "2620",
            "2850",
            "2950"});
            this.cbx_RPM.Location = new System.Drawing.Point(606, 185);
            this.cbx_RPM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_RPM.Name = "cbx_RPM";
            this.cbx_RPM.Size = new System.Drawing.Size(194, 28);
            this.cbx_RPM.TabIndex = 31;
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.Enabled = false;
            this.cbx_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "CZERWENY",
            "WEG",
            "EMAR",
            "SOLO MOTOR"});
            this.cbx_Marca.Location = new System.Drawing.Point(161, 185);
            this.cbx_Marca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(194, 28);
            this.cbx_Marca.TabIndex = 30;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(602, 256);
            this.lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(73, 20);
            this.lbl_Cantidad.TabIndex = 29;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_RPM
            // 
            this.lbl_RPM.AutoSize = true;
            this.lbl_RPM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RPM.Location = new System.Drawing.Point(601, 153);
            this.lbl_RPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RPM.Name = "lbl_RPM";
            this.lbl_RPM.Size = new System.Drawing.Size(44, 20);
            this.lbl_RPM.TabIndex = 28;
            this.lbl_RPM.Text = "RPM";
            // 
            // lbl_HP
            // 
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HP.Location = new System.Drawing.Point(377, 153);
            this.lbl_HP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(31, 20);
            this.lbl_HP.TabIndex = 27;
            this.lbl_HP.Text = "HP";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(156, 153);
            this.lbl_Marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.lbl_Marca.TabIndex = 26;
            this.lbl_Marca.Text = "Marca";
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Red;
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(92, 48);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(242, 60);
            this.btn_Volver.TabIndex = 25;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(1242, 48);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(242, 60);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(951, 48);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(242, 60);
            this.btn_Eliminar.TabIndex = 23;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(669, 48);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(242, 60);
            this.btn_Modificar.TabIndex = 22;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(381, 48);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(242, 60);
            this.btn_Nuevo.TabIndex = 21;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_ExportarPDF
            // 
            this.btn_ExportarPDF.BackColor = System.Drawing.Color.White;
            this.btn_ExportarPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExportarPDF.BackgroundImage")));
            this.btn_ExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarPDF.Location = new System.Drawing.Point(1528, 743);
            this.btn_ExportarPDF.Name = "btn_ExportarPDF";
            this.btn_ExportarPDF.Size = new System.Drawing.Size(184, 91);
            this.btn_ExportarPDF.TabIndex = 43;
            this.btn_ExportarPDF.UseVisualStyleBackColor = false;
            this.btn_ExportarPDF.Click += new System.EventHandler(this.btn_ExportarPDF_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.White;
            this.btn_Imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.BackgroundImage")));
            this.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Location = new System.Drawing.Point(1528, 568);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(184, 91);
            this.btn_Imprimir.TabIndex = 42;
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // Motores_domiciliarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1724, 1050);
            this.Controls.Add(this.btn_ExportarPDF);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.gbx_Filtro);
            this.Controls.Add(this.cbx_Hz);
            this.Controls.Add(this.lbl_Hz);
            this.Controls.Add(this.cbx_Volts);
            this.Controls.Add(this.lbl_Volts);
            this.Controls.Add(this.dgv_Domiciliario);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cbx_HP);
            this.Controls.Add(this.cbx_RPM);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_RPM);
            this.Controls.Add(this.lbl_HP);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "Motores_domiciliarios";
            this.Text = "Motores_domiciliarios";
            this.Load += new System.EventHandler(this.Motores_domiciliarios_Load);
            this.gbx_Filtro.ResumeLayout(false);
            this.gbx_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Domiciliario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Filtro;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.ComboBox cbx_Hz;
        private System.Windows.Forms.Label lbl_Hz;
        private System.Windows.Forms.ComboBox cbx_Volts;
        private System.Windows.Forms.Label lbl_Volts;
        private System.Windows.Forms.DataGridView dgv_Domiciliario;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox cbx_HP;
        private System.Windows.Forms.ComboBox cbx_RPM;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_RPM;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_ExportarPDF;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}