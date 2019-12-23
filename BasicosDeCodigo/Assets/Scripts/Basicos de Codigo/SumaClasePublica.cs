using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// este programa crea una clase Pública llamada "SumaClasePublica

/* en una clase a la cual se accesa desde otro script SumaPublicFuncions
y viene en el tutorial:
 Scope and Access Modifiers
 https://learn.unity.com/tutorial/scope-and-access-modifiers?projectId=5c8920b4edbc2a113b6bc26a
*/
public class SumaClasePublica : MonoBehaviour {
					public int apples;
					public int bananas;
					
					
					private int stapler;
					private int sellotape;
    
    
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
