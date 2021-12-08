using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddforceButton : MonoBehaviour
{
    public void doForceAction()
    {
        //Debug.Log("AddforceButton:doForceAction() ");
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");

        if ( ball != null)
        {
            ball.GetComponent<BallForceScript>().addImpulseForce(); //импульсирует мяч, силу импульсации можно выставить в юнити
        }
    }
}
