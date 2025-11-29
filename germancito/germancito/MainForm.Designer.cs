/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace germancito
{
	partial class MainForm
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
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(23, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre de usuario :";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(23, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña :";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(177, 35);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(217, 22);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(177, 79);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(217, 22);
			this.txtContraseña.TabIndex = 3;
			// 
			// btnAcceder
			// 
			this.btnAcceder.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAcceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAcceder.Location = new System.Drawing.Point(40, 118);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(138, 41);
			this.btnAcceder.TabIndex = 4;
			this.btnAcceder.Text = "Login";
			this.btnAcceder.UseVisualStyleBackColor = false;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(424, 177);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "germancito";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
