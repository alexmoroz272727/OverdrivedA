using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopScore1 : MonoBehaviour
{
    
    private bool buy1 = false;


    public Text ShowTop;
    // Start is called before the first frame update
    void Start()
    {
        ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
    }
    
}


