using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlaneCool : MonoBehaviour {
    Color myColor;
    Material thisMat;
    public float speed = .0f;
    // Start is called before the first frame update
    void Start()
    {
        myColor = Color.black;
        thisMat = GetComponent<Renderer>().material;
        thisMat.color = myColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.left * speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.right * speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.up * speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.down * speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }
        if (Input.GetKey(KeyCode.W))
        {

            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.forward * speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }
        if (Input.GetKey(KeyCode.S))
        {

            Vector3 tempPos = Vector3.zero;
            tempPos = Vector3.forward * -speed * Time.deltaTime;
            transform.Translate(tempPos);
            ChangeMyColor();
        }


    }
    public void ChangeMyColor()
    {
        myColor.r = transform.position.x / 10f < 0 ? (transform.position.x / 10f) * -1 : transform.position.x / 10f;
        myColor.g = transform.position.y / 10f < 0 ? (transform.position.y / 10f) * -1 : transform.position.y / 10f;
        myColor.b = transform.position.z / 10f < 0 ? (transform.position.z / 10f) * -1 : transform.position.z / 10f;
        thisMat.color = myColor;
    }
}

