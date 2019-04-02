using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DescText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Content").GetComponent<SnapScrolling>().isScrolling == true)
        {
            GameObject.Find("Description").GetComponent<Text>().text = "";
        }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().isScrolling == false)
        {
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 0)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Сидит 15 суток";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 1)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Ссыт в подъездах Начальный множитель 1.5";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 2)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Уменьшенное ускорение";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 3)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Увеличенная начальная скорость";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 4)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Игнорирует стены";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 5)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Цены уменьшены в 2 раза";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 6)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Змея";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 7)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Начальный множитель 5";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 8)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Начальный множитель 15   Цены уменьшены в 2 раза";
            }
            if (GameObject.Find("Content").GetComponent<SnapScrolling>().selectedPanID == 9)
            {
                GameObject.Find("Description").GetComponent<Text>().text = "Начальный множитель 20   Цены уменьшены 2 раза    Игнорирует стены";
            }

        }
    }

}
