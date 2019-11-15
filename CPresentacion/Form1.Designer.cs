namespace CPresentacion
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.bGuardar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tCodigoMateria = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tMaterias = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tApellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tNombreEstudiante = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tCreditos = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tNombreMateria = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.bSalir = new System.Windows.Forms.Button();
			this.bEliminar = new System.Windows.Forms.Button();
			this.bModificar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tEstado = new System.Windows.Forms.TextBox();
			this.bLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// bGuardar
			// 
			this.bGuardar.Location = new System.Drawing.Point(459, 28);
			this.bGuardar.Name = "bGuardar";
			this.bGuardar.Size = new System.Drawing.Size(113, 42);
			this.bGuardar.TabIndex = 0;
			this.bGuardar.Text = "Guardar";
			this.bGuardar.UseVisualStyleBackColor = true;
			this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codigo Materia";
			// 
			// tCodigoMateria
			// 
			this.tCodigoMateria.Location = new System.Drawing.Point(130, 50);
			this.tCodigoMateria.Name = "tCodigoMateria";
			this.tCodigoMateria.Size = new System.Drawing.Size(137, 20);
			this.tCodigoMateria.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 298);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(819, 170);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// tMaterias
			// 
			this.tMaterias.Location = new System.Drawing.Point(130, 238);
			this.tMaterias.Name = "tMaterias";
			this.tMaterias.Size = new System.Drawing.Size(158, 20);
			this.tMaterias.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Materias";
			// 
			// tApellido
			// 
			this.tApellido.Location = new System.Drawing.Point(130, 202);
			this.tApellido.Name = "tApellido";
			this.tApellido.Size = new System.Drawing.Size(158, 20);
			this.tApellido.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Apellido";
			// 
			// tNombreEstudiante
			// 
			this.tNombreEstudiante.Location = new System.Drawing.Point(130, 171);
			this.tNombreEstudiante.Name = "tNombreEstudiante";
			this.tNombreEstudiante.Size = new System.Drawing.Size(137, 20);
			this.tNombreEstudiante.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nombre Estudiante";
			// 
			// tCreditos
			// 
			this.tCreditos.Location = new System.Drawing.Point(130, 113);
			this.tCreditos.Name = "tCreditos";
			this.tCreditos.Size = new System.Drawing.Size(137, 20);
			this.tCreditos.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Creditos";
			// 
			// tNombreMateria
			// 
			this.tNombreMateria.Location = new System.Drawing.Point(130, 76);
			this.tNombreMateria.Name = "tNombreMateria";
			this.tNombreMateria.Size = new System.Drawing.Size(137, 20);
			this.tNombreMateria.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Nombre Materia";
			// 
			// bSalir
			// 
			this.bSalir.Location = new System.Drawing.Point(654, 91);
			this.bSalir.Name = "bSalir";
			this.bSalir.Size = new System.Drawing.Size(113, 42);
			this.bSalir.TabIndex = 14;
			this.bSalir.Text = "Salir";
			this.bSalir.UseVisualStyleBackColor = true;
			this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
			// 
			// bEliminar
			// 
			this.bEliminar.Location = new System.Drawing.Point(654, 28);
			this.bEliminar.Name = "bEliminar";
			this.bEliminar.Size = new System.Drawing.Size(113, 42);
			this.bEliminar.TabIndex = 15;
			this.bEliminar.Text = "Eliminar";
			this.bEliminar.UseVisualStyleBackColor = true;
			this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
			// 
			// bModificar
			// 
			this.bModificar.Location = new System.Drawing.Point(459, 91);
			this.bModificar.Name = "bModificar";
			this.bModificar.Size = new System.Drawing.Size(113, 42);
			this.bModificar.TabIndex = 16;
			this.bModificar.Text = "Modificar";
			this.bModificar.UseVisualStyleBackColor = true;
			this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 278);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Estado";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// tEstado
			// 
			this.tEstado.Location = new System.Drawing.Point(130, 271);
			this.tEstado.Name = "tEstado";
			this.tEstado.Size = new System.Drawing.Size(158, 20);
			this.tEstado.TabIndex = 18;
			// 
			// bLimpiar
			// 
			this.bLimpiar.Location = new System.Drawing.Point(561, 159);
			this.bLimpiar.Name = "bLimpiar";
			this.bLimpiar.Size = new System.Drawing.Size(113, 42);
			this.bLimpiar.TabIndex = 19;
			this.bLimpiar.Text = "Limpiar";
			this.bLimpiar.UseVisualStyleBackColor = true;
			this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 480);
			this.Controls.Add(this.bLimpiar);
			this.Controls.Add(this.tEstado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.bModificar);
			this.Controls.Add(this.bEliminar);
			this.Controls.Add(this.bSalir);
			this.Controls.Add(this.tNombreMateria);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tCreditos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tNombreEstudiante);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tApellido);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tMaterias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tCodigoMateria);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bGuardar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tCodigoMateria;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tMaterias;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tApellido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tNombreEstudiante;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tCreditos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tNombreMateria;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button bSalir;
		private System.Windows.Forms.Button bEliminar;
		private System.Windows.Forms.Button bModificar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox tEstado;
		private System.Windows.Forms.Button bLimpiar;
	}
}

