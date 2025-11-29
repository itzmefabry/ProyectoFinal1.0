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
	partial class menuprincipal
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnalumnos = new System.Windows.Forms.Button();
			this.btnpromedio = new System.Windows.Forms.Button();
			this.btnnumeros = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "¡Bienvenido!";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(65, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 49);
			this.label2.TabIndex = 1;
			this.label2.Text = "¿Que deseas hacer?";
			// 
			// btnalumnos
			// 
			this.btnalumnos.BackColor = System.Drawing.Color.White;
			this.btnalumnos.Location = new System.Drawing.Point(114, 143);
			this.btnalumnos.Name = "btnalumnos";
			this.btnalumnos.Size = new System.Drawing.Size(142, 26);
			this.btnalumnos.TabIndex = 2;
			this.btnalumnos.Text = "Presione aqui";
			this.btnalumnos.UseVisualStyleBackColor = false;
			this.btnalumnos.Click += new System.EventHandler(this.BtnalumnosClick);
			// 
			// btnpromedio
			// 
			this.btnpromedio.BackColor = System.Drawing.Color.White;
			this.btnpromedio.Location = new System.Drawing.Point(114, 254);
			this.btnpromedio.Name = "btnpromedio";
			this.btnpromedio.Size = new System.Drawing.Size(142, 26);
			this.btnpromedio.TabIndex = 3;
			this.btnpromedio.Text = "Presione aqui";
			this.btnpromedio.UseVisualStyleBackColor = false;
			this.btnpromedio.Click += new System.EventHandler(this.BtnpromedioClick);
			// 
			// btnnumeros
			// 
			this.btnnumeros.BackColor = System.Drawing.Color.White;
			this.btnnumeros.Location = new System.Drawing.Point(114, 198);
			this.btnnumeros.Name = "btnnumeros";
			this.btnnumeros.Size = new System.Drawing.Size(142, 26);
			this.btnnumeros.TabIndex = 4;
			this.btnnumeros.Text = "Presione aqui";
			this.btnnumeros.UseVisualStyleBackColor = false;
			this.btnnumeros.Click += new System.EventHandler(this.BtnnumerosClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(54, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "¡Capturar datos de alumnos!";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(54, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(285, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "¡Generar numeros aleatorios!";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(23, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(348, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "¡Sacar promedio de 7 calificaciones!";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(311, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 21);
			this.button1.TabIndex = 8;
			this.button1.Text = "salir";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// menuprincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(378, 296);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnnumeros);
			this.Controls.Add(this.btnpromedio);
			this.Controls.Add(this.btnalumnos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "menuprincipal";
			this.Text = "menuprincipal";
			this.ResumeLayout(false);
			this.Name = "menuprincipal";
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnnumeros;
		private System.Windows.Forms.Button btnpromedio;
		private System.Windows.Forms.Button btnalumnos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
