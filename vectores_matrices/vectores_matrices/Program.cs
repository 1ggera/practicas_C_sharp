/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 3/10/2022
 * Time: 02:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace vectores_matrices
{
	class Program
	{
		public static void Main(string[] args)
		{
			//En C los arrays son objetos y se deben instanciar antes de inicializar. 
			
			/*
			//Array unidimensional
			int[] numero;
			
			numero = new int[5]; //Se instancia antes de usar/inicializar
			
			numero[0]=5;
			numero[2]=6;
			numero[4]=7;
			
			//itera y en cada elemento de 'numero'
			foreach(int elemento in numero){
				Console.WriteLine(elemento);//imprime el valor asignado
			}//si las posiciones del array no tuvieran valor asignado quedarían en cero como la position 1 y 3. 
			*/
			
			//Array bidimensionales (MATRICES)
			//Tambien se declara como un objeto. Se usa una coma. Lado Izq = filas, lado Der = columnas.
			int [,] numero;
			
			//Así instancia una matriz indicando cantidad de filas y columnas.
			numero = new int[3, 3];
			
			//for q itera por cada posición de la matriz solicitando un número
			for(int fila=0; fila <3; fila++){
				for(int col = 0; col < 3; col++){
					Console.WriteLine("Dame un numero");
					numero[fila, col] = Convert.ToInt16(Console.ReadLine());
				}
			}
			Console.Clear();
			
			//for para mostrar la matriz en pantalla de manera ordenada
			for(int fila=0; fila <3; fila++){
				for(int col = 0; col < 3; col++){
					Console.Write(" "+numero[fila,col]);//no se usa WriteLine porq salta de pantalla.
				}
				Console.WriteLine();
			}
			
			Console.ReadKey(true);
		}
	}
}