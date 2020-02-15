using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauza : MonoBehaviour
{
    public GameObject pauzaUI;

    void Start()
    {
        pauzaUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauzaUI.SetActive(true);
        }
    }
    public void wyjscieZGry()
    {
        Application.Quit();
    }
    public void powrotDoGry()
    {
        pauzaUI.SetActive(false);
    }

}
