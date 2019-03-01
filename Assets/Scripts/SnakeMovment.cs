using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SnakeMovment : MonoBehaviour {


    public float Alltime = 0;
    public bool alpha = false;
    public bool omega = false;
    public float Speed;
	public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;

	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
	void Start () {
	tailObjects.Add(gameObject);
	}
	void Update () 
	{
        Speed = 5f + Alltime * 0.05f;
        Alltime += Time.deltaTime;
        ScoreText.text = score.ToString();
		transform.Translate(Vector3.forward*Speed*Time.deltaTime);

		if(omega==true)
		{
			transform.Rotate(Vector3.up*RotationSpeed*Time.deltaTime);
		}
		if(alpha==true)
		{
			transform.Rotate(Vector3.up*-1*RotationSpeed*Time.deltaTime);
		}
	}

	public void AddTail()
	{
		score++;
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
    public void AddTail1()
    {
        score = score + 10;
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
}
