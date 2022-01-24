/*
 * Creado por SharpDevelop.
 * Usuario: Limber
 * Fecha: 18/12/2020
 * Hora: 15:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of ProductosForestalesNoMaderablesDeMayorImportancia.
	/// </summary>
	public class ProductosForestablesNoMaderablesDeMayorImportancia
	{
		private int categoria;
		private string nombreComercial;
		private string especie;
		
		public int Categoria
		{
			get{return categoria;}
			set{categoria = value;}
		}
		public string NombreComercial
		{
			get{return nombreComercial;}
			set{nombreComercial = value;}
		}
		public string Especie
		{
			get{return especie;}
			set{especie = value;}
		}
		public void leer()
		{
			Console.WriteLine("ingrese categoria-->");
			categoria = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese nombre comercial-->");
			nombreComercial = Console.ReadLine();
			Console.WriteLine("ingrese especie-->");
			especie = Console.ReadLine();
		}
		public void mostrar()
		{
			Console.WriteLine(categoria+" "+nombreComercial+" "+especie);
		}
	}
}
