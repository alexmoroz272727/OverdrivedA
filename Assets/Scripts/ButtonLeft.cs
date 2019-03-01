using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
       
    
   void OnMouseDown()
    {
        GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().alpha =true;
    }
    void OnMouseUp()
    {
        GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().alpha = false;
    }
}
