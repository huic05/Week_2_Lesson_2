using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ public float deathTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Death());


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.forward + transform.position;
    }
    private IEnumerator Death()
    {
        print("hello");
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }

}
