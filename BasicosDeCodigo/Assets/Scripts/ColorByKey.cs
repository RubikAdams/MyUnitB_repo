using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//identificando acciones con If sencillo (Cmbia de colores de acuerdo a la tecla que presiones)
public class ColorByKey : MonoBehaviour {

	// Este "void" es de inicialización
	void Start () {
		Debug.Log (transform.position.x);
		if (transform.position.y <= 5f)
		{
			Debug.Log ("Casi choco con el piso"+ gameObject.name);
				
		}

        

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
			{
				GetComponent<Renderer>().material.color=Color.red;
			}
		if (Input.GetKeyDown(KeyCode.G))
			{
				GetComponent<Renderer>().material.color=Color.green;
			}
		if (Input.GetKeyDown(KeyCode.B))
			{
				GetComponent<Renderer>().material.color=Color.blue;
			}
	}
}
