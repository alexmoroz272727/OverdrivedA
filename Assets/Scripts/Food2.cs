using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Food2 : MonoBehaviour
{
    private float lifetime;

    private void Awake()
    {
        lifetime = Random.Range(20f, 60f);
    }

    private void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
        {
            zxcv();
            Destroy(gameObject);
        }
    }

    void zxcv()
    {
       GameObject.Find("GameHelper").GetComponent<FoodGen>().eat1 = false; 

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
