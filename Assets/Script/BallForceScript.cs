using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForceScript : MonoBehaviour
{
    /*
    */
    private Rigidbody rb;
    [SerializeField]
    private float forceValue = 0f;
    private bool isActive;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //
        if (rb == null)
        {
            Debug.Log("BallForceScript: Rigidbodya ei ole " + "asetettu peliobjektille");
            this.enabled = false;

        }
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 change = new Vector3(forceValue, 0f, 0f);

        if (isActive)
        {
            rb.AddForce(change, ForceMode.Impulse);// torque == Момент силы
            isActive = false;

        }

    }
    public void addImpulseForce()
    {
        isActive = true;
    } 
}
