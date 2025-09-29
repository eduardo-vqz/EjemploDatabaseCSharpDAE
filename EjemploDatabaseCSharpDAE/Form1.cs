using System.Data;
using Microsoft.Data.SqlClient;
using EjemploDatabaseCSharpDAE.Core.Lib;

namespace EjemploDatabaseCSharpDAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // realizamos la conexión a la base de datos para verificar que funciona
            try
            {
                var cs = System.Configuration.ConfigurationManager
                            .ConnectionStrings["SqlConn"].ConnectionString;

                using var cn = new SqlConnection(cs);
                cn.Open(); // si no lanza excepción, hay conexión
                MessageBox.Show(cn.State == ConnectionState.Open
                    ? "Conexión OK"
                    : "La conexión no se abrió.");
            }
            catch (SqlException ex) // de Microsoft.Data.SqlClient
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Conexión fallida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Conexión fallida");
            }

        }
    }
}
