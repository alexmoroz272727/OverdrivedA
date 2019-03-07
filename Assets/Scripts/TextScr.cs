using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScr : MonoBehaviour
{
    public Text ShopText;
    
    public double localscore;
    public float localprice = 50;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

            localscore = other.GetComponent<SnakeMovment>().score;
            if (localscore > localprice & GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Speed > 10)
            {
                localscore = localscore - localprice;
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().selld();

                //SpChange = GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Speed;
                //SpChange = SpChange - 5f;
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().SpeedCh();
                localprice = localprice * 2;


            }
        }
    }

    void Update()
    {
        ShopText.text = localprice.ToString();
    }
}
