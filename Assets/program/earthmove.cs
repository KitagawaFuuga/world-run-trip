using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earthmove : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per framet
    void Update()
    {
        time += Time.deltaTime;
        if(time < 60)
        {
            this.gameObject.transform.Rotate(0,0,0.8f);
        }else if(time >= 60 && time < 120){
            this.gameObject.transform.Rotate(0,0,1.0f);
        }
    }
}
