using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinStart : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
    public Material mat7;
    public Material mat8;
    public Material mat9;
    public Material mat10;
    public int SkinBuff;
    


    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetInt("Skin", 1))
        {
            case 1:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat1;
                break;
            case 2:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat2;
                break;
            case 3:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat3;
                break;
            case 4:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat4;
                break;
            case 5:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat5;
                break;
            case 6:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat6;
                break;
            case 7:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat7;
                break;
            case 8:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat8;
                break;
            case 9:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat9;
                break;
            case 10:
                GameObject.Find("SnakeMain").GetComponent<MeshRenderer>().material = mat10;
                break;

        }
        switch (PlayerPrefs.GetInt("Skinbuff", 0))
        {
            case 0:
                ;
                break;
            case 1:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Multi = 1.5;
               
                break;
            case 2:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().acceleration = 0.35f;
               
                break;
            case 3:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Speed = 10f;
              
                break;
            case 4:
            
                break;
            case 5:
                GameObject.Find("SpeedShop").GetComponent<TextScr>().localprice = 12;
                GameObject.Find("SpeedShop1").GetComponent<TextScr1>().localprice1 = 10;
              

                break;
            case 6:
               
                break;
            case 7:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Multi = 5;
               
                break;
            case 8:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Multi = 15;
                GameObject.Find("SpeedShop").GetComponent<TextScr>().localprice = 5;
                GameObject.Find("SpeedShop1").GetComponent<TextScr1>().localprice1 = 4;
               
                break;
            case 9:
                GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().Multi = 20;
                GameObject.Find("SpeedShop").GetComponent<TextScr>().localprice = 5;
                GameObject.Find("SpeedShop1").GetComponent<TextScr1>().localprice1 = 4;

                break;

        }
    }
}
    
