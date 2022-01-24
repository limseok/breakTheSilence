/*
 * Creado por SharpDevelop.
 * Usuario: Limber
 * Fecha: 18/12/2020
 * Hora: 14:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		RecursosForestales r1 = new RecursosForestales();
		public MainForm()
		{
			InitializeComponent();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Label1Click(object sender, EventArgs e)	
		{
			r1.leer();
			
		}
		void Button1Click(object sender, EventArgs e)
		{

		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
	
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
			r1.mostrar();
		}
	}
}
