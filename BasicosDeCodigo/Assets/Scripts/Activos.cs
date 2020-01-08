using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activos : MonoBehaviour {
		public GameObject myObject;
    
    
    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
	private void Update() {
		transform.Translate( new Vector3 (2,4,-5));
	}
}
