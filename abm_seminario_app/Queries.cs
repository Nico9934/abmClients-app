using abm_seminario_app;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abm_seminario_app
{
	public class Queries
	{
		private DBConnection dbConnection;

		public Queries()
		{
			dbConnection = new DBConnection();
		}
	

		public DataTable LeerRegistros()
		{
			string consulta = "SELECT DNI, firstName as Nombre,lastName as Apellido, adress as Direccion, phone as Telefono, birthday as FechNac FROM Person";
			DataTable dataTable = new DataTable();
			SqlConnection Conexion;
			SqlCommand Command;
			SqlDataReader Reader;

			try
			{
				Conexion = new SqlConnection(dbConnection.strConexion);
				Command = new SqlCommand(consulta, Conexion);

				Conexion.Open();
				Reader = Command.ExecuteReader();

				dataTable.Load(Reader); 

				Conexion.Close();
				Reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al leer registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return dataTable;

		}


		public bool create_register(int dni, string firstName, string lastName, string adress, int phone, DateTime birthday)
		{
			string consulta = "INSERT INTO Person (dni, firstName, lastName, adress, phone, birthday) " +
							 "VALUES (@dni, @firstName, @lastName, @adress, @phone, @birthday)";

			using (SqlConnection conexion = new SqlConnection(dbConnection.strConexion))
			{
				using (SqlCommand command = new SqlCommand(consulta, conexion))
				{
					command.Parameters.AddWithValue("@dni", dni);
					command.Parameters.AddWithValue("@firstName", firstName);
					command.Parameters.AddWithValue("@lastName", lastName);
					command.Parameters.AddWithValue("@adress", adress);
					command.Parameters.AddWithValue("@phone", phone);
					command.Parameters.AddWithValue("@birthday", birthday);

					try
					{
						conexion.Open();
						int rowsAffected = command.ExecuteNonQuery();
						return rowsAffected > 0; // Retorna true si al menos una fila fue afectada
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al crear el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}
		}
		
	

		public bool delete_register(int dni)
		{
			string consulta = "DELETE FROM Person WHERE dni = @dni";

			using (SqlConnection conexion = new SqlConnection(dbConnection.strConexion))
			{
				using (SqlCommand command = new SqlCommand(consulta, conexion))
				{
					command.Parameters.AddWithValue("@dni", dni);
					DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					
					if (result == DialogResult.Yes)
					{
						try
						{
							conexion.Open();
							int rowsAffected = command.ExecuteNonQuery();
							return rowsAffected > 0; // Retorna true si al menos una fila fue afectada
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return false;
						}

					} else
					{
						return false;
					}
					
				}
			}
		}
	}
}




































//public bool ActualizarRegistro(int id, string nuevosDatos)
//{
//	string consulta = $"UPDATE Tabla SET Datos = '{nuevosDatos}' WHERE Id = {id}";
//	try
//	{
//		SqlDataReader reader = dbConnection.LeerSQL(consulta);
//		return true;
//	}
//	catch (Exception ex)
//	{
//		MessageBox.Show("Error al actualizar registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//		return false;
//	}
//	finally
//	{
//		dbConnection.Desconectar();
//	}
//}

//public bool EliminarRegistro(int id)
//{
//	string consulta = $"DELETE FROM Tabla WHERE Id = {id}";
//	try
//	{
//		SqlDataReader reader = dbConnection.LeerSQL(consulta);
//		return true;
//	}
//	catch (Exception ex)
//	{
//		MessageBox.Show("Error al eliminar registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//		return false;
//	}
//	finally
//	{
//		dbConnection.Desconectar();
//	}
//}