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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motores_de_linea));
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.lbl_RPM = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.cbx_RPM = new System.Windows.Forms.ComboBox();
            this.cbx_HP = new System.Windows.Forms.ComboBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbx_Cuerpo = new System.Windows.Forms.ComboBox();
            this.lbl_Cuerpo = new System.Windows.Forms.Label();
            this.cbx_Volts = new System.Windows.Forms.ComboBox();
            this.lbl_Volts = new System.Windows.Forms.Label();
            this.cbx_Hz = new System.Windows.Forms.ComboBox();
            this.lbl_Hz = new System.Windows.Forms.Label();
            this.gbx_Filtro = new System.Windows.Forms.GroupBox();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbx_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(242, 26);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(161, 39);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modificar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(434, 26);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(161, 39);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(622, 26);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(161, 39);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(816, 26);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(161, 39);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Red;
            this.btn_Volver.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(49, 26);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(161, 39);
            this.btn_Volver.TabIndex = 4;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(26, 91);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(45, 17);
            this.lbl_Marca.TabIndex = 5;
            this.lbl_Marca.Text = "Marca";
            this.lbl_Marca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_HP
            // 
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HP.Location = new System.Drawing.Point(173, 91);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(24, 17);
            this.lbl_HP.TabIndex = 6;
            this.lbl_HP.Text = "HP";
            // 
            // lbl_RPM
            // 
            this.lbl_RPM.AutoSize = true;
            this.lbl_RPM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_RPM.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RPM.Location = new System.Drawing.Point(323, 91);
            this.lbl_RPM.Name = "lbl_RPM";
            this.lbl_RPM.Size = new System.Drawing.Size(35, 17);
            this.lbl_RPM.TabIndex = 7;
            this.lbl_RPM.Text = "RPM";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(481, 91);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(61, 17);
            this.lbl_Cantidad.TabIndex = 8;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_Marca.Size = new System.Drawing.Size(131, 25);
            this.cbx_Marca.TabIndex = 9;
            // 
            // cbx_RPM
            // 
            this.cbx_RPM.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_RPM.FormattingEnabled = true;
            this.cbx_RPM.Items.AddRange(new object[] {
            "750",
            "900",
            "1500",
            "3000"});
            this.cbx_RPM.Location = new System.Drawing.Point(326, 112);
            this.cbx_RPM.Name = "cbx_RPM";
            this.cbx_RPM.Size = new System.Drawing.Size(131, 25);
            this.cbx_RPM.TabIndex = 10;
            // 
            // cbx_HP
            // 
            this.cbx_HP.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_HP.Size = new System.Drawing.Size(131, 25);
            this.cbx_HP.TabIndex = 11;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(484, 112);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(111, 25);
            this.txt_Cantidad.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(991, 371);
            this.dataGridView1.TabIndex = 13;
            // 
            // cbx_Cuerpo
            // 
            this.cbx_Cuerpo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_Cuerpo.Location = new System.Drawing.Point(31, 172);
            this.cbx_Cuerpo.Name = "cbx_Cuerpo";
            this.cbx_Cuerpo.Size = new System.Drawing.Size(131, 25);
            this.cbx_Cuerpo.TabIndex = 15;
            // 
            // lbl_Cuerpo
            // 
            this.lbl_Cuerpo.AutoSize = true;
            this.lbl_Cuerpo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cuerpo.Location = new System.Drawing.Point(28, 151);
            this.lbl_Cuerpo.Name = "lbl_Cuerpo";
            this.lbl_Cuerpo.Size = new System.Drawing.Size(52, 17);
            this.lbl_Cuerpo.TabIndex = 14;
            this.lbl_Cuerpo.Text = "Cuerpo";
            // 
            // cbx_Volts
            // 
            this.cbx_Volts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Volts.FormattingEnabled = true;
            this.cbx_Volts.Items.AddRange(new object[] {
            "220",
            "380"});
            this.cbx_Volts.Location = new System.Drawing.Point(176, 172);
            this.cbx_Volts.Name = "cbx_Volts";
            this.cbx_Volts.Size = new System.Drawing.Size(131, 25);
            this.cbx_Volts.TabIndex = 17;
            // 
            // lbl_Volts
            // 
            this.lbl_Volts.AutoSize = true;
            this.lbl_Volts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volts.Location = new System.Drawing.Point(173, 151);
            this.lbl_Volts.Name = "lbl_Volts";
            this.lbl_Volts.Size = new System.Drawing.Size(37, 17);
            this.lbl_Volts.TabIndex = 16;
            this.lbl_Volts.Text = "Volts";
            // 
            // cbx_Hz
            // 
            this.cbx_Hz.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Hz.FormattingEnabled = true;
            this.cbx_Hz.Items.AddRange(new object[] {
            "50 Hz",
            "60 Hz"});
            this.cbx_Hz.Location = new System.Drawing.Point(326, 172);
            this.cbx_Hz.Name = "cbx_Hz";
            this.cbx_Hz.Size = new System.Drawing.Size(131, 25);
            this.cbx_Hz.TabIndex = 19;
            // 
            // lbl_Hz
            // 
            this.lbl_Hz.AutoSize = true;
            this.lbl_Hz.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hz.Location = new System.Drawing.Point(323, 151);
            this.lbl_Hz.Name = "lbl_Hz";
            this.lbl_Hz.Size = new System.Drawing.Size(23, 17);
            this.lbl_Hz.TabIndex = 18;
            this.lbl_Hz.Text = "Hz";
            // 
            // gbx_Filtro
            // 
            this.gbx_Filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbx_Filtro.Controls.Add(this.txt_Filtro);
            this.gbx_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbx_Filtro.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Filtro.Location = new System.Drawing.Point(633, 90);
            this.gbx_Filtro.Name = "gbx_Filtro";
            this.gbx_Filtro.Size = new System.Drawing.Size(369, 115);
            this.gbx_Filtro.TabIndex = 20;
            this.gbx_Filtro.TabStop = false;
            this.gbx_Filtro.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(37, 49);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(298, 25);
            this.txt_Filtro.TabIndex = 0;
            this.txt_Filtro.Text = "Buscar...";
            // 
            // Motores_de_linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1015, 618);
            this.Controls.Add(this.gbx_Filtro);
            this.Controls.Add(this.cbx_Hz);
            this.Controls.Add(this.lbl_Hz);
            this.Controls.Add(this.cbx_Volts);
            this.Controls.Add(this.lbl_Volts);
            this.Controls.Add(this.cbx_Cuerpo);
            this.Controls.Add(this.lbl_Cuerpo);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Motores_de_linea";
            this.ShowIcon = false;
            this.Text = "Motores_de_linea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbx_Filtro.ResumeLayout(false);
            this.gbx_Filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.Label lbl_RPM;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.ComboBox cbx_RPM;
        private System.Windows.Forms.ComboBox cbx_HP;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbx_Cuerpo;
        private System.Windows.Forms.Label lbl_Cuerpo;
        private System.Windows.Forms.ComboBox cbx_Volts;
        private System.Windows.Forms.Label lbl_Volts;
        private System.Windows.Forms.ComboBox cbx_Hz;
        private System.Windows.Forms.Label lbl_Hz;
        private System.Windows.Forms.GroupBox gbx_Filtro;
        private System.Windows.Forms.TextBox txt_Filtro;
    }
}