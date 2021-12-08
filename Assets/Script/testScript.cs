using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testScript : MonoBehaviour
{
    public Rigidbody rocket;
    public float speed = 10f;
    // Stat is called before the first frame update
    void Fire()
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position, transform.rotation);
        rocketClone.velocity = transform.forward * speed;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
}
