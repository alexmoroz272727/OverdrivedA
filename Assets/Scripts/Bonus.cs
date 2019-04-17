using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour
{

    private float lifetime;

    private void Awake()
    {
        lifetime = Random.Range(20f, 60f);
        
        gameObject.transform.Rotate(0, 90, 90);
        //transform.rotation (Vector3.up, turnSpeed * Time.deltaTime);

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
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();


            Destroy(gameObject);
        }
    }


}
