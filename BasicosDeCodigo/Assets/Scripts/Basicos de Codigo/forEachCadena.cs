using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// con ForEach /PAra cada cosa hace algo, en este caso
/* Declaro 1 cadena de texto
*/
public class forEachCadena : MonoBehaviour {
	
	// Use this for initialization
	void Start ()
	{
		string [] cadenaTexto=new string[4];
		cadenaTexto[0]="1PRIMER";
		cadenaTexto[1]="2SEGUNDO";
		cadenaTexto[2]="3TERSER";
		cadenaTexto[3]="4CUARTO";
		foreach (string item in cadenaTexto)
		{
			print(item);
		}		
	}
}
