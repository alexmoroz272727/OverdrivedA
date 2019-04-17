using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class accept : MonoBehaviour
{
    public bool accepted;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetInt("Policy", 0);
        if (a == 1 )
        {
            Destroy(gameObject);
        }
    }
    public void PolicyUp()
    {
        PlayerPrefs.SetInt("Policy", 1);
        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
   
}
