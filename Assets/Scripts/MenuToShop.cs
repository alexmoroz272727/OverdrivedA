using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToShop : MonoBehaviour
{


   public void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Policy", 0) == 1)
        {
            SceneManager.LoadScene("Shop");
        }
    }
}


