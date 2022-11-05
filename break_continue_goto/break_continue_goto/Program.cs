using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//

namespace break_continue_goto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			/*
			//break
			for(int id=1; id <= 10; id++){
				Thread.Sleep(500); //aplica un delay de 800 milisegundos.
				//Si no aplicara 'delay' exigiría el procesador
				Console.WriteLine(id);
				
				if(id == 5){ 
					break; //si en las iteraciones del for llegan a 5 acciona break;
				}
			}*/
			
			/*
			//continue
			for(int id=1; id <= 10; id++){
				Thread.Sleep(500);
				if(id == 8){
					Console.WriteLine(); //recordar que WriteLine saltea de linea
					Console.WriteLine("nivel 8");
					continue; //si en las iteraciones del for llegan a 8 saltear, continuar con la siguiente iteración.
				}
				Console.WriteLine(id);
			*/
			
			//goto
			for(int id=1; id <= 10; id++){
				Thread.Sleep(500);
				if(id == 8){ //valida q el id sea 8, si llega a ocho
					goto liquidacion; //ve a liquidacion
				}
				Console.WriteLine(id);
			}
			
			//Así se aclara que se hace cuando llaman a liquidación
			liquidacion:
				Console.WriteLine("Se llamó a una ConsoleWrite");
			
			
			Console.ReadKey(true);
		}
	}
}