using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class endText : MonoBehaviour
{
    GameObject score_object;
    // Start is called before the first frame update
    void Start()
    {
        score_object = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        this.score_object.GetComponent<Text>().text ="走行距離:" + UI.Score + "m";
    }
}
