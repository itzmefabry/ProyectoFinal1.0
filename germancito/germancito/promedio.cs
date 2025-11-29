/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/11/2025
 * Time: 06:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace germancito
{
	/// <summary>
	/// Description of promedio.
	/// </summary>
	public partial class promedio : Form
	{
		public promedio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a, b, c, d, x, f, g, h;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = double.Parse(textBox4.Text);
            x = double.Parse(textBox5.Text);
            f = double.Parse(textBox6.Text);
            g = double.Parse(textBox7.Text);

            h = (a + b + c + d + x + f + g) / 7;

            txtpromedio.Text = h.ToString();
		}
	}
}
