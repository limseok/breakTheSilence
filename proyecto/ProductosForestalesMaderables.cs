
using System;

namespace proyecto
{

	public class ProductosForestalesMaderables
	{
		private string tipo,categoria,descripcion;
		
		public string Tipo
		{
			get{return tipo;}
			set{tipo = value;}
		}
		public string Categoria
		{
			get{return categoria;}
			set{categoria = value;}
		}
		public string Descripcion
		{
			get{return descripcion;}
			set{descripcion = value;}
		}
		public void leer()
		{
			Console.WriteLine("ingrese tipo-->");
			tipo = Console.ReadLine();
			Console.WriteLine("ingrese categoria-->");
			categoria = Console.ReadLine();
			Console.WriteLine("ingrese descripcion-->");
			descripcion = Console.ReadLine();
		}
		public void mostrar()
		{
			Console.WriteLine(tipo+" "+categoria+" "+descripcion);
		}
	}
}
