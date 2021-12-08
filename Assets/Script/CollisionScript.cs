using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Törmäys tapahtui");
        if (other.transform.tag == "Player")
        {
            PointManager.instance.addPoint();

            Destroy(gameObject);
        }

        
    }
}
