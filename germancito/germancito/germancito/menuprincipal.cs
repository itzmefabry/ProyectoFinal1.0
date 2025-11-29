/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace germancito
{
	/// <summary>
	/// Description of menuprincipal.
	/// </summary>
	public partial class menuprincipal : Form
	{
		public menuprincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
						// TODO: Add constructor code after the InitializeComponent() call.
			//
		}



		void BtnalumnosClick(object sender, EventArgs e)
		{
			formularioalumno f = new formularioalumno();
			f.Show();
		}

		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		void BtnnumerosClick(object sender, EventArgs e)
		{
			numaleatorios f = new numaleatorios();
			f.Show();
		}

		void BtnpromedioClick(object sender, EventArgs e)
		{
			promedio f = new promedio();
			f.Show();
		}
	}
}
