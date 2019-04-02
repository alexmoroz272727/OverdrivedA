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
            SceneManager.LoadScene("anime");
        }
    }
    
}
