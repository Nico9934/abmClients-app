using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace abm_seminario_app
{
	public class DBConnection
	{
		public string strConexion = "Data Source = NOTEBOOK_NICO; Initial Catalog = abm_db; Integrated Security = True;";

		static SqlConnection Conexion;
		static SqlCommand Orden;
		static SqlDataReader Lector;

		public void Conectar()
		{
			try
			{
				Conexion = new SqlConnection(strConexion);
				Conexion.Open();
				MessageBox.Show("Exito");
			}
			catch (Exception e)
			{
				MessageBox.Show("Ha ocurrido un error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Desconectar()
		{
			if (Conexion != null && Conexion.State == ConnectionState.Open)
				Conexion.Close();
		}

	}
}





















































//public SqlDataReader LeerSQL(string Consulta)
//{
//	SqlDataReader Lector;
//	//creamos la conexión con la base de datos
//	Conexion = new SqlConnection(strConexion);
//	//establecemos la consulta dentro de la conexión
//	Orden = new SqlCommand(Consulta, Conexion);
//	try
//	{
//		Conexion.Open();//abrimos la conexion
//		//ejecutamos la consulta y la asignamos al DataReader
//		Lector = Orden.ExecuteReader();
//		return Lector; //retornamos los datos obtenidos
//	}
//	catch( Exception pepe)
//	{
//		MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//		Lector = null;
//		return Lector;
//	}
//}
//public  SqlConnection Conectar()
//{
//	string strConexion = "Data Source = NOTEBOOK_NICO; Initial Catalog = abm_db; Integrated Security = True;";

//	try
//	{
//		SqlConnection conexion = new SqlConnection(strConexion);
//		return conexion; 
//		//MessageBox.Show("Conexión exitosa...");

//	}
//	catch ( Exception e) {
//		MessageBox.Show("Ha ocurrido un error" + e.ToString());
//		return null; 
//	}
//}
//public void Desconectar()
//{
//	if (Conexion.State == ConnectionState.Open)
//		Conexion.Close();
//}