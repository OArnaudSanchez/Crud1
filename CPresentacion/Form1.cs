using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
namespace CPresentacion
{
	public partial class Form1 : Form
	{
		Estudiante estudiante = new Estudiante();
		Materia materia = new Materia();
		Conexion Conexion = new Conexion();
		int posicion;
		public Form1()
		{
			InitializeComponent();
		}

		private void bSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bGuardar_Click(object sender, EventArgs e)
		{
			try
			{

				if (tCodigoMateria.Text == string.Empty || tNombreMateria.Text == string.Empty
					|| tCreditos.Text == string.Empty || tNombreEstudiante.Text == string.Empty
					|| tApellido.Text == string.Empty || tNombreEstudiante.Text == string.Empty)
				{
					Validar();
					MessageBox.Show("No Campos Vacios ");

				}
				else
				{
					estudiante.Nombre = tNombreEstudiante.Text;
					estudiante.Apellido = tApellido.Text;
					estudiante.Materias = tMaterias.Text;
					estudiante.Estado =  tEstado.Text;

					materia.Nombre = tNombreMateria.Text;
					materia.Codigo = int.Parse(tCodigoMateria.Text);
					materia.Creditos = int.Parse(tCreditos.Text);

					Conexion.guardar(estudiante.Nombre, estudiante.Apellido, estudiante.Materias
						, estudiante.Estado, materia.Nombre, materia.Codigo, materia.Creditos);
					MessageBox.Show("Agregados correctamente");
				}
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message);
			}

			getDatos();
			
		}
		public void getDatos()
		{
			dataGridView1.DataSource = Conexion.llenarGrid();
		}
		private void bModificar_Click(object sender, EventArgs e)
		{
			try
			{
				if (tCodigoMateria.Text == string.Empty || tNombreMateria.Text == string.Empty
					|| tCreditos.Text == string.Empty || tNombreEstudiante.Text == string.Empty
					|| tApellido.Text == string.Empty || tNombreEstudiante.Text == string.Empty)
				{
					Validar();
					MessageBox.Show("Debe llenar todos los campos ");

				}
				else
				{
					estudiante.Nombre = tNombreEstudiante.Text;
					estudiante.Apellido = tApellido.Text;
					estudiante.Materias = tMaterias.Text;
					estudiante.Estado = tEstado.Text;

					materia.Nombre = tNombreMateria.Text;
					materia.Codigo = int.Parse(tCodigoMateria.Text);
					materia.Creditos = int.Parse(tCreditos.Text);

					Conexion.modificar(estudiante.Nombre, estudiante.Apellido, estudiante.Materias
						, estudiante.Estado, materia.Nombre, materia.Codigo, materia.Creditos);

				    dataGridView1[0, posicion].Value = tCodigoMateria.Text;
					dataGridView1[1, posicion].Value = tNombreMateria.Text;
					dataGridView1[2, posicion].Value = tCreditos.Text;
					dataGridView1[3, posicion].Value = tNombreEstudiante.Text;
					dataGridView1[4, posicion].Value = tApellido.Text;
					dataGridView1[5, posicion].Value = tMaterias.Text;
					dataGridView1[6, posicion].Value = tEstado.Text;
					MessageBox.Show("La modificacion se realizo correctamente");
				}
				getDatos();
				
			}
			catch (Exception error)
			{
				MessageBox.Show("Hubo un error al modificar");
			}
		}

		private void bEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Validar();
				materia.Codigo = int.Parse(tCodigoMateria.Text);
				Conexion.eliminar(materia.Codigo);
				dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
				MessageBox.Show("Se elimino Correctamente");
				clear();
			}
			catch (Exception error)
			{
				MessageBox.Show("Hubo un error al eliminar");
			}
		}
		public bool Validar()
		{
			bool error = false;

			if (tNombreEstudiante.Text == string.Empty)
			{

				errorProvider1.SetError(tNombreEstudiante, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tNombreMateria.Text == string.Empty)
			{
				errorProvider1.SetError(tNombreMateria, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tCodigoMateria.Text == string.Empty)
			{
				errorProvider1.SetError(tCodigoMateria, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tApellido.Text == string.Empty)
			{
				errorProvider1.SetError(tApellido, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tCreditos.Text == string.Empty)
			{
				errorProvider1.SetError(tCreditos, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tMaterias.Text == string.Empty)
			{
				errorProvider1.SetError(tMaterias, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			if (tEstado.Text == string.Empty)
			{
				errorProvider1.SetError(tEstado, "No se puede existir datos nulos o no Validos");
				error = true;
			}
			return true;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			posicion = dataGridView1.CurrentRow.Index;
			tCodigoMateria.Text = dataGridView1[0, posicion].Value.ToString();
			tNombreMateria.Text = dataGridView1[1, posicion].Value.ToString();
			tCreditos.Text = dataGridView1[2, posicion].Value.ToString();
			tNombreEstudiante.Text = dataGridView1[3, posicion].Value.ToString();
			tApellido.Text = dataGridView1[4, posicion].Value.ToString();
			tMaterias.Text = dataGridView1[5, posicion].Value.ToString();
			tEstado.Text = dataGridView1[6, posicion].Value.ToString();
		}
		void clear() {
			tNombreEstudiante.Clear();
			tApellido.Clear();
			tCodigoMateria.Clear();
			tEstado.Clear();
			tCreditos.Clear();
			tNombreMateria.Clear();
			tMaterias.Clear();

		}

		private void bLimpiar_Click(object sender, EventArgs e)
		{
			clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getDatos();
		}
	}
}
