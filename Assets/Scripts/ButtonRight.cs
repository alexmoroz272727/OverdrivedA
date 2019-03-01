using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRight : MonoBehaviour
{

   

    void OnMouseDown()
    {
        GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().omega = true;
    } 
    void OnMouseUp()
    {
        GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().omega = false;
    }
}
