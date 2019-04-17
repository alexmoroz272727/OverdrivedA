using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    private int i = 0;
    public Sprite[] page1;
  
    // Start is called before the first frame update
   
    private void OnMouseUpAsButton()
    {
        i++;
        if (i >= 4)
        {
            PlayerPrefs.SetInt("intro", 1);

            SceneManager.LoadScene("anime");
            //Destroy(gameObject);
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = page1[i];
        
    }
    // Update is called once per frame

}
