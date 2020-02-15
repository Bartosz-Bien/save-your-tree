using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class staty : MonoBehaviour
{
    public static int iloscDrzew;
    public static int miesiac, miesiaceGry, iloscNawozu, iloscPieniedzy, cenaDrzewa, cenaNawozu, iloscPestycydu, cenaPestycydu;
    public Text statsText;
    public bool czyScieloDrzewo = false;
    public string[] tekstMiesiaca = new string[] { "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November" };
    public static float freeDrzewo, freeNawoz, freePestycyd;

    void Start()
    {
        iloscDrzew = 1;
        miesiac = 1;
        iloscNawozu = 0;
        iloscPestycydu = 0;
        iloscPieniedzy = 520;

        miesiaceGry = 2000000000; //było 60 miesięcy, ale dam 2 000 000 000, czyli niemal maxa dla inta - nikt tak długo nie będzie grać
    }

    void Update()
    {
        statsText.text = "Trees: " + iloscDrzew + ", Coins: " + iloscPieniedzy + ", Fertilizers: " + iloscNawozu + ", Pesticides: " + iloscPestycydu + ", Month: " + tekstMiesiaca[(miesiac % 12)] + ", Year: " + miesiac / 12;// + ", Remains: " + (miesiaceGry - miesiac) + " months";     
    }

    public void cennikDrzewa()
    {
        cenaDrzewa = Random.Range(1000, 2500);        
    }

    public void cennikNawozu()
    {
        cenaNawozu = Random.Range(200, 400);
    }

    public void cennikPestycydu()
    {
        cenaPestycydu = Random.Range(40, 60);
    }     
    
    public void prawdopodobienstwoDrzewa (float prawDrzewo)
    {
        freeDrzewo = prawDrzewo;
    }

    public void prawdopodobienstwoNawozu(float prawNawozu)
    {
        freeNawoz = prawNawozu;
    }

    public void prawdopodobienstwoPestycydu(float prawPestycydu)
    {
        freePestycyd = prawPestycydu;
    }
}
