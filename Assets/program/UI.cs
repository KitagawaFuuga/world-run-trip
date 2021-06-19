using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public static float Score;
    GameObject score_object;

    void Start()
    {
        this.score_object = GameObject.Find("Text");
    }

    // Update is called once per frame
    
    void Update()
    {
    }
    public void moving()
    {
        Score += 5;
        this.score_object.GetComponent<Text>().text ="走行距離:" + Score + "m";
    }
}
