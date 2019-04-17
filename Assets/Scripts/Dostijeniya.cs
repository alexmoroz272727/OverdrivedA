using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dostijeniya : MonoBehaviour
{
    public Sprite spr1;
    public Sprite spr2;
    public Sprite spr3;
    public Sprite spr4;
    public Sprite spr5;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Votes1", 0) == 1)
        {
            GameObject.Find("Kvodrat").GetComponent<SpriteRenderer>().sprite = spr2;
            
        }
        if (PlayerPrefs.GetInt("Votes2", 0) == 1)
        {
            GameObject.Find("Kvodrat1").GetComponent<SpriteRenderer>().sprite = spr3;

        }
        if (PlayerPrefs.GetInt("Votes3", 0) == 1)
        {
            GameObject.Find("Kvodrat2").GetComponent<SpriteRenderer>().sprite = spr4;

        }
        if (PlayerPrefs.GetInt("Votes4", 0) == 1)
        {
            GameObject.Find("Kvodrat3").GetComponent<SpriteRenderer>().sprite = spr5;

        }
    }

    // Update is called once per frame
    
}
