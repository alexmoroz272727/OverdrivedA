using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopToMenu : MonoBehaviour
{
   public void  shopout()
    {
        SceneManager.LoadScene("menu");
    }
}
