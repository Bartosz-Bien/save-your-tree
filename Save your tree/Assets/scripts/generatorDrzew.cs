using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorDrzew : staty
{
    // max ilosc drzew = 14
    public List<GameObject> wiosna;
    public List<GameObject> lato;
    public List<GameObject> jesien;
    public List<GameObject> zima;
    public List<GameObject> owoce;
    
    void Start()
    {
        zima[0].SetActive(true);
    }
    
    public void generujDrzewa()
    {
        Debug.Log(miesiac);
        GameObject rycerz = GameObject.Find("eventsSkript");/*
        freePlayEventy hpscript = rycerz.GetComponent<freePlayEventy>();
        czyScieloDrzewo = hpscript.czyScieloDrzewo;
        */
        Debug.Log(czyScieloDrzewo);
        if (miesiac % 12 == 10) // wypłata za plony
            iloscPieniedzy += (1000 * iloscDrzew);

        for (int i = 0; i < iloscDrzew; i++)
        {
            wiosna[i].SetActive(false);            
        }
        if (czyScieloDrzewo && miesiac % 12 >= 3 && miesiac % 12 <= 5)
        {
            wiosna[iloscDrzew].SetActive(false);
            czyScieloDrzewo = false;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 3 && miesiac % 12 <= 5)
        {            
            for (int i = 0; i < iloscDrzew; i++)
            {
                wiosna[i].SetActive(true);
            }            
        }

        for (int i = 0; i < iloscDrzew; i++)
        {
            lato[i].SetActive(false);
        }
        if (czyScieloDrzewo && miesiac % 12 >= 6 && miesiac % 12 <= 8)
        {
            lato[iloscDrzew].SetActive(false);
            czyScieloDrzewo = false;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 6 && miesiac % 12 <= 8)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                lato[i].SetActive(true);
            }
        }


        for (int i = 0; i < iloscDrzew; i++)
        {
            owoce[i].SetActive(false);
        }
        if (czyScieloDrzewo && miesiac % 12 == 9)
        {
            owoce[iloscDrzew].SetActive(false);
            czyScieloDrzewo = false;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 == 9)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                owoce[i].SetActive(true);
            }
            
        }

        for (int i = 0; i < iloscDrzew; i++)
        {
            jesien[i].SetActive(false);
        }
        if (czyScieloDrzewo && miesiac % 12 >= 10 && miesiac % 12 <= 11)
        {
            jesien[iloscDrzew].SetActive(false);
            czyScieloDrzewo = false;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 10 && miesiac % 12 <= 11)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                jesien[i].SetActive(true);

            }
        }
                      
        for (int i = 0; i < iloscDrzew; i++)
        {
            zima[i].SetActive(false);
        }
        if (czyScieloDrzewo && miesiac % 12 >= 0 && miesiac % 12 <= 2)
        {
            zima[iloscDrzew].SetActive(false);
            czyScieloDrzewo = false;
            Debug.Log(miesiac);
        }
        if (miesiac % 12 >= 0 && miesiac % 12 <= 2)
        {
            for (int i = 0; i < iloscDrzew; i++)
            {
                zima[i].SetActive(true);
            }
        }
    }
}
