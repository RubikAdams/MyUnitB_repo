using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Verificando temperatura con if, else if, else
public class cafeTemperatura : MonoBehaviour {
	// Use this for initialization
	float cafeTemp= 85.0f;
	float calienteLimitTemp= 70.0f;
	float frioLimitTemp=40.0f;
	void Start () {
		
	}
	
	//Función llamada una vez por frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
			TemperaturaTest();
			cafeTemp -= Time.deltaTime * 5.0f;
	}
	void TemperaturaTest()
	{
		// If the coffee's temperature is greater than the hottest drinking temperature...
		if (cafeTemp > calienteLimitTemp)
			{
				print ("Cafe es muy caliente");
			}
		else if(cafeTemp<frioLimitTemp)
			{
				print("Cafe muy frio");
			}
		else
			{
				print("El café esta en el temperatura adecuada");
				//Color newColor = new Vector4(0.5f, 0.4f, 0.6f);
			}
	}	
		
}
