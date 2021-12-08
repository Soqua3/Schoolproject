using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    
    public static PointManager instance;
    private int points;
    [SerializeField]
    private Text Scoretext;



    private void Awake()
    {
        instance = this;
        points = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoint()
    {
        points++;
        if (Scoretext != null)
        {
            string newText = "Scores: " + points.ToString();
            Scoretext.text = newText;
        }
        else
        {
            Debug.Log("ScoreManager: ScoreText elementtiä ei löydy");
        }
    }

    public int getPoints()
    {
        return points;
    }
}
