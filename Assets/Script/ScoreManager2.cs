using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{

    public int Score;

    // Start is called before the first frame update
    public void OnGui()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score: " + Score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
