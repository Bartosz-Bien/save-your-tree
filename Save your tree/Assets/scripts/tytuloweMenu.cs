using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tytuloweMenu : MonoBehaviour
{
    public void doGry()
    {
        SceneManager.LoadScene(1);
    }

    public void doTytulowego()
    {
        SceneManager.LoadScene(0);
    }

    public void doWyjscia()
    {
        Application.Quit();
    }

    public void doPomocy()
    {
        SceneManager.LoadScene(2);
    }

    public void doWyboruRodzajuGry()
    {
        SceneManager.LoadScene(3);
    }

    public void doFreeplay()
    {
        SceneManager.LoadScene(4);
    }

    public void doSuwakow()
    {
        SceneManager.LoadScene(5);
    }
}
