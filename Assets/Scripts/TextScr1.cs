using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScr1 : MonoBehaviour
{
    public Text ShopText1;
    
    public double localscore1;
    public float localprice1 = 40;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

            localscore1 = other.GetComponent<SnakeMovment>().score;
            if (localscore1 > localprice1)
            {
                localscore1 = localscore1 - localprice1;
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().sells();

              
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().MultiUp();
                localprice1 = localprice1 * 2;


            }
        }
    }

    void Update()
    {
        ShopText1.text = localprice1.ToString();
    }
}
