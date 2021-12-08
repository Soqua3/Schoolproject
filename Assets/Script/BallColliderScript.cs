using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliderScript : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraObject;
    [SerializeField]
    private Vector3 cameraNewPosition = new Vector3(0f, 0f, 0f); 
    private bool cameraObjectExists;
    // Start is called before the first frame update
    void Start()
    {
        if ( cameraObject == null)
        {
            Debug.Log("BallColliderScript: Siirrettävää kameraa ei ole");
            cameraObjectExists = false;
        }else
        {
            cameraObjectExists = true; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Törmäys on tapahtunut");

        if ( collision.transform.tag == "Ball")
        {
            Debug.Log("Törmääjää oli Ball");
            //Kun pallo törmää
            if ( cameraObjectExists)
            {
                // Ptää ottaa kameran ja pallon kiinnitys pois
                cameraObject.GetComponent<CameraFollow>().enabled = false;
                // pitää siirtää kameraa katsomaan keilauksen loppuun
                cameraObject.transform.position = cameraNewPosition;

                GameObject[] pins = GameObject.FindGameObjectsWithTag("pin");

                if (pins != null)
                {
                    foreach (GameObject pin in pins)
                    {
                        
                        
                        if (pin.transform.rotation.x < -92 || pin.transform.rotation.x > -88)

                        {
                            ScoreManager.instance.addPoint();

                        }
                    }
                }

            }
        }
    }
}
