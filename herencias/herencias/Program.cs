/*
 * 1er paso: Crear clase aparte, será la clase father.
 * 2do paso: crear clase aparte, será la child.
 * 3er paso: en la 'child' agregar : indicando de quien tiene que heredar. Así -> clase_child : clase_father
 * 4to paso: En el programa principal, instanciar que se desprende de la clase child.
 * 	Al presionar . se podran ver los métodos/propiedades heredadas.
 */
using System;

namespace herencias
{
	class Program
	{
		public static void Main(string[] args)
		{
			//clase de la q se desprende la instancia
			//nombre de variable q maneja esa instancia
			//new + clase de la q se instancian las propieddes y métodos 
			clase_child testeando_prop_herencia = new clase_child();
			
			//invocación de métodos/atributos de la clase padre
			testeando_prop_herencia.Saludar();
			testeando_prop_herencia.Despedirse();
				
			Console.ReadKey(true);
		}
	}
}