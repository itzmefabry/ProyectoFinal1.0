/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace germancito
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			menuprincipal m = new menuprincipal();
			if(txtUsuario.Text=="Admin" && txtContraseña.Text=="123")
			{
				m.Show();
				this.Hide();
					
			}
			else{
				MessageBox.Show("Los datos no son correctos");
			}
		}
	}
}
