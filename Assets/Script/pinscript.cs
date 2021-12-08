using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinscript : MonoBehaviour
{

    private float originalX;
    private float originalZ;

    // Start is called before the first frame update
    void Start()
    {
        originalX = this.transform.position.x;
        originalZ = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float getoriginalX;
}
