using UnityEngine;
using System.Collections;

public class FoodGen : MonoBehaviour
{

    public float XSize = 160f;
    public float ZSize = 55f;
    public GameObject foodPrefab1;
    public Vector3 curPos1;
    public GameObject curFood1;
    
    public bool eat1 = true;
    public int pol1 = 0;


    void AddNewSphere()
    {
        RandomPos();
        curFood1 = GameObject.Instantiate(foodPrefab1, curPos1, Quaternion.identity) as GameObject;
        
        
    }
    void RandomPos()
    {
        curPos1 = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
    }
    void Start()
    {
      for (pol1=30; pol1>5; pol1-- )
        {
            AddNewSphere();
            
        }
    }

    void Update()
    {
        if (pol1 < 30)
        {
            AddNewSphere();
            pol1++;
            print(pol1);
        }

        if (eat1 == false)
        {

            //AddNewFood();
            pol1--;
            print(pol1);
            eat1 = true;


        }



    }

    //void Update()
    //{


    //      if (eat1 == false)
    //     {
    //        AddNewSphere();
    //      eat1 = true;

    //}


    // else
    //{
    //  return;
    //}
    //}
}

