using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class state : MonoBehaviour
{

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
