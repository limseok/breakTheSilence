/*
 * Creado por SharpDevelop.
 * Usuario: Limber
 * Fecha: 18/12/2020
 * Hora: 15:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyecto
{
	/// <summary>
	/// Description of RecursosForestales.
	/// </summary>
	public class RecursosForestales
	{
		private string titulo;
		private int nroProductosm,nroProductosnm,nroProductosnmi;
		private string []regionesProductivas = new string[8];
		private string []tiposDeMadera = new string[10];
		private ProductosForestalesMaderables[] pm= new ProductosForestalesMaderables[20];
		private ProductosForestalesNoMaderables[] pnm= new ProductosForestalesNoMaderables[20];
		private ProductosForestablesNoMaderablesDeMayorImportancia []p= new ProductosForestablesNoMaderablesDeMayorImportancia[10];
		public RecursosForestales()
		{
			nroProductosnm = 0;
			regionesProductivas[0]="bajoparagua";regionesProductivas[1]="chiquitania";regionesProductivas[2]="chore";
			regionesProductivas[3]="guarayos";regionesProductivas[4]="piedemonteamazonico";regionesProductivas[5]="bosqueamazonico";
			regionesProductivas[6]="tucumano";regionesProductivas[7]="tucumano";
			
			tiposDeMadera[0]="roble";tiposDeMadera[1]="mara";tiposDeMadera[2]="cedro cedrela";
			tiposDeMadera[3]="mara";tiposDeMadera[4]="tajibo";tiposDeMadera[5]="standley";
			tiposDeMadera[6]="morado";tiposDeMadera[7]="cambara";tiposDeMadera[8]="ocho hura crepitans";
			
			for (int i = 1; i <= 19; i++) {
				pm[i] = new ProductosForestalesMaderables();
			}
			for (int i = 1; i <= 9; i++) {
				p[i] = new ProductosForestablesNoMaderablesDeMayorImportancia();
			}
		}
		public string Titulo
		{
			get{return titulo;}
			set{titulo = value;}
		}
		public int NroProductosm
		{
			get{return nroProductosm;}
			set{nroProductosm = value;}
		}
		public int NroProductosnm
		{
			get{return nroProductosnm;}
			set{nroProductosnm = value;}
		}
		public int NroProductosnmi
		{
			get{return nroProductosnmi;}
			set{nroProductosnmi = value;}
		}
		public void leer()
		{
			Console.WriteLine("ingrese titulo-->");
			titulo = Console.ReadLine();
			Console.WriteLine("ingrese nro de productos forestales maderables-->");
			nroProductosm = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese nro de productos forestales no maderables-->");
			NroProductosnm = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese nro de productos forestales no maderables de mayor importancia-->");
			nroProductosnmi = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= nroProductosm; i++) {
				pm[i].leer();
			}
			for (int i = 1; i <= nroProductosnmi; i++) {
				p[i].leer();
			}
			agregarPnm();
		}
		public void mostrar()
		{
			Console.WriteLine(titulo);
			for (int i = 0; i <= regionesProductivas.Length-1; i++) {
				Console.WriteLine(regionesProductivas[i]);
			}
			for (int i = 0; i <= tiposDeMadera.Length-1; i++) {
				Console.WriteLine(tiposDeMadera[i]);
			}
			for (int i = 1; i < nroProductosm; i++) {
				pm[i].mostrar();
			}
			for (int i = 1; i <= nroProductosnm; i++) {
				pnm[i].mostrar();
			}
			for (int i = 1; i <= NroProductosnmi; i++) {
				p[i].mostrar();
			}
			
			
		}
		public void agregarPnm()
		{
			for (int i = 1; i <= NroProductosnm; i++) {
				pnm[i] = new ProductosForestalesNoMaderables();
				pnm[i].leer();
			}
		}
	}
}
