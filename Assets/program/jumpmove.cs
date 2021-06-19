using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  jumpmove : MonoBehaviour
{
    public GameObject _player;
    public string _earthTag;         //除外するタグの名前
    public float _forceHeight;       //吹き飛ばす高さ調整値
    public float _forcePower;        //吹き飛ばす強さ調整値


    bool flag = false; // フラグ管理 (ジャンプ)
    bool tran = false;
    bool change_scene = false;
    Rigidbody2D rigit2D;
    float jumpPower = 50.0f;
    bool Uimove;
    GameObject refObj;
    float scene_change_timer;


    // Start is called before the first frame update
    void Start()
    {
        this.rigit2D = GetComponent<Rigidbody2D>();
        Uimove = true;
        refObj = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && !flag) // スペースを押してflagがfalseのとき
        {
            this.rigit2D.AddForce(transform.up * jumpPower); // ジャンプ処理
            flag = true; //地面につくまでflagをtrueに
        }
        if(Uimove)
        {
            UI a = refObj.GetComponent<UI>();
            a.moving();
        }
        down();

        if(change_scene)
        {
            scene_change_timer += Time.deltaTime;
            if(scene_change_timer >= 1.0f)
                SceneManager.LoadScene("end");
        }

    }

    void OnTriggerStay2D(Collider2D other) // もし物に当たっていて
    {
        if (other.gameObject.CompareTag("Ground")) // それが地球だったら
        {
            flag = false; // flagをfalseに
            tran = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("top"))
        {
                tran = true;
        }else if(other.gameObject.CompareTag("enemy")){
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.AddForce(new Vector2(-500,-500)); 
                Uimove = false;
                change_scene = true;
        }
    }

    

    void down()
    {
        if(tran)
            this.gameObject.transform.Translate(0,-0.02f,0);
    }

    
}
