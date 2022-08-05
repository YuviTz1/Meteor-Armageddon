using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{


    public static int score;

    Text text;
    


    private void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="Score: " + score.ToString();
    }
}
