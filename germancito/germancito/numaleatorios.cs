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
	/// Description of numaleatorios.
	/// </summary>
	public partial class numaleatorios : Form
	{
		
		public numaleatorios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		Random rand = new Random();
		int[] Numeros = new int[10];
	
		void NumaleatoriosLoad(object sender, EventArgs e)
		{
			
			
		}
		
		void LsbNumerosSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			
			
			
			if(lsbNumerosO.Items.Count==0)
			{
			for(int i = 0; i < 10 - 1; i++)
			{
				for(int j = 0; j < 10 - 1 - i; j++)
				{
				
					if(Numeros[j] > Numeros[j + 1])
					{
					
						int temp = Numeros[j];
						Numeros[j] = Numeros[j + 1];
						Numeros[j + 1] = temp;
					
					}
				
				}
			
			}
			lsbNumeros.Text="";
			for(int i = 0; i < 10; i++)
			{
				
				lsbNumerosO.Items.Add(Numeros[i]);
				
			}
			}
			
			else{
				lsbNumerosO.Items.Clear();
				for(int i = 0; i < 10 - 1; i++)
			{
				for(int j = 0; j < 10 - 1 - i; j++)
				{
				
					if(Numeros[j] > Numeros[j + 1])
					{
					
						int temp = Numeros[j];
						Numeros[j] = Numeros[j + 1];
						Numeros[j + 1] = temp;
					
					}
				
				}
			
			}
			lsbNumeros.Text="";
			for(int i = 0; i < 10; i++)
			{
				
				lsbNumerosO.Items.Add(Numeros[i]);
				
			}
			}
			
			
			
			
			
			
		}
		
		void BtngenerarClick(object sender, EventArgs e)
		{
			if(lsbNumeros.Items.Count==0)
			{
			
		
            for(int i = 0; i < 10; i++)
			{
				Numeros[i] = rand.Next(1, 101);
			}
			for(int i = 0; i < 10; i++)
			{
				
				lsbNumeros.Items.Add(Numeros[i]);
				
			}	

            }	
			else {
			    lsbNumeros.Items.Clear();

			    for(int i = 0; i < 10; i++)
			{
				Numeros[i] = rand.Next(1, 101);
			}
			for(int i = 0; i < 10; i++)
			{
				
				lsbNumeros.Items.Add(Numeros[i]);
				
			}
			}
		}
	}
}
