using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freePlayEventy : staty
{
    public GameObject eventPestycydy;
    public GameObject eventDrzewa;
    public GameObject eventNawoz;
    public GameObject eventKoniec;
    public int czyEvent;
    public GameObject eventWygrana;

    void Start()
    {
        eventPestycydy.SetActive(false);
        eventDrzewa.SetActive(false);
        eventNawoz.SetActive(false);
    }

    void Update()
    {
        if (iloscDrzew == 0)
        {
            eventKoniec.SetActive(true);
        }
        if ((miesiac == miesiaceGry - 1) && (iloscDrzew > 0))
        {
            eventWygrana.SetActive(true);
        }
    }

    public void eventFunction()
    {
        czyEvent = Random.Range(1, 300);
        if ((czyEvent < freePestycyd) && (miesiac > 2))
        {
            eventPestycydy.SetActive(true);
        }

        if ((czyEvent < freeDrzewo + 100) && (miesiac > 36))
        {
            eventDrzewa.SetActive(true);
        }

        if ((czyEvent < freeNawoz + 200) && (miesiac > 21))
        {
            eventNawoz.SetActive(true);
        }
    }
    public void PestycydyTak()
    {
        if (iloscPestycydu > 0)
        {
            iloscPestycydu--;
            eventPestycydy.SetActive(false);
        }
    }

    public void PestycydyNie()
    {
        iloscDrzew--;
        eventPestycydy.SetActive(false);
        czyScieloDrzewo = true;
    }

    public void DrzewoTak()
    {
        iloscDrzew--;
        eventDrzewa.SetActive(false);
        czyScieloDrzewo = true;
    }

    public void NawozTak()
    {
        if (iloscNawozu > 0)
        {
            iloscNawozu--;
            eventNawoz.SetActive(false);
        }
    }

    public void NawozNie()
    {
        iloscDrzew--;
        eventNawoz.SetActive(false);
        czyScieloDrzewo = true;
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
