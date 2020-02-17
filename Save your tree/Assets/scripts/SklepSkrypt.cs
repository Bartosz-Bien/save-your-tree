using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SklepSkrypt : staty
{
    public static bool czySklepOtwarty = false;
    public GameObject sklepUI;
    public Text cenaDrzewaTekst;
    public Text cenaNawozuTekst;
    public Text cenaPestycyduTekst;
        
    private void Start()
    {
        sklepUI.SetActive(false);
    }

    public void otworzSklep()
    {
        // sie wyswietla canvas jak wywolana funkcja        
        sklepUI.SetActive(true);
        czySklepOtwarty = true;
        cenaDrzewaTekst.text = "One tree costs: " + cenaDrzewa;
        cenaNawozuTekst.text = "One fertilizer costs: " + cenaNawozu;
        cenaPestycyduTekst.text = "One pesticide costs: " + cenaPestycydu;
    }

    public void nastepnyMiesiac()
    {
        sklepUI.SetActive(false);
        czySklepOtwarty = false;
        miesiac++;       
    }

    public void kupDrzewo()
    {
        Debug.Log(cenaDrzewa);
        if ((iloscPieniedzy >= cenaDrzewa) && iloscDrzew < 14)
        {
            iloscDrzew++;
            iloscPieniedzy -= cenaDrzewa;           
        }        
    }

             
    public void kupNawoz()
    {
        if (iloscPieniedzy >= cenaNawozu)
        {
            iloscNawozu++;
            iloscPieniedzy -= cenaNawozu;
        }
    }

    public void kupPestycyd()
    {
        if (iloscPieniedzy >= cenaPestycydu)
        {
            iloscPestycydu++;
            iloscPieniedzy -= cenaPestycydu;
        }
    }
}
