using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 160f;
	public float ZSize = 55f;
	public GameObject foodPrefab;
	public Vector3 curPos;
	public GameObject curFood;
    public bool eat = true;
    public int pol;


    void Start()
    {
        for (pol = 30; pol > 5; pol--)
        {
            AddNewFood();

        }
    }

    void AddNewFood()
	{
	RandomPos();
	curFood = GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject;
	}
	void RandomPos()
	{
    curPos = new Vector3(Random.Range(XSize*-1,XSize),-1f,Random.Range(ZSize*-1,ZSize));
	}

    void Update()
    {


        if (eat == false)
        {
            AddNewFood();
            eat = true;

        }


        else
        {
            return;
        }
    }
}
