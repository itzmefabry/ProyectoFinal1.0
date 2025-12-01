/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace germancito
{
	partial class numaleatorios
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
			this.lsbNumeros = new System.Windows.Forms.ListBox();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.lsbNumerosO = new System.Windows.Forms.ListBox();
			this.btngenerar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(422, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "NUMEROS ALEATORIOS";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numeros generados:";
			// 
			// lsbNumeros
			// 
			this.lsbNumeros.FormattingEnabled = true;
			this.lsbNumeros.ItemHeight = 20;
			this.lsbNumeros.Items.AddRange(new object[] {
									" "});
			this.lsbNumeros.Location = new System.Drawing.Point(261, 86);
			this.lsbNumeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lsbNumeros.Name = "lsbNumeros";
			this.lsbNumeros.Size = new System.Drawing.Size(90, 224);
			this.lsbNumeros.TabIndex = 2;
			this.lsbNumeros.SelectedIndexChanged += new System.EventHandler(this.LsbNumerosSelectedIndexChanged);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrdenar.Location = new System.Drawing.Point(62, 146);
			this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(142, 91);
			this.btnOrdenar.TabIndex = 3;
			this.btnOrdenar.Text = "Ordenar Numeros";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// lsbNumerosO
			// 
			this.lsbNumerosO.FormattingEnabled = true;
			this.lsbNumerosO.ItemHeight = 20;
			this.lsbNumerosO.Items.AddRange(new object[] {
									" "});
			this.lsbNumerosO.Location = new System.Drawing.Point(363, 111);
			this.lsbNumerosO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lsbNumerosO.Name = "lsbNumerosO";
			this.lsbNumerosO.Size = new System.Drawing.Size(104, 244);
			this.lsbNumerosO.TabIndex = 4;
			// 
			// btngenerar
			// 
			this.btngenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btngenerar.Location = new System.Drawing.Point(62, 264);
			this.btngenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btngenerar.Name = "btngenerar";
			this.btngenerar.Size = new System.Drawing.Size(142, 91);
			this.btngenerar.TabIndex = 5;
			this.btngenerar.Text = "Generar";
			this.btngenerar.UseVisualStyleBackColor = false;
			this.btngenerar.Click += new System.EventHandler(this.BtngenerarClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(261, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Numeros:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(363, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Numeros";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(363, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ordenados:";
			// 
			// numaleatorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(486, 385);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btngenerar);
			this.Controls.Add(this.lsbNumerosO);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.lsbNumeros);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "numaleatorios";
			this.Text = "numaleatorios";
			this.Load += new System.EventHandler(this.NumaleatoriosLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btngenerar;
		private System.Windows.Forms.ListBox lsbNumerosO;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.ListBox lsbNumeros;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
