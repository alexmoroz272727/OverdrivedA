using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopScore : MonoBehaviour
{
    private int moneys;
    private bool buy1 = false;


    public Text ShowTop;
    // Start is called before the first frame update
    void Start()
    {
        ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
    }
    public void Buy1()
    {
      moneys = PlayerPrefs.GetInt("Votes", 0);
        switch (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID)
        {
            case 1:
                if (moneys >= 50 && buy1 == false)
                {
                    moneys -= 50;
                    print("Kupil");
                    buy1 = true;
                }
            break;

        }
        PlayerPrefs.SetInt("Votes", moneys);
        ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
    }
}

  
