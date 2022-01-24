/*
 * Creado por SharpDevelop.
 * Usuario: Limber
 * Fecha: 18/12/2020
 * Hora: 15:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of ProductosForestalesNoMaderables.
	/// </summary>
	public class ProductosForestalesNoMaderables
	{
		private string categoria;
		private string descripcion;
		private int especiesEntontradas;
		
		public void leer()
		{
			Console.WriteLine("ingrese categoria-->");
			categoria = Console.ReadLine();
			Console.WriteLine("ingrese descripcion-->");
			descripcion = Console.ReadLine();
			Console.WriteLine("ingrese nro especies encontradas-->");
			especiesEntontradas = int.Parse(Console.ReadLine());
		}
		public void mostrar()
		{
			Console.WriteLine(categoria+" "+descripcion+" "+especiesEntontradas);
		}
	}
}
