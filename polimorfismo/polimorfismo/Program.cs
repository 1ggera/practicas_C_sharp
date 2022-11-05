/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 5/10/2022
 * Time: 01:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

/*
Es la capacidad de usar un elemento de diferentes maneras.
Polimorfismo = tiene diferentes formas de usar una propiedad o método.
*/

namespace polimorfismo
{
	//Encontrar el área de formas geometricas
	//creo una clase aparte para FiguraRectangulo y Figura Triangulo
	//en una de las clases nuevas indicar cual hereda de la otra.
	//En este archivo principal instanciar una variable q herede el método 'area' de cada archivo.
	//Enviar los parámetros para calcular cada figura.
	
	class Program
	{
		public static void Main(string[] args)
		{
			FiguraRectangulo calcularRectangulo = new FiguraRectangulo();
			calcularRectangulo.Area(20,22); // -> el . mostrará la prop/metod disponible de usar
			
			FiguraTriangulo calcularTriangulo = new FiguraTriangulo();
			calcularTriangulo.Area(20,22);
			
			Console.ReadKey(true);
		}
	}
}