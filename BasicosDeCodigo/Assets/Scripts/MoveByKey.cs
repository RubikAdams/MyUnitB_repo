using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ESTE PROGRAMA MUEVE AL OBJETO POR TECLA PRESIONADA
// Y CAMBIA SU COLOR CONFORME SE DESPLAZA
public class MoveByKey : MonoBehaviour {
						public float moveSpeed = 20f;
						public float myColorR = 0; 
						public float myColorG = 0; 
						public float myColorB = 0;
	//public float newColorPlane;
	void Update () {
		Color newColorPlane = new Color(myColorR, 0.0f, myColorB, 0.1f);
		gameObject.GetComponent<Renderer>().material.color=newColorPlane;
		if(Input.GetKey(KeyCode.UpArrow))
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
			if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
		transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		MyColor ();
	}
	public void MyColor ()
	{
		if (transform.position.x <0)
		{
			myColorR=(transform.position.x /10.0f) *-1;
			Debug.Log("<color=green>_En X_:</color>" + myColorR);
		}
		else
			{
				myColorR=transform.position.x /10.0f;
				Debug.Log("<color=green>_En X_:</color>" + myColorR);
			}
		if (transform.position.z <0)
		{
			myColorB=(transform.position.z /10.0f)* -1;
			Debug.Log("<color=red> _En Z_ </color>"+myColorB);
		}
		else
			{
				myColorB=transform.position.z /10.0f;
				Debug.Log("<color=red>_En Z:_</color>" + myColorB);
			}
	}
}