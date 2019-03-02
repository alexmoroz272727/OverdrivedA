using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Food2 : MonoBehaviour
{
    

   void zxcv()
    {
       GameObject.Find("GameHelper1").GetComponent<FoodGen>().eat1 = false; 

    }


    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("waste"))
        {

            zxcv();



            Destroy(gameObject);
        }


        
            if (other.CompareTag("SnakeMain"))
            {
                other.GetComponent<SnakeMovment>().AddTail1();
                
                zxcv();



                Destroy(gameObject);
            }
        

    }
}
