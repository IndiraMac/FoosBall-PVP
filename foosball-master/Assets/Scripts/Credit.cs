using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditMenu;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainMenu.SetActive(false);
            creditMenu.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            creditMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}
