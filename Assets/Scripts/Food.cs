using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Food : MonoBehaviour
{

    private float lifetime;

    private void Awake()
    {
        lifetime = Random.Range(20f, 60f);
    }

    void sel()
    {
        GameObject.Find("GameHelper").GetComponent<FoodGeneration>().eat = false;
        

    }


    private void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
        {
            sel();
            Destroy(gameObject);
        }
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
            GameObject.Find("GameHelper").GetComponent<AudioSource>().Play();
            
            sel();
            



            Destroy(gameObject);
        }
    }
   

}
