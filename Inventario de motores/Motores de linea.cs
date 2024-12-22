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
                    //codigo = Convert.ToInt32(comandoSQL.ExecuteScalar());
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cargado correctamente");

                }
                else if (guardar == "Modificar")
               {
                    comandoSQL = new SqlCommand("UPDATE motorDeLinea SET marca=@Marca, hp=@HP, rpm=@RPM, cantidad=@Cantidad, cuerpo=@Cuerpo, volts+@Volts, hz=@Hz WHERE codigo=@Codigo", Conexion);
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
    }

}
