using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BordersMob : MonoBehaviour
{
    public int replace;
    public Text ShowTop;
    public int MoneyScore;
    public int LastMoney = 0;
    public int a;
    void OnTriggerEnter(Collider other)
    {
        a = PlayerPrefs.GetInt("Skinbuff", 0);

        if (other.CompareTag("SnakeMain"))
        {    
            if (a ==0 | a == 1 | a == 2 | a == 3 | a ==5  | a == 6 | a == 7 | a == 9)
            {
                
            

            replace = Convert.ToInt32(other.GetComponent<SnakeMovment>().Votes);
                LastMoney = PlayerPrefs.GetInt("Votes", 0);
                MoneyScore = LastMoney + replace;
                PlayerPrefs.SetInt("Votes", MoneyScore);


                // if (PlayerPrefs.GetInt("Votes", 0) < replace)
                //{
                //PlayerPrefs.SetInt("Votes", replace);

                GameObject.Find("GameHelper").GetComponent<AdControl>().ShowAd();
                ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                SceneManager.LoadScene("menu");
            }
        }

    }
    public void TakieDela()
    {

        replace = Convert.ToInt32(GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Votes);
        LastMoney = PlayerPrefs.GetInt("Votes", 0);
        MoneyScore = LastMoney + replace;
        PlayerPrefs.SetInt("Votes", MoneyScore);
        //PlayerPrefs.GetInt("Skinbuff", 0) != 4 |

        // if (PlayerPrefs.GetInt("Votes", 0) < replace)
        //{
        //PlayerPrefs.SetInt("Votes", replace);

        GameObject.Find("GameHelper").GetComponent<AdControl>().ShowAd();
        ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
        SceneManager.LoadScene("menu");
    }
    private void Update()
    {
        a = PlayerPrefs.GetInt("Skinbuff", 0);
    }
}
