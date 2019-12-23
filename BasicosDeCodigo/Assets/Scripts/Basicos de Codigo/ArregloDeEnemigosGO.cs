using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crea varios "Enemigos" GameObjects por arreglo público
public class ArregloDeEnemigosGO : MonoBehaviour {
					public GameObject[] enemies; //dragged 3 GameObjects into Inspector
	    void OnTriggerEnter(Collider collider)
    {
        //activate enemies
        foreach (GameObject enemy in enemies)
        {
           enemy.SetActive(true);   
        }
    }

}
