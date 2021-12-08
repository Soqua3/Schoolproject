
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int point;
    [SerializeField]
    private Text ScoreText;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addPoint()
    {
        point++;

        if(ScoreText != null) 
        { 
        string newText = "Scores" + point.ToString();
        ScoreText.text = newText;
        } else
        {
            Debug.Log("ScoreManager: ScoreText elementtiä ei löydy");
        }
    }
}
