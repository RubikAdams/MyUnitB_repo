using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PROGRAMA QUE CREA OBJETOS PRIMITIVOS QUE VIENEN Y VAN
public class vaiven : MonoBehaviour {
  GameObject cubeR;
  GameObject thing1, thing2, thing3;

  float delayOb;
	// Use this for initialization
	int controlPos=20;
	void Start() {
		//Declaro colores 
		cubeR = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubeR.transform.position = new Vector3(2.0f,1.0f,2.0f);
		cubeR.GetComponent<Renderer>().material.color=Color.cyan;
		print (cubeR.name="Objeto:__Rubik__ en escena");
	/*
		while(controlPos>10)
		{
			delayOb= controlPos * Time.deltaTime;
			print (cubeR.name="__Rubik__ en coordenadas");
			cubeR.transform.position = new Vector3(2.0f*delayOb,1.0f*delayOb,2.0f*delayOb);
			controlPos--;
		}
	*/
		thing1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		thing1.transform.position = new Vector3(5.0f,5.0f,5.0f);	
			for (float fc=0; fc<15;fc++)
		{
			Color newColor = new Color(0.3f, 0.4f, 0.6f, 0.0f*fc*Time.deltaTime);
			thing1.GetComponent<Renderer>().material.color=newColor;
		}
		thing2 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		thing2.transform.position = new Vector3(-5.0f,5.0f,5.0f);
			Color newColor2 = new Color ( 0.3f, 0.3f, 0.3f);
			thing2.GetComponent<Renderer>().material.color=newColor2;
			
	}
	
	// Update is called once per frame
	void Update () {
		//
		for (int i=1; i<30; i++)
		{
			delayOb= i * Time.deltaTime;
			print (cubeR.name="__Rubik__ en coordenadas");
			cubeR.transform.position = new Vector3(8.0f*delayOb,5.0f*delayOb,-4.0f*delayOb);
		}
	
	}
}
