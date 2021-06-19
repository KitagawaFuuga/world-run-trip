using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objete : MonoBehaviour
{

    bool deleteflag;    
    float time;
    float deletetime;
    float normaltime;
    public GameObject Flame;
    public GameObject Flame2;
    public GameObject Flame3;
    public GameObject Flame4;
    public GameObject Flame5;
    GameObject Obj;
    GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("earth");
        deleteflag = false;
    }    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        normaltime += Time.deltaTime;

        int i = Random.Range(0,5);
        if(normaltime <= 10)
        {
                if(time >= 5)
                {
                        seisan();
                        time = 0.0f;
                }
        }

        if(normaltime >= 10 && normaltime < 20)
        {
                if(time >= 4)
                {
                        seisan();
                        time = 0.0f;
                }
        }
        if(normaltime >= 20 && normaltime < 35)
        {
                if(time >= 3)
                {
                        seisan();
                        time = 0.0f;
                }
        }
        if(normaltime >= 35 && normaltime < 50)
        {
                if(time >= 2.5f)
                {
                        seisan();
                        time = 0.0f;
                }
        }
        if(normaltime >= 50 && normaltime < 60)
        {
                if(time >= 2)
                {
                        seisan();
                        time = 0.0f;
                }
        }



        if(deleteflag)
        {
                Destroy(Obj, 3.5f);
                deleteflag = false;
        }
    }
    
    public void seisan()
    {
            int i = Random.Range(0,5);
            if(i == 0)
                        {
                                Obj = Instantiate (Flame, new Vector3(0, -2.0f, 0),  Quaternion.identity);
                                Obj.transform.parent = Player.transform;
                                deleteflag = true;

                        }else if(i == 1){
                                Obj = Instantiate (Flame2, new Vector3(0, -2.2f, 0),  Quaternion.identity);
                                Obj.transform.parent = Player.transform;
                                deleteflag = true;

                        
                        }else if(i == 2){
                                Obj = Instantiate (Flame3, new Vector3(0, -2.2f, 0),  Quaternion.identity);
                                Obj.transform.parent = Player.transform;
                                deleteflag = true;

                        
                        }else if(i == 3){
                                Obj = Instantiate (Flame4, new Vector3(0, -1.8f, 0),  Quaternion.identity);
                                Obj.transform.parent = Player.transform;   
                                deleteflag = true;
                
                        }else if(i == 4){
                                Obj = Instantiate (Flame5, new Vector3(0, -2.5f, 0),  Quaternion.identity);
                                Obj.transform.parent = Player.transform;　    
                                deleteflag = true;
                        }
    }
}
