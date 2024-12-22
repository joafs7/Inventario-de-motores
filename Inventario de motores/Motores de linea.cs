using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario_de_motores
{
    public partial class Motores_de_linea : Form
    {
        public Motores_de_linea()
        {
            InitializeComponent();
        }
        public string guardar = "Nuevo";
        public int codigo;
        public SqlConnection Conexion = new SqlConnection("Data Source=JOAQUIN;Initial Catalog=Gatti_DB;Integrated Security=True;Encrypt=False");

        private void Nuevo()
        {
            //Nuevo="Nuevo"
            //habilitamos botones 

            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;

            //habilitamos cajas de textos
            txt_Cantidad.Enabled = true;
            cbx_Marca.Enabled = true;
            cbx_HP.Enabled = true;
            cbx_RPM.Enabled = true;
            cbx_Cuerpo.Enabled = true;
            cbx_Hz.Enabled = true;
            cbx_Volts.Enabled = true;

         
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cbx_Marca.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'Marca' del motor", "Dato requerido");
                cbx_Marca.Focus();
                return;
            }

            if (cbx_HP.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'HP' del motor", "Dato requerido");
                cbx_HP.Focus();
                return;
            }

            if (cbx_RPM.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'RPM' del motor", "Dato requerido");
                cbx_RPM.Focus();
                return;
            }

            if (txt_Cantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe colocar la 'cantidad' de motores a ingresar", "Dato requerido");
                txt_Cantidad.Focus();
                return;
            }

            if (cbx_Cuerpo.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'Cuerpo' del motor", "Dato requerido");
                cbx_Cuerpo.Focus();
                return;
            }

            if (cbx_Volts.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'Volts' del motor", "Dato requerido");
                cbx_Volts.Focus();
                return;
            }

            if (cbx_Hz.Text == "Seleccione")
            {
                MessageBox.Show("Debe seleccionar 'Hz' del motor", "Dato requerido");
                cbx_Hz.Focus();
                return;
            }

            string marca = cbx_Marca.Text;
            string hp = cbx_HP.Text;
            string rpm = cbx_RPM.Text;
            string cantidad = txt_Cantidad.Text;
            string cuerpo = cbx_Cuerpo.Text;
            string volts = cbx_Volts.Text;
            string hz = cbx_Hz.Text;


            Conexion.Open();
            try
            {
                SqlCommand comandoSQL;
                if (guardar == "Nuevo")
                {
                    comandoSQL = new SqlCommand("INSERT INTO motorDeLinea (marca,hp,rpm,cantidad,cuerpo,volts,hz)" + "VALUES (@Marca,@HP,@RPM,@Cantidad,@Cuerpo,@Volts,@Hz)", Conexion);
                    comandoSQL.Parameters.AddWithValue("@Marca", marca);
                    comandoSQL.Parameters.AddWithValue("@HP", hp);
                    comandoSQL.Parameters.AddWithValue("@RPM", rpm);
                    comandoSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                    comandoSQL.Parameters.AddWithValue("@Cuerpo", cuerpo);
                    comandoSQL.Parameters.AddWithValue("@Volts", volts);
                    comandoSQL.Parameters.AddWithValue("@Hz", hz);
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cargado correctamente");

                }
                else if (guardar == "Modificar")
               {
                    comandoSQL = new SqlCommand("UPDATE motorDeLinea SET marca=@Marca, hp=@HP, rpm=@RPM, cantidad=@Cantidad, cuerpo=@Cuerpo, volts=@Volts, hz=@Hz WHERE codigo=@Codigo", Conexion);
                    comandoSQL.Parameters.AddWithValue("@Marca", marca);
                    comandoSQL.Parameters.AddWithValue("@HP", hp);
                    comandoSQL.Parameters.AddWithValue("@RPM", rpm);
                    comandoSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                    comandoSQL.Parameters.AddWithValue("@Cuerpo", cuerpo);
                    comandoSQL.Parameters.AddWithValue("@Volts", volts);
                    comandoSQL.Parameters.AddWithValue("@Hz", hz);
                    comandoSQL.Parameters.AddWithValue("@Codigo", codigo);
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Motores actualizados exitosamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "ERROR");
            }
            finally
            {

                Conexion.Close();
                LimpiarCampos();
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            try
            {
                

                Conexion.Open();

                // Consulta SQL
                string consultaSQL = "SELECT * FROM motorDeLinea";
                SqlCommand comando = new SqlCommand(consultaSQL, Conexion);

                // Cargar datos en DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable datosGrilla = new DataTable();
                adapter.Fill(datosGrilla);

                // Asignar datos al DataGridView
                dgv_Linea.DataSource = datosGrilla;
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos en la grilla: {ex.Message}", "Error");
            }
        }
         private void btn_Modificar_Click(object sender, EventArgs e)
         {
            if (dgv_Linea.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Linea.SelectedRows)
                {
                    codigo = Convert.ToInt32(row.Cells["Codigo"].Value); // Capturamos el ID del cliente seleccionado
                    cbx_Marca.Text = row.Cells["Marca"].Value.ToString();
                    cbx_HP.Text = row.Cells["HP"].Value.ToString();
                    cbx_RPM.Text = row.Cells["RPM"].Value.ToString();
                    cbx_Cuerpo.Text = row.Cells["Cuerpo"].Value.ToString();
                    txt_Cantidad.Text = row.Cells["Cantidad"].Value.ToString();
                    cbx_Volts.Text = row.Cells["Volts"].Value.ToString();
                    cbx_Hz.Text = row.Cells["Hz"].Value.ToString();
                    guardar = "Modificar";
                    Nuevo();
                }

            }
            else
            {
                //No hay filas seleccionadas
                MessageBox.Show("Debe seleccionar un 'MOTOR'", "Seleccione");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Linea.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Linea.SelectedRows)
                {
                    int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);

                    Conexion.Open();
                    SqlCommand comandoSQL;
                    comandoSQL = new SqlCommand("DELETE FROM motorDeLinea WHERE codigo = @Codigo", Conexion);
                    comandoSQL.Parameters.AddWithValue("@Codigo", codigo);
                    comandoSQL.ExecuteNonQuery();
                    Conexion.Close();
                    CargarGrilla();
                    MessageBox.Show("Motores eliminado exitosamente", "Eliminacion");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar Motores", "Seleccione");
            }
        }

        private void LimpiarCampos()
        {
            txt_Cantidad.Text = string.Empty;
            cbx_Marca.SelectedIndex = 0;
            cbx_HP.SelectedIndex = 0;
            cbx_RPM.SelectedIndex = 0;
            cbx_Cuerpo.SelectedIndex = 0;
            cbx_Hz.SelectedIndex = 0;
            cbx_Volts.SelectedIndex = 0;
        }


        private void Motores_de_linea_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal menu_Principal = new Menu_Principal();
            menu_Principal.Show();
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();

                // Captura el texto en el textbox
                string filtro = txt_Filtro.Text;

                // Crea la consulta SQL con el filtro 
                string consulta = "SELECT * FROM motorDeLinea WHERE HP LIKE @filtro";
                SqlCommand comandoSQL = new SqlCommand(consulta, Conexion);
                comandoSQL.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                //Ejecuta la consulta y obtiene los resultados
                SqlDataAdapter adaptor = new SqlDataAdapter(comandoSQL);
                DataTable tablaResultados = new DataTable();
                adaptor.Fill(tablaResultados);

                //Muestra los resultados de la DataGridView
                dgv_Linea.DataSource = tablaResultados;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
        }
    }

}
