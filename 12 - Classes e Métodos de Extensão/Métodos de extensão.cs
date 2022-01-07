
///Injetando um metodo numa classe existente

using System;
public static class MyExtensions
{
	//injetando método "ToUrl" na classe string
	//this String => significa que to inserindo o metodo ToUrl na classe String
	//str => é a instancia na qual vou trabalhar
	public static string ToUrl(this String str){
		return str.Insert(0,"http://")
	}
}