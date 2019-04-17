using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    
    
    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Policy", 0) == 1) 
        {
            if (PlayerPrefs.GetInt("intro", 0) == 0)
            {
                SceneManager.LoadScene("intro");
            }
            else
            {
                SceneManager.LoadScene("anime");
            }
        }
    }
    
}
