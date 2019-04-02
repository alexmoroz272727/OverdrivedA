using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour
{

    private float lifetime;

    private void Awake()
    {
        lifetime = Random.Range(20f, 60f);
    }

    public void sel()
    {


        GameObject.Find("GameHelper").GetComponent<BonusGen>().eat2 = false;
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


        if (other.CompareTag("waste"))
        {

            sel();



            Destroy(gameObject);
        }



        if (other.CompareTag("SnakeMain"))
        {
            
            
            GameObject.Find("SnakeMain").GetComponent<SnakeMovment>().BonusBuff();


            Destroy(gameObject);
        }
    }


}
