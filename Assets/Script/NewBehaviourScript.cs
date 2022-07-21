using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public float x = 1;
    public float z = 1;
    private CharacterController characterController;
    private Camera _camera;
    /*
    // Start is called before the first frame update
    private BoxCollider myCollider;
    private Transform myTransform;
    private Camera mycamera;
    private Transform otherPlace;
    */

    void Start()
    {
        /*
        myCollider = GetComponent<BoxCollider>();
        myTransform = GetComponent<Transform>();
        print(myCollider.name);
        mycamera = transform.GetChild(0).GetComponent<Camera>();
        otherPlace = GameObject.Find("Cube").GetComponent<Transform>();*/
        characterController = GetComponent<CharacterController>();
        _camera = transform.GetChild(0).GetComponent<Camera>();
    }

    void Update()
    {
        /*float x = 0;
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
        } */
    float time = Time.deltaTime;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal") * time , 0, Input.GetAxis("Vertical") * time);
        characterController.Move(move);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        _camera.transform.Rotate(Input.GetAxis("Mouse Y"), 0, 0);
        print(_camera.transform.eulerAngles);
        if (_camera.transform.eulerAngles.x >=50)
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x - 360, -30, 0), _camera.transform.eulerAngles.y, 0);

        }
        else
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x, 0, 45), _camera.transform.eulerAngles.y, 0);
        }
    }

}


// Update is called once per frame




