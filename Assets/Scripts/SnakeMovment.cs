using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
public class SnakeMovment : MonoBehaviour
{


    public float Alltime = 0;
    public bool alpha = false;
    public bool omega = false;
    public float Speed = 5f;
    public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;

	public GameObject TailPrefab;
	public Text ScoreText;
    public Text MainScore;
    public Text ShowMulti;
	public double score = 0;
    public double MScore = 1250f;
    public double EnemyScore = 5000000f;
    public double Vote;
    public double Multi = 1f;
    public double Votes;
    public float bufftime = 40f;
    public bool buffgo = false;
    public float acceleration = 0.05f;
   
	void Start ()
    {
	tailObjects.Add(gameObject);
        
    }

    void Update () 
	{
        //Alltime += Time.deltaTime;
        Speed = Speed + Time.deltaTime * acceleration;
        EnemyScore = EnemyScore + 70f * Time.deltaTime;
        //Vote = MScore / EnemyScore * 100f;
        Vote = Math.Round(MScore / EnemyScore * 100f, 2);
        
        ScoreText.text = score.ToString();
        MainScore.text = Vote.ToString() + "%";
        ShowMulti.text = Multi.ToString();



        transform.Translate(Vector3.down*Speed*Time.deltaTime);
        if (Vote > 25)
        {
            PlayerPrefs.SetInt("Votes1", 1);
            if (Vote > 50)
            {
                PlayerPrefs.SetInt("Votes2", 1);
                if (Vote > 100)
                {
                    PlayerPrefs.SetInt("Votes3", 1);
                    if (Vote > 146)
                    {
                    PlayerPrefs.SetInt("Votes4", 1);
                    }
                }

            }
        }


        if (omega==true)
		{
			transform.Rotate(Vector3.right*RotationSpeed*Time.deltaTime);
		}
		if(alpha==true)
		{
			transform.Rotate(Vector3.right * -1*RotationSpeed*Time.deltaTime);
		}
        if (buffgo==true)
        {
            bufftime -= Time.deltaTime;
            if (bufftime < 0)
            {
                Multi = Multi/2;
                Multi = Math.Round(Multi, 3);
                GameObject.Find("GameHelper").GetComponent<BonusGen>().eat2 = false;
                bufftime = 40f;
                buffgo = false;


            }
        }
	}

    public void selld()
    {
        score = GameObject.Find("SpeedShop").GetComponent<TextScr>().localscore;

    }
    public void sells()
    {
        score = GameObject.Find("SpeedShop1").GetComponent<TextScr1>().localscore1;

    }
    public void SpeedCh()
    {
        Speed = Speed - 5f;
    }
    public void MultiUp()
    {
        Multi = Multi + 0.3f;
        Multi = Math.Round(Multi, 3);
    }

    public void AddTail()
	{
        Multi += 0.005f;
        Multi = Math.Round(Multi, 3);
        MScore = MScore + 10f * Multi;
        score += 1* Multi;
        score = Math.Round(score, 0);
        Votes += 1 * Multi;
        Votes = Math.Round(Votes, 0);


        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
    public void AddTail1()
    {
        Multi += 0.015f;
        Multi = Math.Round(Multi, 3);
        MScore = MScore + 30f *Multi;
        score = score + 5f * Multi;
        score = Math.Round(score, 0);
        Votes += 5 * Multi;
        Votes = Math.Round(Votes, 0);



        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    } 
    public void BonusBuff()
    {
        Multi = Multi*2;
        buffgo = true;
       

    }
}
