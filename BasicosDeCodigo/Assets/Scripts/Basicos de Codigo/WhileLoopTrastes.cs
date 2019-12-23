using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//mientras Condicional while con menor que
public class WhileLoopTrastes : MonoBehaviour {
	int trastesSucios=20;
	// Use this for initialization
	void Start () {
		while (trastesSucios>0)
		{
			print("Continuar lavando"+trastesSucios);
			trastesSucios--;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
