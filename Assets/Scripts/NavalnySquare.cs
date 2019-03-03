using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavalnySquare : MonoBehaviour
    
{
    private int KD;
    private bool Vverhu;
    private float timevverhu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   





    // Update is called once per frame
    void Update()
    {

        if (Vverhu==false)
        { 
        KD = Random.Range(0, 2400);
           if (KD == 1)
            {
             transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                Vverhu = true;
                timevverhu = Random.Range(10, 25);
            }
        }
        if (Vverhu == true)
        {
           
            //if (timevverhu > 0)
             timevverhu -= Time.deltaTime;
             if(timevverhu < 5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1 , transform.position.z);
                timevverhu = 0;
                Vverhu = false;
                
            }


        }
    }
}
