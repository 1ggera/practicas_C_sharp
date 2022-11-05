using System;

//Polimorfismo permite usar la misma función inclusive embebida en otra clase.
//Ej: funcion area del rectangulo es usada embebida en la formula del triangulo.
//Permite llamar a una función con el mismo nombre que en otra clase. No causa ambiguedad.
namespace polimorfismo
{
	//indico q va a heredar algo de la clase 'FiguraRectangulo'
	public class FiguraTriangulo : FiguraRectangulo
	{
		//función del rectangulo renombrada igual para usarla
		public void Area(int Base, int Altura){
			//uso la función 'area' combinada en el calculo del area de este elemento: En este caso un triangulo
			//En este caso está sobreescribiendo el la acción de la funcion heredada. 
			Console.WriteLine("El área del triangulo es: "+((Base * Altura) /2));
		}
	}
}
