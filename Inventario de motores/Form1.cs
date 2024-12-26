using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Inventario_de_motores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
       
        }
        

       public SqlConnection Conexion = new SqlConnection("Data Source=JOAQUIN;Initial Catalog=Gatti_DB;Integrated Security=True;Encrypt=False");

 
      private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {

            string usuario = txt_Usuario.Text;
            string contrasena = (txt_Contrasena.Text);

            using (SqlConnection conn = new SqlConnection("Data Source=JOAQUIN;Initial Catalog=Gatti_DB;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario=@Usuario AND Contrasena=@Contrasena", conn);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasena", contrasena);

                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataSet dataSet = new DataSet();
                datos.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    Menu_Principal menu = new Menu_Principal();
                    menu.Show();
                    txt_Usuario.Clear();
                    txt_Contrasena.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Usuario.Text))
            {
                MessageBox.Show("Debe ingresar 'Usuario'", "Dato requerido");
                txt_Usuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Contrasena.Text))
            {
                MessageBox.Show("Debe ingresar 'Contraseña'", "Dato requerido");
                txt_Contrasena.Focus();
                return;
            }

            string usuario = txt_Usuario.Text;
            string contraseña = (txt_Contrasena.Text);

            using (SqlConnection conn = new SqlConnection("Data Source=JOAQUIN;Initial Catalog=Gatti_DB;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                SqlCommand comandoSQL = new SqlCommand("INSERT INTO Usuarios (usuario,contrasena) VALUES (@usuario,@contrasena)", conn);
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@contrasena", contraseña);
                comandoSQL.ExecuteNonQuery();

                MessageBox.Show("Usuario guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Usuario.Clear();
                txt_Contrasena.Clear();
            }

        }

    }
}
