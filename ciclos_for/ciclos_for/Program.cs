/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 2/10/2022
 * Time: 23:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ciclos_for
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			for(int x =1; x <= 5; x++)
			{
				Console.WriteLine(x);
			}
			
			//tambien funciona con letras
			for(Char letra ='a'; letra <= 'z'; letra++)
			{
				Console.WriteLine(letra);
			}
			
			//for anidado
			for(int x =1; x<=5;x++){
				for(int y=1; y <= 5; y++){
					Console.WriteLine("Holanda");
				}
			}
			//for each
			string user = "admin";
				
				//primero declaro una variable.
				//es tipo char porq trabajará con una palabra:'admin'
				foreach(char letra in user)//significa por cada letra en 'user'
				{
					Console.Write(" "+letra+" "); //consoleWrite escribe todo en una linea
					//Console.WriteLine escribe el caracter con salto de linea
					
				}
			Console.ReadKey();
		}
	}
}