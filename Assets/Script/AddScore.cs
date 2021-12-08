using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame


    void OnCollisionEnter(Collision variable)
        {
            if (variable.gameObject == Player)
            {
                Player.GetComponent<ScoreManager2>().Score += 10;
                Destroy(gameObject);
            }
        }
    
}
