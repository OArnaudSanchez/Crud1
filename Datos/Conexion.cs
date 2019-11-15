using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class Conexion
    {
		SqlConnection conexion = new SqlConnection("Data Source=ADMINISTRADOR;Initial Catalog=Escuelaa;Integrated Security=True");

		SqlCommand comando;


		public void guardar(string Nombre, string Apellido, string Materias,
						string Estado, string nombreMateria, int Codigo, int Creditos)
		{
			conexion.Open();
			string query = $"insert into administracion(codigoMateria,nombreMateria,creditos,nombre,apellido,materias,estado) Values ('{Codigo}','{nombreMateria}','{Creditos}','{Nombre}','{Apellido}','{Materias}','{Estado}')";
			comando = new SqlCommand(query, conexion);
			comando.ExecuteNonQuery();
			conexion.Close();
		}


		public void modificar(string Nombre, string Apellido, string Materias,
						string Estado, string nombreMateria, int Codigo,int Creditos)
		{
			conexion.Open();
			string query = $"update administracion set nombre='{Nombre}', apellido='{Apellido}', materias='{Materias}',  estado='{Estado}',  nombreMateria='{nombreMateria}'" +
				$",   creditos='{Creditos}' where codigoMateria='{Codigo}'";
			comando = new SqlCommand(query, conexion);
			comando.ExecuteNonQuery();
			conexion.Close();
		}


		public void eliminar(int id)
		{
			conexion.Open();
			string LineaComando = $"delete from administracion where codigoMateria ='{id}'";
			comando = new SqlCommand(LineaComando, conexion);
			comando.ExecuteNonQuery();
			conexion.Close();
		}


		public DataTable llenarGrid()
		{
			conexion.Open();
			string query = "Select * from administracion";
			comando = new SqlCommand(query, conexion);
			comando.ExecuteNonQuery();
			SqlDataAdapter datos = new SqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			datos.Fill(tabla);
			conexion.Close();
			return tabla;
		}

		
	}
}
