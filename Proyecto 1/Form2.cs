using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Método para cargar los datos de la tabla Calculations en el DataGridView
        private void CargarDatos()
        {
            try
            {
                // Crear conexión
                Conexion conexion = new Conexion();
                SqlConnection cnx = new SqlConnection("Server=AARON\\SQLEXPRESS;Initial Catalog=CalculadoraDB;Encrypt=False;User ID=arong;Password=010223;TrustServerCertificate=True;Trusted_Connection=True");

                // Consulta SQL
                string query = "SELECT * FROM Calculations";

                // Adaptador para llenar el DataTable
                SqlDataAdapter da = new SqlDataAdapter(query, cnx);

                // DataTable para almacenar los resultados
                DataTable dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar los datos al DataGridView
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}

