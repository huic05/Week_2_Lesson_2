using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider myCollider;
    private Transform myTransform;


    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        myTransform = GetComponent<Transform>();    
    }

    void Update()
    {
        transform.position += new Vector3(0.01f, 0.01f, 0.01f);
    }

}


// Update is called once per frame




