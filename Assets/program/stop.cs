using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{

    [SerializeField]
    private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;
    
    void Update()
    {
        if(Input.GetKeyDown("q")) 
        {
            if(pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }else{
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}
