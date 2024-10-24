using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_1
{
    class Conexion
    {
        SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Server=AARON\\SQLEXPRESS;Initial Catalog=CalculadoraDB;Encrypt =False;User ID=arong;Password =010223;TrustServerCertificate =True;Trusted_Connection =True"); 
                cnx.Open();
                //MessageBox.Show("Conectado Correctamente");
            } catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message);
            }
        }

        // Método para insertar un cálculo en la base de datos
        public void GuardarCalculo(string operacion, decimal resultado, string tipoOperacion)
        {
            try
            {
                string query = "INSERT INTO Calculations (Operacion, Resultado, Tipo_Operacion) VALUES (@Operacion, @Resultado, @TipoOperacion)";
                SqlCommand cmd = new SqlCommand(query, cnx);

                cmd.Parameters.AddWithValue("@Operacion", operacion);
                cmd.Parameters.AddWithValue("@Resultado", resultado);
                cmd.Parameters.AddWithValue("@TipoOperacion", tipoOperacion);

                cmd.ExecuteNonQuery(); // Ejecuta la consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cálculo: " + ex.Message);
            }
        }
    }
}
