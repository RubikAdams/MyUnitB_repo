using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Creando enemigos con FOR
public class ManyEnemies : MonoBehaviour {
	int numEnemies=3	;
	// Use this for initialization
	void Start () {
		for (int i=0; i<numEnemies;i++)
		{
			Debug.Log("Creando enemigo numero:_"+i);
		}
	}
}
