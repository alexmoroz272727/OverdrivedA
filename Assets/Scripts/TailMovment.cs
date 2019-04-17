using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TailMovment : MonoBehaviour {

	public float Speed;
	public Vector3 tailTarget;
	public int indx;
	public GameObject tailTargetObj;
	public SnakeMovment mainSnake;
    private int replace;
    void Start()
	{
		
		mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
		
		tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		indx = mainSnake.tailObjects.IndexOf(gameObject);
	}
	void Update () {
        Speed = mainSnake.Speed;

    tailTarget = tailTargetObj.transform.position;
	transform.LookAt(tailTarget);
	transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
	}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("SnakeMain"))
		{
			if(indx > 15)
			{


                GameObject.Find("Earth").GetComponent<Borders>().TakieDela();


            }
		}

	}
	
}
