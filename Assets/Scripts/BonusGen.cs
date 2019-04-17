using UnityEngine;
using System.Collections;

public class BonusGen : MonoBehaviour
{

    public float XSize = 160f;
    public float ZSize = 55f;
    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;
    public bool eat2 = true;
    public int pol2;


    //void Awake()
    //{



    //for (pol = 30; pol > 5; pol--)
    //{
    //   AddNewFood();
    // 
    //print(pol);

    //}
    //}

    private void Start()
    {
        AddNewFood2();



    }

    void AddNewFood2()
    {
        //curPos = new Vector3(Random.Range(XSize * -1, XSize), -1f, Random.Range(ZSize * -1, ZSize));
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), -1f, Random.Range(ZSize * -1, ZSize));
    }

    void Update()
    {
        

        if (eat2 == false)
        {

            AddNewFood2();
            
            eat2 = true;


        }



    }
}
