using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// este programa Declara variables y una función pública
/*y accesa a modificadores de otra clase pública creada el 
el Script "SumaClasePublica"
y viene en el tutorial:
 Scope and Access Modifiers
 https://learn.unity.com/tutorial/scope-and-access-modifiers?projectId=5c8920b4edbc2a113b6bc26a
*/
public class SumaPublicFuncions : MonoBehaviour {
						public int alpha = 5;
						private int beta = 0;
						private int gamma = 5;
						private SumaClasePublica myOtherClass;
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new SumaClasePublica();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    void Update ()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
