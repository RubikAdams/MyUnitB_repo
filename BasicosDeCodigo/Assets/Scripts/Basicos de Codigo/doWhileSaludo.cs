using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ejemplo con doWhile /Saludar mientras se cumpla la condición
/* no declaro variables*/
public class doWhileSaludo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool saludoTemporal=false;
		do
		{
			print("hola");
		}
		while (saludoTemporal==true);
	}
}
