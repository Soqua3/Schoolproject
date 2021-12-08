using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject doorToUnlock;
    [SerializeField]
    private GameObject doorToUnlock2;
    [SerializeField]
    private float doorUnlockDelay = 0f;
    [SerializeField]
    private GameObject doorUnlockEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {

        
        if (doorToUnlock != null)
        {
            if (doorUnlockEffect != null)
            {
                Vector3 effectObjectPosition = transform.position;
                GameObject effectObject = Instantiate(doorUnlockEffect, effectObjectPosition, Quaternion.identity);

                effectObject.transform.LookAt(doorToUnlock.transform);
                Destroy(effectObject, 3f);
            }

            Destroy(doorToUnlock, doorUnlockDelay);
        }
        }
        if (collision.collider.tag == "Player")
        {


            if (doorToUnlock2 != null)
            {
                if (doorUnlockEffect != null)
                {
                    Vector3 effectObjectPosition = transform.position;
                    GameObject effectObject = Instantiate(doorUnlockEffect, effectObjectPosition, Quaternion.identity);

                    effectObject.transform.LookAt(doorToUnlock2.transform);
                    Destroy(effectObject, 3f);
                }

                Destroy(doorToUnlock2, doorUnlockDelay);
            }
        }
    }
} 
