using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour
{
    

    void sel()
    {
        GameObject.Find("GameHelper").GetComponent<FoodGeneration>().eat = false;
        

    }

    void OnTriggerEnter(Collider other)
    {


        if(other.CompareTag("waste"))
        {
            
            sel();



            Destroy(gameObject);
        }



        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovment>().AddTail();
            sel();



            Destroy(gameObject);
        }
    }

}
