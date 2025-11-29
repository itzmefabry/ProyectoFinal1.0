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
	/// Description of formularioalumno.
	/// </summary>
	public partial class formularioalumno : Form
	{
		public formularioalumno()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtnombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Txtp1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Txtp3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Txtp2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbgeneroSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbsemestreSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbcarreraSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbclubSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbedadTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbtegustaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		void BtnguardarClick(object sender, EventArgs e)
		{
        
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtp1.Text))
            {
                MessageBox.Show("El Parcial 1 es obligatorio", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtp1.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtp2.Text))
            {
                MessageBox.Show("El Parcial 2 es obligatorio", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtp2.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtp3.Text))
            {
                MessageBox.Show("El Parcial 3 es obligatorio", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtp3.Focus();
                return;
            }
            
            if (cmbgenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un género", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbgenero.Focus();
                return;
            }
            
            if (cmbsemestre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un semestre", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbsemestre.Focus();
                return;
            }
            
            if (cmbcarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carrera", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbcarrera.Focus();
                return;
            }
            
            if (cmbclub.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un club", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbclub.Focus();
                return;
            }
            
            ListViewItem fila = new ListViewItem(txtnombre.Text);
            fila.SubItems.Add(txtp1.Text);
            fila.SubItems.Add(txtp2.Text);
            fila.SubItems.Add(txtp3.Text);
            fila.SubItems.Add(cmbgenero.SelectedItem.ToString());
            fila.SubItems.Add(cmbsemestre.SelectedItem.ToString());
            fila.SubItems.Add(cmbcarrera.SelectedItem.ToString());
            fila.SubItems.Add(cmbclub.SelectedItem.ToString());
            
            listView1.Items.Add(fila);
            
            MessageBox.Show("Alumno registrado exitosamente", "Éxito", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
