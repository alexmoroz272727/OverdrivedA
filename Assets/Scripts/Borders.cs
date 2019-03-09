using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Borders : MonoBehaviour {
    public int replace;
    public Text ShowTop;
    public int MoneyScore;
    public int LastMoney = 0;
    void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("SnakeMain"))
        {
            replace = Convert.ToInt32(other.GetComponent<SnakeMovment>().Votes);
            LastMoney = PlayerPrefs.GetInt("Votes", 0);
            MoneyScore = LastMoney + replace;
            PlayerPrefs.SetInt("Votes", MoneyScore);


           // if (PlayerPrefs.GetInt("Votes", 0) < replace)
            //{
                //PlayerPrefs.SetInt("Votes", replace);
                
        
            ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
            SceneManager.LoadScene("anime");
        }

	}
}
