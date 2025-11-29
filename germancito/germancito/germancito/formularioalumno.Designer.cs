/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace germancito
{
	partial class formularioalumno
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.txtp1 = new System.Windows.Forms.TextBox();
			this.txtp2 = new System.Windows.Forms.TextBox();
			this.txtp3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbgenero = new System.Windows.Forms.ComboBox();
			this.cmbsemestre = new System.Windows.Forms.ComboBox();
			this.cmbcarrera = new System.Windows.Forms.ComboBox();
			this.cmbclub = new System.Windows.Forms.ComboBox();
			this.cmbtegusta = new System.Windows.Forms.ComboBox();
			this.cmbedad = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Nombre = new System.Windows.Forms.ColumnHeader();
			this.Parcial_1 = new System.Windows.Forms.ColumnHeader();
			this.Parcial_2 = new System.Windows.Forms.ColumnHeader();
			this.Parcial_3 = new System.Windows.Forms.ColumnHeader();
			this.Genero = new System.Windows.Forms.ColumnHeader();
			this.Semestre = new System.Windows.Forms.ColumnHeader();
			this.Carrera = new System.Windows.Forms.ColumnHeader();
			this.Club = new System.Windows.Forms.ColumnHeader();
			this.Edad = new System.Windows.Forms.ColumnHeader();
			this.Satisfaccion = new System.Windows.Forms.ColumnHeader();
			this.btnguardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(30, 60);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(158, 25);
			this.txtnombre.TabIndex = 1;
			this.txtnombre.TextChanged += new System.EventHandler(this.TxtnombreTextChanged);
			// 
			// txtp1
			// 
			this.txtp1.Location = new System.Drawing.Point(209, 60);
			this.txtp1.Name = "txtp1";
			this.txtp1.Size = new System.Drawing.Size(100, 25);
			this.txtp1.TabIndex = 2;
			this.txtp1.TextChanged += new System.EventHandler(this.Txtp1TextChanged);
			// 
			// txtp2
			// 
			this.txtp2.Location = new System.Drawing.Point(319, 60);
			this.txtp2.Name = "txtp2";
			this.txtp2.Size = new System.Drawing.Size(100, 25);
			this.txtp2.TabIndex = 3;
			this.txtp2.TextChanged += new System.EventHandler(this.Txtp2TextChanged);
			// 
			// txtp3
			// 
			this.txtp3.Location = new System.Drawing.Point(425, 60);
			this.txtp3.Name = "txtp3";
			this.txtp3.Size = new System.Drawing.Size(100, 25);
			this.txtp3.TabIndex = 4;
			this.txtp3.TextChanged += new System.EventHandler(this.Txtp3TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(209, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Parcial 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(319, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Parcial 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(425, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Parcial 3:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(566, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Género:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(707, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Semestre:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(30, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Carrera:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(209, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 20);
			this.label8.TabIndex = 11;
			this.label8.Text = "Club:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(319, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 20);
			this.label9.TabIndex = 12;
			this.label9.Text = "Edad:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(425, 113);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(213, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "Te gusta la prepa?:";
			// 
			// cmbgenero
			// 
			this.cmbgenero.FormattingEnabled = true;
			this.cmbgenero.Items.AddRange(new object[] {
									"Masculino",
									"Femenino"});
			this.cmbgenero.Location = new System.Drawing.Point(566, 60);
			this.cmbgenero.Name = "cmbgenero";
			this.cmbgenero.Size = new System.Drawing.Size(100, 24);
			this.cmbgenero.TabIndex = 14;
			this.cmbgenero.SelectedIndexChanged += new System.EventHandler(this.CmbgeneroSelectedIndexChanged);
			// 
			// cmbsemestre
			// 
			this.cmbsemestre.FormattingEnabled = true;
			this.cmbsemestre.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6"});
			this.cmbsemestre.Location = new System.Drawing.Point(707, 61);
			this.cmbsemestre.Name = "cmbsemestre";
			this.cmbsemestre.Size = new System.Drawing.Size(100, 24);
			this.cmbsemestre.TabIndex = 15;
			this.cmbsemestre.SelectedIndexChanged += new System.EventHandler(this.CmbsemestreSelectedIndexChanged);
			// 
			// cmbcarrera
			// 
			this.cmbcarrera.FormattingEnabled = true;
			this.cmbcarrera.Items.AddRange(new object[] {
									"Programación",
									"Contabilidad",
									"Soporte",
									"Alimentos",
									"Mecanica",
									"Ciberseguridad"});
			this.cmbcarrera.Location = new System.Drawing.Point(30, 136);
			this.cmbcarrera.Name = "cmbcarrera";
			this.cmbcarrera.Size = new System.Drawing.Size(100, 24);
			this.cmbcarrera.TabIndex = 16;
			this.cmbcarrera.SelectedIndexChanged += new System.EventHandler(this.CmbcarreraSelectedIndexChanged);
			// 
			// cmbclub
			// 
			this.cmbclub.FormattingEnabled = true;
			this.cmbclub.Items.AddRange(new object[] {
									"Musica",
									"Dibujo",
									"Lectura",
									"Tiro al arco"});
			this.cmbclub.Location = new System.Drawing.Point(209, 136);
			this.cmbclub.Name = "cmbclub";
			this.cmbclub.Size = new System.Drawing.Size(66, 24);
			this.cmbclub.TabIndex = 17;
			this.cmbclub.SelectedIndexChanged += new System.EventHandler(this.CmbclubSelectedIndexChanged);
			// 
			// cmbtegusta
			// 
			this.cmbtegusta.FormattingEnabled = true;
			this.cmbtegusta.Items.AddRange(new object[] {
									"Si",
									"No"});
			this.cmbtegusta.Location = new System.Drawing.Point(425, 136);
			this.cmbtegusta.Name = "cmbtegusta";
			this.cmbtegusta.Size = new System.Drawing.Size(151, 24);
			this.cmbtegusta.TabIndex = 19;
			this.cmbtegusta.SelectedIndexChanged += new System.EventHandler(this.CmbtegustaSelectedIndexChanged);
			// 
			// cmbedad
			// 
			this.cmbedad.Location = new System.Drawing.Point(319, 135);
			this.cmbedad.Name = "cmbedad";
			this.cmbedad.Size = new System.Drawing.Size(52, 25);
			this.cmbedad.TabIndex = 20;
			this.cmbedad.TextChanged += new System.EventHandler(this.CmbedadTextChanged);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Nombre,
									this.Parcial_1,
									this.Parcial_2,
									this.Parcial_3,
									this.Genero,
									this.Semestre,
									this.Carrera,
									this.Club,
									this.Edad,
									this.Satisfaccion});
			this.listView1.Location = new System.Drawing.Point(30, 206);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(777, 116);
			this.listView1.TabIndex = 21;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.Width = 119;
			// 
			// Parcial_1
			// 
			this.Parcial_1.Text = "Parcial_1";
			this.Parcial_1.Width = 110;
			// 
			// Parcial_2
			// 
			this.Parcial_2.Text = "Parcial_2";
			this.Parcial_2.Width = 100;
			// 
			// Parcial_3
			// 
			this.Parcial_3.Text = "Parcial_3";
			this.Parcial_3.Width = 100;
			// 
			// Genero
			// 
			this.Genero.Text = "Género";
			this.Genero.Width = 77;
			// 
			// Semestre
			// 
			this.Semestre.Text = "Semestre";
			this.Semestre.Width = 104;
			// 
			// Carrera
			// 
			this.Carrera.Text = "Carrera";
			this.Carrera.Width = 97;
			// 
			// Club
			// 
			this.Club.Text = "Club";
			// 
			// Edad
			// 
			this.Edad.Text = "Edad";
			// 
			// Satisfaccion
			// 
			this.Satisfaccion.Text = "Satisfaccion";
			this.Satisfaccion.Width = 141;
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(661, 137);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(125, 42);
			this.btnguardar.TabIndex = 22;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// formularioalumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 334);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.cmbedad);
			this.Controls.Add(this.cmbtegusta);
			this.Controls.Add(this.cmbclub);
			this.Controls.Add(this.cmbcarrera);
			this.Controls.Add(this.cmbsemestre);
			this.Controls.Add(this.cmbgenero);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtp3);
			this.Controls.Add(this.txtp2);
			this.Controls.Add(this.txtp1);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Minecraft", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "formularioalumno";
			this.Text = "Alumnos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.ColumnHeader Satisfaccion;
		private System.Windows.Forms.ColumnHeader Edad;
		private System.Windows.Forms.ColumnHeader Club;
		private System.Windows.Forms.ColumnHeader Carrera;
		private System.Windows.Forms.ColumnHeader Semestre;
		private System.Windows.Forms.ColumnHeader Genero;
		private System.Windows.Forms.ColumnHeader Parcial_3;
		private System.Windows.Forms.ColumnHeader Parcial_2;
		private System.Windows.Forms.ColumnHeader Parcial_1;
		private System.Windows.Forms.ColumnHeader Nombre;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox cmbedad;
		private System.Windows.Forms.ComboBox cmbtegusta;
		private System.Windows.Forms.ComboBox cmbclub;
		private System.Windows.Forms.ComboBox cmbcarrera;
		private System.Windows.Forms.ComboBox cmbsemestre;
		private System.Windows.Forms.ComboBox cmbgenero;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtp3;
		private System.Windows.Forms.TextBox txtp2;
		private System.Windows.Forms.TextBox txtp1;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
	}
}
