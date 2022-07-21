using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public Transform trash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var BulletVar = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            BulletVar.transform.SetParent(trash);
            
        }
        print(spawnPoint.position);
    }
}
