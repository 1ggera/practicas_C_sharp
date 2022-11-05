/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 3/10/2022
 * Time: 02:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace while_doWhile
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* While repite el ciclo siempre y cuando la condición sea verdadera. */
			double contador = 1; 
			
			while(contador<5){//verifica la condición y si es verdadera ejecuta el código
				Console.WriteLine("Hello everybody");
				contador++;
			}
			
			//hacer algo siempre y cuando el 'while' sea verdadero 
			do{ //al menos lo ejecuta una vez y luego verifica la condición
				Console.WriteLine("Hola mundo");
				contador++;
			}while(contador<5);
			
			Console.ReadKey(true);
		}
	}
}