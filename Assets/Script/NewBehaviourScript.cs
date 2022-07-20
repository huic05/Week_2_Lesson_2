using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider myCollider;
    private Transform myTransform;
    private Camera mycamera;
    private Transform otherPlace;


    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        myTransform = GetComponent<Transform>();
        print(myCollider.name);
        mycamera = transform.GetChild(0).GetComponent<Camera>();
        otherPlace = GameObject.Find("Cube").GetComponent<Transform>();

    }

    void Update()
    {
        float x = 0;
        if (Input.GetKey(KeyCode.W))
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            x = -1;
        }
        else
        {
            x = 0;
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vetical"));
        transform.position = movement;
    }

}


// Update is called once per frame




