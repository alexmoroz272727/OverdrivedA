using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopScore : MonoBehaviour
{
    private int moneys;
    private int buy1 = 0;
    private int buy2 = 0;
    private int buy3 = 0;
    private int buy4 = 0;
    private int buy5 = 0;
    private int buy6 = 0;
    private int buy7 = 0;
    private int buy8 = 0;
    private int buy9 = 0;
    private int buy10 = 0;
    //public Sprite[] heroSprites1;



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
            case 0:
                if (moneys >= 0 && PlayerPrefs.GetInt("Buy1", 0) == 0)
                {
                    moneys -= 0;
                    print("Kupil");
                    buy1 = 1;
                    PlayerPrefs.SetInt("Buy1", buy1);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
            break;
            case 1:
                if (moneys >= 2000 && PlayerPrefs.GetInt("Buy2", 0) == 0)
                {
                    moneys -= 2000;
                    print("Kupil1");
                    buy2 = 1;
                    PlayerPrefs.SetInt("Buy2", buy2);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 2:
                if (moneys >= 5000 && PlayerPrefs.GetInt("Buy3", 0) == 0)
                {
                    moneys -= 5000;
                    print("Kupil2");
                    buy3 = 1;
                    PlayerPrefs.SetInt("Buy3", buy3);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 3:
                if (moneys >= 10000 && PlayerPrefs.GetInt("Buy4", 0) == 0)
                {
                    moneys -= 10000;
                    print("Kupil3");
                    buy4 = 1;
                    PlayerPrefs.SetInt("Buy4", buy4);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 4:
                if (moneys >= 15000 && PlayerPrefs.GetInt("Buy5", 0) == 0)
                {
                    moneys -= 15000;
                    print("Kupil3");
                    buy5 = 1;
                    PlayerPrefs.SetInt("Buy5", buy5);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 5:
                if (moneys >= 25000 && PlayerPrefs.GetInt("Buy6", 0) == 0)
                {
                    moneys -= 25000;
                    print("Kupil3");
                    buy6 = 1;
                    PlayerPrefs.SetInt("Buy6", buy6);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 6:
                if (moneys >= 25000 && PlayerPrefs.GetInt("Buy7", 0) == 0)
                {
                    moneys -= 25000;
                    print("Kupil3");
                    buy7 = 1;
                    PlayerPrefs.SetInt("Buy7", buy7);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 7:
                if (moneys >= 50000 && PlayerPrefs.GetInt("Buy8", 0) == 0)
                {
                    moneys -= 50000;
                    print("Kupil3");
                    buy8 = 1;
                    PlayerPrefs.SetInt("Buy8", buy8);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 8:
                if (moneys >= 100000 && PlayerPrefs.GetInt("Buy9", 0) == 0)
                {
                    moneys -= 100000;
                    print("Kupil3");
                    buy9 = 1;
                    PlayerPrefs.SetInt("Buy9", buy9);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;
            case 9:
                if (moneys >= 225000 && PlayerPrefs.GetInt("Buy10", 0) == 0)
                {
                    moneys -= 225000;
                    print("Kupil3");
                    buy10 = 1;
                    PlayerPrefs.SetInt("Buy10", buy10);
                    PlayerPrefs.SetInt("Votes", moneys);
                    ShowTop.text = PlayerPrefs.GetInt("Votes", 0).ToString();
                }
                break;


        }
      
       
    }
    private void Update()
    {

        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 0 && PlayerPrefs.GetInt("Buy1", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 1 && PlayerPrefs.GetInt("Buy2", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 2 && PlayerPrefs.GetInt("Buy3", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 3 && PlayerPrefs.GetInt("Buy4", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 4 && PlayerPrefs.GetInt("Buy5", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 5 && PlayerPrefs.GetInt("Buy6", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 6 && PlayerPrefs.GetInt("Buy7", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 7 && PlayerPrefs.GetInt("Buy8", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 8 && PlayerPrefs.GetInt("Buy9", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 9 && PlayerPrefs.GetInt("Buy10", 0) == 1)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "Использовать";
        }




        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 0 && PlayerPrefs.GetInt("Buy1", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "0";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 1 && PlayerPrefs.GetInt("Buy2", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "2000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 2 && PlayerPrefs.GetInt("Buy3", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "5000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 3 && PlayerPrefs.GetInt("Buy4", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "10000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 4 && PlayerPrefs.GetInt("Buy5", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "15000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 5 && PlayerPrefs.GetInt("Buy6", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "25000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 6 && PlayerPrefs.GetInt("Buy7", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "25000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 7 && PlayerPrefs.GetInt("Buy8", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "50000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 8 && PlayerPrefs.GetInt("Buy9", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "100000";
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 9 && PlayerPrefs.GetInt("Buy10", 0) == 0)
        {
            GameObject.Find("BuyedText").GetComponent<Text>().text = "225000";
        }
    }
    public void ChangeSkin()
    {
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 0 && PlayerPrefs.GetInt("Buy1", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 1);
            PlayerPrefs.SetInt("Skinbuff", 0);
            


        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 1 && PlayerPrefs.GetInt("Buy2", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 2);
            PlayerPrefs.SetInt("Skinbuff", 1);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 2 && PlayerPrefs.GetInt("Buy3", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 3);
            PlayerPrefs.SetInt("Skinbuff", 2);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 3 && PlayerPrefs.GetInt("Buy4", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 4);
            PlayerPrefs.SetInt("Skinbuff", 3);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 4 && PlayerPrefs.GetInt("Buy5", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 5);
            PlayerPrefs.SetInt("Skinbuff", 4);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 5 && PlayerPrefs.GetInt("Buy6", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 6);
            PlayerPrefs.SetInt("Skinbuff", 5);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 6 && PlayerPrefs.GetInt("Buy7", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 7);
            PlayerPrefs.SetInt("Skinbuff", 6);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 7 && PlayerPrefs.GetInt("Buy8", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 8);
            PlayerPrefs.SetInt("Skinbuff", 7);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 8 && PlayerPrefs.GetInt("Buy9", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 9);
            PlayerPrefs.SetInt("Skinbuff", 8);
        }
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 9 && PlayerPrefs.GetInt("Buy10", 0) == 1)
        {
            PlayerPrefs.SetInt("Skin", 10);
            PlayerPrefs.SetInt("Skinbuff", 9);
        }
    }
      
    
}

  
