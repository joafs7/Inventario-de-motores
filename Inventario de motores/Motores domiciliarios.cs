using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;


namespace Inventario_de_motores
{
    public partial class Motores_domiciliarios : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private int currentRow = 0;
        public Motores_domiciliarios()
        {
            InitializeComponent();
            // Configurar el evento para imprimir
            printDocument.BeginPrint += PrintDocument_BeginPrint;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        public string guardar = "Nuevo";
        public int codigo;
        public SqlConnection Conexion = new SqlConnection("Data Source=JOAQUIN;Initial Catalog=Gatti_DB;Integrated Security=True;Encrypt=False");

        private void Nuevo()
        {
            //Nuevo="Nuevo"
            //habilitamos botones 

            btn_Modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Guardar.Enabled = true;

            //habilitamos cajas de textos
            txt_Cantidad.Enabled = true;
            cbx_Marca.Enabled = true;
            cbx_HP.Enabled = true;
            cbx_RPM.Enabled = true;
            cbx_Hz.Enabled = true;
            cbx_Volts.Enabled = true;

        }

        private void CargarGrilla()
        {
            try
            {
                Conexion.Open();

                // Consulta SQL
                string consultaSQL = "SELECT * FROM MotorDomiciliario ORDER BY HP ASC, RPM";
                SqlCommand comando = new SqlCommand(consultaSQL, Conexion);

                // Cargar datos en DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable datosGrilla = new DataTable();
                adapter.Fill(datosGrilla);

                // Asignar datos al DataGridView
                dgv_Domiciliario.DataSource = datosGrilla;
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
            cbx_Marca.Text = "";
            cbx_HP.Text = "";
            cbx_RPM.Text = "";
            cbx_Hz.Text = "";
            cbx_Volts.Text = "";
        }
        private void Motores_domiciliarios_Load(object sender, EventArgs e)
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
            string volts = cbx_Volts.Text;
            string hz = cbx_Hz.Text;

            Conexion.Open();
            try
            {
                SqlCommand comandoSQL;
                if (guardar == "Nuevo")
                {
                    comandoSQL = new SqlCommand("INSERT INTO MotorDomiciliario (marca,hp,rpm,cantidad,volts,hz)" + "VALUES (@Marca,@HP,@RPM,@Cantidad,@Volts,@Hz)", Conexion);
                    comandoSQL.Parameters.AddWithValue("@Marca", marca);
                    comandoSQL.Parameters.AddWithValue("@HP", hp);
                    comandoSQL.Parameters.AddWithValue("@RPM", rpm);
                    comandoSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                    comandoSQL.Parameters.AddWithValue("@Volts", volts);
                    comandoSQL.Parameters.AddWithValue("@Hz", hz);
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cargado correctamente");

                }
                else if (guardar == "Modificar")
                {
                    comandoSQL = new SqlCommand("UPDATE MotorDomiciliario SET marca=@Marca, hp=@HP, rpm=@RPM, cantidad=@Cantidad, volts=@Volts, hz=@Hz WHERE codigo=@Codigo", Conexion);
                    comandoSQL.Parameters.AddWithValue("@Marca", marca);
                    comandoSQL.Parameters.AddWithValue("@HP", hp);
                    comandoSQL.Parameters.AddWithValue("@RPM", rpm);
                    comandoSQL.Parameters.AddWithValue("@Cantidad", cantidad);
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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Domiciliario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Domiciliario.SelectedRows)
                {
                    codigo = Convert.ToInt32(row.Cells["Codigo"].Value); // Capturamos el ID del cliente seleccionado
                    cbx_Marca.Text = row.Cells["Marca"].Value.ToString();
                    cbx_HP.Text = row.Cells["HP"].Value.ToString();
                    cbx_RPM.Text = row.Cells["RPM"].Value.ToString();
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
            if (dgv_Domiciliario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Domiciliario.SelectedRows)
                {
                    int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);

                    Conexion.Open();
                    SqlCommand comandoSQL;
                    comandoSQL = new SqlCommand("DELETE FROM MotorDomiciliario WHERE codigo = @Codigo", Conexion);
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

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Principal menu_Principal= new Menu_Principal();
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
                string consulta = "SELECT * FROM MotorDomiciliario WHERE HP LIKE @filtro";
                SqlCommand comandoSQL = new SqlCommand(consulta, Conexion);
                comandoSQL.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                //Ejecuta la consulta y obtiene los resultados
                SqlDataAdapter adaptor = new SqlDataAdapter(comandoSQL);
                DataTable tablaResultados = new DataTable();
                adaptor.Fill(tablaResultados);

                //Muestra los resultados de la DataGridView
                dgv_Domiciliario.DataSource = tablaResultados;

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

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }
        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            currentRow = 0; // Reiniciar la fila actual
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 50; // Margen izquierdo
            int y = 50; // Margen superior
            int rowHeight = 25; // Altura de las filas
            int colWidth = 100; // Ancho de las columnas
            int tableWidth = dgv_Domiciliario.Columns.Count * colWidth; // Ancho total de la tabla

            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            System.Drawing.Font rowFont = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            Pen blackPen = new Pen(Brushes.Black, 1); // Para dibujar líneas

            // Dibujar encabezados
            e.Graphics.DrawRectangle(blackPen, x, y, tableWidth, rowHeight);
            for (int col = 0; col < dgv_Domiciliario.Columns.Count; col++)
            {
                e.Graphics.DrawString(dgv_Domiciliario.Columns[col].HeaderText, headerFont, Brushes.Black, x + (col * colWidth) + 5, y + 5);
                e.Graphics.DrawLine(blackPen, x + (col * colWidth), y, x + (col * colWidth), y + rowHeight);
            }
            y += rowHeight;

            // Dibujar filas de datos
            while (currentRow < dgv_Domiciliario.Rows.Count)
            {
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                // Determinar el color de fondo según el valor de Hz
                Brush backgroundBrush = Brushes.White; // Por defecto
                if (dgv_Domiciliario.Rows[currentRow].Cells["Hz"].Value?.ToString() == "60 Hz")
                {
                    backgroundBrush = Brushes.LightGreen; // Color para 60 Hz
                }

                // Dibujar fondo de la fila
                e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, rowHeight);

                // Dibujar celdas y texto
                for (int col = 0; col < dgv_Domiciliario.Columns.Count; col++)
                {
                    string cellValue = dgv_Domiciliario.Rows[currentRow].Cells[col].Value?.ToString() ?? "";
                    e.Graphics.DrawString(cellValue, rowFont, Brushes.Black, x + (col * colWidth) + 5, y + 5);

                    // Dibujar líneas verticales entre columnas
                    e.Graphics.DrawLine(blackPen, x + (col * colWidth), y, x + (col * colWidth), y + rowHeight);
                }

                // Dibujar línea vertical final
                e.Graphics.DrawLine(blackPen, x + tableWidth, y, x + tableWidth, y + rowHeight);

                currentRow++;
                y += rowHeight;
            }

            e.HasMorePages = false;
            currentRow = 0;
        }

        private void btn_ExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF|*.pdf",
                Title = "Guardar como PDF",
                FileName = "DataGridViewExport.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportarPDF(saveFileDialog.FileName);
            }
        }

        private void ExportarPDF(string nombreArchivo)
        {
            Document documento = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                documento.Open();

                // Título
                documento.Add(new Paragraph("Motores de Línea"));
                documento.Add(new Paragraph(" ")); // Espacio en blanco

                PdfPTable tabla = new PdfPTable(dgv_Domiciliario.Columns.Count);
                tabla.WidthPercentage = 100;

                // Encabezados
                foreach (DataGridViewColumn columna in dgv_Domiciliario.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText))
                    {
                        BackgroundColor = BaseColor.ORANGE,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    tabla.AddCell(celda);
                }

                // Filas
                foreach (DataGridViewRow fila in dgv_Domiciliario.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        BaseColor colorFondo = BaseColor.WHITE; // Color por defecto

                        // Comprobar el valor de Hz y cambiar el color de fondo si es 60
                        if (fila.Cells["Hz"].Value?.ToString() == "60 Hz")
                        {
                            colorFondo = BaseColor.GREEN; // Color para 60 Hz
                        }

                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            string textoCelda = celda.Value?.ToString() ?? "";
                            PdfPCell pdfCelda = new PdfPCell(new Phrase(textoCelda))
                            {
                                BackgroundColor = colorFondo
                            };
                            tabla.AddCell(pdfCelda);
                        }
                    }
                }

                documento.Add(tabla);
                MessageBox.Show("Archivo PDF generado exitosamente.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el archivo PDF: " + ex.Message, "Error");
            }
            finally
            {
                documento.Close();
            }
        }
    }
}
