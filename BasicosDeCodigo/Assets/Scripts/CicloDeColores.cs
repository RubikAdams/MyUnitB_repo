using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Cambio de colores por slide en UI
public class CicloDeColores : MonoBehaviour {
	Renderer mi_Render;
	public Color color = Color.white;
	// Use this for initialization
	void Start () {
		mi_Render=GetComponent<Renderer>();
	}
	//Cambio del color solo sobre el objeto
	/*void OnMouseOver()
	{
		mi_Render.material.color = Color.gray;
	}
	void OnMouseExit()
	{
		mi_Render.material.color = Color.blue;
		
	}
	*/
	private void OnGUI()
	{
		color.r = GUI.HorizontalSlider (new Rect(0, 00, 100, 30), color.r, 0, 1);
		color.g = GUI.HorizontalSlider (new Rect(0, 40, 100, 30), color.g, 0, 1);
		color.b = GUI.HorizontalSlider (new Rect(0, 80, 100, 30), color.b, 0, 1); 

		//Set the Color of the GameObject's Material to the new Color
        mi_Render.material.color = color;
	}
}
