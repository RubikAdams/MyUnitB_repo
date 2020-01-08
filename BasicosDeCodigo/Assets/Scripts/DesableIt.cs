using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesableIt : MonoBehaviour {
				private Light myLight;
				public GameObject phantomObj;
	// Use this for initialization
	void Start () {
		myLight=GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space))
		{
			myLight.enabled= !myLight.enabled;
		}
	}
}
